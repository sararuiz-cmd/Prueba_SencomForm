using System;
using System.Collections.Generic;
using System.IO;

namespace Proyect_Sencom_Form.Business
{
    public class AuthService
    {
        private readonly string _rutaArchivo;
        private readonly Dictionary<string, string> _usuarios;

        public AuthService(string rutaArchivo = "usuarios.txt")
        {
            _rutaArchivo = rutaArchivo;
            _usuarios = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            if (!File.Exists(_rutaArchivo)) return;
            foreach (var linea in File.ReadAllLines(_rutaArchivo))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                var partes = linea.Split(';');
                if (partes.Length == 2)
                {
                    var u = partes[0].Trim();
                    var p = partes[1].Trim();
                    if (!_usuarios.ContainsKey(u))
                        _usuarios.Add(u, p);
                }
            }
        }

        private void GuardarUsuarios()
        {
            var lineas = new List<string>();
            foreach (var kv in _usuarios)
                lineas.Add($"{kv.Key};{kv.Value}");
            File.WriteAllLines(_rutaArchivo, lineas);
        }

        public bool RegistrarUsuario(string usuario, string contrasena, out string mensaje)
        {
            usuario = (usuario ?? "").Trim();
            contrasena = (contrasena ?? "").Trim();
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                mensaje = "El usuario y la contraseña no pueden estar vacíos.";
                return false;
            }
            if (_usuarios.ContainsKey(usuario))
            {
                mensaje = "El usuario ya existe.";
                return false;
            }
            _usuarios.Add(usuario, contrasena);
            GuardarUsuarios();
            mensaje = "Usuario registrado correctamente.";
            return true;
        }

        public bool ValidarLogin(string usuario, string contrasena)
        {
            usuario = (usuario ?? "").Trim();
            contrasena = (contrasena ?? "").Trim();
            return _usuarios.TryGetValue(usuario, out var pass) && pass == contrasena;
        }
    }
}

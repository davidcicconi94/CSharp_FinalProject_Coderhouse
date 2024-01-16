﻿namespace FinalProject.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }  
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }  
        public string Mail { get; set; }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail) 
        { 
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }
    }
}

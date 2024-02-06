using Project_Coderhouse.Entities;

Usuario user1 = new Usuario(1, "David", "Cicconi", "davidcicc", "1234", "david.cicconi94@gmail.com");

Console.WriteLine($"El usuario {user1.Nombre} {user1.Apellido}, cuyo username es {user1.NombreUsuario} " +
    $"y password {user1.Contrasenia}, tiene de mail: {user1.Mail} "); 

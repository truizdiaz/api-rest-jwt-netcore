using Jwt.Models;

namespace Jwt.Constants
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "jperez", Password = "admin123", Rol = "Administrador", EmailAddress = "jperez@gmail.com", FirstName = "Juan", LastName = "Perez"},
            new UserModel() { Username = "mgonzalez", Password = "admin123", Rol = "Vendedor", EmailAddress = "mgonzalez@gmail.com", FirstName = "Maria", LastName = "Gonzalez"},
        };
    }
}

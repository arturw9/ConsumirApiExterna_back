using System.ComponentModel.DataAnnotations;

namespace ConsumirApiExterna.Models
{
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Nat { get; set; }
    }

    public class Name
    {
        [Key]
        public Guid IdName { get; set; }
        public Guid IdUsuario { get; set; }
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class Location
    {
        [Key]
        public Guid IdLocation { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdStreet { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public Guid IdCoordinates { get; set; }
        public Guid IdTimezone { get; set; }
    }

    public class Street
    {
        [Key]
        public Guid IdStreet { get; set; }
        public Guid IdUsuario { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
    }

    public class Coordinates
    {
        [Key]
        public Guid IdCoordinates { get; set; }
        public Guid IdUsuario { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class Timezone
    {
        [Key]
        public Guid IdTimezone { get; set; }
        public Guid IdUsuario { get; set; }
        public string Offset { get; set; }
        public string Description { get; set; }
    }

    public class Login
    {
        [Key]
        public Guid IdLogin { get; set; }
        public Guid IdUsuario { get; set; }
        public string Uuid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }
    }

    public class DateOfBirth
    {
        [Key]
        public Guid IdDateOfBirth { get; set; }
        public string Date { get; set; }
        public Guid IdUsuario { get; set; }
        public int Age { get; set; }
    }

    public class Registered
    {
        [Key]
        public Guid IdRegistered { get; set; }
        public Guid IdUsuario { get; set; }
        public string Date { get; set; }
        public int Age { get; set; }
    }

    public class Id
    {
        [Key]
        public Guid Idid { get; set; }
        public Guid IdUsuario { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Picture
    {
        [Key]
        public Guid IdPicture { get; set; }
        public Guid IdUsuario { get; set; }
        public string Large { get; set; }
        public string Medium { get; set; }
        public string Thumbnail { get; set; }
    }
}
namespace ConsumirApiExterna.ViewModels
{
    public class UsuarioViewModel
    {
        public Guid IdUsuario { get; set; }
        public string Gender { get; set; }
        public NameViewModel Name { get; set; }
        public DateOfBirthViewModel DateOfBirth { get; set; }
        public LocationViewModel Location { get; set; }
        public string Email { get; set; }
        public LoginViewModel Login { get; set; }
        public RegisteredViewModel Registered { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public IdViewModel Id { get; set; }
        public PictureViewModel Picture { get; set; }
        public string Nat { get; set; }
    }

    public class NameViewModel
    {
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class LocationViewModel
    {
        public StreetViewModel Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public CoordinatesViewModel Coordinates { get; set; }
        public TimezoneViewModel Timezone { get; set; }
    }

    public class StreetViewModel
    {
        public int Number { get; set; }
        public string Name { get; set; }
    }

    public class CoordinatesViewModel
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class TimezoneViewModel
    {
        public string Offset { get; set; }
        public string Description { get; set; }
    }

    public class LoginViewModel
    {
        public string Uuid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }
    }

    public class DateOfBirthViewModel
    {
        public string Date { get; set; }
        public Guid IdUsuario { get; set; }
        public int Age { get; set; }
    }

    public class RegisteredViewModel
    {
        public string Date { get; set; }
        public int Age { get; set; }
    }

    public class IdViewModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class PictureViewModel
    {
        public string Large { get; set; }
        public string Medium { get; set; }
        public string Thumbnail { get; set; }
    }
}
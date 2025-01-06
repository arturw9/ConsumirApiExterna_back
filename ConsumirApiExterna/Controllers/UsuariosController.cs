using ConsumirApiExterna.Data;
using ConsumirApiExterna.Models;
using ConsumirApiExterna.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace ConsumirApiExterna.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ILogger<UsuariosController> _logger;
        private readonly ApiDbContext _context;
        public UsuariosController(ILogger<UsuariosController> logger,
       ApiDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("/Usuarios/BuscarUsuariosApi")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> BuscarUsuariosApi()
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetStringAsync("https://randomuser.me/api/?results=10");
                var json = JObject.Parse(response);

                foreach (var u in json["results"])
                {
                    var usuarioId = Guid.NewGuid();

                    var name = new Name
                    {
                        IdName = Guid.NewGuid(),
                        IdUsuario = usuarioId,
                        Title = u["name"]["title"].ToString(),
                        First = u["name"]["first"].ToString(),
                        Last = u["name"]["last"].ToString()
                    };

                    var dateOfBirth = new DateOfBirth
                    {
                        IdDateOfBirth = Guid.NewGuid(),
                        IdUsuario = usuarioId,
                        Age = Convert.ToInt32(u["dob"]["age"].ToString()),
                        Date = u["dob"]["date"].ToString()
                    };

                    var street = new Street
                    {
                        IdStreet = Guid.NewGuid(),
                        IdUsuario = usuarioId,
                        Number = Convert.ToInt32(u["location"]["street"]["number"].ToString()),
                        Name = u["location"]["street"]["name"].ToString()
                    };


                    var coordinates = new Coordinates
                    {
                        IdCoordinates = Guid.NewGuid(),
                        IdUsuario = usuarioId,
                        Latitude = u["location"]["coordinates"]["latitude"].ToString(),
                        Longitude = u["location"]["coordinates"]["longitude"].ToString()
                    };

                    var timezone = new Timezone
                    {
                        IdTimezone = Guid.NewGuid(),
                        IdUsuario = usuarioId,
                        Offset = u["location"]["timezone"]["offset"].ToString(),
                        Description = u["location"]["timezone"]["description"].ToString()
                    };

                    var location = new Location
                    {
                        IdLocation = Guid.NewGuid(),
                        IdUsuario = usuarioId,
                        IdCoordinates = coordinates.IdCoordinates,
                        IdTimezone = timezone.IdTimezone,
                        IdStreet = street.IdStreet,
                        City = u["location"]["city"].ToString(),
                        State = u["location"]["state"].ToString(),
                        Country = u["location"]["country"].ToString(),
                        Postcode = u["location"]["postcode"].ToString(),
                    };

                    var login = new Login
                    {
                        IdLogin = Guid.NewGuid(),
                        IdUsuario = usuarioId,
                        Uuid = u["login"]["uuid"].ToString(),
                        Username = u["login"]["username"].ToString(),
                        Password = u["login"]["password"].ToString(),
                        Salt = u["login"]["salt"].ToString(),
                        Md5 = u["login"]["md5"].ToString(),
                        Sha1 = u["login"]["sha1"].ToString(),
                        Sha256 = u["login"]["sha256"].ToString()
                    };

                    var registered = new Registered
                    {
                        IdRegistered = Guid.NewGuid(),
                        IdUsuario = usuarioId,
                        Date = u["registered"]["date"].ToString(),
                        Age = Convert.ToInt32(u["registered"]["age"].ToString())
                    };

                    var id = new Id
                    {
                        Idid = Guid.NewGuid(),
                        IdUsuario = usuarioId,
                        Name = u["id"]["name"].ToString(),
                        Value = u["id"]["value"].ToString()
                    };

                    var picture = new Picture
                    {
                        IdPicture = Guid.NewGuid(),
                        IdUsuario = usuarioId,
                        Large = u["picture"]["large"].ToString(),
                        Medium = u["picture"]["medium"].ToString(),
                        Thumbnail = u["picture"]["thumbnail"].ToString()
                    };

                    await _context.Pictures.AddAsync(picture);
                    await _context.Ids.AddAsync(id);
                    await _context.Registrations.AddAsync(registered);
                    await _context.Logins.AddAsync(login);
                    await _context.Timezones.AddAsync(timezone);
                    await _context.Coordinates.AddAsync(coordinates);
                    await _context.Streets.AddAsync(street);
                    await _context.Locations.AddAsync(location);
                    await _context.Names.AddAsync(name);
                    await _context.DateOfBirths.AddAsync(dateOfBirth);

                    var usuario = new Usuario
                    {
                        Id = usuarioId,
                        Gender = u["gender"].ToString(),
                        Email = u["email"].ToString(),
                        Phone = u["phone"].ToString(),
                        Cell = u["cell"].ToString(),
                        Nat = u["nat"].ToString(),
                    };

                    await _context.Usuarios.AddAsync(usuario);
                }

                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception)
            {
                throw;
            }

        }

        [Route("/Usuarios/Listar")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Usuario>>> ListarUsuarios()
        {
            try
            {
                var todosUsuarios = await _context.Usuarios.ToListAsync();
                var usuariosViewModel = UsuarioViewModelToUsuario(todosUsuarios);
                return Ok(usuariosViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<UsuarioViewModel> UsuarioViewModelToUsuario(List<Usuario> usuarios)
        {
            try
            {
                var usuariosViewModel = usuarios.Select(usuario => new UsuarioViewModel
                {
                    IdUsuario = usuario.Id,

                    Gender = usuario.Gender,


                    Name = _context.Names
                                  .Where(n => n.IdUsuario == usuario.Id)
                                  .Select(n => new NameViewModel
                                  {
                                      Title = n.Title,
                                      First = n.First,
                                      Last = n.Last
                                  }).FirstOrDefault(),


                    DateOfBirth = _context.DateOfBirths
                                  .Where(dob => dob.IdUsuario == usuario.Id)
                                  .Select(dob => new DateOfBirthViewModel
                                  {
                                      Date = dob.Date,
                                      IdUsuario = dob.IdUsuario,
                                      Age = dob.Age
                                  }).FirstOrDefault(),


                    Location = _context.Locations
                                  .Where(l => l.IdUsuario == usuario.Id)
                                  .Select(l => new LocationViewModel
                                  {
                                      City = l.City,
                                      State = l.State,
                                      Country = l.Country,
                                      Postcode = l.Postcode,
                                      Street = _context.Streets
                                          .Where(s => s.IdStreet == l.IdStreet)
                                          .Select(s => new StreetViewModel
                                          {
                                              Number = s.Number,
                                              Name = s.Name
                                          }).FirstOrDefault(),
                                      Coordinates = _context.Coordinates
                                          .Where(c => c.IdCoordinates == l.IdCoordinates)
                                          .Select(c => new CoordinatesViewModel
                                          {
                                              Latitude = c.Latitude,
                                              Longitude = c.Longitude
                                          }).FirstOrDefault(),
                                      Timezone = _context.Timezones
                                          .Where(t => t.IdTimezone == l.IdTimezone)
                                          .Select(t => new TimezoneViewModel
                                          {
                                              Offset = t.Offset,
                                              Description = t.Description
                                          }).FirstOrDefault()
                                  }).FirstOrDefault(),

                    Email = usuario.Email,


                    Login = _context.Logins
                                  .Where(lg => lg.IdUsuario == usuario.Id)
                                  .Select(lg => new LoginViewModel
                                  {
                                      Uuid = lg.Uuid,
                                      Username = lg.Username,
                                      Password = lg.Password,
                                      Salt = lg.Salt,
                                      Md5 = lg.Md5,
                                      Sha1 = lg.Sha1,
                                      Sha256 = lg.Sha256
                                  }).FirstOrDefault(),

                    Registered = _context.Registrations
                                  .Where(r => r.IdUsuario == usuario.Id)
                                  .Select(r => new RegisteredViewModel
                                  {
                                      Date = r.Date,
                                      Age = r.Age
                                  }).FirstOrDefault(),

                    Phone = usuario.Phone,
                    Cell = usuario.Cell,

                    Id = _context.Ids
                                  .Where(i => i.IdUsuario == usuario.Id)
                                  .Select(i => new IdViewModel
                                  {
                                      Name = i.Name,
                                      Value = i.Value
                                  }).FirstOrDefault(),

                    Picture = _context.Pictures
                                  .Where(p => p.IdUsuario == usuario.Id)
                                  .Select(p => new PictureViewModel
                                  {
                                      Large = p.Large,
                                      Medium = p.Medium,
                                      Thumbnail = p.Thumbnail
                                  }).FirstOrDefault(),

                    // Preenchendo o Nat
                    Nat = usuario.Nat

                }).ToList();

                return usuariosViewModel;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("/Usuarios/Editar")]
        [HttpPut]
        [AllowAnonymous]
        public async Task<ActionResult> Editar(Guid idUsuario, [FromBody] UsuarioViewModel usuarioViewModel)
        {
            try
            {
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == idUsuario);

                UpdateDadosUsuario(usuarioViewModel, usuario);

                return Ok(usuarioViewModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private Usuario UpdateDadosUsuario(UsuarioViewModel viewModel, Usuario usuario)
        {
            var usuarioUpdate = _context.Usuarios.FirstOrDefault(x => x.Id == usuario.Id);
            var nameoUpdate = _context.Names.FirstOrDefault(x => x.IdUsuario == usuario.Id);
            var locationoUpdate = _context.Locations.FirstOrDefault(x => x.IdUsuario == usuario.Id);
            var streetUpdate = _context.Streets.FirstOrDefault(x => x.IdUsuario == usuario.Id);
            var coordinatesUpdate = _context.Coordinates.FirstOrDefault(x => x.IdUsuario == usuario.Id);
            var timezonetesUpdate = _context.Timezones.FirstOrDefault(x => x.IdUsuario == usuario.Id);
            var loginUpdate = _context.Logins.FirstOrDefault(x => x.IdUsuario == usuario.Id);
            var dateOfBirthUpdate = _context.DateOfBirths.FirstOrDefault(x => x.IdUsuario == usuario.Id);
            var registeredUpdate = _context.Registrations.FirstOrDefault(x => x.IdUsuario == usuario.Id);
            var idUpdate = _context.Ids.FirstOrDefault(x => x.IdUsuario == usuario.Id);
            var pictureUpdate = _context.Pictures.FirstOrDefault(x => x.IdUsuario == usuario.Id);

            usuarioUpdate.Gender = viewModel.Gender;
            usuarioUpdate.Email = viewModel.Email;
            usuarioUpdate.Phone = viewModel.Phone;
            usuarioUpdate.Cell = viewModel.Cell;
            usuarioUpdate.Nat = viewModel.Nat;

            nameoUpdate.First = viewModel.Name.First;
            nameoUpdate.Last = viewModel.Name.Last;
            nameoUpdate.Title = viewModel.Name.Title;

            locationoUpdate.City = viewModel.Location.City;
            locationoUpdate.State = viewModel.Location.State;
            locationoUpdate.Country = viewModel.Location.Country;
            locationoUpdate.Postcode = viewModel.Location.Postcode;

            streetUpdate.Name = viewModel.Location.Street.Name;
            streetUpdate.Number = viewModel.Location.Street.Number;

            coordinatesUpdate.Latitude = viewModel.Location.Coordinates.Latitude;
            coordinatesUpdate.Longitude = viewModel.Location.Coordinates.Longitude;

            timezonetesUpdate.Offset = viewModel.Location.Timezone.Offset;
            timezonetesUpdate.Description = viewModel.Location.Timezone.Description;

            loginUpdate.Uuid = viewModel.Login.Uuid;
            loginUpdate.Username = viewModel.Login.Username;
            loginUpdate.Password = viewModel.Login.Password;
            loginUpdate.Salt = viewModel.Login.Salt;
            loginUpdate.Md5 = viewModel.Login.Md5;
            loginUpdate.Sha1 = viewModel.Login.Sha1;
            loginUpdate.Sha256 = viewModel.Login.Sha256;

            dateOfBirthUpdate.Date = viewModel.DateOfBirth.Date;
            dateOfBirthUpdate.Age = viewModel.DateOfBirth.Age;

            registeredUpdate.Date = viewModel.Registered.Date;
            registeredUpdate.Age = viewModel.Registered.Age;

            idUpdate.Name = viewModel.Id.Name;
            idUpdate.Value = viewModel.Id.Value;

            pictureUpdate.Large = viewModel.Picture.Large;
            pictureUpdate.Medium = viewModel.Picture.Medium;
            pictureUpdate.Thumbnail = viewModel.Picture.Thumbnail;

            _context.Usuarios.Update(usuarioUpdate);
            _context.Names.Update(nameoUpdate);
            _context.Locations.Update(locationoUpdate);
            _context.Streets.Update(streetUpdate);
            _context.Coordinates.Update(coordinatesUpdate);
            _context.Timezones.Update(timezonetesUpdate);
            _context.Logins.Update(loginUpdate);
            _context.DateOfBirths.Update(dateOfBirthUpdate);
            _context.Registrations.Update(registeredUpdate);
            _context.Ids.Update(idUpdate);
            _context.Pictures.Update(pictureUpdate);

            _context.SaveChanges();

            return usuario;
        }
    }
}
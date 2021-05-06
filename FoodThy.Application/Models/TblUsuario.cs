#nullable disable

namespace FoodThy.Application.Models
{
    public partial class TblUsuario
    {
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public bool? PendienteConfirmar { get; set; }
        public bool? Estado { get; set; }
        public string Contrasena { get; set; }
    }
}

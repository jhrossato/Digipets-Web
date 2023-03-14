using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digipets.API.Entities
{
    [Table("TB_Admins")]
    public sealed class Admin : UserBase
    {
        public int ClinicaId { get; set; }
    }
}

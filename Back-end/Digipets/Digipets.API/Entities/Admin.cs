using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digipets.API.Entities
{
    public sealed class Admin : UserBase
    {
        public Clinica Clinica { get; private set; }
    }
}

using AutoMapper;
using Digipets.Application.DTOs;
using Digipets.Domain.Entities;

namespace Digipets.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Veterinario, VeterinarioDTO>().ReverseMap();
            CreateMap<Tutor, TutorDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap();
            CreateMap<Animal, AnimalDTO>().ReverseMap();
            CreateMap<Vacina, VacinaDTO>().ReverseMap();
            CreateMap<Vacina, VacinaDetailsDTO>().ReverseMap();
            CreateMap<VacinaAplicada, VacinaAplicadaDTO>().ReverseMap();
            CreateMap<VacinaAplicada, VacinaAplicadaDetailsDTO>().ReverseMap();
        }
    }
}

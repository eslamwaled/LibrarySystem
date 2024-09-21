using AutoMapper;
using LibrarySystem.Models.Entities;
using LibrarySystem.Services.Src.Services.author.DRO;
using LibrarySystem.Services.Src.Services.book.DTO;
using LibrarySystem.Services.Src.Services.user.DTO;

namespace LibrarySystem.Services.Src.AutoMapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Author, AuthorDTO>()
                          .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.Books))
                          .ReverseMap()
                          .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.Books));          

            CreateMap<User, UserDTO>().ReverseMap();

            CreateMap<Book, BookDTO>().ReverseMap();
        }

    }
}
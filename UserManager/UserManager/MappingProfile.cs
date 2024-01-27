using AutoMapper;
using UserManager.CQRS.Users.ViewModel;
using UserManager.Models;

namespace UserManager
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(user => user.Id, view => view.MapFrom(entity => entity.Id))
                .ForMember(user => user.FirstName, view => view.MapFrom(entity => entity.FirstName))
                .ForMember(user => user.LastName, view => view.MapFrom(entity => entity.LastName))
                .ForMember(user => user.Country, view => view.MapFrom(entity => entity.Country))
                .ForMember(user => user.Province, view => view.MapFrom(entity => entity.Province))
                .ForMember(user => user.City, view => view.MapFrom(entity => entity.City))
                .ForMember(user => user.ZipCode, view => view.MapFrom(entity => entity.ZipCode))
                .ForMember(user => user.Birthdate, view => view.MapFrom(entity => entity.Birthdate))
                .ForMember(user => user.PhoneNumber, view => view.MapFrom(entity => entity.PhoneNumber))
                .ForMember(user => user.Email, view => view.MapFrom(entity => entity.Email))
                .ForMember(user => user.Username, view => view.MapFrom(entity => entity.Username))
                .ForMember(user => user.PasswordHash, view => view.MapFrom(entity => entity.PasswordHash))
                .ForMember(user => user.LinkedInProfileUrl, view => view.MapFrom(entity => entity.LinkedInProfileUrl))
                .ForMember(user => user.IsDeleted, view => view.MapFrom(entity => entity.IsDeleted))
                .ForMember(user => user.LastModification, view => view.MapFrom(entity => entity.LastModification));
            CreateMap<UserViewModel, User>()
                .ForMember(user => user.Id, view => view.MapFrom(entity => entity.Id))
                .ForMember(user => user.FirstName, view => view.MapFrom(entity => entity.FirstName))
                .ForMember(user => user.LastName, view => view.MapFrom(entity => entity.LastName))
                .ForMember(user => user.Country, view => view.MapFrom(entity => entity.Country))
                .ForMember(user => user.Province, view => view.MapFrom(entity => entity.Province))
                .ForMember(user => user.City, view => view.MapFrom(entity => entity.City))
                .ForMember(user => user.ZipCode, view => view.MapFrom(entity => entity.ZipCode))
                .ForMember(user => user.Birthdate, view => view.MapFrom(entity => entity.Birthdate))
                .ForMember(user => user.PhoneNumber, view => view.MapFrom(entity => entity.PhoneNumber))
                .ForMember(user => user.Email, view => view.MapFrom(entity => entity.Email))
                .ForMember(user => user.Username, view => view.MapFrom(entity => entity.Username))
                .ForMember(user => user.PasswordHash, view => view.MapFrom(entity => entity.PasswordHash))
                .ForMember(user => user.LinkedInProfileUrl, view => view.MapFrom(entity => entity.LinkedInProfileUrl))
                .ForMember(user => user.IsDeleted, view => view.MapFrom(entity => entity.IsDeleted))
                .ForMember(user => user.LastModification, view => view.MapFrom(entity => entity.LastModification));
        }
    }
}

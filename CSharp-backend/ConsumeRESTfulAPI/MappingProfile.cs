using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Users.ViewModel;
using ConsumeRESTfulAPI.Model;

namespace ConsumeRESTfulAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(user => user.Id, view => view.MapFrom(entity => entity.Id))
                .ForMember(user => user.Name, view => view.MapFrom(entity => entity.Name))
                .ForMember(user => user.Email, view => view.MapFrom(entity => entity.Email))
                .ForMember(user => user.Password, view => view.MapFrom(entity => entity.Password))
                .ForMember(user => user.Address, view => view.MapFrom(entity => entity.Address))
                .ForMember(user => user.Country, view => view.MapFrom(entity => entity.Country))
                .ForMember(user => user.City, view => view.MapFrom(entity => entity.City))
                .ForMember(user => user.Salary, view => view.MapFrom(entity => entity.Salary))
                .ForMember(user => user.IsDeleted, view => view.MapFrom(entity => entity.IsDeleted))
                .ForMember(user => user.InsertedDateTime, view => view.MapFrom(entity => entity.InsertedDateTime))
                .ForMember(user => user.UpdatedDateTime, view => view.MapFrom(entity => entity.UpdatedDateTime))
                .ForMember(user => user.DeletedDateTime, view => view.MapFrom(entity => entity.DeletedDateTime))
                .ForMember(user => user.CurrentUser, view => view.MapFrom(entity => entity.CurrentUser));

            CreateMap<UserViewModel, User>()
                .ForMember(user => user.Id, view => view.MapFrom(entity => entity.Id))
                .ForMember(user => user.Name, view => view.MapFrom(entity => entity.Name))
                .ForMember(user => user.Email, view => view.MapFrom(entity => entity.Email))
                .ForMember(user => user.Password, view => view.MapFrom(entity => entity.Password))
                .ForMember(user => user.Address, view => view.MapFrom(entity => entity.Address))
                .ForMember(user => user.Country, view => view.MapFrom(entity => entity.Country))
                .ForMember(user => user.City, view => view.MapFrom(entity => entity.City))
                .ForMember(user => user.Salary, view => view.MapFrom(entity => entity.Salary))
                .ForMember(user => user.IsDeleted, view => view.MapFrom(entity => entity.IsDeleted))
                .ForMember(user => user.InsertedDateTime, view => view.MapFrom(entity => entity.InsertedDateTime))
                .ForMember(user => user.UpdatedDateTime, view => view.MapFrom(entity => entity.UpdatedDateTime))
                .ForMember(user => user.DeletedDateTime, view => view.MapFrom(entity => entity.DeletedDateTime))
                .ForMember(user => user.CurrentUser, view => view.MapFrom(entity => entity.CurrentUser));
        }
    }
}

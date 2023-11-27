using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;
using ConsumeRESTfulAPI.CQRS.Products.ViewModel;
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
                .ForMember(user => user.CurrentUser, view => view.MapFrom(entity => entity.CurrentUser))
                .ForMember(user => user.CurrentUserId, view => view.MapFrom(entity => entity.CurrentUserId));
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
                .ForMember(user => user.CurrentUser, view => view.MapFrom(entity => entity.CurrentUser))
                .ForMember(user => user.CurrentUserId, view => view.MapFrom(entity => entity.CurrentUserId));

            CreateMap<Device, DeviceViewModel>()
                .ForMember(device => device.Id, view => view.MapFrom(entity => entity.Id))
                .ForMember(device => device.Name, view => view.MapFrom(entity => entity.Name))
                .ForMember(device => device.UserId, view => view.MapFrom(entity => entity.UserId))
                .ForMember(device => device.User, view => view.MapFrom(entity => entity.User))
                .ForMember(device => device.Price, view => view.MapFrom(entity => entity.Price))
                .ForMember(device => device.IsDeleted, view => view.MapFrom(entity => entity.IsDeleted))
                .ForMember(device => device.InsertedDateTime, view => view.MapFrom(entity => entity.InsertedDateTime))
                .ForMember(device => device.UpdatedDateTime, view => view.MapFrom(entity => entity.UpdatedDateTime))
                .ForMember(device => device.DeletedDateTime, view => view.MapFrom(entity => entity.DeletedDateTime))
                .ForMember(device => device.CurrentUser, view => view.MapFrom(entity => entity.CurrentUser))
                .ForMember(device => device.CurrentUserId, view => view.MapFrom(entity => entity.CurrentUserId));
            CreateMap<DeviceViewModel, Device>()
                .ForMember(device => device.Id, view => view.MapFrom(entity => entity.Id))
                .ForMember(device => device.Name, view => view.MapFrom(entity => entity.Name))
                .ForMember(device => device.UserId, view => view.MapFrom(entity => entity.UserId))
                .ForMember(device => device.User, view => view.MapFrom(entity => entity.User))
                .ForMember(device => device.Price, view => view.MapFrom(entity => entity.Price))
                .ForMember(device => device.IsDeleted, view => view.MapFrom(entity => entity.IsDeleted))
                .ForMember(device => device.InsertedDateTime, view => view.MapFrom(entity => entity.InsertedDateTime))
                .ForMember(device => device.UpdatedDateTime, view => view.MapFrom(entity => entity.UpdatedDateTime))
                .ForMember(device => device.DeletedDateTime, view => view.MapFrom(entity => entity.DeletedDateTime))
                .ForMember(device => device.CurrentUser, view => view.MapFrom(entity => entity.CurrentUser))
                .ForMember(device => device.CurrentUserId, view => view.MapFrom(entity => entity.CurrentUserId));

            CreateMap<Product, ProductViewModel>()
                .ForMember(product => product.Id, view => view.MapFrom(entity => entity.Id))
                .ForMember(product => product.Name, view => view.MapFrom(entity => entity.Name))
                .ForMember(product => product.Price, view => view.MapFrom(entity => entity.Price))
                .ForMember(product => product.QuantityInStock, view => view.MapFrom(entity => entity.QuantityInStock))
                .ForMember(product => product.IsDeleted, view => view.MapFrom(entity => entity.IsDeleted))
                .ForMember(product => product.InsertedDateTime, view => view.MapFrom(entity => entity.InsertedDateTime))
                .ForMember(product => product.UpdatedDateTime, view => view.MapFrom(entity => entity.UpdatedDateTime))
                .ForMember(product => product.DeletedDateTime, view => view.MapFrom(entity => entity.DeletedDateTime))
                .ForMember(product => product.CurrentUser, view => view.MapFrom(entity => entity.CurrentUser))
                .ForMember(product => product.CurrentUserId, view => view.MapFrom(entity => entity.CurrentUserId));
            CreateMap<ProductViewModel, Product>()
                .ForMember(product => product.Id, view => view.MapFrom(entity => entity.Id))
                .ForMember(product => product.Name, view => view.MapFrom(entity => entity.Name))
                .ForMember(product => product.Price, view => view.MapFrom(entity => entity.Price))
                .ForMember(product => product.QuantityInStock, view => view.MapFrom(entity => entity.QuantityInStock))
                .ForMember(product => product.IsDeleted, view => view.MapFrom(entity => entity.IsDeleted))
                .ForMember(product => product.InsertedDateTime, view => view.MapFrom(entity => entity.InsertedDateTime))
                .ForMember(product => product.UpdatedDateTime, view => view.MapFrom(entity => entity.UpdatedDateTime))
                .ForMember(product => product.DeletedDateTime, view => view.MapFrom(entity => entity.DeletedDateTime))
                .ForMember(product => product.CurrentUser, view => view.MapFrom(entity => entity.CurrentUser))
                .ForMember(product => product.CurrentUserId, view => view.MapFrom(entity => entity.CurrentUserId));
        }
    }
}

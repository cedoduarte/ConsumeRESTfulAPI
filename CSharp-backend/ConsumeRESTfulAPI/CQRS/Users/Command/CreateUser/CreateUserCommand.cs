﻿using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Users.Command.CreateUser
{
    public class CreateUserCommand : IRequest<bool>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? ConfirmedEmail { get; set; }
        public string? Password { get; set; }
        public string? ConfirmedPassword { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public decimal Salary { get; set; }
    }
}

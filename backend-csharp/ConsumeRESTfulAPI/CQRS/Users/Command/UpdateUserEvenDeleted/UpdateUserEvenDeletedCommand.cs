using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Users.Command.UpdateUserEvenDeleted
{
    public class UpdateUserEvenDeletedCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public decimal Salary { get; set; }
        public int CurrentUserId { get; set; }
    }
}

using ConsumeRESTfulAPI.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Users.Command.DeleteUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public DeleteUserHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(DeleteUserCommand command, CancellationToken cancel)
        {
            try
            {
                User? existingUser = await _dbContext.Users
                    .Where(user => !user.IsDeleted && user.Id == command.Id)
                    .FirstOrDefaultAsync(cancel);
                if (existingUser is null)
                {
                    throw new Exception($"{nameof(User)} with ID {command.Id} not exists!");
                }
                existingUser.IsDeleted = true;
                existingUser.DeletedDateTime = DateTime.Now;
                existingUser.CurrentUserId = command.CurrentUserId;
                _dbContext.Users.Update(existingUser);
                await _dbContext.SaveChangesAsync(cancel);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

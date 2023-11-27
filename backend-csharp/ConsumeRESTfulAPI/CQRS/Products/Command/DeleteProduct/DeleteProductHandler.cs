using ConsumeRESTfulAPI.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Products.Command.DeleteProduct
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public DeleteProductHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(DeleteProductCommand command, CancellationToken cancel)
        {
            try
            {
                // checks the current user exists
                User? currentUser = await _dbContext.Users
                    .Where(user => user.Id == command.CurrentUserId && !user.IsDeleted)
                    .FirstOrDefaultAsync(cancel);
                if (currentUser is null)
                {
                    throw new Exception($"{nameof(User)} with ID {command.CurrentUserId} not exists!");
                }

                Product? existingProduct = await _dbContext.Products
                    .Where(product => !product.IsDeleted && product.Id == command.Id)
                    .FirstOrDefaultAsync(cancel);
                if (existingProduct is null)
                {
                    throw new Exception($"{nameof(Product)} with ID {command.Id} not exists!");
                }
                existingProduct.IsDeleted = true;
                existingProduct.DeletedDateTime = DateTime.Now;
                existingProduct.CurrentUserId = command.CurrentUserId;
                _dbContext.Products.Update(existingProduct);
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

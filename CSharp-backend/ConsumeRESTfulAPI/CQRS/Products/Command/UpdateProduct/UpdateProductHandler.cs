using ConsumeRESTfulAPI.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Products.Command.UpdateProduct
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public UpdateProductHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(UpdateProductCommand command, CancellationToken cancel)
        {
            try
            {
                if (string.IsNullOrEmpty(command.Name))
                {
                    throw new Exception("The name cannot be empty!");
                }

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
                existingProduct.Name = command.Name;
                existingProduct.Price = command.Price;
                existingProduct.QuantityInStock = command.QuantityInStock;
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

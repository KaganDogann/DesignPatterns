using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand updateProductCommand)
        {
            var values = _context.Products.Find(updateProductCommand.ProductId);
            values.Name = updateProductCommand.Name;
            values.Status = true;
            values.Description = updateProductCommand.Description;
            values.Price = updateProductCommand.Price;
            values.Stock = updateProductCommand.Stock;
            _context.SaveChanges();
        }
    }
}
 


namespace Basket.API.Basket.StoreBasket
{
    public record StoreaBasketCommand(ShoppingCart Cart) : ICommand<StoreBasketResult>;
    public record StoreBasketResult(string UserName);

    public class StoreaBasketCommandValidator : AbstractValidator<StoreaBasketCommand>
    {
        public StoreaBasketCommandValidator()
        {

            RuleFor(x => x.Cart).NotNull().WithMessage("Cart can not be null");
            RuleFor(x => x.Cart.UserName).NotEmpty().WithMessage("UserName is required");
        }
        public class StoreBasketCommandHandler
            : ICommandHandler<StoreaBasketCommand, StoreBasketResult>
        {
            public async Task<StoreBasketResult> Handle(StoreaBasketCommand command, CancellationToken cancellationToken)
            {
                ShoppingCart cart = command.Cart;

                //Todo = store basket in database
                //Todo = update cache

                return new StoreBasketResult("sdw");
            }
        }
    }
}

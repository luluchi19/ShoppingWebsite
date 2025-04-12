using ShoppingWeb.Models;
using ShoppingWeb.Models.Momo;

namespace ShoppingWeb.Services.Momo
{
    public interface IMomoService
    {
        Task<MomoCreatePaymentResponseModel> CreatePaymentMomo(OrderInfoModel model);

        MomoExecuteResponseModel PaymentExecuteAsync(IQueryCollection collection);
    }
}

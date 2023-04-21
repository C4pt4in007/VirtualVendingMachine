using Microsoft.AspNetCore.Mvc;
using VirtualVendingMachine.Model;
using VirtualVendingMachine.Models;
using VirtualVendingMachine.Service.CancelPurchaseService;
using VirtualVendingMachine.Service.ProductDetailsService;
using VirtualVendingMachine.Service.InsertMoneyService;
using VirtualVendingMachine.Service.PurchaseService;

namespace VirtualVendingMachine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VirtualVendingMachineController : ControllerBase
    {
        private readonly IProductDetailsService productDetailsService;
        private readonly IInsertMoneyService insertMoneyService;
        private readonly ICancelPurchaseService cancelPurchaseService;
        private readonly IPurchaseService makePurchaseService;

        public VirtualVendingMachineController(IProductDetailsService productDetailsService, IInsertMoneyService insertMoneyService, ICancelPurchaseService cancelPurchaseService, IPurchaseService makePurchaseService)
        {
            this.productDetailsService = productDetailsService;
            this.insertMoneyService = insertMoneyService;
            this.cancelPurchaseService = cancelPurchaseService;
            this.makePurchaseService = makePurchaseService;            
        }

        [HttpGet("{id}")]
        public ProductDetailsResponseEntity Get(int id)
        {
            return productDetailsService.GetProductDetails(id);
        }

        [Consumes("application/json")]
        [HttpPut("/insertmoney")]
        public InsertMoneyResponseEntity Put([FromBody] InsertMoneyRequestEntity insertMoneyRequestEntity)
        {
            return insertMoneyService.InsertMoneyInTheMachine(insertMoneyRequestEntity.productId, insertMoneyRequestEntity.amount);
        }

        [Consumes("application/json")]
        [HttpPut("/cancel")]
        public bool CancelPurchase()
        {
            return cancelPurchaseService.CancelPurchase();
        }

        [Consumes("application/json")]
        [HttpPost("/purchase")]
        public PurchaseResponseEntity PurchaseProduct([FromBody] PurchaseRequestEntity purchaseRequestEntity)
        {
            return makePurchaseService.BuyProductAndReturnChange(purchaseRequestEntity.productId);
        }
    }
}
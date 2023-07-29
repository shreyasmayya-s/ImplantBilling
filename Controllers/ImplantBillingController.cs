using Microsoft.AspNetCore.Mvc;
using ImplantBillingService.Models;
using ImplantBillingService.Services;

namespace ImplantBillingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        private readonly BillingService _billingService;

        public BillingController(BillingService billingService)
        {
            _billingService = billingService;
        }

        [HttpPost]
        public ActionResult<ImplantBillingResponse> CalculateBill(UsageRequestModel input)
        {
            var billOutput = _billingService.CalculateBill(input);
            return Ok(billOutput);
        }
    }
}

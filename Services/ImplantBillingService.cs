using System.Collections.Generic;
using System.Linq;
using ImplantBillingService.Factories.Factory;
using ImplantBillingService.Models;

namespace ImplantBillingService.Services
{
    public class BillingService
    {

        public readonly ImplantBillFactory _implantFactory;

        public BillingService(ImplantBillFactory implantFactory)
        {
            _implantFactory = implantFactory;
        }

        public ImplantBillingResponse CalculateBill(UsageRequestModel usageInput)
        {
            decimal totalBill = 0m;

            foreach (var usage in usageInput.Usages)
            {
                var implantTypeInstance = _implantFactory.CreateImplantTypeInstance(usage.featureName);
                var implantTypeTotal = implantTypeInstance.getImplantTypeTotalBill(usage);
                totalBill += implantTypeTotal;
            }
            
            return new ImplantBillingResponse { BillableAmount = totalBill };
        }
    }
}
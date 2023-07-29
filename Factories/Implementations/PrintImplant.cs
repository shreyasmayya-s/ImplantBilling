using ImplantBillingService.Factories.Interface;
using ImplantBillingService.Models;

namespace ImplantBillingService.Factories.Implementation
{
    public class PrintImplant : IImplant
    {
        public decimal getImplantTypeTotalBill(Usage usage)
        {
            var totalPrintImplantBill = 0m;
            if (usage.quantityUsed > 25)
            {
                var extraTierUsage = usage.quantityUsed - 25;
                var chargeForExtraTierUsage = extraTierUsage * 59.99m;
                var chargeForInitialTierUsage = 5m * 49.99m;
                totalPrintImplantBill += (chargeForExtraTierUsage + chargeForInitialTierUsage);
            }
            else
            {
                var chargeForInitialTierUsage = usage.quantityUsed * 49.99m;
                totalPrintImplantBill += chargeForInitialTierUsage;
            }
            return totalPrintImplantBill;
        }
    }
}
using ImplantBillingService.Factories.Interface;
using ImplantBillingService.Models;

namespace ImplantBillingService.Factories.Implementation
{
    public class DesignImplant : IImplant
    {
        public decimal getImplantTypeTotalBill(Usage usage)
        {
            var totalDesignImplantBill = 0m;
            if (usage.quantityUsed > 5)
            {
                var extraTierUsage = usage.quantityUsed - 5;
                var chargeForExtraTierUsage = extraTierUsage * 34.99m;
                var chargeForInitialTierUsage = 5m * 29.99m;
                totalDesignImplantBill += (chargeForExtraTierUsage + chargeForInitialTierUsage);
            }
            else
            {
                var chargeForInitialTierUsage = usage.quantityUsed * 29.99m;
                totalDesignImplantBill += chargeForInitialTierUsage;
            }
            return totalDesignImplantBill;
        }
    }
}
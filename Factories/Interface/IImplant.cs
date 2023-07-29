using ImplantBillingService.Models;

namespace ImplantBillingService.Factories.Interface
{
    public interface IImplant
    {
        decimal getImplantTypeTotalBill(Usage usage);
    }
}
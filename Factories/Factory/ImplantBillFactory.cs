using ImplantBillingService.Factories.Implementation;
using ImplantBillingService.Factories.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ImplantBillingService.Factories.Factory
{
    public class ImplantBillFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ImplantBillFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IImplant CreateImplantTypeInstance(string category)
        {
            switch (category)
            {
                case "DesignImplant":
                    return (IImplant)_serviceProvider.GetService(typeof(DesignImplant));
                case "PrintImplant":
                    return (IImplant)_serviceProvider.GetService(typeof(PrintImplant));
                default:
                    throw new ArgumentException("Invalid category.");
            }
        }
    }

}

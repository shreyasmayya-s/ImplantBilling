namespace ImplantBillingService.Models
{
    public class Usage
    {
        public string featureName { get; set; }
        public int quantityUsed { get; set; }
    }

    public class UsageRequestModel
    {
        public List<Usage> Usages {get; set;}
    }
}
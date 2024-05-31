namespace sicotyc.entities.RequestFeatures
{
    public class CompanyParameters : RequestParameters
    {
        public CompanyParameters()
        {
            OrderBy = "CompanyName";
        }

        public string SearchTerm { get; set; }
    }
}

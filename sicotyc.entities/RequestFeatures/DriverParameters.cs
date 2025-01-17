namespace sicotyc.entities.RequestFeatures
{
    public class DriverParameters : RequestParameters
    {
        public DriverParameters()
        {
            OrderBy = "LastName";
        }

        public string SearchTerm { get; set; }
    }
}

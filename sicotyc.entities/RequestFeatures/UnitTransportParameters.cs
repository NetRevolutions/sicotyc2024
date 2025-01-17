namespace sicotyc.entities.RequestFeatures
{
    public class UnitTransportParameters: RequestParameters
    {
        public UnitTransportParameters() 
        {
            OrderBy = "Plate";
        }

        public string SearchTerm { get; set; }
    }
}

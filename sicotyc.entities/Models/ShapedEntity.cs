namespace sicotyc.entities.Models
{
    public class ShapedEntity
    {
        public ShapedEntity()
        {
            Entity = new Entity();
        }
        public Guid Id { get; set; }
        public Entity Entity { get; set; }
    }
}

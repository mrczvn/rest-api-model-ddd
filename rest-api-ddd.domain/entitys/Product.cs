namespace rest_api_ddd.domain.entitys
{
    public class Product: Base
    {
        public string Name { get; set; }

        public decimal Value { get; set; }

        public bool IsAvailable { get; set; }
    }

}

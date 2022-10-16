namespace healthcare_web_core_api
{
    public class Products
    {
        public int id { get; set; }
        public string title { get; set; } = String.Empty;

        public int price { get; set; }

        public string description { get; set; } = String.Empty;

        public string category { get; set; } = String.Empty;

        public string image { get; set; } = String.Empty;

    }
}

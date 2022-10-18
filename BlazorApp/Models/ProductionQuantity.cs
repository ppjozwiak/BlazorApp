namespace BlazorApp.Models
{
    public class ProductionQuantity
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name=value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public ProductionQuantity() { }

        public ProductionQuantity(string productname, int productquantity)
        {
            Name = productname;
            Quantity = productquantity;
        }
    }
}

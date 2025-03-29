class Order 
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
    this.customer = customer;
    products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double total =0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        return total;
    }
}
class Order 
{
  private List<Product> products = new List<Product>();
  private Customer _customer;
  public Order(Customer customer)
  {
    _customer = customer;
  }
  public void AddProduct(Product product)
  {
    products.Add(product);
  }

  public double GetTotalPrice()
  {
    double total = 0;
    foreach (Product product in products)
    {
      total += product.GetTotalPrice();
    }

    total += _customer.IsInUSA() ? 5 : 35;
    return total;
  }

  public string GetPackingLabel()
  {
    string label = "Packing Label:\n";
    foreach (Product product in products)
    {
      label += product.GetPackingLabel() + "\n";
    }
    return label;
  }

  public string GetShippingLabel()
  {
    return _customer.GetShippingLabel();
  }

}
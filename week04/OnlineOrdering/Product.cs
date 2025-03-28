class Product
{
  private string _name;
  private int _id;
  private int _quantity;
  private float _price;

  public Product(string name, int id, int quantity, float price)
  {    
    _name = name;
    _id = id;
    _quantity = quantity;
    _price = price;
  }

  public float GetTotalPrice()
  {
    return _quantity * _price;
  }

  public string GetPackingLabel()
  {
    return $"Product: {_name} ID: {_id}";
  }
}
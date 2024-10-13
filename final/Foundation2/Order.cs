using System;
using System.Collections.Generic;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingList()
    { 
        string packingList = "PACKING LIST\n";
        foreach (var product in _products)
        {
            packingList += $"Product: {product.Name}\n ID: {product.Id}\n Price: {product.Price:C}\nQuantity: {product.Quantity}\n";
        }
        packingList += $"Total: {CalculateTotalCost():C}\n";
        return packingList;
    }
    public string GetShippingLabel()
    {
        if (_customer.Address == null)
        {
            return $"SHIPPING LABEL:\n{_customer.FullName}\nNo Address Provided";
        } 
        return $"SHIPPING LABEL:\n{_customer.FullName}\n{_customer.Address.GetFullAddress()}\n";
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.TotalCost();
        }
        totalCost += _customer.InUSA() ? 5 : 35;
        return totalCost;
    }
}


//     public string GetFullOrder()
//     {
//         string orderDetails = "";
//         foreach (var product in _products)
//         {
//             orderDetails += $"Product: {product.ProductName}, Price: {product.Price}, Quantity: {product.Quantity}\n";
//         }
//         return orderDetails;
//     }
//     public int GetOrderCount()
//     {
//         return _products.Count;
//     }
//     public void DisplayOrder()
//     {
//         Console.WriteLine(_customer.FullName);
//         Console.WriteLine(_customer.Address.Street);
//         Console.WriteLine(_customer.Address.City);
//         Console.WriteLine(_customer.Address.State);
//         Console.WriteLine(_customer.Address.Country);
//         Console.WriteLine(_customer.Address.Zipcode);
//         Console.WriteLine($"Total Products: {GetOrderCount()}");
//         foreach (var product in _products)
//         {
//             Console.WriteLine($"Product: {product.ProductName}, Price: {product.Price}, Quantitiy: {product.Quantity}");
//         }


// Order
// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer
using System;
//I didnt include Id because it didnt made sence in the end product//
class Product
{
    private string name;
    private double price;
    private int quantity;


public Product(string name, double price, int quantity)
{
    this.name = name;
    this.price = price;
    this.quantity = quantity;
}

public double GetTotalCost()
{
    return price * quantity;
}

public string GetName() => name;
}

class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country) 
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string GetAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}

class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }
}
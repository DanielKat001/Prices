using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Vehicle

[Serializable]
public class Vehicle
{
    public static int size;
    protected string company;
    protected string type;
    protected int year;
    protected double price;
    protected int index;





    public string COMPANY
    {
        get { return company; }
        set { company = value; }
    }
    public string TYPE
    {
        get { return type; }
        set { type = value; }
    }
    public int YEAR
    {
        get { return year; }
        set { year = value; }
    }
    public double PRICE
    {
        get { return price; }
        set { price = value; }
    }
    public int INDEX
    {
        get { return index; }
        set { index = value; }
    }
}


[Serializable]

public class Car : Vehicle
{

}
[Serializable]
public class Motorcycle : Vehicle
{

}
[Serializable]
public class Toyota : Car
{


    public Toyota(string type, string company,int year, double price, int index)
    {
        this.type = type;
        this.company = company;
        this.year = year;
        this.price = price;
       this.index = index;
    }
}
[Serializable]
public class Kia : Car
{


    public Kia(string type, string company, int year, double price, int index)
    {
        this.type = type;
        this.company = company;
        this.year = year;
        this.price = price;
        this.index = index;
    }
}
[Serializable]
public class Honda : Motorcycle
{

    public Honda(string type, string company, int year, double price, int index)
    {
        this.type = type;
        this.company = company;
        this.year = year;
        this.price = price;
        this.index = index;
    }

}
[Serializable]
public class Suzuki : Motorcycle
{

    public Suzuki(string type, string company, int year, double price, int index)
    {
        this.type = type;
        this.company = company;
        this.year = year;
        this.price = price;
        this.index = index;
    }

}

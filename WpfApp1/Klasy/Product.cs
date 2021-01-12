/***********************************************************************
 * Module:  Product.cs
 * Author:  124671
 * Purpose: Definition of the Class Product
 ***********************************************************************/

using System;

public class Product
{
   
    private string _produtctName;
    private int _amount;

    /// <summary>
    /// Name of the food products stored in the storage
    /// </summary>
    public string ProductName
    {
       get
       {
           return _produtctName;
       }
       set
       {
           _produtctName = value;
       }
    }


    /// <summary>
    /// Ammount of food products stored in the storage
    /// </summary>
    public int Amount
    {
        get
        {
            return _amount;
        }
        set
        {
            _amount = value;
        }
    }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="productName">Type of the Product</param>
    /// <param name="amount">Amount of the product</param>
    public Product(string productName, int amount)
    {
        ProductName = productName;
        Amount = amount;
    }

}
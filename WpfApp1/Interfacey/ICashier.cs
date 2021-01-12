/***********************************************************************
 * Module:  ICashier.cs
 * Author:  124671
 * Purpose: Definition of the Interface ICashier
 ***********************************************************************/

using System;
using System.Collections.Generic;

public interface ICashier
{
    /// <summary>
    /// Create Clear list for products
    /// </summary>
    /// <returns>Empty list of products</returns>
    List<Product> CreateProductList();

    /// <summary>
    /// Get List of ordered porducts
    /// </summary>
    /// <returns>list of the ordered products</returns>
    List<Product> GetListOfOrderedProducts();

    /// <summary>
    /// Add new product to the list
    /// </summary>
    /// <param name="productName">Name of the product that we want to add</param>
    void AddProduct(string productName);

    /// <summary>
    /// Login Casher to system
    /// </summary>
    /// <param name="login">login used by cashier</param>
    /// <param name="password">Password used by cashier</param>
    /// <returns>positive boolean value if login and password are correct</returns>
    bool Login(string login, string password);
}
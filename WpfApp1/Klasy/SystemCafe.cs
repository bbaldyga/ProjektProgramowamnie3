/***********************************************************************
 * Module:  SystemCafe.cs
 * Author:  124671
 * Purpose: Definition of the Class SystemCafe
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class SystemCafe : ISystem, ICashier
{
   

    private List<Cashier> cashiers = new List<Cashier>();
    private List<Manager> managers = new List<Manager>();
    private List<Product> products = new List<Product>();
    private List<Manager> managersloged = new List<Manager>();
    private List<Cashier> cashiersloged = new List<Cashier>();

    private static SystemCafe instance = null;
    public static SystemCafe Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SystemCafe();
            }
            return instance;
        }
    }

    private static ISystem systemInstance = null;
    public static ISystem SystemInstance
    {
        get
        {
            if (systemInstance == null)
            {
                systemInstance = new SystemCafe();
            }
            return systemInstance;
        }
    }
    private static ICashier cashierInstance = null;
    public static ICashier CashierInstance
    {
        get
        {
            if (cashierInstance == null)
            {
                cashierInstance = new SystemCafe();
            }
            return cashierInstance;
        }
    }


    bool ISystem.Login(string login, string password)
    {
        managers.Add(new Manager("manager", "manager1"));
        managers.Add(new Manager("manager2", "manager2"));
        for (int i = 0; i < managers.Count; i++)
        {
            if (login == managers[i].Login)
            {
                if (password == managers[i].Password)
                    return true;
            }
        }
        return false;
    }


    List<Product> ICashier.CreateProductList()
    {
        products.Clear();
        return products;
    }
    List<Product> ICashier.GetListOfOrderedProducts()
    {
        return products;
    }

    void ICashier.AddProduct(string productName)
    {
        products.Add(new Product(productName, 1));
    }

    bool ICashier.Login(string login, string password)
    {
        cashiers.Add(new Cashier("kasjer", "kasjer1"));
        cashiers.Add(new Cashier("kasjer2", "kasjer2"));
        for (int i = 0; i < cashiers.Count; i++)
        {
            if (login == cashiers[i].Login)
            {
                if (password == cashiers[i].Password)
                    return true;
            }
        }
        return false;
    }

    public List<Manager> GetManagers()
    {
        return managersloged;
    }

    public void AddLoggedManager(string login, string password)
    {
        managersloged.Clear();
        managersloged.Add(new Manager(login,password));
    }

    public List<Cashier> GetCashiers()
    {
        return cashiersloged;
    }

    public void AddLoggedCashier(string login, string password)
    {
        cashiersloged.Clear();
        cashiersloged.Add(new Cashier(login, password));
    }

}
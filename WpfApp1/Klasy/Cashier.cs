/***********************************************************************
 * Module:  Cashier.cs
 * Author:  124671
 * Purpose: Definition of the Class Cashier
 ***********************************************************************/

using System;
/// <summary>
/// Allows cashier to login into his account
/// </summary>
public class Cashier : User
{
    private ICashier iCashier;

    private string _login;
    private string _password;

    /// <summary>
    /// Login used by cashier to login to the system
    /// </summary>
    public override string Login
    {
        get
        {
            return _login;
        }
        set
        {
            _login = value;
        }
    }

    /// <summary>
    /// Password used by cashier to login to the system
    /// </summary>
    public override string Password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;
        }
    }
    
    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="login"> Login of the Cashier</param>
    /// <param name="password"> Password of the Cashier</param>
    public Cashier(string login, string password)
    {
        Login = login;
        Password = password;
    }
}
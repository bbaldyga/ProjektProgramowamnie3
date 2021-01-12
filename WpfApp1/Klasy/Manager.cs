/***********************************************************************
 * Module:  Manager.cs
 * Author:  124671
 * Purpose: Definition of the Class Manager
 ***********************************************************************/

using System;

public class Manager : User
{
    private ISystem iSystem;

    private string _login;
    private string _password;

    /// <summary>
    /// Login used by manager to login to the system
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
    /// Pasword used by manager to login in to the system
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
    /// <param name="login"> Login of the Manager</param>
    /// <param name="password"> Password of the Manager</param>
    public Manager(string login, string password)
    {
        Login = login;
        Password = password;
    }
}
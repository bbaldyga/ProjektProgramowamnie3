/***********************************************************************
 * Module:  ISystem.cs
 * Author:  124671
 * Purpose: Definition of the Interface ISystem
 ***********************************************************************/

using System;

public interface ISystem
{
    /// <summary>
    /// Login Manager to system
    /// </summary>
    /// <param name="login"> login used by manager</param>
    /// <param name="password"> Password used by manager</param>
    /// <returns>positive boolean value if login and password are correct</returns>
    bool Login(string login, string password);
}
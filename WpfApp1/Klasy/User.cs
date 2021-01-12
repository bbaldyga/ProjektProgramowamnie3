/***********************************************************************
 * Module:  User.cs
 * Author:  124671
 * Purpose: Definition of the Class User
 ***********************************************************************/

using System;

public abstract class User
{
    /// <summary>
    /// Login of the user
    /// </summary>
    public abstract string Login
    {
        get;
        set;
    }

    /// <summary>
    /// Password of the user
    /// </summary>    
    public abstract string Password
    {
        get;
        set;
    }


}
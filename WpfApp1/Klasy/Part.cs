/***********************************************************************
 * Module:  Part.cs
 * Author:  124671
 * Purpose: Definition of the Class Part
 ***********************************************************************/

using System;

public class Part
{
    

    private string _partName;
    private int _amount;

    /// <summary>
    /// Name of the part in storage
    /// </summary>
    public string PartName
    {
        get
        {
            return _partName;
        }
        set
        {
            _partName = value;
        }
    }

   

    /// <summary>
    /// Amount of parts stored in the storage
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
    public Part()
    {

    }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="part"> name of the part</param>
    /// <param name="amount"> amount of the part</param>
    public Part(string part,int amount)
    {
        PartName = part;
        Amount = amount;
    }

   
}
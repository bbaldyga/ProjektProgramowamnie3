/***********************************************************************
 * Module:  PeripheralDevice.cs
 * Author:  124671
 * Purpose: Definition of the Class PeripheralDevice
 ***********************************************************************/

using System;

public class PeripheralDevice
{
   
    private string _peripheralDeviceName;
    private int _amount;

    /// <summary>
    /// Name of the peripherial devices
    /// </summary>
    public string PeripheralDeviceName
    {
       get
       {
           return _peripheralDeviceName;
       }
       set
       {
           _peripheralDeviceName = value;
       }
    }

    /// <summary>
    /// Amount of peripherial devices stored in the storage
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
    public PeripheralDevice()
    {


    }

    /// <summary>
    /// Classs constructor
    /// </summary>
    /// <param name="deviceName"> name of the peripherial device</param>
    /// <param name="ammount"> ammount of the peripherial devices in the storage</param>
    public PeripheralDevice(string deviceName,int ammount )
    {
        PeripheralDeviceName = deviceName;
        Amount = ammount;
    }

}
/***********************************************************************
 * Module:  Computer.cs
 * Author:  124671
 * Purpose: Definition of the Class Computer
 ***********************************************************************/

using System;

public class Computer
{
    private static int _globalID = 0;
    private int _ID;
    private bool _use;
    private bool _work;
    private string _specification;
    private string _operatingSystem;

    /// <summary>
    /// Identification number of a single Computer
    /// </summary>
    public static int GlobalID
    {
        get
        {
            return _globalID;
        }

        set
        {
            _globalID = value;
        }
    }


    /// <summary>
    /// Identification number of a computer
    /// </summary>
    public int ID
    {
        get
        {
            return _ID;
        }

        set
        {
            _ID = value;
        }
    }

    

    /// <summary>
    /// Represent whether the Computer is working
    /// </summary>
    public bool Work
    {
        get
        {
            return _work;
        }
        set
        {
            _work = value;
        }
    }

   

   

    /// <summary>
    /// Represent whether the Computer is used right
    /// </summary>
    public bool Use
    {
        get
        {
            return _use;
        }
        set
        { 
            _use = value;
        }
    }
  
    

    /// <summary>
    /// Contains entire specification of the Computer
    /// </summary>

    public string Specification
    {
        get
        {
            return _specification;
        }
        set
        {
            _specification = value;
        }
    }

    

    /// <summary>
    /// Represent operating system of the Computer
    /// </summary>

    public string OperatingSystem
    {
        get
        {
            return _operatingSystem;
        }
        set
        {
            _operatingSystem = value;
        }
    }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="iD"> Identity Number assinged to the Computer</param>
    /// <param name="work"> status describing the Computer ability to operate</param>
    /// <param name="use"> status decribing the Computer reservation status</param>
   public Computer(bool work,bool use)
   {
        Computer.GlobalID++;
        ID = GlobalID;
        Work = work;

        if (Work == false)
            Use = false;
        else
            Use = use;

        Specification = "Procesor: AMD Ryzen 7 3700X BOX, P³yta g³ówna: ASRock X470 Master SLI, Karta graficzna: KFA2 RTX 2070 SUPER Black, Pamiêæ RAM: 2x 8 GB Patriot Viper, Dysk SSD: Plextor M9PeGN 1 TB, Zasilacz: Corsair TX550M 550W, Cooler CPU: Thermalright Macho Rev B, Obudowa: be quiet! Pure Base 600";
        OperatingSystem = "Windows 10";
   }
   

}
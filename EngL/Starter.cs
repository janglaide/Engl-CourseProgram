/***********************************************************************
 * Module:  Starter.cs
 * Author:  User
 * Purpose: Definition of the Class Starter
 ***********************************************************************/

using System;

public class Starter
{
    private string name;            
    private string surname;

    public string Name                      //get and set name
    {
        get { return name; }
        set { name = value; }
    }

    public string Surname                   //get and set surname
    {
        get { return surname; }
        set { surname = value; }
    }
    public Starter()                        //default constructor
    {
        name = "DefaultName";
        surname = "DefaultSurname";
    }

    ~Starter()                              //destructor
    {

    }
   public bool Entrance()
   {
      // TODO: implement
      return false;
   }



}
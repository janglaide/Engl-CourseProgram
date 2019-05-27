/***********************************************************************
 * Module:  Student.cs
 * Author:  User
 * Purpose: Definition of the Class Student
 ***********************************************************************/

using System;

public class Student
{
    private string name;    
    private string surname;
    private string level;                      //level of english

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

    public string Level                        //get and set level
    {
        get { return level; }
        set { level = value; }
    }

    public Student()                        //default constructor
    {
        name = "DefaultName";
        surname = "DefaultSurname";
        level = "DefaultLevel";
    }
    ~Student()                              //destructor
    {

    }
   public void Edit()
   {
      // TODO: implement
   }
   
   public void CreateCard()
   {
      // for ceating a file
   }
   
   public void ShowInfo()
   {
      // TODO: implement
   }

}
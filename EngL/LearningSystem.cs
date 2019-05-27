/***********************************************************************
 * Module:  LearningSystem.cs
 * Author:  User
 * Purpose: Definition of the Class LearningSystem
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class LearningSystem
{
    private Starter starter_user;                       //starter user
    private List<Syllabus> syllabus;                    //syllabus
    private int n_students;                             //quantity of students

    public LearningSystem()                             //default constructor
    {
        starter_user = new Starter();
        Syllabus syl = new Syllabus();
        syllabus = new List<Syllabus>();
        syllabus.Add(syl);
        n_students = 0;
    }

    ~LearningSystem()                                   //destructor
    {

    }
   public bool Existance()
   {
      // TODO: implement
      return false;
   }
   
   public void NewUser()
   {
      // TODO: implement
   }
   
   public bool GetTested()
   {
      // TODO: implement
      return false;
   }


   public int N_students                                //get and set n_students
   {
       get { return n_students; }
       set { n_students = value; }
   }
   public Starter Starter_user                          //get and set starter_user
   {
       get { return starter_user; }
       set { starter_user = value; }
 
   }
   
   public List<Syllabus> GetSyllabus()                    //get syllabus
   {
      if (syllabus == null)
         syllabus = new List<Syllabus> ();
      return syllabus;
   }
   
   public void SetSyllabus(List<Syllabus> newSyllabus)    //set syllabus
   {
      RemoveAllSyllabus();
      foreach (Syllabus oSyllabus in newSyllabus)
         AddSyllabus(oSyllabus);
   }
   
   public void AddSyllabus(Syllabus newSyllabus)          //Add a syllabus
   {
      if (newSyllabus == null)
         return;
      if (this.syllabus == null)
         this.syllabus = new List<Syllabus>();
      if (!this.syllabus.Contains(newSyllabus))
         this.syllabus.Add(newSyllabus);
   }
   
   public void RemoveSyllabus(Syllabus oldSyllabus)       //Remove a syllabus
   {
      if (oldSyllabus == null)
         return;
      if (this.syllabus != null)
         if (this.syllabus.Contains(oldSyllabus))
            this.syllabus.Remove(oldSyllabus);
   }
   
   public void RemoveAllSyllabus()                      //Remove all syllabuses
   {
      if (syllabus != null)
         syllabus.Clear();
   }



}
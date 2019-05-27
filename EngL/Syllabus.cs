/***********************************************************************
 * Module:  Syllabus.cs
 * Author:  User
 * Purpose: Definition of the Class Syllabus
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class Syllabus
{
    private List<string> test;                  //themes of tests 
    private Student studentInfo;                //student`s info
    private string id;                      
    private List<string> learn_list;            //themes to learn
    private int incorrect;                      //quantity of incorrect answers
    private int current_th;                     //curren theory

    public Syllabus()                           //default constructor
    {
        string str_test = "DefaultTest";
        test = new List<string>();
        test.Add(str_test);
        studentInfo = new Student();
        id = "DefaultId";
        string str_learn = "DefaultLearnTheme";
        learn_list = new List<string>();
        learn_list.Add(str_learn);
        incorrect = 0;
        current_th = 0;
    }
    ~Syllabus()                                 //destructor
    {

    }
    public Student StudentInfo                  //get and set studentInfo
    {
        get { return studentInfo; }
        set { studentInfo = value; }
    }

    public string Id                            //get and set id
    {
        get { return id; }
        set { id = value; }
    }

    public int Incorrect                        //get and set incorrect
    {
        get { return incorrect; }
        set { incorrect = value; }
    }

    public int Current_th                      //get and set current_th
    {
        get { return current_th; }
        set { current_th = value; }
    }

    public List<string> GiveTest()
   {
      // TODO: implement
      return null;
   }
   
   public bool CheckResult()
   {
      // TODO: implement
      return false;
   }
   
   public void Upgrade()
   {
      // TODO: implement
   }
   
   public void ToLearnList()
   {
      // TODO: implement
   }
   
   public void LearnTheory()
   {
      // TODO: implement
   }
   
   public void EditHours()
   {
      // TODO: implement
   }


   public List<string> GetLearnList()                                 //get test
   {
      if (learn_list == null)
         learn_list = new List<string>();
      return learn_list;
   }
   
   public void SetLearnList(List<string> newLearnList)                //set test
   {
      RemoveAllLearnLists();
      foreach (string oLearnList in newLearnList)
         AddLearnList(oLearnList);
   }
   
   public void AddLearnList(string newLearnList)                      //add a test
   {
      if (newLearnList == null)
         return;
      if (this.learn_list == null)
         this.learn_list = new List<string>();
      if (!this.learn_list.Contains(newLearnList))
         this.learn_list.Add(newLearnList);
   }
   
   public void RemoveLearnList(string oldList)                        //remove a test
   {
      if (oldList == null)
         return;
      if (this.learn_list != null)
         if (this.learn_list.Contains(oldList))
            this.learn_list.Remove(oldList);
   }

   public void RemoveAllLearnLists()                                  //remove all tests
   {
      if (learn_list != null)
         learn_list.Clear();
   }

   public List<string> GetTest()                                      //get learn_list
   {
       if (test == null)
           test = new List<string>();
       return test;
   }

   public void SetTest(List<string> newTest)                          //set learn_list
   {
       RemoveAllTest();
       foreach (string oTest in newTest)
           AddTest(oTest);
   }

   public void AddTest(string newTest)                                //add a learn_list theme
   {
       if (newTest == null)
           return;
       if (this.test == null || this.GetTest()[0] == "DefaultTest")
           this.test = new List<string>();
       if (!this.test.Contains(newTest))
           this.test.Add(newTest);
   }

   public void RemoveTest(string oldTest)                             //remove a learn_list theme
   {
       if (oldTest == null)
           return;
       if (this.test != null)
           if (this.test.Contains(oldTest))
               this.test.Remove(oldTest);
   }

   public void RemoveAllTest()                                        //remove all learn_list
   {
       if (test != null)
           test.Clear();
   }

}
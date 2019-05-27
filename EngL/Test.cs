/***********************************************************************
 * Module:  Test.cs
 * Author:  User
 * Purpose: Definition of the Class Test
 ***********************************************************************/

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class Test
{
    private string wrongs;
    private string testNameRA;
    private int uAnswer;
    private int nowScore;

    public string Wrongs                //get and set wrongs
    {
        get { return wrongs; }
        set { wrongs = value; }
    }

    public string TestNameRA            //get and set testNameRA
    {
        get { return testNameRA; }
        set { testNameRA = value; }
    }

    public int UAnswer                  //get and set uAnswer
    {
        get { return uAnswer; }
        set { uAnswer = value; }
    }

    public int NowScore                 //get and set nowScore
    {
        get { return nowScore; }
        set { nowScore = value; }
    }

    public Test()                       //default constructor
    {
        wrongs = "DefaultWrong";
        testNameRA = "DefaultNameRA";
        uAnswer = 0;
        nowScore = 0;
    }

    ~Test()
    {

    }

    public int Testing(LearningSystem ls, string[] ua)
    {
        string l = ls.GetSyllabus()[0].StudentInfo.Level;
        int score = 10;
        string filename_k = l + "key1.txt";
        string[] all_from_k = File.ReadAllLines(filename_k, Encoding.Default);
        string[] th = { "", "", "", "", "", "", "", "", "", "" };
        if (l == "a2")
        {
            for (int qn = 0; qn < 10; qn++)
            {
                if (qn == 0 || qn == 1)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "vocab0";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 2 || qn == 3)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "parts_of_speech";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 4 || qn == 5)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "present_tenses";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 6 || qn == 7)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "simple_past";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 8 || qn == 9)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "modal_verbs1";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
            }
        }
        if (l == "b1" || l == "b2")
        {
            for (int qn = 0; qn < 10; qn++)
            {
                if (qn == 0 || qn == 1)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "vocab0";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 2 || qn == 3)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "past_tenses";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 4 || qn == 5)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "infinitive";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 6 || qn == 7)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "modal_verbs2";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 8 || qn == 9)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "conditionals";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
            }
        }
        if (l == "c1" || l == "c2")
        {
            for (int qn = 0; qn < 10; qn++)
            {
                if (qn == 0 || qn == 1)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "vocab0";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 2 || qn == 3)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "passive_voice";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 4 || qn == 5)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "narrative_tenses";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 6 || qn == 7)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "clauses";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
                if (qn == 8 || qn == 9)
                {
                    if (ua[qn] != all_from_k[qn])
                    {
                        th[qn] = "wish";
                        ls.GetSyllabus()[0].AddTest(th[qn]);
                        score--;
                    }
                }
            }
        }
        return score;
    }
   
   public bool Check(LearningSystem ls, string[] ua)
   {
        ls.GetSyllabus()[0].Incorrect = 0;
        ///////////
        string filename_k = ls.GetSyllabus()[0].GetTest()[0] + "_key1.txt";
        ///////////
        string[] all_from_k = File.ReadAllLines(filename_k, Encoding.Default);
        for (int qn = 0; qn < 10; qn++)
        {
             if (ua[qn] != all_from_k[qn])
             {
                 ls.GetSyllabus()[0].Incorrect++;
             }
        }
        if (ls.GetSyllabus()[0].Incorrect <= 2) { return true; }
        else { return false; }
   }



}
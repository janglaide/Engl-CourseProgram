/***********************************************************************
 * Module:  Exept.cs
 * Author:  User
 * Purpose: Definition of the Class Exept
 ***********************************************************************/

using System;
using System.Windows.Forms;

public class Exept : Exception
{
    private int type;
    public Exept(int t)
    {
        type = t;
    }
    public void SearchError()
    {
        switch (type)
        {
            case 1:
                emptyInput();
                break;
            case 2:
                incorrectInCombobox();
                break;
        }
    }
    public void emptyInput()
    {
        MessageBox.Show("The input is empty! \nTry again");
    }
    public void incorrectInCombobox()
    {
        MessageBox.Show("Incorrect input in ComboBox!\nTry again");
    }
}
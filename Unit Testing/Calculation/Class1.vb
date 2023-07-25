Using System;
Using System.Collections.Generic;
Using System.Linq;
Using System.Text;
Using System.Threading.Tasks;

Namespace Calculation
{
    Public Class Calculations
    {
        Private int num1, num2;

        Public Calculations(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        Public int Num1 { Get => num1; Set => num1 = value; }
        Public int Num2 { Get => num2; Set => num2 = value; }

        Public int Add() { Return num1 + num2; }
        Public int Sub() { Return num1 - num2; }
    }
}

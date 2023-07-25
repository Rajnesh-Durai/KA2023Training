namespace Calculator
{
    public class Class1
    {
        private int num1, num2;

        public Class1(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }

        public int Add() { return num1 + num2; }
        public int Sub() { return num1 - num2; }
    }
}
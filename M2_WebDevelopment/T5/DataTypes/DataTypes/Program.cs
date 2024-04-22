using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a String ";
            int age = 35;
            DateTime now = DateTime.Now;

            double amount = 0;

            //variables y formato tipo string
            string string2 = text + " a second string " + age + now + amount;

            string string3 = string.Format("The age is {0}, the time is {1}, and the amount is {2}", age, now, amount);

            string string4 = $"The age is {age}, the time is {now}, and the amount is {amount}";

            //varibles tipo char
            char sampleChar = 'c';
            char[] arrayChar = string4.ToCharArray();

            amount = (double)10 / (double)3;

            //fecha
            DateTime dateTime = new DateTime(2000, 1, 1);

            //intervalo de tiempo entre fechas
            TimeSpan timeStamp1 = now - dateTime;

            Console.WriteLine(timeStamp1.Days);

            string test = "15";
            age = int.Parse(test);

            string booleanValue = "true";
            bool isTrue = bool.Parse(booleanValue);

            Console.ReadKey();
        }
    }
}

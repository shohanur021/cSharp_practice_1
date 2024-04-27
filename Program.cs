using System;

namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num1, num2, num3, sum;
            double average;

            num1 = 15;
            num2 = 20;
            num3 = 30;

            sum = num1 + num2 + num3;
            Console.WriteLine(sum);
            
            average = (double) sum / 3;
            Console.WriteLine(average);
            */
            /*
            double arm1, arm2, arm3, area, s;
            Console.Write("enter the 3 amrs of a triangle:");
            arm1 = Convert.ToInt32(Console.ReadLine());
            arm2 = Convert.ToInt32(Console.ReadLine());
            arm3 = Convert.ToInt32(Console.ReadLine());
            s = (arm1 + arm2 + arm3) / 2;
            area = Math.Sqrt(s * (s - arm1) * (s - arm2) * (s - arm3));
            Console.WriteLine(area);
            */
            /*
            double radious, area;
            radious = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radious *radious;
            Console.WriteLine(area);
            */
            /*
           int num1 = 20;
           int num2 = 35;

           int greater_num = num1>num2 ? num1 : num2;
           Console.WriteLine(greater_num);
           */
            /*
            int year;
            year = Convert.ToInt32(Console.ReadLine());
            if(year%400==0){
                Console.WriteLine($"{year} is a leap year");
            }
            else if(year%4==0 && year%100!=0){

                Console.WriteLine($"{year} is a leap year");
            }
            else{
                Console.WriteLine($"{year} is not a leap year");
            }
            */
            /*
            char c = Convert.ToChar(Console.ReadLine());
            if (c>='A' && c<='Z'){
                Console.WriteLine(Convert.ToChar(c+32));
            }
            else if(c>='a' && c<='z'){
                Console.WriteLine(Convert.ToChar(c-32));
            }
            else
            {
                Console.WriteLine("Error");
            }
            */
            /*
            char ch1 = 'A';
            char ch2 = 'a';
            char ch3 = 'B';
            int output;

            output = ch1.CompareTo(ch2);
            Console.WriteLine(output);

            output = ch1.CompareTo('1');
            Console.WriteLine(output);

            output = ch2.CompareTo('g');
            Console.WriteLine(output);

            bool isHere = false;

            Console.WriteLine(ch3.GetType());
            Console.WriteLine(isHere.GetType());
            Console.WriteLine(6.4.GetType());
            */
            
            /*
            int utf = 0x0042;
            string value = Char.ConvertFromUtf32(utf);
            Console.WriteLine(value);
            */ 
            /*
            int utf = 0xF42; 
            string value = Char.ConvertFromUtf32(utf); 
            int val = Char.ConvertToUtf32(value, 0); 
            Console.WriteLine("value is 0x{0:X}", val); 
            */
            /*
            char ch = 'g';
            bool result = ch.Equals('G');
            Console.WriteLine(result);
            result = ch.Equals('g');
            Console.WriteLine(result);
            */
            char ch = 'v';
            int val = ch.GetHashCode();
            Console.WriteLine(val);


        }
    }
}

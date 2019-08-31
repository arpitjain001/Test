using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertNumberToStringName(9));
            Console.WriteLine(ConvertNumberToStringName(11));
            Console.WriteLine(ConvertNumberToStringName(21));
            Console.WriteLine(ConvertNumberToStringName(34));
            Console.WriteLine(ConvertNumberToStringName(109));
            Console.WriteLine(ConvertNumberToStringName(999));
            Console.WriteLine(ConvertNumberToStringName(4994));
            Console.WriteLine(ConvertNumberToStringName(47999));
            Console.WriteLine(ConvertNumberToStringName(479099));
            Console.WriteLine(ConvertNumberToStringName(4799749));
            Console.WriteLine(ConvertNumberToStringName(47974956));
            Console.WriteLine(ConvertNumberToStringName(479974956));
            Console.WriteLine(ConvertNumberToStringName(4799749032));
        }

        private static string ConvertNumberToStringName(long num)
        {
            string numString = num.ToString();
            Console.WriteLine();
            Console.Write(numString + " : ");

            if (num == 0)
            {
                return "Zero";
            }
            else if (numString.Length == 1)
            {
                return GetStringNum(num);
            }
            else if (numString.Length == 2 && num > 9 && num < 21)
            {
                return GetStringTenceOnly(num);
            }
            else if (numString.Length == 3 || numString.Length == 2)
            {
                return GetThreeDigitStringName(numString);
            }

            List<string> tempList = new List<string>();
            int count = 1;
            StringBuilder tempBuilder = new StringBuilder();
            foreach (var y in numString.Reverse())
            {
                tempBuilder.Insert(0, y);
                if (count == 3)
                {
                    tempList.Add(tempBuilder.ToString());
                    tempBuilder.Clear();
                    count = 0;
                }

                count++;
            }

            if (tempBuilder.Length > 0)
            {
                tempList.Add(tempBuilder.ToString());
                tempBuilder.Clear();
            }

            int counter = 0;
            string numStringName = string.Empty;
            foreach (var listItem in tempList)
            {
                var intg = Int32.Parse(listItem);
                if (counter == 0)
                {
                    numStringName = GetThreeDigitStringName(listItem);
                }
                if (counter == 1)
                {
                    numStringName = $"{GetThreeDigitStringName(listItem)} Thousand And {numStringName}";
                }
                if (counter == 2)
                {
                    numStringName = $"{GetThreeDigitStringName(listItem)} Million And {numStringName}";
                }
                if (counter == 3)
                    numStringName = $"{GetThreeDigitStringName(listItem)} Billion And {numStringName} ";

                counter++;
            }

            return numStringName;
        }

        private static string GetThreeDigitStringName(string numString)
        {
            int counter = 0;
            List<string> st = new List<string>();
            foreach (var t in numString.Reverse())
            {
                if (counter == 0)
                {
                    st.Add($"{GetStringNum(Int32.Parse(t.ToString()))} ");
                }
                else if (counter == 1)
                {
                    st.Add($"{GetStringTence(Int32.Parse(t.ToString()))} ");
                }
                else if (counter == 2)
                {
                    st.Add($"{GetStringNum(Int32.Parse(t.ToString()))} Hundred ");
                }

                counter++;
            }

            st.Reverse();
            string outPut = string.Empty;
            foreach (var d in st)
            {
                outPut = outPut + d;
            }

            return outPut;
        }

        private static string GetStringNum(long number)
        {
            if (number == 1)
                return "One";
            if (number == 2)
                return "Two";
            if (number == 3)
                return "Three";
            if (number == 4)
                return "Four";
            if (number == 5)
                return "Five";
            if (number == 6)
                return "Six";
            if (number == 7)
                return "Seven";
            if (number == 8)
                return "Eight";
            if (number == 9)
                return "Nine";

            return string.Empty;
        }

        private static string GetStringTence(long number)
        {
            if (number == 1)
                return "Eleven";
            if (number == 2)
                return "Twenty";
            if (number == 3)
                return "Thirty";
            if (number == 4)
                return "Fourty";
            if (number == 5)
                return "Fifty";
            if (number == 6)
                return "Sixty";
            if (number == 7)
                return "Seventy";
            if (number == 8)
                return "Eighty";
            if (number == 9)
                return "Ninety";

            return string.Empty;
        }

        private static string GetStringTenceOnly(long number)
        {
            if (number == 10)
                return "Ten";
            if (number == 11)
                return "Eleven";
            if (number == 12)
                return "Twelve";
            if (number == 13)
                return "Thirteen";
            if (number == 14)
                return "Fourteen";
            if (number == 15)
                return "Fifteen";
            if (number == 16)
                return "Sixteen";
            if (number == 17)
                return "Seventeen";
            if (number == 18)
                return "Eighteen";
            if (number == 19)
                return "Nineteen";
            if (number == 20)
                return "Twenty";

            return string.Empty;
        }
    }
}

using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;

internal class Program
{
    private static int Main(string[] args)
    {
        string ifoda = "";
            int index = 0, firstNum = 0, secondNum = 0;
        do
        {
            ifoda = "";
            index = 0;
            firstNum = 0;
            secondNum = 0;
            Console.WriteLine("\n\nKerakli bo'limni tanlang: \n");
            Console.WriteLine("1 - Elementar xisob-kitob.\n\n2 - Log a (b) ni xisoblash.\n\n3 - Dasturni yakunlash.\n");
            string amal = Console.ReadLine();
            switch (amal)
            {
                case "1":
                    Console.WriteLine("Elementar xisob-kitob:\n");
                    Console.WriteLine("Ifodani kiriting(a + {'^', '*', '/', '+', '-' + b})");
                    ifoda = Console.ReadLine();
                    while (ifoda[index] >= '0' && ifoda[index] <= '9')
                    {
                        firstNum *= 10;
                        firstNum += ifoda[index] - '0';
                        index++;
                    }
                    char belgi = ifoda[index];
                    while (index < ifoda.Length)
                    {
                        secondNum *= 10;
                        secondNum += ifoda[index] - '0';
                        index++;
                    }
                    Console.Write("Javob : ");
                    switch (belgi)
                    {
                        case '*': Console.WriteLine(firstNum * secondNum); break;
                        case '/': Console.WriteLine(1.0 * firstNum / secondNum); break;
                        case '+': Console.WriteLine(firstNum + secondNum); break;
                        case '-': Console.WriteLine(firstNum - secondNum); break;
                        case '^':
                            long ans = firstNum;
                            while (secondNum-- > 1)
                                ans *= firstNum;
                            Console.WriteLine(ans); break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Log a (b)\n");
                    Console.WriteLine("Ifodani kiriting(Log a (b)) : ");
                    ifoda = Console.ReadLine();
                    index = 4;
                    while (ifoda[index] != ' ')
                    {
                        firstNum *= 10;
                        firstNum += ifoda[index] - '0';
                        index++;
                    }
                    index += 2;
                    while (ifoda[index] != ')')
                    {
                        secondNum *= 10;
                        secondNum += ifoda[index] - '0';
                        index++;
                    }
                    Console.WriteLine("Javob : " + 1.0 * Math.Log2(secondNum) / Math.Log2(firstNum));
                    break;
                case "3": return 0;
                default: return 0;
            }
        } while (true);
    }
}
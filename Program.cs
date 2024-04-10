using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;

do
{

Console.WriteLine("Kerakli bo'limni tanlang: \n");
Console.WriteLine("1 - Elementar xisob-kitob.\n\n2 - Log a (b) ni xisoblash.\n\n3 - Dasturni yakunlash.\n");
string amal = Console.ReadLine();
switch(amal)
{
    case "1": 


    default :
    return 0;

}

}while(true);

void calc()
{
    List <double> nums = new List<double>();
    List <char> amallar = new List<char>();
    int index = 0;
    double ans = 0;
    Console.Clear();
    Console.WriteLine("Elementar xisob-kitob bo'limi:\n");
    Console.WriteLine("Amallarni kiriting ('*', '/', '+', '-'):");
    string ifoda = Console.ReadLine(); 
    int size = ifoda.Length;
    while(index < size)
    {
        nums.Add(num(ifoda, index));
        if (index < size) amallar.Add(ifoda[index]);
    }
    
}

double num(string ifoda, int index)
{
    int ans = 0, size = ifoda.Length;
    while(index < size && ifoda[index] <= '9' && ifoda[index] >= '0')
        {
            ans *=  10;
            ans += ifoda[index];
            index ++;
        }
    return ans;
}

double get(double firstNum, double secondNum, char amal)
{
    switch (amal)
    {
        case '+': return firstNum + secondNum;
        case '-': return firstNum - secondNum;
        case '*': return firstNum * secondNum;
        case '/': return firstNum / secondNum;
        default : return 0;
    }
} 
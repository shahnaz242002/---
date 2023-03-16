using System.Text;

Console.OutputEncoding=Encoding.UTF8;
string name = "xurma";
Console.WriteLine("Введите количество товарa");
int count = Convert.ToInt32(Console.ReadLine());
int price = 20;
string aksia = "yes";
double result = price * count;
if(count>=5)
{
    result = result * 0.9;
}
if(aksia=="yes")
{
    result = result * 0.85;
}
Console.WriteLine(result);

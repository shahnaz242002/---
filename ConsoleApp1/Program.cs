using System.Text;

Console.OutputEncoding=Encoding.UTF8;
//Напишите часть программы регистрации аккаунта.
//Пользователь вводит пароль и затем повторяет его.
//Если пароли совпадают выведите на консоль сообщение о успешной регистрации. Если нет - сообщение об ошибке.
Console.WriteLine("Введите пароль:");
int password = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пароль повторно:");
int otherPassword = Convert.ToInt32(Console.ReadLine());
if (password == otherPassword)
{
    Console.WriteLine("Correct");
}
if (password != otherPassword)
{
    Console.WriteLine("Incorrect");
}

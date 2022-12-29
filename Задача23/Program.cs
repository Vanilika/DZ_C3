//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int Qwe(string name)
{
    Console.WriteLine(name);
    int Ax = Convert.ToInt32(Console.ReadLine());
    return Ax;
}

int Ax = Qwe("Введи чиcло: ");
string kub = "";

for( int index = 1; index <= Ax; index++)
{
    kub = kub + Math.Pow(index, 3).ToString() + ", ";
}
Console.WriteLine(kub);
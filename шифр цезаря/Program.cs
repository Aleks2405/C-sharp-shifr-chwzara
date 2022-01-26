using System;
/*Пользователь вводит строку с клавиатуры. 
 * Необходимо зашифровать данную строку используя шифр Цезаря.
Из Википедии:
ДОМАШНЕЕ ЗАДАНИЕ
1
Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется
символом, находящимся на некотором постоянном числе
позиций левее или правее него в алфавите. Например,
в шифре со сдвигом вправо на 3, A была бы заменена на
D, B станет E, и так далее.*/
namespace шифр_цезаря
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку которую нужно зашифровать ");
            string a = Console.ReadLine();
            char[] arr = a.ToCharArray();
            int d;
            for (int i = 0; i < a.Length; i++)
            {

                //arr[i] = (char)(arr[i] + 3);
               // arr[i] = (char)arr[i];
                if ('a' <= arr[i] || arr[i] >= 'z')
                {
                    // arr[i] = (char)(arr[i] + 3);
                    if (arr[i]>'z')
                    {
                    
                        arr[i] = (char) (arr[i] - 'z');
                    }
                    arr[i] = (char)(arr[i] + 3);
                }
                a = new string(arr);
            }
            Console.WriteLine(a);
        }
    }
}




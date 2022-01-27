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
                    if (arr[i]>'w')
                    {
                        if((char) arr[i] == 'x')
                        {
                            arr[i] = (char)('a' - 3);

                        } else if ((char)arr[i] == 'y')           /* возможно слишком уж не красиво но придумал так был вариант добавить алфавит вручную но что так что так не красиво*/
                        {
                            arr[i] = (char)('b' - 3);
                        }
                        else if ((char)arr[i] == 'z')
                        {
                           arr[i] = (char)('c' - 3);
                        }
                        //arr[i] = (char) (arr[i] - 'z');
                    }
                    arr[i] = (char)(arr[i] + 3);
                }
                a = new string(arr);
            }
            Console.WriteLine(a);
            char[] arr1 = a.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if ('a' <= arr[i] || arr[i] >= 'z')
                {
                    if ((char)arr[i] == 'a')
                    {
                        arr[i] = (char)('x' + 3);

                    }
                    else if ((char)arr[i] == 'b')           /* возможно слишком уж не красиво но придумал так был вариант добавить алфавит вручную но что так что так не красиво*/
                    {
                        arr[i] = (char)('y' + 3);
                    }
                    else if ((char)arr[i] == 'c')
                    {
                        arr[i] = (char)('z' + 3);
                    }
                    arr[i] = (char)(arr[i] - 3);
                }
                a = new string(arr);
            }
            Console.WriteLine(a + " Дешифровка");

        }
    }
}




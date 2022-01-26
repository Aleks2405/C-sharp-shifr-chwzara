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
            for (int i = 0; i < a.Length; i++)
            {

                //arr[i] = (char)(arr[i] + 3);

                arr[i] = (char)arr[i];
                if ('a' <= arr[i] || arr[i] >= 'z')
                {
                    arr[i] = (char)(arr[i] + 3);
                    if (arr[i] > 'w' + 3)
                    {
                        Console.WriteLine("tyt");


                        if (arr[i] > 'w' + 3)
                        {
                            arr[i] = 'a';
                            arr[i]++;

                            // arr[i] = (char)(arr[i] + 1);
                            // arr[i]++;
                            //break;
                        }
                    }
                }

                //switch((int) arr[i])
                //{
                //    case ((int)'x' + 3):
                //        arr[i] = 'a';
                //        break;
                //    case ((int)'y' + 3):
                //        arr[i] = 'b';
                //        break;
                //    case ((int)'z' + 3):
                //        arr[i] = 'c';
                //        break;
                //    case ((int)'X'+3):
                //        arr[i] = 'A';
                //        break;
                //    case ((int)'Y' + 3):
                //        arr[i] = 'B';
                //        break;
                //    case ((int)'Z' + 3):
                //        arr[i] = 'C';
                //        break;
                //}
                //Console.WriteLine((int)(arr[i]));
                a = new string(arr);
            }
            Console.WriteLine(a); // убедились что работает 

            //for (int i = 0; i < arr.Length; i++)
            //{
            //   arr[i] = (char)(arr[i] - 3);
            //    Console.WriteLine(arr[i]);
            //}
            // a = new string(arr);
            // Console.WriteLine();
            // Console.WriteLine(a + "yraa");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (arr[i] >= 'a' && arr[i] <= 'z' || arr[i] >= 'а' && arr[i] <= 'я')
            //    {
            //        Console.Write((char)(arr[i] - 3));
            //    }

            //}

        }
    }
}



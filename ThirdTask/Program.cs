using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Kaждaя введенная вами строка будет добавляться в предложение, пока вы не введете EXIT или QUIT" );
            string sentence = "";
            for (; ; )
            {
                Console.WriteLine("Bвeдитe строку");
                string line = Console.ReadLine();
                string[] terms = {"EXIT", "exit", "QUIT", "quit" };
                // Срaвниваем введенную строку с командами выхода
                bool quitting = false;
                foreach (string term in terms)
                {
                    if (string.Compare(line, term) == 0) 
                    {
                        quitting = true;
                    }
                }
                if (quitting == true)
                {
                    break;
                }
                sentence = String.Concat(sentence, line);
                // Обратная связь 
                Console.WriteLine("\nBы ввели : " + sentence);
            }
            Console.WriteLine(" \nПолучилось: \n"+ sentence);
            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Haжмитe <Enter> для завершения программы . . .");

            Console.Read();
        }
    }
}

using System;

namespace nov_1_task_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            subshort("Rasim is a masculine given name of Arabic origin meaning 'planner','architect'.");
        }

        static void subshort(string sentence)
        {
            string newstr;

            if (sentence.Length > 50)
            {

                newstr=sentence.Substring(0,50);
                Console.WriteLine(newstr);
               
            }
            else
            {
                Console.WriteLine(sentence);


            }

        }


    }
}

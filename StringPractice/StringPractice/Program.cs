using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string a = Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            string b = Console.ReadLine();
            Console.WriteLine("Enter 3rd string");
            string c = Console.ReadLine();

            string sentence = a + " " + b + " " + c;
            Console.WriteLine(sentence);


            string sentenceUpper = sentence.ToUpper();
            Console.WriteLine(sentenceUpper);

            StringBuilder builtSentence = new StringBuilder(); //instantiate class
            builtSentence.Append("Sentence 1 ");
            builtSentence.Append("Sentence 2 ");
            builtSentence.Append("Sentence 3");




            Console.WriteLine(builtSentence);
            
            
            
            
            Console.ReadLine();

        }
    }
}

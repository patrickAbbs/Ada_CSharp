using System;
using Ada_CSharp_Try.Classes;
using Ada_CSharp_Try.Instance_Transformers;


namespace Ada_CSharp_Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.Dimension_Space Word_Space = new Dimension_Space("word", .4, .34, .03, 5.0, .8);

            Word_Instance_Transformer word_Instance_Transformer = new Word_Instance_Transformer();

            Console.WriteLine(Word_Space.Space_Name);
            Console.WriteLine("Hello World!");
        }
    }
}

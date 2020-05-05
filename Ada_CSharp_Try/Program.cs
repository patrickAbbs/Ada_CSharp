using System;
using System.Collections.Generic;
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
            string test_sentence = "transform me into word embeddings";

            List<Dimension_Instance> word_Instances = word_Instance_Transformer.Transform_Text_Into_Instances(test_sentence);

            
            Dimension_Space word_Space = new Dimension_Space("word_space", .35, 1.5, 0.005, 5.0, 0.7);
            word_Space.Top_Cluster = new Dimension_Cluster(true, word_Instances[0], null, 0.0);


            Console.WriteLine(Word_Space.Space_Name);
            Console.WriteLine("Hello World!");
        }
    }
}

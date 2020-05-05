using System;
using System.Collections.Generic;
using Ada_CSharp_Try.Classes;
namespace Ada_CSharp_Try.Instance_Transformers
{
    public class Word_Instance_Transformer
    {
        public Dictionary<string, List<double>> Word_Embedding_Model;

        public Word_Instance_Transformer()
        {
            Word_Embedding_Model = new Dictionary<string, List<double>>();

            string word_embedding;
            System.IO.StreamReader word_embedding_file = new System.IO.StreamReader(@"/Users/patrickabbs/Projects/Ada_CSharp_Try/Ada_CSharp_Try/Resources/glove.twitter.27B.25d.txt");
            while((word_embedding = word_embedding_file.ReadLine()) != null)
            {
                string[] split_word_embedding = word_embedding.Split(' ');
                string word = split_word_embedding[0];
                List<double> embedding_values = new List<double>();
                for (int i = 1; i < split_word_embedding.Length; i++)
                {
                    embedding_values.Add(Convert.ToDouble(split_word_embedding[i]));
                }

                Word_Embedding_Model.Add(word, embedding_values);
            }
        }

        public List<Dimension_Instance> Transform_Text_Into_Instances(string input_text)
        {
            return new List<Dimension_Instance>();
        }
    }
}

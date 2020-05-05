using System;
using System.Collections.Generic;
using Ada_CSharp_Try.Classes;
namespace Ada_CSharp_Try.Instance_Transformers
{
    public class Word_Instance_Transformer
    {
        public Dictionary<string, List<double>> Word_Embedding_Model;
		public List<string> Words_To_Skip;

        public Word_Instance_Transformer()
        {
			Words_To_Skip = new List<string>() { "a", "about", "all", "almost", "among", "and", "another", "are", "around", "as", "at", "available", "away",
			"back", "bag", "be", "because", "been", "before", "beside", "besides", "between", "both", "but", "by",
			"can", "cause", "certain", "certainly", "chance", "clearly", "close", "come", "common", "consider", "continue", "could", "course", "current",
			"day", "decide", "decision", "describe", "design", "determine", "difference", "different", "direction", "do", "does", "during",
			"each", "effect", "either", "else", "enough", "entire", "especially", "even", "ever", "every", "exactly", "expect", "explain",
			"far", "fast", "few", "fill", "finally", "for", "forward", "from", "full",
			"get", "give", "go",
			"happen", "have", "he", "her", "here", "hers", "herself", "him", "himself", "his", "how", "however", "http", "https",
			"i", "if", "in", "include", "indeed", "inside", "into", "involve", "is", "it", "item", "its", "itself",
			"just",
			"know",
			"late", "later", "least", "less", "let", "likely", "long", "lot",
			"main", "major", "make", "many", "matter", "may", "maybe", "me", "mention", "middle", "might", "minute", "moment", "more", "most", "move", "mr", "mrs", "ms", "much", "must", "my", "myself",
			"near", "nearly", "necessary", "need", "next", "none", "not", "now",
			"ah", "occur", "of", "off", "offer", "often", "oh", "okay", "ok", "on", "once", "only", "onto", "open", "or", "other", "others", "our", "out", "over",
			"part", "pass", "per", "person", "piece", "place", "present", "probably", "provide", "purpose", "put",
			"quickly", "quite",
			"rather", "ready", "real", "realize", "really", "reason", "receive", "recent", "recently", "require", "return", "reveal", "rt", "RT",
			"same", "saw", "say", "see", "seem", "send", "set", "several", "she", "should", "similar", "simply", "since", "so", "some", "somebody", "someone", "something", "sometimes", "soon", "stay", "still", "stuff", "such", "sure",
			"take", "talk", "tell", "telling", "than", "that", "the", "their", "them", "themselves", "then", "there", "these", "they", "thing", "think", "this", "those", "though", "thought", "through", "throughout", "thus", "time", "to", "today", "together", "told", "too", "toward", "try", "turn",
			"until", "upon", "us", "use", "usually",
			"various", "very",
			"want", "was", "way", "we", "well", "what", "whatever", "when", "where", "whether", "which", "while", "who", "whole", "whom", "whose", "why", "will", "with", "within", "without", "would",
			"yet", "you", "your", "yourself",
			"la", "los", "las", "y", "que",

			// top word reactions
			"an",
			// regex gaps
			"co", "t", "rt", "@", "\"", "”"};
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
			string[] split_words = input_text.Split(' ');
			List<Dimension_Instance> word_instances = new List<Dimension_Instance>();
            for(var i = 0; i < split_words.Length; i++)
            {
                string word = split_words[i];
                if (!Words_To_Skip.Contains(word))
                {
                    if (Word_Embedding_Model.ContainsKey(word))
                    {
                        Dictionary<string, double> dimension_set = new Dictionary<string, double>();
                        for(var j = 0; j < Word_Embedding_Model[word].Count; j++)
                        {
                            dimension_set.Add(j.ToString(), Word_Embedding_Model[word][j]);
                        }

                        Dimension_Instance word_instance = new Dimension_Instance(word, dimension_set);
                        word_instances.Add(word_instance);
                    }
                }
            }

            return(word_instances);
        }
    }
}

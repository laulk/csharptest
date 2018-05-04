using System;
using System.Collections.Generic;

namespace tutorials
{
    public class Program{
        public static void Main()
        {
            List<Word> words = new List<Word>
            {
                new Word{theWord= "Apple", ID = "WordSticker1", numberOfTimesLearned=0,hasAlreadyCollected=false},
                new Word{theWord= "Bubble", ID = "WordSticker2", numberOfTimesLearned=0,hasAlreadyCollected=false},
                new Word{theWord= "Couple", ID = "WordSticker3", numberOfTimesLearned=0,hasAlreadyCollected=false}
            };

            foreach (var word in words)
             Console.WriteLine("Word: {0} ID: {1}, Learned: {2}, Number of Times learned: {3}", word.theWord, word.ID, word.hasAlreadyCollected, word.numberOfTimesLearned);
            //words.ForEach(Console.WriteLine);
        }
    }


    public class Word
    {
        public string theWord { get; set; }
        public string ID { get; set; }
        public int numberOfTimesLearned { get; set; }
        public bool hasAlreadyCollected { get; set; }
    
    }
}

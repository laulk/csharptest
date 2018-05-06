using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tutorials
{
    public class Program{
        public static void Main()   //Adds multiple datatypes to <words> list & prints the results
        {
            List<Word> words = new List<Word>
            {
                new Word{theWord= "Apple", ID = "WordSticker1", numberOfTimesLearned=0,hasAlreadyCollected=false},
                new Word{theWord= "Bubble", ID = "WordSticker2", numberOfTimesLearned=0,hasAlreadyCollected=false},
                new Word{theWord= "Couple", ID = "WordSticker3", numberOfTimesLearned=0,hasAlreadyCollected=false},
                new Word{theWord= "Double", ID = "WordSticker4", numberOfTimesLearned=0,hasAlreadyCollected=false},
                new Word{theWord= "Epple", ID = "WordSticker5", numberOfTimesLearned=0,hasAlreadyCollected=false}
            };

            List<LearnedLastLesson> learneds = new List<LearnedLastLesson>
            {
                new LearnedLastLesson{iD = "WordSticker1"},
                new LearnedLastLesson{iD = "WordSticker2"},
                new LearnedLastLesson{iD = "WordSticker3"}
            };


            Console.WriteLine("Lets see your achievement shall we?");




            //var learned = learneds.Where(d => d.iD == "WordSticker3").FirstOrDefault();
            //if (learned != null) 
            //{
            //    var word = words.Where(i => i.ID == iD).FirstOrDefault(); 
            //    word.hasAlreadyCollected = true; 
            //}
            //words.Where(d => d.theWord == "Apple").First().hasAlreadyCollected = true; 

            //Uncomment the following to check if changed data in the list is saved.
            foreach (var word3 in words)
             Console.WriteLine("Word: {0} ID: {1}, Learned: {2}, Number of Times learned: {3}", word3.theWord, word3.ID, word3.hasAlreadyCollected, word3.numberOfTimesLearned);


        }
    }

    //Word class defines the word, the ID which is also the WordSticker, bool for "learnt"or not and number of times learned
    public class Word
    {
        public string theWord { get; set; }
        public string ID { get; set; }
        public int numberOfTimesLearned { get; set; }
        public bool hasAlreadyCollected { get; set; }
    
    }

    public class LearnedLastLesson
    {
        public string iD { get; set; }

    }

    internal bool DoIDsMatch(List<LearnedLastLesson> learneds, List<Word> words)
    {
        return !learneds.Except(words).Any();
    }
}

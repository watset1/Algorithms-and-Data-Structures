using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordLadderApplication
{
    //Static class to build and solve a word ladder
    public static class WordLadder
    {
        const String DICTIONARY_FILEPATH = "dictionary.txt";

        public static void BuildLadder(String word1, String word2, ListBox listBox)
        {
            List<String> words = Solve(word1, word2, FileReader.ReadTxtFile(DICTIONARY_FILEPATH));
            foreach (String word in words)
            listBox.Items.Add(word);
        }

        public static List<String> Solve(String start, String end, List<String> dictionary)
        {
            StringQueue queue = new StringQueue();
            List<String> startLadder = new List<String>(); 
            startLadder.Add(start); //Stores the start word in a list
            queue.Push(startLadder); //Pushes list to queue
            while (!queue.IsEmpty()) 
            {
                int lastIndex = queue.Peek().Count() - 1; //Gets index of final word in queued ladder
                List<String> ladder = queue.Pop(); //Dequeues ladder from queue
                String finalWord = ladder[lastIndex]; //Gets the last word in the dequeued ladder 
                if (finalWord.Equals(end)) //If the last word in the ladder is the end word return this ladder
                    return ladder;
                for (int i = 0; i < dictionary.Count(); i++)
                {
                    if (OneLetterDifference(finalWord, dictionary[i])) //Iterates through dictionary checking if current word is one letter different from the previous word
                    {
                        List<String> newLadder = ladder.ToList(); //If one letter different, clones previous ladder
                        newLadder.Add(dictionary[i]); //and appends current word to cloned ladder
                        queue.Push(newLadder); //Adds cloned ladder to queue
                        dictionary.Remove(dictionary[i]); //Removes current word from dictionary so it cannot be revisited
                    }
                }
            }
            return new List<string>() { "No word ladder exists" }; //If queue is empty returns list with a feedback value
        }

        //Checks if current word is one letter different from a comparison word
        public static bool OneLetterDifference(String word, String comparator)
        {
            int numDif = 0;
            char[] word1 = word.ToCharArray();
            char[] word2 = comparator.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (!word1[i].Equals(word2[i]))
                    numDif++;
            }
            if (numDif == 1)
                return true;
            else
                return false;
        }
    }
}

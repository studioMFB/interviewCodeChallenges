using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            #region New Version Only string alphabet, No List
            //string line = Console.ReadLine().ToLower();
            //string line = "Aa slow yellow fox ] crawls under the proactive # dog".ToLower();
            // outpout bjkmqz
            string line = "A quick brown fox / jumps over the lazy dog -+";
            // output NULL

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            #region Read all letters in input line
            foreach (char letter in line)
            {
                if (alphabet.Contains(letter)) // Prevents checking for duplicate letters in line
                {
                    int i = alphabet.IndexOf(letter);
                    alphabet = alphabet.Remove(i, 1); // Remove letter at letter's index
                }
            }
            #endregion
            // Checks if input line is a Pangram
            if (alphabet == "")
            { line = "NULL"; } // Output if Pangram 
            else
            { line = alphabet; }
            Console.WriteLine(line); // Default output are the missing letters in lowercase and alphabtic order
            #endregion



            #region Old Version w/ List
            //string line = Console.ReadLine().ToLower();
            line = "A slow yellow fox ] crawls under the proactive # dog";
            // outpout bjkmqz
            //string line = "A quick brown fox / jumps over the lazy dog -+";
            // output NULL
            #region Create alphabet
            List<Char> alphabetList = new List<Char>();
            alphabet = "abcdefghijklmnopqrstuvwxyz";
            foreach (char letter in alphabet)
            {
                alphabetList.Add(letter);
            }
            #endregion

            #region Read all letters in input line
            foreach (char letter in line)
            {
                if (alphabetList.Contains(letter))
                {
                    alphabetList.Remove(letter);
                }
            }
            #endregion
            // Checks if input line is a Pangram
            if (alphabetList.Count == 0)
            {
                line = "NULL"; // Output if Pangram
            }
            else
            {
                // Otherwise output missing letters in alphabetic order
                line = ""; // clear line
                foreach (char letter in alphabetList)
                {
                    line += letter;
                }
            }
            Console.WriteLine(line);
            #endregion

        }
    }
}

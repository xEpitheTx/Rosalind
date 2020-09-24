using System;
using System.Collections.Generic;

namespace ConsensusAndProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stuff = new List<string>()
            {
                ">Rosalind_1",
                "ATCCAGCT",
                ">Rosalind_2",
                "GGGCAACT",
                ">Rosalind_3",
                "ATGGATCT",
                ">Rosalind_4",
                "AAGCAACC",
                ">Rosalind_5",
                "TTGGAACT",
                ">Rosalind_6",
                "ATGCCATT",
                ">Rosalind_7",
                "ATGGCACT",
            };

            FindConsensusString(stuff);
        }

        private static void FindConsensusString(List<string> dnaStrings)
        {
            //input: a collection of no more than 10 dna strings of equal length in this format
            //>Rosalind_1
            //ATCCAGCT
            //output: a consensus string and profile matrix. 
            //A consensus string is created from the most prevelant letter in each position of each string
            int aCount = 0;
            int cCount = 0;
            int gCount = 0;
            int tCount = 0;
            string aCountStr = "A: ";
            string cCountStr = "C: ";
            string gCountStr = "G: ";
            string tCountStr = "T: ";
            string concensusString = "";
            //get data ready to process: strip off the DNA ID, since it's a collection just read every other string.
            for (int i = 0; i < dnaStrings.Count; i++)
            {
                dnaStrings.RemoveAt(i);
            }
            //Count up how many times a letter appears in the first spot of each string (ACGT are the only letters we're looking for)
            for (int characterPlace = 0; characterPlace <= dnaStrings.Count; characterPlace++)
            {
                foreach (string DNA in dnaStrings)
                {
                    switch (DNA[characterPlace])
                    {
                        case 'A':
                            aCount++;
                            break;
                        case 'C':
                            cCount++;
                            break;
                        case 'G':
                            gCount++;
                            break;
                        case 'T':
                            tCount++;
                            break;
                        default:
                            break;
                    }
                }
                //Figure out which letter occurs the most and add it to the new consensus string (If more than one, just pick a winner)
                if (aCount >= cCount && aCount >= gCount && aCount >= tCount)
                {
                    concensusString += "A";
                }
                else if (cCount >= aCount && cCount >= gCount && cCount >= tCount)
                {
                    concensusString += "C";
                }
                else if (gCount >= aCount && gCount >= cCount && gCount >= tCount)
                {
                    concensusString += "G";
                }
                else
                {
                    concensusString += "T";
                }
                //for each ACGT add a string for that letter and the count of the occurences at that position in this formaat
                //A: 5 1 0 0 5 5 0 0
                aCountStr += aCount.ToString() + " ";
                cCountStr += cCount.ToString() + " ";
                gCountStr += gCount.ToString() + " ";
                tCountStr += tCount.ToString() + " ";
                aCount = 0;
                cCount = 0;
                gCount = 0;
                tCount = 0;
            }
            Console.WriteLine(concensusString);
            Console.WriteLine(aCountStr);
            Console.WriteLine(cCountStr);
            Console.WriteLine(gCountStr);
            Console.WriteLine(tCountStr);
        }
    }
}

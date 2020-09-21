using System;
using System.Linq;

namespace ComplementingaStrandofDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseCompliment("CGAGTCTAGGCCAGCTCCAGGCCGCTGTAAAAGATATAATACCCACAATCCACGACCTGAACAGCATTAGGGTACAACAATAACATGGGTTGAGGCGTCCACATTGGTTGGAACCCAACCCGCGGAAGACAGATAAATCGCAACTATCATAGGTATGGCATTGAAACATGTCGTCTACCGTCCGAGCTGTCGGTGGGGGACGTTAGAGTCACGAAAACGGTGTGTTTTGGCACTAGCCCCCAAATTGTACTCTCCCCGTGTTCATGAGGGACACGACGCAACTTAATTTGGCCAGACGTTCGAAAGTTATTCAATTGTACGTTTCCATTGAAATCATGTCAGTGTTTCCCCAAGACGCGTCTAGGAACCATCTGTTTACCTGAAAGGACAAGTTTGCAACTTGCGTTAAGTTAGTGGCCTGTTGGTCCAAGTGTAAGCCCTCTTGAGGAAGCCTTTGAACGGTGTTTCGACTCTTAAAGGCGCAGTTGACGTTTATCCGGGGCGTGTCTCTATCTTCCTCCTAACTCGCGTGGTGTGCTCAACCAGGAGGTGGGAGGGCTGCCCAGACTGTTTAAAAATACTTCTTGGATGTAGGCCCCGAAGAAACCAGAGGCAACGTCATCAAATGGGCTGCGACCGATTGTGAACCACGGCGCTTCAAGAGTACTTGCAGTATGAAAAATACCTCACCCGCGCGCGCTACCCGTCAGGGCGCAGCGACGAGGGAAGCCAGTCGGGTCTAGAGCGGGGGTGGAACGTCCACTATCCTATTAATACGGGGTATTCTAATAGATTCAAGTGTTGGTGATGGCGAATTTCAATCGACGGCACTGGCATGAGAAGTGTTCGAATAACAGATTGCGATGTCGCACTAGAAATCATTGTAATAAGAAGAGCTTCCTGAGAGATGTTGAAGGCTCTTGAGTGCGGCACTTGCACCTGTGTAA");
        }

        private static void ReverseCompliment(string s)
        {
            //input: a dna string 
            //output: the reverse compliment of the input. Reverse compliment is the input reversed, then 
            //exchanging each A with a T (or vice versa) and each C with a G (or vice versa)
            //get data ready to process. Before we go through the string, let's reverse it first
            string reverseS = "";
            for (int character = s.Length - 1; character >= 0; character--)
            {
                reverseS += s[character];
            }
            string sc = "";
            //now that the string is reversed, if we find a T make it an A, if we find an A make it a T
            //if we find a C make it a G, if we find a G make it a C
            foreach (char character in reverseS)
            {
                switch (character)
                {
                    case 'A':
                        sc += 'T';
                            break;
                    case 'T':
                        sc += 'A';
                        break;
                    case 'C':
                        sc += 'G';
                        break;
                    case 'G':
                        sc += 'C';
                        break;
                }
            }
            //print the results of our changes
            Console.WriteLine(sc);
        }
    }
}

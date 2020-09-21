using System;

namespace Rosalind
{
    class CountingDNANucleotides
    {
        static void Main(string[] args)
        {
            CountDNANucleotides("CCAGGTGGGGACAGCAAGAATCACGAACTGATGGCTAGCCAAGGGTCGTATTTAATGCTTCGTGGTCGCGCTAAGTCGGGATTTCGCCTCGGACCTCCGAATCGACCAAAAGGCAGTAAGTCTCTTATCCGCTGTGGCTGAAATTTGCCCAACGCCTAACACCCCATGCCCCTCTCTGTGTGGGAGCAATTTTCGCGCTTCAGGGGATCAGAACCGAATAATTTACCACTCCGTTCTGGATCAAGGTGGGCCTGGATGGACCATCCTGTCTCATGCTGGCAGCGCAAAGAAGAGAATCACAGATTTACCCACTCGGGTCCTTGAAAGTACATAATTGCTTTGACACGCGTACCTTACGGAGAGTGACGGGTGCACGCGTTTGTACTTAATAATCGAGGAGTTGCAATTGCTAATGCGGCGTGTTGTGTTTATGCCTCAAACGTATTCCTCGAGGGCCGGCACAAGCTCTGGGATTCATCCTTTGCGTTTGGATGGTCTCCGTACTCGACAGTTCTCTAAGTTAAATGGGGAGCCATTCATGAGCTAGAGCTTGCAGCCGGGAGGCCGACAGGTAAAGAAAAGCTCTTGGACTTCTGGTCAGGCTCAACATTCATGCTATATGGCCCACAGCTGAATTAAGCGGTCACACTTCCAGAGGGGAACTGCGTCCCATTGACCAACTGGGCATGTTGTAAAGAGCTCTCGGACTTCAATCTTGGTAAGGTTCCGTACGAAGTTGGACCAGTTTAACTCAGATTCAATAGTGGCCCTCCCAATGTTTTGCGGAGATTCGGGACTGACTGCACTATATTTAGCGCACTGTGTGTTGTCCCGGAGTTGATTGTTTTGTGCACATCGTGGTTGTTCTTATTGTCGTAGGTACCTTGGAACGGCCTTAAATGCTTAGTTCCCCGAATCTGGGTGCCGTCCCCTATTGGACCAGTAGGCTAAGC");
        }

        private static void CountDNANucleotides(string s)
        {
            //input: a string of length s where s < 1001
            //output: four integers, seperated by spaces, counting the number of times A,C,G and T occur
            //get data ready to process, we need to count characters so a string is fine
            //need four counts, one for each character
            int a = 0;
            int c = 0;
            int g = 0;
            int t = 0;
            //go through each character in the string, adding one to the character that is represented
            foreach (char character in s)
            {
                switch (character)
                {
                    case 'A':
                        a++;
                        break;
                    case 'C': c++;
                        break;
                    case 'G': g++;
                        break;
                    case 'T': t++;
                        break;
                }
            }
            //print each number to screen, separated by a space. No space after the last number
            Console.WriteLine(a + " " + c + " " + g + " " + t);
        }
    }
}

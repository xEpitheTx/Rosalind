﻿using System;

namespace TranscribingDNAintoRNA
{
    class Program
    {
        static void Main(string[] args)
        {
            TranscribeDNAtoRNA("GGGTCAACACATTAACGTTCTGACATCACCCAAACGGCTGAGCATGCCGTATGTGGCTTACCGAGACGGTAAAGAGGGAGGGGTGAATGAGGATTCGGCAATTCTCACTTCCGTCTGCCATGCTCTAACGGCAACTTCAACGGTTGATGGGAGGCTTGCCCTGGCAAACGATTGGTAGACAAGTGGATATTGCTTCTCTACTATATACGGTTAAATCTAAACTTGTCTTCATCTCGCTGGAGGACCCATTCACCATCTCGATGTAGCATGCTCTGGGCGCTTACCGGCCTGCTTCATGTTTGCACGGACAAAGCCCATACCTGCTAATCCTATTCTTTAACTTTGCTCTTACATACGCCGGAGGGCCGGACTGTCTCTTTGATGGCAGCATTGTGGGGGCGGTGCGCGCCCAGACTGGTAACAATGCATTCGTGTTGTAATTGCAGTCAAACGACATGTCCCTGCGGGGGTTGTTCCCAATGCGTATCTAGACGATCAGTTGATATTGATTGGTGCCCGGCGCCGCCATCTACGATCCGGGATATGATGCAGTCTATCCTTATGTCGTGGGGCAAGGCACAATTGCGATGTCGATCAAATTGCGGACCCGCAGCCCCGAACAGGAGTCCTAAGAGATTTTGTCGGTGGTCCACAGTAGGGCGGACTTGACAACGGTAGATACATAAGTTGTTCCGCCCGCAAGACGACATAGTAGATAAGTGATAAATGTTCTTAGAGTCGGTGGGATTTCGTGTAAGGAGTGTGGTACCCCAGTTGACCAAATTATTCTTCTACTCGCTAATTCTGTACACAATACAGGCGCCCTTGACCATTCGTATTTGGGGACAGTCAAACAGGACCTAGATAGCGCGCCACGGCCCGCCCGGACAAAGATTCGTCAAGTGCTTCAAACGTTCTTTTTTGAACGGTCATAGCCGAACTCCCCGCATGATCTTCCTTCC");
        }

        private static void TranscribeDNAtoRNA(string t)
        {
            //input: a dna string of A,C,G and T
            //output: a string where every instance of T is replaced with U
            string u = "";
            for (int character = 0; character < t.Length; character++)
            {
                if (t[character] == 'T')
                {
                    u += 'U';
                }
                else
                    u += t[character];
            }
            Console.WriteLine(u);
        }
    }
}

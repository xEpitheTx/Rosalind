﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsensusAndProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string unprocessedDNA = @">Rosalind_0210
GCATTCTACAGGGCCCTACCGGCGTACCGAAAGGACTCTGATCATGTGCGCTAGAAGTGA
ACGAAGAACTGGACCTCTAGCTGCCTGTGCTAGCTGCCCACATGAGGTTGTGTTCAACCC
CATACGATCAATGTCTTGAGTTCGAGCTCCCGAAGTCACGTAAGTGGACGAGGCGGGAAT
TGAGTTCGGTTCGAAAGCGAGTCCTCCGCTACAACAGCGAGAAGTGTGCCACCAGGCTGG
CTGAGAACGGTTGTAGTACCGTTGCCTAGTCCTGCCACCCAACTGATGACTACGACCAGC
ACAATACCAACCTGATCGCGTTGTGTCCCACGGTGTCCGAGTTTCCCTTCTTGAGAGGCA
ACAGTCTAGTCCCATATTCTGAAATCGTATATACTGTGTCGAGGGTAGGCGCTTTGTTTT
CCACCCTAATGTAGCAGTTATGTTTAGACTTAGCCGCTGGCGATTATCGCAAAGTCGACC
CACCCTGAGTCGGCTCACTTAGATCAAGACTGTGCGACCAAGGATGTGCCGTCTTTTGGG
GCATTGTCTCCGCACCTGAAACCTGATCTCTCTCAAATAGCGGCCGTACTGCTCCACCTC
ATCCCAAATCTAGTCCACGTGACTACACATCCGAGGACCGATTTTGCGTGGAAAATCATT
TGTTGAGTGACCTCCAGAGTGGGATCGCCATCTGACTGGAATTAGCTATTCACCAATCTT
GCAGTCTAAGTCGCACCGTCATAAAACAAGGTAGCGAGTCGCAGTCGTAACGGTCTTCTC
TCCATACGATACCATGCAGGTAAAGATGAGACAGTCCGACTAGACCCTGCTCTATTGTGT
CCGCTTTTAGCTCGGAAGAGCGAGAAACCGAAACAGTCTCGCAATAGTGTAAGCATTACC
AACCAGAAAAAATGGCACGGTGCTATTCGACGGCAAGTTAATACAGTTCCTTTTGTTAAA
ACGGGG
>Rosalind_0395
CCCCTCGAGAAGGTGTGTTTAAACAGAAATCTTTTTCTTTTCCCTATGCCCAACTTTTAT
TTCCGGTGTACTCATATAGTTTTAAAGTTCGAAACCGAATGGATCCCAGCCCCCCGTCCT
ATGGGCAACCCAACCGGGAGTGTAACATAATTGCGGCTCAATATGATCAATCTTTTAGCA
CATACCGCTGATCACACTCTAATGCACTTATGACAGATACGGGTCTGTGAGTCCAGGCAG
CCTCTTGGACCGGACGGTGTTAAAACTATTCGGTGCACAGGGCATACCGTTGGACATGCC
GACGTAGGATGCTCTCCCTTCAGTCCCCTGGTATTGGTAAGAAGGGTAGAGAGTAGTGTA
TTCGTTCACTCCTTGCGGCTCAGTGTTTGACCCCGTGTGTCGGGGGAAGAATCTAAAACA
AACATATAAGACATCAGGGGAGAAGCATCATGGAATACAATAGTACCCACTAGAGTCTGT
CGGCGCTAGGCAGCCGGTGTGTGGGTAACCCCGAACAAGTGACTTCCTCTCCGTAAGGGT
GATCAGTAGTGCCAAAAGCCCTTCTTTCTCAGTCGTTACCATCGGAGAGCTACTAACGGA
GGTCTACTCCTCCACGGAAACGTCGCTACCTACTTTATCGGCAGAACAGCCCAGGGACTA
CTCATCGTCTTCTCACTCGACCCATTGATTCTCGATATGAGGAAGTGGATTCGCAAACAG
GGCGGCAACCCAAGGCAGAACACGATGAGTCACTCACGATCCCTCGTAGAAACACCATGA
TGACGGACTAAACCGACCAGTCAACCCGGGGATGGCACTACTAAAGCGGGCCGGAGGGGA
ATCAACATTACGACCACGATGCCAGTCCCTTTATATCCTCATTGTCGTAGACATTGCTGA
GCTCCAAAGCACATTATAGGACACACTCTAAGAAGTTGAGTTGGGGCTCCTACCGGAATT
CTTCTG
>Rosalind_7696
ACACTCGCACAGCCACGGGGTGTTTCACGTTTTTAACCATATGGGCATTATTCTCAGCCA
GTACCGAACCGAGGGAATGGATAGAAGACTTTGTACTACGGTATGACAACGGGGGGAATC
CGGCTAAATGGCGAGTGAGCCAACACTAACTACGGCTTGAAAATTAAAAGGTTTGCCCGA
GGTCACTGTACTACTAAGGTGCTTCTTCGGCCCTTCATAAGCGAGTCTTACACACTTTAT
ACCTCAATCGAACTGTCTTTAGCGGGTCTGCTCATGAAGAGCACACGTGATCCCGCATCA
GCCCGGTCATACGATCTAGATTGTGGCGCTTCAAAAGCGCTGTCAGAGTGACCCTGCCCT
CGAGTGATATCGTACTGACACCTCCACGGGTGAGCTCGGAGAGCCGATCTCAGACAGGCG
GCCGGGGACGGAAGTGAATCCGCTGCGACGGCAGGTGCAGGCGGACAATGGTCGTCGTAG
CGCTTTGTCTCCTATCTTTAGGTAAAACTGACGACCCATCGCGCTTTACGCCAACGAACC
CTGAAGCATTTGTACAGTCCTGAGTCTTGCACGTGCAGAGCACTGCATGTATTATTCTTG
CGACTGCCGACAGTGTGCTTTTCAGTCCGTTACACTAACAAAGTGCATCCTCCGTTTGAT
CAGATAATTGCTCGGCAGCGCTCGCAGGCAAGATATAGTGAGCCAGGGTGACGCTATTGA
CTGATTATAGCGCATAATAGAATCTCTACTAATAAACACTCCACGTAGATCGGAAGACCT
TGGCACTCGTTACCAGCCGAGAGAAACACCTAATAGAGGATCGACGGCATGTACATCCTC
ATTACCCTTGCTCGCTGAACCTAGCGGCCAGGTTTATCATCGCAGCTTGTGTGCATGTCT
ACATCGTATGTGATCGAGCCTTGCTCCGCCACCGCCCTGAAAAAGCGACTAACACTAAGA
TAGACA
>Rosalind_5432
CAGAAATATCTGTAGCATGAGTTAGCCTTCAGCTGTCTTGACGTGGAGTAACGGGGACTT
TAAGCTACTCAGGTTTGGGTTGCCTTTGTCTCAGTTCAATGGCCCACCATACTGTTCCCC
GCGGGCACGAGTACTTCTGAATGCAACTCGTGATGTGTTCCGACTCCCGGGCGCGCTGGC
CTGATACGTTATAAACGACGCCTACCGTAATTGTGTGCATGGACGGTCACGAAGTCTGTA
TAGATGTAAACCAGTATGGTGGCCCCAACATGATAAAACTTAAGCTACGATGTACTTCCC
TCCGATTTATAATTGCGCATCGCTGGTGCAGGATCACCACGAAGTGAACCTTCGCAGAAC
CAGCTTTGACGAGACTCTTATCTATTCCACCGGAGCGATTCATATTGTATAGTGAGATCC
ATGCGATGCTACGTGCAGGCGCAAAAGTACATGCTCGAACATATGAGCCGTCCCAGAAAC
GACATAATCTAGCTATTTTTACTAATTTGGGGCCAGGGGCGCCCTCAAGTGTTCTGGCCT
TGGGCATTGAGCCTTAAGAGAAGGCGTGCTGATAAGTCTCAGTAGGAATCTGAGCGACTC
TGATATCCTTTTGGAAGAGGGCCAAGGACCAGTCAGAACTCATTGCGGCCTCCGGTACTA
CTAGCACGATCTCAATTCGCCTAGACAGTCATCTTGAGCTAAAACGCGACCGGAGGCGAC
GGAGTGAGAGCTGAAAGAGGCTGCCGTCAGACAAACGTTGCGGAGGTCTTACGTGGGGAT
TCATAGCTAAGACCAGTTTACGAGGACTGTCCTCTTAGCGACGTCATTCTTTCGCGGCGT
AAACTGCGAAAGGGTTCTCATTTCCAACTAGTCGAGGCAAAGCGCAAGAAATAAGTCAAT
ATCAAGTGCTGGACAAGAGGCTATGATATTCATGCCGTGGGCTAAACCATTTCTCAATAG
CCCGAA
>Rosalind_9971
AACCATAAGGCTTTTACCTTAAGGCAACGCGCGGACAGATTGGAACGTCCTGGTTCGGCA
CTTAAGGAAGTCGTATGAGACTTCGATAAAGCTTTCGCTCACTTAGGCGGTATTTGGACG
AGTCGTGTAAACAAGTAGGCGGTACAAGAAGTCGATATTTTCTTGGATGCAATGATATTG
TGATCGTGGTACGCATAGACGATTTTTAGCCCGTAATCGGTCAACATAACCAGTCTTGCC
CGCGGGACTCGGTGTATGTACAAAGAAAGTTTCTTAGCCTCACGTCGACTTCAGGCCGAA
ACACCTGAATCCGCGAACTCGTTTAATGGTATATGACGAGGCGTGCGGTACCGCATCGGC
GGGTGCTCTAGGTATCACTTTCCCTTAGTACTATAGTTTAGGCCCGATGGCCTTCCTTCC
TTCCTTTAAGCTCTTCTCTAAGGGCGCTGTGTAGGGAATCGGTGGGGGACTTAAAAGCTA
GCAGACAACTCTTCCTCAGATGGACACACGCGAACAAACGGTGGTTCAAATGATTACGCC
GGACCCCACATTTTACAGACAAAGGCAGTCTAAGCGGTTCGGAACTGCTGACACCGGTAC
TGCCATCGCTGTCTGGGAGCCGATGGCGGTTTGTCTCCGCGTCATCGAGTAGTCAGTAAG
GTTTGCTCTGGATGGTATAAGACACGTACGATTATATGTGGAACCCCCTGCTAGCATTAC
GTAGGCGCCGAGGGTGCCTGTACGCAGTTCTCTTCGCCACTGACCTCCTACGAGCTGTTG
GGGTGCGCGAGTCTGGTCGCTCGGCCGTACCTGGCACAGTGGTCGAACACAGGAGCGGCT
ACCCCTCGTCGAGATTCCCGCCGGGAGATAGGTTTAACCTACTTGACAGTCCAGCATCTT
TTTTCCGAATCTGGGACTATCGGGACCACACTATCGTGCTGGAGTATGATCTGCCTGAAG
GAGTAC
>Rosalind_0784
TGCTGATATGTTTAAAGAGCAATTTCGGACTTTTCGTCAACGCGTAACTGATTGTATCTA
TGTCCGACGACCGCCAATAGCGTGTGGTGAACTCATTACCCCCCAATGAACATACTTCAT
GGTCCTTATCCCTCTGAGCGATATTTTCGACGACCTTGATAGTAGCTTCGCTCTTGGCGT
GGAGTTTCACTCGGAACGGGCGGTTAACTTGCGAGAACGACCCCGACTTTATCGCTATGA
GGTTGATAGCAAGGTTGGCGCAAAGTCCCATCCACAATCACGTACTTAATCGCCATGCGA
ACGAAGACTTCGACACAGTACGAGTCTGGAGTTCAGACGCTGCGTGTACCATCCAACTCC
GTGCAGCGCGAAGGGTGCGCCCCCTCCCGTTCCATTTATGACGGTTCGTTACCCCGTCAA
AGCGCTACATTCCGGCCGCAGCGATTGAAGTGCCAAGGAGAAATATCCAGTTGGACGCGT
AGCGAGTCCGTCGATTGGGAATCCGAATATCCTGTAAGCCGTAGAGGCGAAACTTCGGTT
TAACTTATGCACAATGTACGGCATCACGGGCCTTTAATACTGCGGTCCGTATGAAGGAAG
ATGGAGTCAATTGTACTGAAACCCCTTGAAACCACAGTTTCTCATTTGGAAAGACCAGTG
TTCCGTCCGACGTTACGCAAAACGTGCATCTGCTCATAATCCCAAGAGACGTTGACACAG
ATCTCATGACTACTGAGGTGAAGTCATATGGTTTCGGTAATAGCGTCCAGCTGGGGGATC
CTGCCCGTAACGGCCTTCACTCTACTGTTGCATGCCCCTTTCCCTGATTCTGAACCCGCT
CCTGTTCGGGCGACGGGCGATGCGTCAAACTGGCCGTCAATTTCGCTTATCGCATGACGC
TTTGCAGCTTTTACCACCTTATAACCCCGGAGATCGCTACCGATACCCATTCGGCGGTGG
AAGAAG
>Rosalind_8142
GTCCTATCCTTATATGTTCGGTTCATTTCAACTCCTAAATACAAGTATGTGCCTTGGTCC
GACGCACCCAACGGTGACTGACTGATAAAATTGGTGCTAAGAAAGGACATAAAGCTTCGC
ACGCTATGGGTTTTTTAACCTTGCCATTCACTGTTACCACTGCCGACTTATACACCGTTC
TCATCCTTATAGCCGGCGTTGCCTGTGAACGATATGAAGACCTTGCTGTCTTCTAATACA
TTACGACCGCTGTCTCATTATACAAATTTCTCCCAGATGCCGGCTAGGTCCAGTGAGAAT
TACTCTGATGTTGGAGAGGACTCTTCTATATCTCCGATGGGCGTCCTACACCAGGTGTTG
GGTTCGTACACTAAAGCTCACAACCACTAACAGTCACGAAGTGTAAAGCTATCAGACTCT
CCGAAACTTTTATAGCTTAGGGGGTCGGATTGGCGCGAGTTACCGTCATTACGCAGCTAA
TGGTGCGCATGAATAGTCGATCGCCGCGTATCCAACGCCAGGAACCCGCGAGTGTTATCA
CAGAGATTTCGGCCGAATCGCTTCTTATGAAATACCTGATGGCAACGTAATGGCGCTTCC
GGTCTATAGTTCCAAAAACGCGGAATACCGGGCGGCTATCGTCACGATTGCGAAGGTCCT
GAACATGTTCAGGCAGGCATTAGCTCTGACCGGCATGAGAGATAGTCTGGACGCCTTTGT
GTATTAATGAGGTACGCGTAATGCACGCTTGTGTCTTGCCCCATAGTTAAATAGCTGTGT
GGTTTCTTGCATTTCATTATAAGCTACACCTTGTAGTAGTCCCGTTCGGGAGAGAGGAGC
AGGTGTTAAAGGCGAGGTGGACACTCCTTTTTAGTCTACCTTACTAAGCTGATGGGTTGA
AGCCAACTTGGAAGGCTACGGCTGTGCGGCTCGTTTCAGCTGGTGTGTCTATCAAGTCAG
CATGTG
>Rosalind_4202
TCCCTTGTGCACATATTGAAGTGATGACGGCCCTATAGGTGGGACTGTCCGGCCGTTCAT
GTACAGCCCTGACGCCCTCTCTAACTCAGAGTATTCCCAGCTTGTAGTTTTAGGCGATTA
TATGAACCCTACGTCTGTGCGCCTGACTAGTACGAGATCCTCGAAGGCCACCCGAGACGG
GGCACAAGCTACCGTTGGGCAGAGTTATGCACATACTGGAGGCTGGAGCACCTTGACCCC
GGTGTATCAAGAATTGCGACTCGTTCGAATCGTCACGCGTATGGCTCCCCCCCCTGCTAA
AAGGTTGCCCTAACACTGCGCGGTGTGCTTATCACTTACTGGGTATGGGTGGTTCGTGGG
TAAGATTCTGTACTGAAGATCCCAGCACGTTCGCGAACCTAGAAGTGGTGATCCTTCGCG
TCTCGCAACTTCCCGACGAGTCCATTCCCACTCTGTGCGACGACTATTTGCGAAAGTTCA
ACCTGAGTCGTCGATCGACGCTAGAAACTGGCGTGCTCATTCAGTAGCCGCACAAGTGAA
CCTCGCCTATTGCTGTTAAGTGACGGTTGGGCGACCGACCCTCAACACCGCTTCACTCTC
AGTCCGTTACGGAGGTAGTCGCTAAAATATTAATGCTATACGACCAGCACGTAAGTCAGC
AGCATGACTTACCGAGGACACTGGACACGTCGTACTGCTCTGAGTGTATCGGCCACCCTA
GGATTAGGCTCAATCGTCAAATGATACTCTTCTACGCAATACACTATGCTTTATAGAAGT
TAAATACTTTCGACTACCAATAGTGATAGGTAAAGCCTCAAAGATCCGCATCCAGGGGTG
GTCAAAGTCAACCAAAGTGGCTTGCATCCAGCTTCCATATAGAGCCTCACAACGTGCGGG
CGCGGCCCAGAGGGCGAGGACCAAATTTCGCCTGATTGTAGCCCCTATCCAGTTAGCTCT
GGCCCC
>Rosalind_0109
CACATAACGTTGGCCGGACATGAATCCCAAACGAGAGGTAAGTCAGAGTTAGGGTGTATG
TAGTGAGTCGGAGCTCGTCGGCGCCGGTGCTCTCCTCTCACCAAGGCGTATACTTCTTTA
TGACTTTTATCATTCTGAAGTGGGAACGCGTGCTCTTCGTGCCCGCGCGTGCATTACTCA
GGCATGCGCTAATGTTCGTGCCGCGCATCCATATAGGTAGAAATTACGAGGAGTCCCTCA
TGTCGACCTAAAAGATTCTAAACTGCCGCAACCTAGAAGTCAACAGTACCATTGTCGGTA
AGGTTACTACACAGCCCGTGAAGAACATTTTTAGTGGGGCTGGAGATCGTATGAGTAATA
ACGCAGTACCTTGCTCACATAGCCCTCTTCTCGTTTAGGGCAACCGGGAGAAACGTTGCT
ACACTCCTTACACGGAGTCAACACCTCATCGCATCGCCCACTAATTTTCTCTTAAGATAG
CAACATCGTTCGCGGGTCACGCCGAGCTCCGAACACGTGCGGAGCGCGGTTCGCCGCATA
GGGAGCTCCGGGCTATCACTCGTATTGTCCGTGAGCACATTTACTGATGTGTCATTATCA
CTGACAAGGCCATAGCGGCTTACGCCAACTCTTGCATCCCGACGATGATCTGATGAGGGG
TAGTCAGCCCTTCGCGTTAAGACACGTTGAGGGTAGCTGGCCGATACGTCTAGGCCGAGC
AGGGACCCATGATCGCCATGGGTTCATTGCTTCCATTGAACATTCATGGAATGACTTGCA
TATCGTGTAAGAACCAGTGAGAGTGAGGTATTGCTAATAGTTCAGAATAACGCATGCACG
AAATATATTATAGTCATTATTATGCTGAACTATGGCGCGTCTTATCCGCTTCGGCCTTCG
CTATGAGACAGCAGTTTGTTCCTTATCAGCATGTATCGAATCTATAACCGTTCCATGAAA
ACTTGC
>Rosalind_4058
CGGCACATCAACGACTACACCCTGCATAAGTATAGATACCTCAGTAAGTCTGACCTCGAT
ATAGGCACCAATCCCGCCTTCTGAAGGGCGACGAGTATAGGGGAATTGGCCTTCTTGTGC
AACTTACCAGAAGACAGTGCCCTTTCTCCCATTCAGGGTCCCCGCTAAGATCCTTGTTTT
GTTAAGGGTGCGGATGCTCGGGACTAGTAGCCAGTAAGCCATGTAGCATGACCGCTTAGG
ATTAACGGCAGAGGATTCTCCGACGACTCTCAAATATTCGGTACGACATCCTGGGGGGCT
TGAACTGAGATGTAGTCTAAACGTACTTGCGGTAACTCAGAACTGGACTCGCGCGCGACT
TTCAAGAACATTTACGGAGATCGAGTGATCCTCTCACACCGTGTATTTTCTTCATCCAAA
TAAGCACCTCGAGGAGTGAGTACCTCTCGAATGGTATTTGTCCAAACCTGATTTGTAAGT
TGGCTCGGGTTCAAAGCGCACCGGCTCTGAATTAAGCTACAATGCTCACATCAGTTAATG
GCGATCAATCCTACTGTCCCAGGAAAAATCGGGGTAGTGCTAAGTCCCTGCCAAGTCAGA
CATAATATATCGCATCGGTTTTAGAGCATTCGAGGGCCAAAAATAGCAGTGTTAAACGGC
ATTAATATTTTTTCTGGTCGCGCGTACGACATTACGCTAACCACTGTGAACTAAACGTCA
ACTGGGGTGATCCCAACCAAAGCGTGTGCAATGGACTCTGGCCGCTCGAAGACGGATGGT
GTGGGTCTTCCTCCGTCTTTACACAGACCTTCATATATTGAGGCCTTAGGAGGATCTTAT
CTATTGATAACGTCAGGTGGAGGCTGACTCTGTTAACGTCTTATCGGCCTTGTAAAACTA
TCGTATCATCGCTGCAGACGAGAACACGCGGGCGCGTACCGTCAAATGGCTCTATTGATT
GTTAGC
";
            List<string> answer = ProcessDNACollection(unprocessedDNA, 13);
            answer = FindConsensusString(answer);
            foreach (string str in answer)
            {
                Console.WriteLine(str);
            }
        }

        private static List<string> FindConsensusString(List<string> dnaStrings)
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
            //Count up how many times a letter appears in the first spot of each string (ACGT are the only letters we're looking for)
            for (int characterPlace = 0; characterPlace <= dnaStrings[0].Length - 1; characterPlace++)
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
                concensusString += FindMostOccurences(aCount, cCount, gCount, tCount);
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
            List<string> consensusStrings = new List<string>()
            {
                concensusString,
                aCountStr,
                cCountStr,
                gCountStr,
                tCountStr,
            };
            return consensusStrings;
        }

        private static string FindMostOccurences(int aCount, int cCount, int gCount, int tCount)
        {
            if (aCount >= cCount && aCount >= gCount && aCount >= tCount)
            {
                return "A";
            }
            else if (cCount >= aCount && cCount >= gCount && cCount >= tCount)
            {
                return "C";
            }
            else if (gCount >= aCount && gCount >= cCount && gCount >= tCount)
            {
                return "G";
            }
            else
            {
                return "T";
            }
        }

        public static List<string> ProcessDNACollection(string DNACollection, int idLength)
        {
            List<string> processedCollection = DNACollection.Split('>').ToList();
            processedCollection.RemoveAt(0);
            for (int str = 0; str < processedCollection.Count; str++)
            {
                processedCollection[str] = processedCollection[str].Remove(0, idLength);
                processedCollection[str] = processedCollection[str].Trim();
                processedCollection[str] = processedCollection[str].Replace("\r\n", "");
            }
            return processedCollection;
        }
    }
}

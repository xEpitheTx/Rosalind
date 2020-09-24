using System;

namespace MedelsFirstLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            DominantProbability(19, 18, 19);
        }
        private static void DominantProbability(double k, double m, double n)
        {
            //k is homozygous dominant, m is heterozygous, n is homozygous recessive
            double totalOrganisms = k + m + n;
            double kProbability = k / totalOrganisms;
            double mProbability = m / totalOrganisms;
            double totalOrganismsAfterOneRound = totalOrganisms - 1;

            double kkProbability = (kProbability) * ((k - 1) / totalOrganismsAfterOneRound);
            //given a punnet square, the outcomes for heterozygous dominance is 3 times out of 4
            double mmProbability = (mProbability * ((m - 1) / totalOrganismsAfterOneRound)) * .75;
            //nn will never be dominant
            //double nnProbability = ((n / totalOrganisms) * ((n - 1) / (totalOrganisms - 1)));
            double kmProbability = (kProbability) * (m / totalOrganismsAfterOneRound) * 2;
            double knProbability = (kProbability) * (n / totalOrganismsAfterOneRound) * 2;
            //given a punnet square, the outcomes for heterozygous dominance and homozygous recessive is 2 times out of 4
            //mutlitplying by two to account for both mn pair and nm pair
            double mnProbability = (mProbability * (n / (totalOrganismsAfterOneRound)) * .5) * 2;
            double domProb = kkProbability + kmProbability + knProbability + mmProbability + mnProbability;
            Console.WriteLine(domProb.ToString("f5"));
        }
    }
}

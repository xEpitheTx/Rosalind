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
            double kkProbability = (k / totalOrganisms) * ((k - 1) / (totalOrganisms - 1));
            //given a punnet square, the outcomes for heterozygous dominance is 3 times out of 4
            double mmProbability = ((m / totalOrganisms) * ((m - 1) / (totalOrganisms - 1))) * .75;
            //nn will never be dominant
            //double nnProbability = ((n / totalOrganisms) * ((n - 1) / (totalOrganisms - 1)));
            double kmProbability = (k / totalOrganisms) * (m / (totalOrganisms - 1)) * 2;
            double knProbability = (k / totalOrganisms) * (n / (totalOrganisms - 1)) * 2;
            //given a punnet square, the outcomes for heterozygous dominance and homozygous recessive is 2 times out of 4
            //mutlitplying by two to account for both mn pair and nm pair
            double mnProbability = ((m / totalOrganisms) * (n / (totalOrganisms - 1)) * .5) * 2;
            double domProb = kkProbability + kmProbability + knProbability + mmProbability + mnProbability;
            Console.WriteLine(decimal.Round((decimal)domProb, 5));
        }


    }
}

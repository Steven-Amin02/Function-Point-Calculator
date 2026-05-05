using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function_Point_Calculator.Data;

namespace Function_Point_Calculator.Logic
{
    internal class CalculatorEngine
    {
        public static int CalculateUFP(int[] ei, int[] eo, int[] eq, int[] ilf, int[] eif)
        {
            int ufp = 0;

            ufp += CalculateCategory(ei, "External Input");
            ufp += CalculateCategory(eo, "External Output");
            ufp += CalculateCategory(eq, "External Inquiry");
            ufp += CalculateCategory(ilf, "Internal Logical File");
            ufp += CalculateCategory(eif, "External Interface File");

            return ufp;
        }

        // Helper method 
        private static int CalculateCategory(int[] counts, string categoryName)
        {
            if (counts == null || counts.Length < 3) return 0;

            var weights = MetricsData.ComplexityWeights[categoryName];

            return (counts[0] * weights.Low) +
                   (counts[1] * weights.Average) +
                   (counts[2] * weights.High);
        }

        public static double CalculateTCF (int di)
        {
            return 0.65 + (di * 0.01);
        }

        public static double CalculateFP (int ufp, double tcf)
        {
            return ufp * tcf;
        }

        public static double CalculateLOC (double fp, string selectedLanguage)
        {
            if (!Data.MetricsData.AVC.TryGetValue(selectedLanguage, out int avc))
            {
                throw new ArgumentException("Invalid language selected.");
            }

            return fp * avc;
        }
    }
}

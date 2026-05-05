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
        public static int CalculateUFP (int[] ei, int[] eo, int[] eq, int[] ilf, int[] eif)
        {
            int ufp = 0;
            
            ufp += ei[0] * MetricsData.ComplexityWeights["External Input"].Low;
            ufp += ei[1] * MetricsData.ComplexityWeights["External Input"].Average;
            ufp += ei[2] * MetricsData.ComplexityWeights["External Input"].High;

            ufp += eo[0] * MetricsData.ComplexityWeights["External Output"].Low;
            ufp += eo[1] * MetricsData.ComplexityWeights["External Output"].Average;
            ufp += eo[2] * MetricsData.ComplexityWeights["External Output"].High;

            ufp += eq[0] * MetricsData.ComplexityWeights["External Inquiry"].Low;
            ufp += eq[1] * MetricsData.ComplexityWeights["External Inquiry"].Average;
            ufp += eq[2] * MetricsData.ComplexityWeights["External Inquiry"].High;

            ufp += ilf[0] * MetricsData.ComplexityWeights["Internal Logical File"].Low;
            ufp += ilf[1] * MetricsData.ComplexityWeights["Internal Logical File"].Average;
            ufp += ilf[2] * MetricsData.ComplexityWeights["Internal Logical File"].High;

            ufp += eif[0] * MetricsData.ComplexityWeights["External Interface File"].Low;
            ufp += eif[1] * MetricsData.ComplexityWeights["External Interface File"].Average;
            ufp += eif[2] * MetricsData.ComplexityWeights["External Interface File"].High;


            return ufp;
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

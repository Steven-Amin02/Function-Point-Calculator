using System.Collections.Generic;

namespace Function_Point_Calculator.Data
{
    public static class MetricsData
    {
        // Function Point Weights (UFP)
        public static readonly Dictionary<string, (int Low, int Average, int High)> ComplexityWeights =
            new Dictionary<string, (int, int, int)>()
        {
            { "External Input", (3, 4, 6) },
            { "External Output", (4, 5, 7) },
            { "External Inquiry", (3, 4, 6) },
            { "Internal Logical File", (7, 10, 15) },
            { "External Interface File", (5, 7, 10) }
        };

        // GSC (14 TCF Attributes)
        public static readonly Dictionary<string, int> GSC =
            new Dictionary<string, int>()
        {
            { "Data Communications", 3 },
            { "Distributed Data Processing", 3 },
            { "Performance", 3 },
            { "Heavily Used Configuration", 3 },
            { "Transaction Rate", 3 },
            { "Online Data Entry", 3 },
            { "End User Efficiency", 3 },
            { "Online Update", 3 },
            { "Complex Processing", 3 },
            { "Reusability", 3 },
            { "Installation Ease", 3 },
            { "Operational Ease", 3 },
            { "Multiple Sites", 3 },
            { "Facilitate Change", 3 }
        };

        // AVC (Language Factors)
        public static readonly Dictionary<string, int> AVC =
            new Dictionary<string, int>()
        {
            { "Assembly", 320 },
            { "C", 128 },
            { "C++", 53 },
            { "Java", 53 },
            { "C#", 54 },
            { "Python", 21 }
        };
    }
}
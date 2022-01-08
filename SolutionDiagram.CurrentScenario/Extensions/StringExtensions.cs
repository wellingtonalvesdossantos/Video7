using SolutionDiagram.CurrentScenario.Exceptions;

namespace SolutionDiagram.CurrentScenario.Extensions
{
    public static class StringExtensions
    {
        public static void ValidateCpf(this string value)
        {
            
        }

        public static bool IsCpfValid(this string value)
        {
            return true;
        }

        public static string FormatCpf(this string value)
        {
            if (value.Length == 11)
            {
                return string.Format("{0}.{1}.{2}-{3}", value.Substring(0, 3), value.Substring(3, 3), value.Substring(6, 3), value.Substring(9, 2));
            }
            else
            {
                throw new BusinessRuleException("Invalid Cpf to format");
            }
        }
    }
}

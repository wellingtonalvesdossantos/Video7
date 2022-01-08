using SolutionDiagram.A.Exceptions;

namespace SolutionDiagram.A.Extensions
{
    public static class StringExtensions
    {
        public static void ValidateCpfCnpj(this string value)
        {
            
        }

        public static bool IsCpfCnpjValid(this string value)
        {
            return true;
        }

        public static string FormatCpfCnpj(this string value)
        {
            if (value.Length == 14)
            {
                return string.Format("{0}.{1}.{2}/{3}-{4}", value.Substring(0, 2), value.Substring(2, 3), value.Substring(5, 3), value.Substring(8, 4),value.Substring(12,2)); 
            }
            else if(value.Length == 11)
            {
                return string.Format("{0}.{1}.{2}-{3}", value.Substring(0, 3), value.Substring(3, 3), value.Substring(6, 3), value.Substring(9, 2));
            }
            else
            {
                throw new BusinessRuleException("Invalid Cpf/Cnpj to format");
            }
        }
    }
}

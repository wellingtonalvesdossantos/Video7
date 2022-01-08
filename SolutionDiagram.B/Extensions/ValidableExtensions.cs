using SolutionDiagram.B.Exceptions;
using SolutionDiagram.B.Interfaces;
using System;

namespace SolutionDiagram.B.Extensions
{
    public static class ValidableExtensions
    {
        public static bool IsValid(this IValidable validable)
        {
            try
            {
                validable.Validate();
                return true;
            }
            catch (BusinessRuleException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

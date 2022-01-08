using SolutionDiagram.A.Exceptions;
using SolutionDiagram.A.Interfaces;
using System;

namespace SolutionDiagram.CurrentScenario.Extensions
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

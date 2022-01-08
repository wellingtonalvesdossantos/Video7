using SolutionDiagram.CurrentScenario.Exceptions;
using SolutionDiagram.CurrentScenario.Interfaces;
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

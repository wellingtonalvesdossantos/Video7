using SolutionDiagram.CurrentScenario.Exceptions;
using SolutionDiagram.CurrentScenario.Extensions;
using SolutionDiagram.CurrentScenario.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace SolutionDiagram.CurrentScenario
{
    public class Customer : IValidable
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string SocialName { get; set; }

        public void Validate()
        {
            if (BirthDate.Year < 1900)
                throw new BusinessRuleException("Invalid birthdate");

            CPF.ValidateCpf();
        }

        public override string ToString()
        {
            return CPF.FormatCpf();
        }
    }
}

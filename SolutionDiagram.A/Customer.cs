using SolutionDiagram.A.Exceptions;
using SolutionDiagram.A.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace SolutionDiagram.A
{
    public class Customer
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

            CPF.ValidateCpfCnpj();
        }

        public override string ToString()
        {
            return CPF.FormatCpfCnpj();
        }
    }
}

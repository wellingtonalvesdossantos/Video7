using SolutionDiagram.B.Exceptions;
using SolutionDiagram.B.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace SolutionDiagram.B
{
    public class Customer
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public IDocument Document { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string SocialName { get; set; }

        public void Validate()
        {
            if (BirthDate.Year < 1900)
                throw new BusinessRuleException("Invalid birthdate");

            Document.Validate();
        }

        public override string ToString()
        {
            return Document.Format();
        }
    }
}

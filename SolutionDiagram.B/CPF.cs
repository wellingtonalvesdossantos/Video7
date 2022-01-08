using SolutionDiagram.B.Interfaces;

namespace SolutionDiagram.B
{
    public class CPF : SingleBase<string>, IDocument
    {
        public CPF()
        {
        }

        public CPF(string value) : base(value)
        {
        }

        public void Validate()
        {

        }

        public string Format()
        {
            return string.Format("{0}.{1}.{2}-{3}", Value.Substring(0, 3), Value.Substring(3, 3), Value.Substring(6, 3), Value.Substring(9, 2));
        }
    }
}

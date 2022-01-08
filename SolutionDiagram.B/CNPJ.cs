using SolutionDiagram.B.Interfaces;

namespace SolutionDiagram.B
{
    public class CNPJ : SingleBase<string>, IDocument
    {
        public CNPJ()
        {
        }

        public CNPJ(string value) : base(value)
        {
        }

        public void Validate()
        {

        }

        public string Format()
        {
            return string.Format("{0}.{1}.{2}/{3}-{4}", Value.Substring(0, 2), Value.Substring(2, 3), Value.Substring(5, 3), Value.Substring(8, 4), Value.Substring(12, 2));
        }
    }
}

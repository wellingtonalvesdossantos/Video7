using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionDiagram.B.Interfaces
{
    public interface IDocument : ISingleBase<string>, IValidable, IFormattable
    {
    }
}

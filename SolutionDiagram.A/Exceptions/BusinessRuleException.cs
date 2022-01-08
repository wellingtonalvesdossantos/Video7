using System;

namespace SolutionDiagram.A.Exceptions
{
    [Serializable]
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException() { }
        public BusinessRuleException(string message) : base(message) { }
        public BusinessRuleException(string message, Exception inner) : base(message, inner) { }
        protected BusinessRuleException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

namespace SolutionDiagram.B.Interfaces
{
    public interface ISingleBase<T>
    {
        T Value { get; }

        void SetValue(T value);
    }
}

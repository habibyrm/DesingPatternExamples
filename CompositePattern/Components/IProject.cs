namespace CompositePattern.Components
{
    public interface IProject
    {
        string Name { get; set; }
        void Begin();
        void Complete();
        int CalculateRisk();
    }
}

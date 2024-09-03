using CompositePattern.Components;

namespace CompositePattern
{
    public class ProjectComposite : IProject
    {
        private readonly List<IProject> _components = new List<IProject>();

        public string Name { get; set; }

        public ProjectComposite(string name)
        {
            Name = name;
        }

        public void AddComponent(IProject component)
        {
            _components.Add(component);
        }

        public void RemoveComponent(IProject component)
        {
            _components.Remove(component);
        }
        public void Begin()
        {
            Console.WriteLine($"{Name} projesi başlatıldı.");
            foreach (var component in _components)
            {
                component.Begin();
            }
        }
        public void Complete()
        {
            Console.WriteLine($"{Name} projesi tamamlandı.");
            foreach (var component in _components)
            {
                component.Complete();
            }
        }
        public int CalculateRisk()
        {
            int totalRisk = 0;

            foreach (var component in _components)
            {
                totalRisk += component.CalculateRisk();
            }

            Console.WriteLine("******************************************");
            Console.WriteLine($"*  {Name} projesinin toplam riski: {totalRisk}  *");
            Console.WriteLine("******************************************");

            return totalRisk;
        }
    }
}

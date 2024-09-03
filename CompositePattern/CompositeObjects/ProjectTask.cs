using CompositePattern.Components;

namespace CompositePattern.CompositeObjects
{
    public class ProjectTask : IProject, IProjectRisk
    {
        public string Name { get; set; }
        public int Risk { get; set; }

        public ProjectTask(string name, int risk)
        {
            Name = name;
            Risk = risk;
        }

        public void Begin()
        {
            Console.WriteLine($"{Name} görevi başlatıldı.");
        }

        public void Complete()
        {
            Console.WriteLine($"{Name} görevi tamamlandı.");
        }

        public int CalculateRisk()
        {
            Console.WriteLine($"{Name} görevinin riski: {Risk}");
            return Risk;
        }
    }
}

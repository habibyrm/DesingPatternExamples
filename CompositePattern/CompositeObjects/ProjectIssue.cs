using CompositePattern.Components;

namespace CompositePattern.CompositeObjects
{
    public class ProjectIssue : IProject, IProjectRisk
    {
        public string Name { get; set; }
        public int Risk { get; set; }

        public ProjectIssue(string name, int risk)
        {
            Name = name;
            Risk = risk;
        }

        public void Begin()
        {
            Console.WriteLine($"{Name} hatası başlatıldı.");
        }

        public void Complete()
        {
            Console.WriteLine($"{Name} hatası tamamlandı.");
        }

        public int CalculateRisk()
        {
            Console.WriteLine($"{Name} hatasının riski: {Risk}");
            return Risk;
        }
    }
}

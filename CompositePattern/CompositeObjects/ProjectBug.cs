using CompositePattern.Components;

namespace CompositePattern.CompositeObjects
{
    public class ProjectBug :  IProjectRisk
    {
        public string Name { get; set; }
        public int Risk { get; set; }

        public ProjectBug(string name, int risk)
        {
            Name = name;
            Risk = risk;
        }

        public void Begin()
        {
            Console.WriteLine($"{Name} bug'ı başlatıldı.");
        }

        public void Complete()
        {
            Console.WriteLine($"{Name} bug'ı tamamlandı.");
        }

        public int CalculateRisk()
        {
            Console.WriteLine($"{Name} bug'ının riski: {Risk}");
            return Risk;
        }
    }
}

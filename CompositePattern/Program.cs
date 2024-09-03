using CompositePattern;
using CompositePattern.CompositeObjects;
//using Task = CompositePattern.Task;

ProjectComposite mainProject = new ProjectComposite("Ana Proje");

ProjectTask task1 = new ProjectTask("Task 1", 2);
ProjectIssue issue1 = new ProjectIssue("Issue 1", 3);
ProjectBug bug1 = new ProjectBug("Bug 1", 5);

// Projeye parçaları ekleme
mainProject.AddComponent(task1);
mainProject.AddComponent(issue1);
mainProject.AddComponent(bug1);

// İşlemleri çağırma
mainProject.Begin();
Console.WriteLine(Environment.NewLine);
mainProject.CalculateRisk();
Console.WriteLine(Environment.NewLine);
mainProject.Complete();

# TheCsprojLibrary

Tired of guessing how the names of your csproj properties? This library is for you!

Usage:

```csharp

TypedProject myProject = new TypedProject(new Project("MyProject.csproj"));

foreach (Reference reference in myProject.References)
{
    Console.WriteLine(reference.Name);
    Console.WriteLine(reference.HintPath);
    Console.WriteLine(reference.Private);
    Console.WriteLine(reference.RequiredTargetFramework);
    Console.WriteLine(reference.SpecificVersion);
    Console.WriteLine(reference.UnevaluatedInclude);

    reference.SpecificVersion = true;
}

myProject.TargetFrameworkVersion = "v4.5";

myProject.DefineConstants += " MyConstant";

```

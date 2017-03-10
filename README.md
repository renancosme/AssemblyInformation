# AssemblyInformation
Provide a class with properties  that displays application assembly information (title, description, company, product, copyright, trademark and/or version number).

## Installing via the NuGet Package

    Install-Package AssemblyInformations

## Why the project is useful

You can get assembly information to show on the footer, header and/or in a about page for example.

## How we can use it

See here an example:

```
    using System.Reflection;
    using AssemblyInformations;

    Assembly assembly = typeof(Program).Assembly;
    var assemblyInformation = new AssemblyInformation(assembly);

    Console.WriteLine(string.Format("Title: \t\t{0}", assemblyInformation.Title));
    Console.WriteLine(string.Format("Description: \t{0}", assemblyInformation.Description));
    Console.WriteLine(string.Format("Company: \t{0}", assemblyInformation.Company));
    Console.WriteLine(string.Format("Product: \t{0}", assemblyInformation.Product));
    Console.WriteLine(string.Format("Copyright: \t{0}", assemblyInformation.Copyright));
    Console.WriteLine(string.Format("Trademark: \t{0}", assemblyInformation.Trademark));
    Console.WriteLine(string.Format("Version: \t{0}", assemblyInformation.Version));
    Console.ReadLine();
```

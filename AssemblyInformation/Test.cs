namespace AssemblyInformations
{
    using System;
    using System.Reflection;

    class Test
    {
        static void Main(string[] args)
        {
            Assembly assembly = typeof(Test).Assembly;            
            AssemblyInformation assemblyInformation = new AssemblyInformation(assembly);

            Console.WriteLine(string.Format("Title: \t\t{0}", assemblyInformation.Title));
            Console.WriteLine(string.Format("Description: \t{0}", assemblyInformation.Description));
            Console.WriteLine(string.Format("Company: \t{0}", assemblyInformation.Company));
            Console.WriteLine(string.Format("Product: \t{0}", assemblyInformation.Product));
            Console.WriteLine(string.Format("Copyright: \t{0}", assemblyInformation.Copyright));
            Console.WriteLine(string.Format("Trademark: \t{0}", assemblyInformation.Trademark));
            Console.WriteLine(string.Format("Version: \t{0}", assemblyInformation.Version));

            Console.ReadLine();
        }
    }
}

namespace AssemblyInformation
{
    using System;
    using System.Linq;
    using System.Reflection;    

    public class AssemblyInformation
    {
        private Assembly _assembly = null;

        public AssemblyInformation(Assembly assembly)
        {
            _assembly = assembly;
        }

        public string Title
        {
            get { return GetInformationAtribute<AssemblyTitleAttribute>().Title; }
        }

        public string Description
        {
            get { return GetInformationAtribute<AssemblyDescriptionAttribute>().Description; }
        }

        public string Company
        {
            get { return GetInformationAtribute<AssemblyCompanyAttribute>().Company; }
        }

        public string Product
        {
            get { return GetInformationAtribute<AssemblyProductAttribute>().Product; }
        }

        public string Copyright
        {
            get { return GetInformationAtribute<AssemblyCopyrightAttribute>().Copyright; }
        }

        public string Trademark
        {
            get { return GetInformationAtribute<AssemblyTrademarkAttribute>().Trademark; }
        }

        public string Version
        {
            get { return GetInformationAtribute<AssemblyFileVersionAttribute>().Version; }
        }

        private T GetInformationAtribute<T>() where T : Attribute
        {
            return _assembly.GetCustomAttributes<T>().FirstOrDefault();
        }
    }
}

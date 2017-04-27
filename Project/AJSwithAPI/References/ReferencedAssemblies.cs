using System.Reflection;

namespace Architecture.Web.References
{
    public static class ReferencedAssemblies
    {
        public static Assembly Services
        {
            get { return Assembly.Load("Architecture.Services"); }
        }

        public static Assembly Repositories
        {
            get { return Assembly.Load("Architecture.Data"); }
        }

        public static Assembly Dto
        {
            get
            {
                return Assembly.Load("Architecture.Dto");
            }
        }

        public static Assembly Domain
        {
            get
            {
                return Assembly.Load("Architecture.Core");
            }
        }
    }
}

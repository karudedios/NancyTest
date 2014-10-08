using System.Collections.Generic;
using System.Linq;
using NancyTest.DAL.Models;

namespace NancyTest.DAL.Extensions
{
    public static class ModelExtensions
    {
        public static IEnumerable<Model> Search(this IEnumerable<Model> self, string Term)
        {
            return Term == null
                ? self
                : self.Where(
                    x => x.Name.ToLower().Contains(Term.ToLower())
                         || Term.ToLower().Contains(x.Name.ToLower())
                         || x.LastName.ToLower().Contains(Term.ToLower())
                         || Term.ToLower().Contains(x.LastName.ToLower())
                         || x.Cedula.ToLower().Contains(Term.ToLower())
                         || Term.ToLower().Contains(x.Cedula.ToLower())
                    );
        }
    }
}
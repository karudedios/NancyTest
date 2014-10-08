using System.Collections.Generic;
using NancyTest.DAL.Models;

namespace NancyTest.DAL.Implementation.Abstract
{
    public interface IProvider
    {
        IEnumerable<Model> Search(string term);
        Model getByCedula(string Cedula);
        IEnumerable<Model> GetAll();
        Model Add(Model data);
    }
}

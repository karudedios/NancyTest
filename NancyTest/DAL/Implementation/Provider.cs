using System;
using System.Collections.Generic;
using System.Linq;
using Nancy.Routing.Trie.Nodes;
using NancyTest.DAL.Extensions;
using NancyTest.DAL.Implementation.Abstract;

namespace NancyTest.DAL.Implementation
{
    public class Constants
    {
        public static List<Models.Model> MockDataz = new List<Models.Model>() {
                new Models.Model() { Cedula = "402-00647146-5", LastName = "De Dios", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , 
        };
    }

    public class Provider : IProvider
    {
        public IEnumerable<Models.Model> Search(string term)
        {
            return Constants.MockDataz.Search(term);
        }

        public Models.Model getByCedula(string cedula)
        {
            return Constants.MockDataz.FirstOrDefault(x => x.Cedula == cedula);
        }

        public IEnumerable<Models.Model> GetAll()
        {
            return Constants.MockDataz;
        }

        public Models.Model Add(Models.Model data)
        {
            if (Constants.MockDataz.Any(x => x.Cedula == data.Cedula))
                return null;

            Constants.MockDataz.Add(data);
            return data;
        }
    }
}
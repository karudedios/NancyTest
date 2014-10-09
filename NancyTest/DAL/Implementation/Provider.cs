using System;
using System.Collections.Generic;
using System.Linq;
using NancyTest.DAL.Implementation.Abstract;

namespace NancyTest.DAL.Implementation
{
    public class Constants
    {
        public static List<Models.Model> mockDataz = new List<Models.Model>() {
                new Models.Model() { Cedula = "402-00647146-5", LastName = "De Dios", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
            , new Models.Model() { Cedula = "402-00647146-2", LastName = "Something", Name = "Carlos" }
            , new Models.Model() { Cedula = "402-00647146-1", LastName = "Whatever", Name = "Something" }
            , new Models.Model() { Cedula = "402-00647146-3", LastName = "Yeah", Name = "And Stuff" }
            , new Models.Model() { Cedula = "402-00647146-4", LastName = "Igneel", Name = "Dragneel" }
        };
    }

    public class Provider : IProvider
    {
        public IEnumerable<Models.Model> Search(string term)
        {
            throw new NotImplementedException();
        }

        public Models.Model getByCedula(string Cedula)
        {
            return Constants.mockDataz.FirstOrDefault(x => x.Cedula == Cedula);
        }

        public IEnumerable<Models.Model> GetAll()
        {
            return Constants.mockDataz;
        }

        public Models.Model Add(Models.Model data)
        {
            if (Constants.mockDataz.Select(x => x.Cedula).Contains(data.Cedula))
                return null;

            Constants.mockDataz.Add(data);
            return data;
        }
    }
}
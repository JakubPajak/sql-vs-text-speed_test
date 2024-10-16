using Bogus;
using PDB_SpeedTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTest.Services
{
    internal class GenerateDummyDataService
    {
        public GenerateDummyDataService()
        {
        }
        public List<BasicDataDto> GenerateDummyData(int amount)
        {
            var faker = new Faker<BasicDataDto>()
                .RuleFor(o => o.Id, f => f.IndexFaker)
                .RuleFor(o => o.Name, f => f.Person.FirstName)
                .RuleFor(o => o.Surname, f => f.Person.LastName)
                .RuleFor(o => o.Phone, f => f.Person.Phone);

            List<BasicDataDto> dummyCollection = faker.Generate(amount);

            return dummyCollection;
        }
    }
}

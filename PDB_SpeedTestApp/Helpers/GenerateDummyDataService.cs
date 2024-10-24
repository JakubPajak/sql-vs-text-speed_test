﻿using Bogus;
using PDB_SpeedTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Helpers
{
    internal class GenerateDummyDataService
    {
        public GenerateDummyDataService()
        {
        }
        public List<BasicDataDto> GenerateDummyData(int amount)
        {
            var faker = new Faker<BasicDataDto>()
                .RuleFor(o => o.Name, f => f.Person.FirstName)
                .RuleFor(o => o.Surname, f => f.Person.LastName)
                .RuleFor(o => o.DateOfBirth, f => f.Person.DateOfBirth)
                .RuleFor(o => o.Phone, f => f.Person.Phone);

            List<BasicDataDto> dummyCollection = faker.Generate(amount);

            return dummyCollection;
        }
    }
}

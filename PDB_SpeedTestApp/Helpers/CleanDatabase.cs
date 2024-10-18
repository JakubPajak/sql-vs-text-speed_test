using PDB_SpeedTest.Models;
using PDB_SpeedTestApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Helpers
{
    internal class CleanDatabase
    {
        private AppDbContext _dbContext;
        
        public CleanDatabase(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public bool CleanTheDatabase()
        {

            try
            {
                var basicDataDtos = _dbContext.basicDataDtos.ToList();

                if (basicDataDtos.Any())
                {
                    _dbContext.basicDataDtos.RemoveRange(basicDataDtos);
                }

                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;
            }
        }
    }
}

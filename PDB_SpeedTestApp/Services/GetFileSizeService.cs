using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Services
{
    internal class GetFileSizeService
    {
        public GetFileSizeService()
        {
        }

        public List<double> GetFileSize()
        {
            List<double> filesSize = new List<double>();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "PDB");

            DirectoryInfo di = new DirectoryInfo(folderPath);
            FileInfo di_db = new FileInfo(
                "C:\\Program Files\\Microsoft SQL Server\\MSSQL16.MSSQLSERVER\\MSSQL\\DATA\\pdb_database.mdf");
                //"C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\PDB.mdf");
                 

            foreach (var item in di.GetFiles())
            {
                filesSize.Add(item.Length);
            }

            filesSize.Add(di_db.Length);

            return filesSize;
        }
    }
}

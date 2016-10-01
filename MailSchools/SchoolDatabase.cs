using LinqToExcel;

namespace MailSchools
{
    public class SchoolDatabase
    {
        ExcelQueryFactory database;
        public SchoolDatabase()
        {
            database = new ExcelQueryFactory(@"File.xlsx");
            database.DatabaseEngine = LinqToExcel.Domain.DatabaseEngine.Ace;
        }
        public void GetSchoolsByCity(string city)
        {

        }
    }
}

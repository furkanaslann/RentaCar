using RentaCarKDS.Models;
using System.Linq;

namespace RentaCarKDS.Data
{
    public class TableCategoryRepository
    {
        private static List<TableCategory> _tbcategories = null;

        static TableCategoryRepository() 
        {
            _tbcategories = new List<TableCategory>
            {
                //Veri tabanındaki kayıtlar
                new TableCategory {Id=1, Name="Id", Description = "empty"},
                new TableCategory {Id=2, Name="StartDate", Description = "empty"},
                new TableCategory {Id=3, Name="FinishDate", Description = "empty"},
                new TableCategory {Id=4, Name="ChassisNo", Description = "empty"},
                new TableCategory {Id=5, Name="Plate", Description = "empty"},
                new TableCategory {Id=6, Name="Type", Description = "empty"},
                new TableCategory {Id=7, Name="Price", Description = "empty"},
                new TableCategory {Id=8, Name="City", Description = "empty"},
                new TableCategory {Id=9, Name="Brand", Description = "empty"},
                new TableCategory {Id=10, Name="Model", Description = "empty"},
            };
        }
        public static List<TableCategory> TableCategories 
        {
            get { return _tbcategories; } 
        }
        public static void AddTableCategory(TableCategory category) 
        { 
            _tbcategories.Add(category);
        }
        public static TableCategory GetCategoryById(int id) 
        {  
            return _tbcategories.FirstOrDefault(tbc => tbc.Id == id); 
        }
    }
}

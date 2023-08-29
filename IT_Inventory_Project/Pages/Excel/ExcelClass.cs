using IT_Inventory_Project.Data;
using Microsoft.JSInterop;

namespace IT_Inventory_Project.Pages.Excel
{
    public class ExcelClass
    {
        public async Task GenerateExcelAsync(IJSRuntime js,
                                             Device_GetAll[] getAllVar,
                                             string filename = "export.xlsx")
        {
            var getAll = new GetAllXLS();
            
        }
    }
}

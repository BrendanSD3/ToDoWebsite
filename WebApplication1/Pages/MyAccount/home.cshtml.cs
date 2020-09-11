using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace ToDoWebsite.Pages
{
    public class homeModel : PageModel
    {
        [ViewData]
        public string Message { get; set; } = "Hello World";

        public void OnGet()
        {
            Message = "change";

        }
        //public void OnPost()
        //{
        //    Message = "Post worked";
            
        //}

        //change to the dev branch for testing
        //merged
        public void OnPostView()
        {
            string name = Request.Form["FName"+1];
            string occupation = Request.Form["Occup"+1];
            string wsName = Request.Form["wsName"];
            int add1 = Convert.ToInt32(Request.Form["add1"]);

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Sample Sheet");
            worksheet.Cell("A1").Value = "First Name";
            worksheet.Cell("B1").Value = "Occupation";
            var col1 = worksheet.Column("A");
            col1.Width = 20;
            col1.Style.Font.FontSize = 15;

            var col2 = worksheet.Column("B");
            col2.Width = 20;
            col2.Style.Font.FontSize = 15;
            //
            worksheet.Cell("A2").Value = name;
            worksheet.Cell("B2").Value = occupation;
            int count = 2;
           // worksheet.Cell(1).Style.Font.Bold = true;
            for (var i = 2; i < add1+1; i++)
            {
                count++;
                
                name= Request.Form["FName" + i];
                occupation = Request.Form["Occup" + i];
                worksheet.Cells("A" + count).Value = name;
                worksheet.Cells("B" + count).Value = occupation;
            }
            worksheet.Row(1).Style.Font.Bold = true;
            worksheet.Row(1).Style.Fill.BackgroundColor = XLColor.AirForceBlue;
            //var co = 1;
            //var ro = 0;
           
           
            workbook.SaveAs(wsName+".xlsx");
           // Redirect("/MyAccount/success");
            Message = "Thanks for submitting, "+ name;

        }

    }
}

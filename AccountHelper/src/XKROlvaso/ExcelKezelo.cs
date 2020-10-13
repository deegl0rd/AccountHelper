using Microsoft.Office.Interop.Excel;
using System;

namespace AccountHelper.src.XKROlvaso
{
    class ExcelKezelo
    {
        readonly Application excelApp;
        readonly Workbook excelFile;
        readonly Worksheet excelSheet;
        readonly System.IO.FileInfo info;

        public ExcelKezelo(string hely, string fajlNev)
        {

            info = new System.IO.FileInfo(hely + "\\" + fajlNev + ".xlsx");

            excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelFile = excelApp.Workbooks.Add();
            excelSheet = excelApp.ActiveSheet;

            excelSheet.Range["A1"].ColumnWidth = 26;
            excelSheet.Range["B1"].ColumnWidth = 11;
            excelSheet.Range["C1"].ColumnWidth = 11;
            excelSheet.Range["D1"].ColumnWidth = 7;
            excelSheet.Range["E1"].ColumnWidth = 14;
            excelSheet.Range["F1"].ColumnWidth = 12;
            excelSheet.Range["G1"].ColumnWidth = 8;

            excelSheet.Range["A1"].Value = "Név";
            excelSheet.Range["B1"].Value = "Mikortól";
            excelSheet.Range["C1"].Value = "Meddig";
            excelSheet.Range["D1"].Value = "Napok";
            excelSheet.Range["E1"].Value = "Adószám";
            excelSheet.Range["F1"].Value = "TAJ-szám";
            excelSheet.Range["G1"].Value = "Típus";
        }

        public void CellaIr(string cella, string ertek)
        {
            excelSheet.Range[cella].Value = ertek;
        }

        public void ExcelBezar()
        {
            try
            {
                excelFile.SaveAs(info.ToString());
                excelFile.Close(true);
                excelApp.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
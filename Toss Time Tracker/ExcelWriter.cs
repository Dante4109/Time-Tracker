using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Toss_Time_Tracker
{
    //test
    class ExcelWriter
    {

        //Static variables only used in ExcelWriterClass 
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;



        public void InitializeExcel(Excel_Data excel_data)
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(excel_data.excelTemplatePath + excel_data.excelTemplateName);
            MySheet = (Excel.Worksheet)MyBook.Sheets[excel_data.currentSheet];
            
        }




        public void Write_Name_DateToExcel(Excel_Data excel_data)
        {
            MySheet.Cells[2, 2] = excel_data.currentUser;
            MySheet.Cells[2, 4] = excel_data.currentDate;
        }

        public void WriteTimeToExcel(Excel_Data excel_data)
        {

            {
                try
                {
                    
                    MySheet.Cells[excel_data.currentRow, excel_data.currentColumn] = excel_data.elapsedTime;
                }
                catch (Exception)
                { }


                //MyBook.Close();
                //MyApp.Quit();
            }




        }



        public static void checkExcelPath(Excel_Data excel_data)
        
            {
                if (!File.Exists(excel_data.logFilePath + excel_data.currentUser + @"\" + excel_data.currentUser + "-" + excel_data.currentDate + @"\" + excel_data.timeSheetName + @"\" + excel_data.timeSheetName + "-" + excel_data.currentUser + "-" + excel_data.currentDate + ".xlsx"))
                {

                    //Create folder if it does not exist
                    System.IO.Directory.CreateDirectory(excel_data.logFilePath + excel_data.currentUser + @"\" + excel_data.currentUser + "-" + excel_data.currentDate + @"\" + excel_data.timeSheetName + @"\");
                }
            }
        


        public static void SaveExcelFile(Excel_Data excel_data)
        {
            MyApp.DisplayAlerts = false;
            MyBook.SaveAs(excel_data.logFilePath + excel_data.currentUser + @"\" + excel_data.currentUser + "-" + excel_data.currentDate + @"\" + excel_data.timeSheetName + @"\" + excel_data.timeSheetName + "-" + excel_data.currentUser + "-" + excel_data.currentDate + ".xlsx");
        }

        public static void CloseExcel()
        {
            MyApp.Quit();
            Marshal.ReleaseComObject(MySheet);
            Marshal.ReleaseComObject(MyBook);
            Marshal.ReleaseComObject(MyApp);
            MyApp = null;
        }

    }
}

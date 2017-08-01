using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.Windows.Forms;

namespace Toss_Time_Tracker
{
    class ExcelWriter
    {
        /*
        public variables
        variables pulled from the UI 
        */
        public string currentType { get; set; }
        public string elapsedTime { get; set; }
        public int currentSheet { get; set; }
        public string templatePath { get; set; }
        //public static BindingList<DCU_data> DCUDataList = new BindingList<DCU_data>();
        //public static BindingList<NET_data> NETDataList = new BindingList<NET_data>();

        /*
        public variables
        variables pulled from the UI 
        */
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;
        private static int lastRow = 0;




        public void WriteTimeToExcel()
        {

        }

    }

    
}

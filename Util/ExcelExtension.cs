using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WeightProgram.Util {
    public static class ExcelExtension {
        public static void GetDataFrom(this Excel.Worksheet sheet, DataGridView dgv) {
            // Add (bold) column headers
            for(int i = 0; i < dgv.Columns.Count; i++) {
                sheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                Excel.Range headerRange = sheet.Cells[1, i + 1];
                headerRange.Font.Bold = true;
            }
            // Add rows
            for(int i = 0; i < dgv.Rows.Count; i++) {
                for(int j = 0; j < dgv.Columns.Count; j++) {
                    sheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].FormattedValue.ToString();
                }
            }
            // Autofit columns
            Excel.Range usedRange = sheet.UsedRange;
            usedRange.Columns.AutoFit();
        }
    }
}

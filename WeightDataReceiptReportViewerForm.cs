using BarcodeStandard;
using Microsoft.Reporting.WinForms;
using SkiaSharp;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using WeightProgram.Data;
using WeightProgram.Util;

namespace WeightProgram {
    public partial class WeightDataReceiptReportViewerForm : Form {
        private Receipt m_Receipt;
        public WeightDataReceiptReportViewerForm(Receipt receipt) {
            InitializeComponent();
            m_Receipt = receipt;
        }

        private void WeightDataReceiptReportViewerForm_Load(object sender, EventArgs e) {
            // Setup default page settings
            var pageSettings = new PageSettings();
            pageSettings.Margins = new Margins(0, 0, 0, 0);
            var printerSettings = new PrinterSettings();
            if(printerSettings.TryGetPaperSize(PaperKind.A4, out PaperSize paperSize)) {
                pageSettings.PaperSize = paperSize;
            }
            reportViewer.SetPageSettings(pageSettings);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);

            // Clean up old data first
            reportViewer.LocalReport.DataSources.Clear();
            // Setup barcode & generate equivalent image in png
            var b = new Barcode();
            b.BarWidth = 3;
            b.IncludeLabel = true;
            b.ImageFormat = SKEncodedImageFormat.Png;
            // Current settings produce 336x120 (2.6:1) image
            SKImage img = b.Encode(BarcodeStandard.Type.Code128, m_Receipt.GetReceiptCodeShort, 0, 120);
            //using(var stream = new FileStream("BarcodeSample.png", FileMode.Create, FileAccess.Write)) {
            //    img.Encode().SaveTo(stream);
            //}

            string barcodeImgPara = "";
            using(var imgData = img.Encode()) {
                byte[] byteArray = imgData.AsSpan().ToArray();
                barcodeImgPara = Convert.ToBase64String(byteArray);
            }
            ReportParameter[] parameters = new ReportParameter[] {
                new ReportParameter("BarcodeImage", barcodeImgPara)
            };
            reportViewer.LocalReport.SetParameters(parameters);
            var dataSrc = new ReportDataSource("WeightDataDataSet", new WeightData[] { m_Receipt.WeightData });
            reportViewer.LocalReport.DataSources.Add(dataSrc);

            reportViewer.RefreshReport();
        }
    }
}

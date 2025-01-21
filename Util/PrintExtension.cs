using System.Drawing.Printing;

namespace WeightProgram.Util {
    public static class PrintExtension {
        public static bool TryGetPaperSize(this PrinterSettings printerSettings, PaperKind paperKind, out PaperSize paperSize) {
            paperSize = null;
            PrinterSettings settings = new PrinterSettings();
            foreach(PaperSize size in settings.PaperSizes) {
                if(size.Kind == paperKind) {
                    paperSize = size;
                    return true;
                }
            }
            return false;
        }
    }
}
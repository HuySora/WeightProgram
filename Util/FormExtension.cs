using System;
using System.Windows.Forms;

namespace WeightProgram.Util {
    public static class FormExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool TryParseString(this TextBox textBox, out string value) {
            value = string.Empty;
            if(string.IsNullOrWhiteSpace(textBox.Text)) {
                return false;
            }
            value = textBox.Text;
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool TryParseInt(this TextBox textBox, out int value) {
            value = 0; // Default value
            if(string.IsNullOrWhiteSpace(textBox.Text)) {
                return false;
            }
            string inputTxt = textBox.Text.Replace(",", "").Trim();
            if(!int.TryParse(inputTxt, out value)) {
                return false;
            }
            return true;
        }
    }
}

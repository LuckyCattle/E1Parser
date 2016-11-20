using System;
using System.Windows.Forms;

namespace E1Parser {
    static class General {
        [STAThread]
        static void Main() {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            } catch (Exception exception) {
                //FIXME: make as a dialog window
                string errorText = exception.Message;
                Console.WriteLine(errorText);
            }
        }
    }
}

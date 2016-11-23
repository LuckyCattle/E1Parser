using System;
using System.Windows.Forms;

namespace E1Parser {
    static class Program {
        [STAThread]
        static void Main() {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new StartForm());
            } catch (Exception exception) {
                string errorText = exception.Message;
                MessageBox.Show(errorText);
            }
        }
    }
}

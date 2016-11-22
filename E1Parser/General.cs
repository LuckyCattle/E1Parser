using System;
using System.Windows.Forms;

namespace E1Parser {
    static class General {
        [STAThread]
        static void Main() {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainWindow mainWindow = new MainWindow();
                Model e1EventsModel = new ModelModule();
                View e1EventsView = new ViewModule(mainWindow);
                e1EventsModel.RegisterObserver(e1EventsView);
                e1EventsModel.RefreshContent();

                Application.Run(mainWindow);
            } catch (Exception exception) {
                string errorText = exception.Message;
                MessageBox.Show(errorText);
            }
        }
    }
}

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace E1Parser {
    public partial class StartForm : Form {
        private Controller controller;
        private System.Threading.Timer timer;
        private int tickTackerValue;

        public StartForm() {
            InitializeComponent();
            CompleteInitialization();
        }

        private void CompleteInitialization() {
        }

        private void StartForm_Shown(object sender, EventArgs e) {
            AdjustComponentSettings();

            RunProgressMover();

            Initializer.BuildApplication();
            controller = Initializer.GetController();
            RunMvcStarter();
        }

        private void AdjustComponentSettings() {
            DesktopLocation = new Point(450, 250);
        }

        private void RunProgressMover() {
            tickTackerValue = 0;
            tickTacker.WorkerReportsProgress = true;
            tickTacker.DoWork += TickTack;
            tickTacker.ProgressChanged += TickTackerProgressReport;
            tickTacker.RunWorkerAsync();
        }

        private void TickTack(object sender, System.ComponentModel.DoWorkEventArgs e) {
            timer = new System.Threading.Timer(Tick, null, 0, 1000);
            Thread.Sleep(30000);
            TerminateTickTacker();
        }

        private void Tick(object unusable) {
            const int allWork = 100;
            int undone = allWork - tickTackerValue;
            int step = undone / 8;
            tickTackerValue += step;
            tickTacker.ReportProgress(tickTackerValue);
        }

        private void TickTackerProgressReport(object sender, System.ComponentModel.ProgressChangedEventArgs progressReport) {
            progressBar.Value = progressReport.ProgressPercentage;
        }

        private void RunMvcStarter() {
            mvcStarter.WorkerReportsProgress = true;
            mvcStarter.DoWork += MvcStart;
            mvcStarter.ProgressChanged += MvcProgressReport;
            mvcStarter.RunWorkerAsync();
        }

        private void MvcStart(object sender, System.ComponentModel.DoWorkEventArgs e) {
            controller.StartWork();
            const int workComplete = 100;
            mvcStarter.ReportProgress(workComplete);
        }

        private void MvcProgressReport(object sender, System.ComponentModel.ProgressChangedEventArgs e) {
            TerminateTickTacker();
            this.Hide();
            mvcStarter.CancelAsync();
            mvcStarter.Dispose();
            controller.Activate();
        }

        private void TerminateTickTacker() {
            timer.Dispose();
            tickTacker.CancelAsync();
            tickTacker.Dispose();
        }

        private void terminateButton_MouseUp(object sender, MouseEventArgs e) {
            Application.Exit();
        }
    }
}

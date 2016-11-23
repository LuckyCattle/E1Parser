using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace E1Parser {
    public partial class BaseForm : Form {
        private ViewModuleCache cache;

        public BaseForm() {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, System.EventArgs e) {
            AdjustComponentSettings();
        }

        private void AdjustComponentSettings() {
            eventsList.RowHeadersVisible = false;
            DesktopLocation = new Point(250, 100);
        }

        public void bindWithViewModuleCache(ViewModuleCache cache) {
            this.cache = cache;
        }

        private void browserButton_MouseUp(object sender, MouseEventArgs e) {
            Process.Start("http://www.e1.ru/afisha/events/art");
        }

        private void eventsList_CellMouseUp(object unusable, DataGridViewCellMouseEventArgs userAction) {
            int chosenRow = userAction.RowIndex;
            bool clickedOnHeader = (chosenRow < 0);
            if (clickedOnHeader) {
                return;
            }
            DisplayAdressFor(chosenRow);
        }

        public void DisplayEvents(List<Event> events) {
            foreach (Event eachEvent in events) {
                eventsList.Rows.Add(eachEvent.Number, eachEvent.Date, eachEvent.Place, eachEvent.Name);
            }
            const int firstRowIndex = 0;
            DisplayAdressFor(firstRowIndex);
        }

        private void DisplayAdressFor(int rowIndex) {
            DataGridViewRow requiredRow = eventsList.Rows.SharedRow(rowIndex);
            const int indexOfIdColumn = 0;
            DataGridViewCell requiredIdCell = requiredRow.Cells[indexOfIdColumn];
            int requiredEventId = (int)requiredIdCell.Value;
            int requiredEventIndex = requiredEventId - 1;
            string address = cache.GetEventAddress(requiredEventIndex);

            addressField.Text = address;
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}

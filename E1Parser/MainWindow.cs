using System.Windows.Forms;
using System.Collections.Generic;

namespace E1Parser {
    public partial class MainWindow : Form {
        private ViewModuleCache cache;

        public MainWindow() {
            InitializeComponent();
            AdjustComponentSettings();
        }

        private void AdjustComponentSettings() {
            eventsList.RowHeadersVisible = false;
        }

        public void bindWithViewModuleCache(ViewModuleCache cache) {
            this.cache = cache;
        }

        public void DisplayEvents(List<Event> events) {
            foreach (Event eachEvent in events) {
                eventsList.Rows.Add(eachEvent.Number, eachEvent.Date, eachEvent.Place, eachEvent.Name);
            }
            const int firstRowIndex = 0;
            DisplayAdressFor(firstRowIndex);
        }

        private void eventsList_CellMouseUp(object unusable, DataGridViewCellMouseEventArgs userAction) {
            DisplayAdressFor(userAction.RowIndex);
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
    }
}

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
                eventsList.Rows.Add(eachEvent.Id, eachEvent.Date, eachEvent.Place, eachEvent.Name);
            }
            const int firstRow = 0;
            DisplayAdressFor(firstRow);
        }

        public void eventsList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs userAction) {
            DisplayAdressFor(userAction.RowIndex);
        }

        private void DisplayAdressFor(int rowIndex) {
            const int indexOfIdColumn = 0;
            DataGridViewRow  requiredRow = eventsList.Rows.SharedRow(rowIndex);
            DataGridViewCell requiredIdCell = requiredRow.Cells[indexOfIdColumn];
            int requiredEventId = (int)requiredIdCell.Value;
            int requiredEventIndex = requiredEventId - 1;
            string address = cache.GetEventAddress(requiredEventIndex);

            addressField.Text = address;
        }
    }
}

using System.Collections.Generic;

namespace E1Parser.Tests {
    sealed class RefreshContentTestView : View {
        private bool isTestPassed;

        public RefreshContentTestView() {
            isTestPassed = false;
        }

        public bool IsTestPassed {
            get {
                return isTestPassed;
            }
        }

        public void Update(List<Event> events) {
            if (events == null) {
                return;
            }
            if (events.Count > 0) {
                isTestPassed = true;
            }
        }

        public void BecomeVisible() {
        }
    }
}
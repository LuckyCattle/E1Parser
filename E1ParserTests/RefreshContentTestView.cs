using System.Collections;

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

        public void Update(ArrayList events) {
            if (events == null) {
                return;
            }
            if (events.Count > 0) {
                isTestPassed = true;
            }
        }
    }
}
using System.Collections.Generic;

namespace E1Parser.Tests {
    public sealed class ActivateTestView : View {
        private bool isTestPassed;

        public ActivateTestView() {
            isTestPassed = false;
        }

        public bool IsTestPassed {
            get {
                return isTestPassed;
            }
        }

        public void Update(List<Event> events) {
        }

        public void BecomeVisible() {
            isTestPassed = true;
        }
    }
}
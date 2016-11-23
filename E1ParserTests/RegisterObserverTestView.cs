using System.Collections.Generic;

namespace E1Parser.Tests {
    sealed class RegisterObserverTestView : View {
        private bool isTestPassed;

        public RegisterObserverTestView() {
            isTestPassed = false;
        }

        public bool IsTestPassed {
            get {
                return isTestPassed;
            }
        }

        public void Update(List<Event> events) {
            isTestPassed = true;
        }

        public void BecomeVisible() {
        }
    }
}
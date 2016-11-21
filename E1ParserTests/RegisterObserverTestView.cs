using System.Collections;

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

        public void Update(ArrayList events) {
            isTestPassed = true;
        }
    }
}
namespace E1Parser.Tests {
    public sealed class ModelEmulator : Model {
        private bool isTestPassed;

        public ModelEmulator() {
            isTestPassed = false;
        }

        public void RefreshContent() {
            isTestPassed = true;
        }

        public void RegisterObserver(View unusable) {
        }

        public bool IsTestPassed {
            get {
                return isTestPassed;
            }
        }
    }
}
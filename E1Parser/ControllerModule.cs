namespace E1Parser {
    public sealed class ControllerModule : Controller {
        private Model model;

        public void StartWork() {
            model.RefreshContent();
        }

        public void BindWithModel(Model model) {
            this.model = model;
        }
    }
}
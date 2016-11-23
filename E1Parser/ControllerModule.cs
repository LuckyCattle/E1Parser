namespace E1Parser {
    public sealed class ControllerModule : Controller {
        private Model model;
        private View view;

        public void StartWork() {
            model.RefreshContent();
        }

        public void Activate() {
            view.BecomeVisible();
        }

        public void BindWithModel(Model model) {
            this.model = model;
        }

        public void BindWithView(View view) {
            this.view = view;
        }
    }
}
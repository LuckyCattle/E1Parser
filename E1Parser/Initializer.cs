namespace E1Parser {
    public sealed class Initializer {
        private static Model model;
        private static View  view;
        private static Controller controller;

        public static void BuildApplication() {
            model = new ModelModule();
            view  = new ViewModule();
            controller = new ControllerModule();
            model.RegisterObserver(view);
            controller.BindWithModel(model);
            controller.BindWithView(view);
        }

        public static Controller GetController() {
            return controller;
        }
    }
}

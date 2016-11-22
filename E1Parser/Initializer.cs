namespace E1Parser {
    public sealed class Initializer {
        private static Model e1EventsModel;
        private static View  e1EventsView;
        private static Controller e1EventsController;

        public static void BuildApplication(BaseForm mainWindow) {
            e1EventsModel = new ModelModule();
            e1EventsView  = new ViewModule(mainWindow);
            e1EventsController = new ControllerModule();
            e1EventsModel.RegisterObserver(e1EventsView);
            e1EventsController.BindWithModel(e1EventsModel);
        }

        public static void StartApplication() {
            e1EventsController.StartWork();
        }
    }
}

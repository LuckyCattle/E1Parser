using System.Collections.Generic;

namespace E1Parser {
    public sealed class ViewModule : View {
        private MainWindow mainWindow;
        private ViewModuleCache cache;

        public ViewModule(MainWindow window) {
            mainWindow = window;
            cache = new ViewModuleCache();
            mainWindow.bindWithViewModuleCache(cache);
        }

        public void Update(List<Event> freshEvents) {
            cache.Save(freshEvents);
            mainWindow.DisplayEvents(freshEvents);
        }
    }
}
using System.Collections.Generic;

namespace E1Parser {
    public sealed class ViewModule : View {
        private BaseForm mainWindow;
        private ViewModuleCache cache;

        public ViewModule(BaseForm mainWindow) {
            this.mainWindow = mainWindow;
            cache = new ViewModuleCache();
            mainWindow.bindWithViewModuleCache(cache);
        }

        public void Update(List<Event> freshEvents) {
            cache.Save(freshEvents);
            mainWindow.DisplayEvents(freshEvents);
        }
    }
}

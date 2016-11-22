using System.Collections.Generic;

namespace E1Parser {
    public sealed class ModelModule : Model {
        private WebPageLoader pageLoader;
        private Parser e1Parser;
        List<Event> e1Events;
        List<View> observers;

        public ModelModule() {
            pageLoader = new WebPageLoaderModule();
            e1Parser  = new ParserModule(pageLoader);
            observers = new List<View>();
        }

        public void RegisterObserver(View view) {
            observers.Add(view);
        }

        public void RefreshContent() {
            e1Events = e1Parser.ExtractEvents();
            notifyObservers();
        }

        private void notifyObservers() {
            foreach (View eachObserver in observers) {
                eachObserver.Update(e1Events);
            }
        }
    }
}
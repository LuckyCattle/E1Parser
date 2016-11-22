using System.Windows.Forms;
using System.Collections.Generic;

namespace E1Parser {
    public sealed class ViewModuleCache {
        private List<Event> cachedEvents;

        public void Save(List<Event> events) {
            cachedEvents = events;
        }

        public string GetEventAddress(int index) {
            Event requiredEvent = cachedEvents[index];
            string requiredAddress = requiredEvent.Address;
            return requiredAddress;
        }
    }
}

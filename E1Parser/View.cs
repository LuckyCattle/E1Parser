using System.Collections.Generic;

namespace E1Parser {
    public interface View {
        void Update(List<Event> events);
    }
}
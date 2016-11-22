using System.Collections.Generic;

namespace E1Parser {
    public interface Parser {
        List<Event> ExtractEvents();
    }
}
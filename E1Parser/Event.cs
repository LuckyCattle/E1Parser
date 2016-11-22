namespace E1Parser {
    public sealed class Event {
        private static int examplesQuantity = 0;
        private int id;
        private string name;
        private string date;
        private string place;
        private string address;

        public Event() {
            ++examplesQuantity;
            id = examplesQuantity;
        }

        public int Id {
            get {
                return id;
            }
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public string Date {
            get {
                return date;
            }
            set {
                date = value;
            }
        }

        public string Place {
            get {
                return place;
            }
            set {
                place = value;
            }
        }

        public string Address {
            get {
                return address;
            }
            set {
                address = value;
            }
        }
    }
}
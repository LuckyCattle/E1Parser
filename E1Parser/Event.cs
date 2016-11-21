namespace E1Parser {
    public sealed class Event {
        private string name;
        private string date;
        private string place;
        private string address;

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
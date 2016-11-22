namespace E1Parser {
    public sealed class Event {
        private int number;
        private string name;
        private string date;
        private string place;
        private string address;

        public int Number {
            get {
                return number;
            }
            set {
                number = value;
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace E1Parser.Tests {
    [TestClass()]
    public class ViewModuleTests {
        [TestMethod()]
        public void ViewModuleTest() {
            MainWindow window = new MainWindow();
            View viewExample  = new ViewModule(window);
            Assert.IsTrue(viewExample != null);
        }

        [TestMethod()]
        public void UpdateTest() {
            MainWindow window = new MainWindow();
            View viewExample = new ViewModule(window);
            List<Event> events = new List<Event>();
            Event event1 = new Event();
            event1.Name  = "test_event_1";
            event1.Date  = "22.11.2016";
            event1.Place = "cool_place";
            event1.Address = "somwhere_in_the_world";
            events.Add(event1);
            Event event2 = new Event();
            event2.Name = "test_event_2";
            event2.Date = "22.11.2016";
            event2.Place = "cool_place";
            event2.Address = "somwhere_in_the_world";
            events.Add(event2);

            viewExample.Update(events);
        }
    }
}
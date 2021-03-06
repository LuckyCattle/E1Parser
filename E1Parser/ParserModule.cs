﻿using System;
using System.Collections.Generic;

namespace E1Parser {
    public sealed class ParserModule : Parser {
        private WebPageLoader pageLoader;
        private const string placeMarker = "F4F4F4";
        private const string eventMarker = "big_orange";
        private string currentPlace = "[no data]";
        private string currentAddress = "[no data]";
        private int currentNumber;
        private Event currentEvent;

        public ParserModule(WebPageLoader loader) {
            pageLoader = loader;
        }

        public List<Event> ExtractEvents() {
            const string requiredURI = "http://www.e1.ru/afisha/events/art";
            string  pageCode = pageLoader.GetPageCode(requiredURI);
            List<Event> events = Parse(pageCode);
            return events;
        }

        private List<Event> Parse(string pageCode) {
            List<Event> events = new List<Event>();
            currentEvent = new Event();
            currentNumber = 0;

            while ( AreRawItemsLeft(pageCode) ) {
                bool nextItemIsPlace = DefineNextItemKind(pageCode);
                if (nextItemIsPlace) {
                    pageCode = CutLeadingForPlace(pageCode);
                    ExtractPlaceData(pageCode);
                } else {
                    pageCode = CutLeadingForEvent(pageCode);
                    ExtractEventData(pageCode);
                    events.Add(currentEvent);
                    currentEvent = new Event();
                }
            }
            return events;
        }

        private bool AreRawItemsLeft(string pageCode) {
            int eventIndex = pageCode.IndexOf(eventMarker);
            bool rawEventsLeft = (eventIndex != -1);
            return rawEventsLeft;
        }

        /** Returns true if kind of next item is "place", otherwise returns false */
        private bool DefineNextItemKind(string pageCode) {
            int placeIndex = pageCode.IndexOf(placeMarker);
            int eventIndex = pageCode.IndexOf(eventMarker);
            bool rawPlacesLeft = (placeIndex != -1);
            bool nextItemIsPlace = ( (placeIndex < eventIndex) && rawPlacesLeft );
            return nextItemIsPlace;
        }

        private string CutLeadingForPlace(string pageCode) {
            int placeOffset = placeMarker.Length + 5;

            int placeIndex = pageCode.IndexOf(placeMarker);
            pageCode = pageCode.Substring(placeIndex + placeOffset);
            return pageCode;
        }

        private void ExtractPlaceData(string pageCode) {
            string[] separators = { "</b>", @"<span class=""small"">", "<nobr>", "<br>" };
            string[] tokens = pageCode.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            currentPlace = tokens[0];
            currentPlace = CleanToken(currentPlace);
            currentAddress = tokens[2];
            currentAddress = CleanToken(currentAddress);
        }

        private string CutLeadingForEvent(string pageCode) {
            int eventOffset = eventMarker.Length + 2;

            // searching for second event marker appearing.
            // first appearing:
            int eventIndex = pageCode.IndexOf(eventMarker);
            pageCode = pageCode.Substring(eventIndex + eventOffset);
            // second appearing:
            eventIndex = pageCode.IndexOf(eventMarker);
            pageCode = pageCode.Substring(eventIndex + eventOffset);
            return pageCode;
        }

        private void ExtractEventData(string pageCode) {
            string[] separators = { "</b>", "<b>" };
            string[] tokens = pageCode.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string currentName = tokens[0];
            string currentDate = tokens[2];
            currentName = CleanToken(currentName);
            currentDate = CleanToken(currentDate);
            ++currentNumber;
            currentEvent.Number = currentNumber;
            currentEvent.Name = currentName;
            currentEvent.Date = currentDate;
            currentEvent.Place = currentPlace;
            currentEvent.Address = currentAddress;
        }

        private string CleanToken(string token) {
            char[] crap = { ',' };
            token = token.Trim();
            token = token.Trim(crap);
            token = ReplaceSpecialSymbols(token);
            return token;
        }

        private string ReplaceSpecialSymbols(string token) {
            token = token.Replace("&laquo;", @"""");
            token = token.Replace("&raquo;", @"""");
            token = token.Replace("&hellip;", "...");
            token = token.Replace("&ndash;", "-");
            token = token.Replace("&mdash;", "-");
            return token;
        }
    }
}

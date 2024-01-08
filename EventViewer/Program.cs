//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Eventing.Reader;

//public class EventLog_Reader
//{
//    static void Main(string[] args) 
//    {
//        GetApplicationEvents();
//    }

//    static List<string> GetApplicationEvents()
//    {
//        List<string> eventList = new List<string>();

//        try
//        {
//            string query = $"<QueryList><Query Id='0' Path='Application'><Select Path='Application'>*</Select></Query></QueryList>";
//            EventLogQuery eventLogQuery = new EventLogQuery("Application", PathType.LogName, query);
//            EventLogReader eventLogReader = new EventLogReader(eventLogQuery);

//            for (EventRecord eventInstance = eventLogReader.ReadEvent(); eventInstance != null; eventInstance = eventLogReader.ReadEvent())
//            {
//                string eventDetails = $"Event ID: {eventInstance.Id}\n" +
//                                      $"Provider Name: {eventInstance.ProviderName}\n" +
//                                      $"Time Created: {eventInstance.TimeCreated}\n" +
//                                      $"Message: {eventInstance.FormatDescription()}\n" +
//                                      "------------------------------------\n";
//                eventList.Add(eventDetails);
                
//            }
//        }
//        catch (Exception ex)
//        {
//            eventList.Add($"Error reading events: {ex.Message}");
//        }

//        return eventList;

//        //9.08.2022 23:38:55
//        //"Error reading events: The specified resource type cannot be found in the image file"
//    }
//}
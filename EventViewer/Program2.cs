using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Threading;

public class ApplicationEvent
{
    public int EventID { get; set; }
    public string LevelDisplayName { get; set; }
    public DateTime? DateAndTime { get; set; }
    public string Source { get; set; }
    public string TaskDisplayName { get; set; }
    public byte? Level { get; set; }
    public int? Task { get; set; }
    public string Message { get; set; }
    public short? Opcode { get; set; }
    public long? Keywords { get; set; }
    public long? RecordId { get; set; }
    public byte? Version { get; set; }
    public Guid? ProviderId { get; set; }
    public string LogName { get; set; }
    public int? ProcessId { get; set; }
    public int? ThreadId { get; set; }
    public string MachineName { get; set; }
    public SecurityIdentifier UserId { get; set; }
    public Guid? ActivityId { get; set; }
    public Guid? RelatedActivityId { get; set; }
    public int? Qualifiers { get; set; }
    public string OpcodeDisplayName { get; set; }
    public IEnumerable<string> KeywordsDisplayNames { get; set; }
    public EventBookmark Bookmark { get; set; }
    public IList<EventProperty> Properties { get; set; }
}
public class EventlogReader
{
    static void Main(string[] args)
    {
        EventlogReader EventlogReader = new EventlogReader();
    }

    EventlogReader()
    {
        DateTime date1 = new DateTime(2024, 12, 13, 20, 29, 55);
        DateTime date2 = new DateTime(2020, 12, 2, 20, 30, 00);

        GetApplicationEvents(date1, date2);
    }
    public List<ApplicationEvent> GetApplicationEvents(DateTime date1, DateTime date2)
    {
        List<string> errors = new List<string>();
        int count = 0;
        int countCatch = 0;
        List<ApplicationEvent> eventList = new List<ApplicationEvent>();

        string query = $"<QueryList><Query Id='0' Path='Application'><Select Path='Application'>*</Select></Query></QueryList>";
        EventLogQuery eventLogQuery = new EventLogQuery("Application", PathType.LogName, query);
        EventLogReader EventlogReader = new EventLogReader(eventLogQuery);

        for (EventRecord eventInstance = EventlogReader.ReadEvent(); eventInstance != null; eventInstance = EventlogReader.ReadEvent())
        {
            DateTime d = eventInstance.TimeCreated.Value;
            DateTime eventDate = new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
            count++;
            if (count == 95)
            {

            }
            try
            {
                if (eventDate >= date1 && eventDate <= date2 || eventDate <= date1 && eventDate >= date2)
                {
                    ApplicationEvent appEvent = new ApplicationEvent
                    {
                        EventID = eventInstance.Id,
                        LevelDisplayName = eventInstance.LevelDisplayName ?? string.Empty,
                        DateAndTime = eventInstance.TimeCreated ?? DateTime.MinValue,
                        Source = eventInstance.ProviderName,
                        TaskDisplayName = eventInstance.TaskDisplayName ?? string.Empty,
                        Level = eventInstance.Level,
                        Task = eventInstance.Task,
                        Message = eventInstance.FormatDescription() ?? string.Empty,
                        Opcode = eventInstance.Opcode,
                        Keywords = eventInstance.Keywords,
                        RecordId = eventInstance.RecordId,
                        Version = eventInstance.Version,
                        ProviderId = eventInstance.ProviderId,
                        LogName = eventInstance.LogName,
                        ProcessId = eventInstance.ProcessId,
                        ThreadId = eventInstance.ThreadId,
                        MachineName = eventInstance.MachineName,
                        UserId = eventInstance.UserId,
                        ActivityId = eventInstance.ActivityId,
                        RelatedActivityId = eventInstance.RelatedActivityId,
                        Qualifiers = eventInstance.Qualifiers,
                        OpcodeDisplayName = eventInstance.OpcodeDisplayName,
                        KeywordsDisplayNames = eventInstance.KeywordsDisplayNames,
                        Bookmark = eventInstance.Bookmark,
                        Properties = eventInstance.Properties
                    };

                    eventList.Add(appEvent);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error reading events: {ex.Message}");
                if (!errors.Contains(eventInstance.ProviderName)) 
                {
                    errors.Add(eventInstance.ProviderName);
                    Console.WriteLine(eventInstance.ProviderName);
                }
                //Console.WriteLine(eventInstance.ProviderName);
                countCatch++;
            }
        }
        Console.WriteLine(countCatch);
        return eventList;
    }
}
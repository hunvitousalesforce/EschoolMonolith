using System.Collections;

namespace Domain;

public class Schedule
{
    public Guid Id {get; set;}
    public List<ScheduleItem> ScheduleItems {get; set;} = [];
}


public class ScheduleItem
{
    public DayOfWeek DayOfWeek {get; set;}
    public TimeSlot TimeSlot {get; set;}
    public Subject Subject {get; set;}
}



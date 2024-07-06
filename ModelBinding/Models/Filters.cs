﻿public class Filters
{
    public Filters(string filterString)
    {
        FilterString = filterString ?? "all-all-all";
        string[] filters = FilterString.Split('-');


        if (filters.Length >= 3)
        {
            CategoryId = filters[0];
            Due = filters[1];
            StatusId = filters[2];
        }
        else
        {
            CategoryId = "all";
            Due = "all";
            StatusId = "all";
        }
    }

    public string FilterString { get; }
    public string CategoryId { get; }
    public string Due { get; }
    public string StatusId { get; }

    public bool HasCategory => CategoryId.ToLower() != "all";
    public bool HasDue => Due.ToLower() != "all";
    public bool HasStatus => StatusId.ToLower() != "all";

    public static Dictionary<string, string> DueFilterValues =>
        new Dictionary<string, string>
        {
            { "future", "Future" },
            { "past", "Past" },
            { "today", "Today" }
        };

    public bool IsPast => Due.ToLower() == "past";
    public bool IsFuture => Due.ToLower() == "future";
    public bool IsToday => Due.ToLower() == "today";
}
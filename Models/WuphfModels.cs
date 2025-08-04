using WUPHFApp.Services;

namespace WUPHFApp.Models;

public class WuphfMessage
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Content { get; set; } = "";
    public string Sender { get; set; } = "";
    public List<string> Recipients { get; set; } = new();
    public List<WuphfChannel> Channels { get; set; } = new();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public WuphfStatus Status { get; set; } = WuphfStatus.Draft;
    public int Reach { get; set; } // Number of people reached
    public bool IsPrinted { get; set; }
}

public enum WuphfStatus
{
    Draft,
    Sending,
    Sent,
    Failed,
    PartiallyFailed
}

public class WuphfContact
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string FacebookHandle { get; set; } = "";
    public string TwitterHandle { get; set; } = "";
    public string InstagramHandle { get; set; } = "";
    public string LinkedInHandle { get; set; } = "";
    public bool IsOfficeEmployee { get; set; }
    public string Department { get; set; } = "";
}

public class WuphfStats
{
    public int TotalWuphfsSent { get; set; }
    public int TotalReach { get; set; }
    public int PrinterPages { get; set; }
    public Dictionary<WuphfChannel, int> ChannelUsage { get; set; } = new();
    public double AverageResponseTime { get; set; }
    public int SuccessRate { get; set; } // Percentage
}

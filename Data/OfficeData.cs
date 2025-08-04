using WUPHFApp.Models;
using WUPHFApp.Services;

namespace WUPHFApp.Data;

public static class OfficeData
{
    public static List<WuphfContact> GetOfficeContacts() => new()
    {
        new WuphfContact
        {
            Name = "Michael Scott",
            Email = "mscott@dundermifflin.com",
            PhoneNumber = "(570) 555-0001",
            FacebookHandle = "worldsbestboss",
            TwitterHandle = "@WorldsBestBoss",
            InstagramHandle = "michaelscott_official",
            LinkedInHandle = "michael-scott-regional-manager",
            IsOfficeEmployee = true,
            Department = "Management"
        },
        new WuphfContact
        {
            Name = "Jim Halpert",
            Email = "jhalpert@dundermifflin.com",
            PhoneNumber = "(570) 555-0002",
            FacebookHandle = "jimothy.halpert",
            TwitterHandle = "@JimTheMan",
            InstagramHandle = "jimothy_h",
            LinkedInHandle = "jim-halpert-sales",
            IsOfficeEmployee = true,
            Department = "Sales"
        },
        new WuphfContact
        {
            Name = "Pam Beesly",
            Email = "pbeesly@dundermifflin.com",
            PhoneNumber = "(570) 555-0003",
            FacebookHandle = "pam.beesly.art",
            TwitterHandle = "@PamTheReceptionist",
            InstagramHandle = "pam_art_studio",
            LinkedInHandle = "pam-beesly-reception",
            IsOfficeEmployee = true,
            Department = "Reception"
        },
        new WuphfContact
        {
            Name = "Dwight K. Schrute",
            Email = "dschrute@dundermifflin.com",
            PhoneNumber = "(570) 555-0004",
            FacebookHandle = "dwight.schrute.beets",
            TwitterHandle = "@BearsBeetsBSG",
            InstagramHandle = "schrutefarms_official",
            LinkedInHandle = "dwight-schrute-sales-warrior",
            IsOfficeEmployee = true,
            Department = "Sales"
        },
        new WuphfContact
        {
            Name = "Stanley Hudson",
            Email = "shudson@dundermifflin.com",
            PhoneNumber = "(570) 555-0005",
            FacebookHandle = "stanley.crosswords",
            TwitterHandle = "@PretzelsAndCrosswords",
            InstagramHandle = "stanley_the_manley",
            LinkedInHandle = "stanley-hudson-sales",
            IsOfficeEmployee = true,
            Department = "Sales"
        },
        new WuphfContact
        {
            Name = "Kevin Malone",
            Email = "kmalone@dundermifflin.com",
            PhoneNumber = "(570) 555-0006",
            FacebookHandle = "kevin.chili.spill",
            TwitterHandle = "@KevinsMath",
            InstagramHandle = "kevin_accountant_man",
            LinkedInHandle = "kevin-malone-accounting",
            IsOfficeEmployee = true,
            Department = "Accounting"
        },
        new WuphfContact
        {
            Name = "Angela Martin",
            Email = "amartin@dundermifflin.com",
            PhoneNumber = "(570) 555-0007",
            FacebookHandle = "angela.cats.party",
            TwitterHandle = "@AngelaCats",
            InstagramHandle = "party_planning_committee_chair",
            LinkedInHandle = "angela-martin-accounting",
            IsOfficeEmployee = true,
            Department = "Accounting"
        },
        new WuphfContact
        {
            Name = "Oscar Martinez",
            Email = "omartinez@dundermifflin.com",
            PhoneNumber = "(570) 555-0008",
            FacebookHandle = "oscar.actually",
            TwitterHandle = "@OscarMartinez",
            InstagramHandle = "oscar_the_grouch_accountant",
            LinkedInHandle = "oscar-martinez-cpa",
            IsOfficeEmployee = true,
            Department = "Accounting"
        },
        new WuphfContact
        {
            Name = "Phyllis Vance",
            Email = "pvance@dundermifflin.com",
            PhoneNumber = "(570) 555-0009",
            FacebookHandle = "phyllis.bob.vance",
            TwitterHandle = "@PhyllisVanceVance",
            InstagramHandle = "vance_refrigeration_wife",
            LinkedInHandle = "phyllis-vance-sales",
            IsOfficeEmployee = true,
            Department = "Sales"
        },
        new WuphfContact
        {
            Name = "Meredith Palmer",
            Email = "mpalmer@dundermifflin.com",
            PhoneNumber = "(570) 555-0010",
            FacebookHandle = "meredith.supplier.relations",
            TwitterHandle = "@MeredithPalmer",
            InstagramHandle = "meredith_phd",
            LinkedInHandle = "meredith-palmer-supplier-relations",
            IsOfficeEmployee = true,
            Department = "Supplier Relations"
        },
        new WuphfContact
        {
            Name = "Creed Bratton",
            Email = "cbratton@dundermifflin.com",
            PhoneNumber = "(570) 555-0011",
            FacebookHandle = "creed.mystery.man",
            TwitterHandle = "@CreedThoughts",
            InstagramHandle = "creed_quality_assurance",
            LinkedInHandle = "creed-bratton-quality-assurance",
            IsOfficeEmployee = true,
            Department = "Quality Assurance"
        },
        new WuphfContact
        {
            Name = "Toby Flenderson",
            Email = "tflenderson@dundermifflin.com",
            PhoneNumber = "(570) 555-0012",
            FacebookHandle = "toby.hr.guy",
            TwitterHandle = "@TobyHR",
            InstagramHandle = "toby_flenderson_hr",
            LinkedInHandle = "toby-flenderson-hr",
            IsOfficeEmployee = true,
            Department = "Human Resources"
        },
        new WuphfContact
        {
            Name = "Ryan Howard",
            Email = "rhoward@dundermifflin.com",
            PhoneNumber = "(570) 555-0013",
            FacebookHandle = "ryan.b.howard",
            TwitterHandle = "@RyanTheWUPHF",
            InstagramHandle = "ryan_started_the_fire",
            LinkedInHandle = "ryan-howard-wuphf-founder",
            IsOfficeEmployee = true,
            Department = "Business Development"
        },
        new WuphfContact
        {
            Name = "Kelly Kapoor",
            Email = "kkapoor@dundermifflin.com",
            PhoneNumber = "(570) 555-0014",
            FacebookHandle = "kelly.fashion.icon",
            TwitterHandle = "@KellyKapoor",
            InstagramHandle = "kelly_customer_service",
            LinkedInHandle = "kelly-kapoor-customer-service",
            IsOfficeEmployee = true,
            Department = "Customer Service"
        },
        new WuphfContact
        {
            Name = "Darryl Philbin",
            Email = "dphilbin@dundermifflin.com",
            PhoneNumber = "(570) 555-0015",
            FacebookHandle = "darryl.warehouse.boss",
            TwitterHandle = "@DarrylPhilbin",
            InstagramHandle = "darryl_warehouse_foreman",
            LinkedInHandle = "darryl-philbin-warehouse",
            IsOfficeEmployee = true,
            Department = "Warehouse"
        }
    };

    public static List<WuphfMessage> GetSampleWuphfs() => new()
    {
        new WuphfMessage
        {
            Content = "World's Best Boss Mug now available in the break room!",
            Sender = "Michael Scott",
            Recipients = new List<string> { "All Staff" },
            Channels = new List<WuphfChannel> { WuphfChannel.Email, WuphfChannel.Facebook, WuphfChannel.Printer },
            Status = WuphfStatus.Sent,
            Reach = 15,
            IsPrinted = true,
            CreatedAt = DateTime.Now.AddHours(-2)
        },
        new WuphfMessage
        {
            Content = "Bears. Beets. Battlestar Galactica. Fact: WUPHF is superior to all other communication platforms.",
            Sender = "Dwight K. Schrute",
            Recipients = new List<string> { "Jim Halpert", "Michael Scott" },
            Channels = new List<WuphfChannel> { WuphfChannel.Text, WuphfChannel.Twitter, WuphfChannel.LinkedIn },
            Status = WuphfStatus.Sent,
            Reach = 2,
            IsPrinted = false,
            CreatedAt = DateTime.Now.AddHours(-1)
        },
        new WuphfMessage
        {
            Content = "New art piece ready for viewing in the annex! 🎨",
            Sender = "Pam Beesly",
            Recipients = new List<string> { "All Staff" },
            Channels = new List<WuphfChannel> { WuphfChannel.Instagram, WuphfChannel.Facebook, WuphfChannel.Email },
            Status = WuphfStatus.Sent,
            Reach = 12,
            IsPrinted = false,
            CreatedAt = DateTime.Now.AddMinutes(-30)
        },
        new WuphfMessage
        {
            Content = "That's what she said! 😂 #ClassicMichael",
            Sender = "Jim Halpert",
            Recipients = new List<string> { "Pam Beesly", "Dwight K. Schrute" },
            Channels = new List<WuphfChannel> { WuphfChannel.Twitter, WuphfChannel.Text },
            Status = WuphfStatus.Sent,
            Reach = 2,
            IsPrinted = false,
            CreatedAt = DateTime.Now.AddMinutes(-15)
        },
        new WuphfMessage
        {
            Content = "Reminder: No microwaving fish in the break room. This means you, Kevin.",
            Sender = "Toby Flenderson",
            Recipients = new List<string> { "All Staff" },
            Channels = new List<WuphfChannel> { WuphfChannel.Email, WuphfChannel.Printer },
            Status = WuphfStatus.Sent,
            Reach = 15,
            IsPrinted = true,
            CreatedAt = DateTime.Now.AddMinutes(-5)
        }
    };

    public static WuphfStats GetCurrentStats() => new()
    {
        TotalWuphfsSent = 147,
        TotalReach = 2341,
        PrinterPages = 89,
        ChannelUsage = new Dictionary<WuphfChannel, int>
        {
            { WuphfChannel.Email, 45 },
            { WuphfChannel.Text, 38 },
            { WuphfChannel.Facebook, 32 },
            { WuphfChannel.Twitter, 28 },
            { WuphfChannel.Instagram, 25 },
            { WuphfChannel.LinkedIn, 15 },
            { WuphfChannel.Printer, 12 },
            { WuphfChannel.TikTok, 8 }
        },
        AverageResponseTime = 4.2,
        SuccessRate = 94
    };
}

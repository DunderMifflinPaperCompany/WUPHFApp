using Plugin.Maui.Audio;

namespace WUPHFApp.Services;

public interface IWuphfService
{
    Task SendWuphfAsync(string message, List<string> recipients, List<WuphfChannel> channels);
    Task<bool> PlayWoofSoundAsync();
    Task SimulatePrintWuphfAsync(string message);
    Task SendToSocialMediaAsync(string message, WuphfChannel channel);
    event EventHandler<WuphfReceivedEventArgs> WuphfReceived;
    void StartDemoMode();
    void StopDemoMode();
}

public enum WuphfChannel
{
    Email,
    Text,
    Facebook,
    Twitter,
    Printer,
    Instagram,
    TikTok,
    LinkedIn
}

public class WuphfReceivedEventArgs : EventArgs
{
    public string Message { get; set; } = "";
    public string Sender { get; set; } = "";
    public DateTime Timestamp { get; set; }
    public WuphfChannel Channel { get; set; }
}

public class WuphfService : IWuphfService
{
    private readonly IAudioManager _audioManager;
    private Timer? _demoTimer;
    private readonly Random _random = new();

    private readonly string[] _demoMessages =
    {
        "Ryan Howard just sent you a WUPHF!",
        "New notification from Michael Scott!",
        "Jim Halpert says: Bears. Beets. Battlestar Galactica.",
        "Dwight Schrute: FALSE! You have a new message.",
        "Pam Beesley shared a new drawing!",
        "Stanley Hudson: It's pretzel day!",
        "Kevin Malone: Me think, why waste time say lot word when few word do trick",
        "Creed Bratton: I've been involved in a number of cults...",
        "Angela Martin: That's what she said... wait, that's not right",
        "Toby Flenderson: Actually, I think there might be a problem..."
    };

    public event EventHandler<WuphfReceivedEventArgs>? WuphfReceived;

    public WuphfService(IAudioManager audioManager)
    {
        _audioManager = audioManager;
    }

    public async Task SendWuphfAsync(string message, List<string> recipients, List<WuphfChannel> channels)
    {
        foreach (var channel in channels)
        {
            await SendToChannelAsync(message, recipients, channel);
        }

        await PlayWoofSoundAsync();
    }

    private async Task SendToChannelAsync(string message, List<string> recipients, WuphfChannel channel)
    {
        // Simulate sending to different channels
        await Task.Delay(500); // Simulate network delay

        switch (channel)
        {
            case WuphfChannel.Email:
                // Simulate email sending
                break;
            case WuphfChannel.Text:
                // Simulate SMS sending
                break;
            case WuphfChannel.Facebook:
                // Simulate Facebook posting
                break;
            case WuphfChannel.Twitter:
                // Simulate Twitter posting
                break;
            case WuphfChannel.Printer:
                await SimulatePrintWuphfAsync(message);
                break;
            case WuphfChannel.Instagram:
                // Simulate Instagram posting
                break;
            case WuphfChannel.TikTok:
                // Simulate TikTok posting
                break;
            case WuphfChannel.LinkedIn:
                // Simulate LinkedIn posting
                break;
        }
    }

    public async Task<bool> PlayWoofSoundAsync()
    {
        try
        {
            // In a real app, we would load and play the actual audio file
            // For now, we'll simulate the sound playing
            await Task.Delay(1000); // Simulate sound duration
            return true;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error playing woof sound: {ex.Message}");
            return false;
        }
    }

    public async Task SimulatePrintWuphfAsync(string message)
    {
        // Simulate the famous "print on nearest printer" feature
        await Task.Delay(2000); // Simulate printing delay
        System.Diagnostics.Debug.WriteLine($"PRINTING WUPHF: {message}");
        System.Diagnostics.Debug.WriteLine("*Printer noise* bzzzzt... whirrrr... chunk chunk chunk");
    }

    public async Task SendToSocialMediaAsync(string message, WuphfChannel channel)
    {
        await Task.Delay(1000); // Simulate API call
        System.Diagnostics.Debug.WriteLine($"Posted to {channel}: {message}");
    }

    public void StartDemoMode()
    {
        _demoTimer = new Timer(OnDemoTick, null, TimeSpan.Zero, TimeSpan.FromSeconds(10));
    }

    public void StopDemoMode()
    {
        _demoTimer?.Dispose();
        _demoTimer = null;
    }

    private async void OnDemoTick(object? state)
    {
        var message = _demoMessages[_random.Next(_demoMessages.Length)];
        var sender = "Demo User";
        var channel = (WuphfChannel)_random.Next(Enum.GetValues<WuphfChannel>().Length);

        WuphfReceived?.Invoke(this, new WuphfReceivedEventArgs
        {
            Message = message,
            Sender = sender,
            Timestamp = DateTime.Now,
            Channel = channel
        });

        await PlayWoofSoundAsync();
    }
}

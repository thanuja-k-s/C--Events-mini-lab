using System;

class ThreatMonitor
{
    public event Action<string, int>? ThreatDetected;

    private readonly Func<int, bool> isHighRisk =
        score => score >= 80;

    public void ProcessEvent(string sourceIp, int score)
    {
        Console.WriteLine($"Checking {sourceIp}");

        if (isHighRisk(score))
        {
            ThreatDetected?.Invoke(sourceIp, score);
        }
    }
}

class Program
{
    static void Main()
    {
        ThreatMonitor monitor = new();

        Action<string, int> logAlert = (ip, score) =>
        {
            Console.WriteLine($"HIGH RISK: {ip}, score={score}");
        };

        monitor.ThreatDetected += logAlert;

        monitor.ProcessEvent("192.168.1.5", 30);
        monitor.ProcessEvent("10.0.0.15", 95);

        monitor.ThreatDetected -= logAlert;
    }
}
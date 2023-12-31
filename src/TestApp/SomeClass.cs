namespace TestApp;

public class SomeClass
{
    public async Task DoStuff()
    {
        const int jitterScale = 10;
        var jitter = Random.Shared.Next(-jitterScale, jitterScale);
        await Task.Delay(95 + jitter);
    }

    public async Task DoOtherStuff()
    {
        const int jitterScale = 10;
        var jitter = Random.Shared.Next(-jitterScale, jitterScale);
        await Task.Delay(140 + jitter);
    }
}

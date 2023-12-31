using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using TestApp;

namespace BenchmarkProj;

[MemoryDiagnoser]
public class Benchmarks
{
    private readonly SomeClass _someClass = new SomeClass();

    [Benchmark]
    public async Task<int> DoStuff()
    {
        await _someClass.DoStuff();
        return 1;
    }

    [Benchmark]
    public async Task<int> DoOtherStuff()
    {
        await _someClass.DoOtherStuff();
        return 1;
    }
}

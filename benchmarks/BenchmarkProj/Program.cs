using BenchmarkDotNet.Running;
using BenchmarkProj;

BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

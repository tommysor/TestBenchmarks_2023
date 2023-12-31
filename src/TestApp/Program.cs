// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using TestApp;

var someClass = new SomeClass();
var startTime1 = Stopwatch.GetTimestamp();
await someClass.DoStuff();
var elapsed1 = Stopwatch.GetElapsedTime(startTime1);
Console.WriteLine($"{nameof(someClass.DoStuff)} in {elapsed1}");

var startTime2 = Stopwatch.GetTimestamp();
await someClass.DoOtherStuff();
var elapsed2 = Stopwatch.GetElapsedTime(startTime2);
Console.WriteLine($"{nameof(someClass.DoOtherStuff)} in {elapsed2}");

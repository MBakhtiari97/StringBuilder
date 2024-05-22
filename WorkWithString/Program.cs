using BenchmarkDotNet.Running;
using WorkWithString;
public static class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<StringBenchmarks>();
    }
}
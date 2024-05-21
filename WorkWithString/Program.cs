using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;
public static class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<StringBenchmarks>();
    }
}
public class StringBenchmarks
{
    [Benchmark]
    public string DoStringConcatenation()
    {
        string result = "";
        for (int i = 0; i < 1000; i++)
        {
            result += i.ToString();
        }
        return result;
    }
    [Benchmark]
    public string DoStringBuilderOperation()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < 1000; i++)
        {
            result.Append(i.ToString());
        }
        return result.ToString();
    }
}
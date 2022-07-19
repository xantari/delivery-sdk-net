using BenchmarkDotNet.Running;

namespace Kontent.Ai.Delivery.Benchmarks
{
    internal static class Program
    {
        internal static void Main(string[] args) =>
            new BenchmarkSwitcher(Benchmarks.All).Run(args, new BenchmarkConfig());
    }
}


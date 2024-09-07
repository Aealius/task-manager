using System.Diagnostics;

namespace _2_
{
    internal class PerformanceWork
    {
        private static PerformanceCounter _cpuLoadCounter;
        private static PerformanceCounter _memUsageCounter;

        public float GetCPUValue()
        {
            _cpuLoadCounter = new("Processor", "% Processor Time", "_Total");
            _cpuLoadCounter.NextValue();
            Thread.Sleep(1000);
            return (float)_cpuLoadCounter.NextValue();
        }

        public float GetMemoryValue()
        {
            _memUsageCounter = new("Memory", "% Committed Bytes in Use");
            return (float)_memUsageCounter.NextValue();
        }
    }
}

namespace Timings
{
    public static class MyThreadingHelpers
    {
        public static void Sleep(int ms)
        {
            new System.Threading.ManualResetEvent(false).WaitOne(ms);
        }
    }
}
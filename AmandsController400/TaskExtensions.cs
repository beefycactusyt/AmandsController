using System;
using System.Threading.Tasks;

namespace AmandsControllerMod
{
    public static class TaskExtensions
    {
        public static void HandleExceptions(this Task task)
        {
            task.ContinueWith(t =>
            {
                if (t.Exception != null)
                {
                    UnityEngine.Debug.LogException(t.Exception);
                }
            }, TaskContinuationOptions.OnlyOnFaulted);
        }

        public static void HandleExceptions<T>(this Task<T> task)
        {
            task.ContinueWith(t =>
            {
                if (t.Exception != null)
                {
                    UnityEngine.Debug.LogException(t.Exception);
                }
            }, TaskContinuationOptions.OnlyOnFaulted);
        }
    }
}

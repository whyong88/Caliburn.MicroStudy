using System.Threading.Tasks;

namespace WpfApp1.Common
{
    public static class TaskHelper
    {
        public static Task<T> FromResult<T>(T result) => Task.FromResult(result);

        public static Task Delay(int milliseconds) => Task.Delay(milliseconds);
    }
}
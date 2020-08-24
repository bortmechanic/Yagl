using System.Threading;

namespace Yagl.Components
{
    internal static class IdGenerator
    {
        private static long _idsSequence;
        public static long Generate() => Interlocked.Increment(ref _idsSequence);
    }
}
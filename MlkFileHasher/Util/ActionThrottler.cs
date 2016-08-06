using System;

namespace MlkFileHasher.Util
{
    public class ActionThrottler
    {
        readonly TimeSpan _window;

        DateTime _lastRun = DateTime.MinValue;

        public ActionThrottler(TimeSpan window)
        {
            _window = window;
        }

        public void Do(Action action)
        {
            if (DateTime.UtcNow - _lastRun > _window)
            {
                action();
                _lastRun = DateTime.UtcNow;
            }
        }
    }
}

using System;

namespace MlkFileHasher.UI
{
    public class StatusLineUpdater
    {
        readonly Action<string> _setStatus;

        string _statusText;
        bool _overrideActive;

        public StatusLineUpdater(Action<string> setStatus)
        {
            _setStatus = setStatus;
        }

        public void SetStatus(string text)
        {
            _statusText = text;
            if (!_overrideActive)
                _setStatus(_statusText);
        }

        public void ClearStatus()
        {
            SetStatus(string.Empty);
        }

        public void SetOverrideStatus(string text)
        {
            _setStatus(text);
            _overrideActive = true;
        }

        public void ClearOverrideStatus()
        {
            _setStatus(_statusText);
            _overrideActive = false;
        }
    }
}

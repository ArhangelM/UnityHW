﻿namespace Assets.UnityHW.Scripts.Common.SignalBus
{
    public class CallbackWithPriority
    {
        public readonly int Priority;
        public readonly object Callback;

        public CallbackWithPriority(int priority, object callback)
        {
            Priority = priority;
            Callback = callback;
        }
    }
}

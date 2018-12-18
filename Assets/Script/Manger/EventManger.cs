using System;
using System.Collections.Generic;
using GameFramework.Event;
using UnityGameFramework.Runtime;

public class EventManger:Singleton<EventManger>
{
    private EventComponent _eventCompent;

    public EventComponent _EventCompent
    {
        get
        {
            if (_eventCompent == null)
                _eventCompent = GameEntry.GetComponent<EventComponent>();
            return _eventCompent;
        }
    }
}


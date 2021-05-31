using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CustomEvent : ScriptableObject
{
    private readonly List<CustomEventListener> eventListners = new List<CustomEventListener>();

    public void RaiseEvent()
    {
        foreach (CustomEventListener customEvent in eventListners)
        {
            customEvent.OnEventRaised();
        }
    }

    public void RegisterListener(CustomEventListener listener)
    {
        if (!eventListners.Contains(listener))
        {
            eventListners.Add(listener);
        }
    }

    public void UnregisterListener(CustomEventListener listener)
    {
        if (eventListners.Contains(listener))
        {
            eventListners.Remove(listener);
        }
    }
}

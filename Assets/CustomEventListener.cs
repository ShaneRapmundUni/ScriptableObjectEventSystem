using UnityEngine;
using UnityEngine.Events;

public class CustomEventListener : MonoBehaviour
{
    public CustomEvent customEvent;
    public UnityEvent Response;

    private void OnEnable()
    {
        customEvent.RegisterListener(this);
    }
    private void OnDisable()
    {
        customEvent.UnregisterListener(this);
    }
    public void OnEventRaised()
    {
        Response.Invoke();
    }
}

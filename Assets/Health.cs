using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Health : ScriptableObject
{
    public float value = 100f;
    public CustomEvent HealthUpdateEvent;

    public void AddHealth(float amount)
    {
        value += amount;
        HealthUpdateEvent.RaiseEvent();
    }
}

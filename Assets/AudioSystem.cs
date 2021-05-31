using UnityEngine;
public class AudioSystem : MonoBehaviour
{
    //Source: https://opengameart.org/content/heartbeat-sounds
    public AudioSource heartBeat;
    public Health health;

    public void UpdateHeartBeat()
    {
        heartBeat.volume = 1 / (health.value * 0.1f);
        heartBeat.pitch = 1 / (health.value * 0.1f);
    }

    //void Update()
    //{
    //    heartBeat.volume = 1 / health.value;
    //    heartBeat.pitch = 1 / health.value;
    //}

    //void Update()
    //{
    //    heartBeat.volume = 1 / GameObject.FindObjectOfType<Player>().health;
    //    heartBeat.pitch = 1 / GameObject.FindObjectOfType<Player>().health;
    //}
}

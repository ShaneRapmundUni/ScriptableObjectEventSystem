using UnityEngine;
public class MovementSystem : MonoBehaviour
{
    public float maxSpeed = 1f;
    public Health health;

    public void UpdateSpeed()
    {
        float speed = health.value / maxSpeed;
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += gameObject.transform.forward * speed;
        }
    }



    //void Update()
    //{
    //    float speed = health.value / maxSpeed;
    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        transform.position += gameObject.transform.forward * speed;
    //    }
    //}

    //}

    //void Update()
    //{
    //    float speed = GameObject.FindObjectOfType<Player>().health / maxSpeed;
    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        transform.position += gameObject.transform.forward * speed;
    //    }
    //}
}

using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;
    public Health healthSO;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            healthSO.AddHealth(-5);
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
public class UISystem : MonoBehaviour
{
    public Text text;
    public Health health;

    public void UpdateText()
    {
        text.text = health.value.ToString();
    }
    
    //void Update()
    //{
    //    text.text = health.value.ToString();
    //}

    //void Update()
    //{
    //    text.text = GameObject.FindObjectOfType<Player>().health.ToString();
    //}
}

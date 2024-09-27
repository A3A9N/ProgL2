using UnityEngine;
using System;

public class Pickup : MonoBehaviour
{
    public Action<int> onPickedUp;

    public Scoreboard scoreboard;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            onPickedUp?.Invoke(50); 
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if (scoreboard != null)
        {
            onPickedUp += scoreboard.AddScore; 
        }
    }
}

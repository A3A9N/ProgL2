using UnityEngine;

public class Brute : EnemyParent
{
    void Start()
    {
        maxHealth = 50;
        speed = 2f;
        currentHealth = maxHealth;
    }


}

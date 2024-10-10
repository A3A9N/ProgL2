using UnityEngine;
using System.Collections;

public class Elf : EnemyParent
{
    void Start()
    {
        maxHealth = 50;
        speed = 10f;
        currentHealth = maxHealth;

        StartCoroutine(ToggleVisibility());
    }

    IEnumerator ToggleVisibility()
    {
        while (currentHealth > 0)
        {
            yield return new WaitForSeconds(3f);
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.enabled = false;
                yield return new WaitForSeconds(0.5f);
                renderer.enabled = true;
            }
        }
    }
}

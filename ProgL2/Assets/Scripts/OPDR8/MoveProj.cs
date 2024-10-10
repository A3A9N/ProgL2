using UnityEngine;

public class MoveProj : MonoBehaviour
{
    public float moveSpeed = 20f;

    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyParent enemy = other.GetComponent<EnemyParent>();
            if (enemy != null)
            {
                enemy.TakeDamage(10);
            }
            Destroy(gameObject);
        }
    }
}

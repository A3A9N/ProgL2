using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float speed = 5f;
    public int maxHealth = 50;
    protected int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        // Beweeg van links naar rechts langs de x-as
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(gameObject.name + " heeft " + damage + " schade gekregen. Huidige gezondheid: " + currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log(gameObject.name + " is gestorven.");
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            TakeDamage(10); // Schade waarde kan aangepast worden
            Destroy(other.gameObject); // Vernietig het projectiel
        }
    }
}

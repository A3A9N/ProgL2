using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 3f;
    public float direction = 1f; 

    void Update()
    {
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
    }
}

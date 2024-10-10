using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyParentPrefab;
    public GameObject brutePrefab;
    public GameObject elfPrefab;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        int choice = Random.Range(0, 3);
        GameObject enemyToSpawn = enemyParentPrefab;

        if (choice == 1)
        {
            enemyToSpawn = brutePrefab;
        }
        else if (choice == 2)
        {
            enemyToSpawn = elfPrefab;
        }

        Vector3 spawnPosition = new Vector3(-10, 0.5f, Random.Range(-5f, 5f));
        Instantiate(enemyToSpawn, spawnPosition, Quaternion.identity);
    }
}

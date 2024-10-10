using UnityEngine;
using System.Collections.Generic;

public class EnemySpawnerr : MonoBehaviour
{
    public GameObject enemyPrefab; 
    public Transform centerPoint;
    public float spawnRadius = 5f; 
    public int numEnemiesToSpawn = 3; 

    private List<GameObject> enemies = new List<GameObject>(); 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnEnemies(100);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            RemoveAllEnemies();
        }
    }

    void SpawnEnemies(int numEnemies)
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Vector2 randomPos2D = UnityEngine.Random.insideUnitCircle.normalized * spawnRadius;
            Vector3 spawnPosition = new Vector3(randomPos2D.x, randomPos2D.y, 0) + centerPoint.position;


            GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            EnemyScript enemyScript = newEnemy.GetComponent<EnemyScript>();
            enemyScript.direction = UnityEngine.Random.Range(0, 2) == 0 ? -1f : 1f; 

            enemies.Add(newEnemy); 
        }
    }

    void RemoveAllEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy); 
        }
        enemies.Clear(); 
    }
}

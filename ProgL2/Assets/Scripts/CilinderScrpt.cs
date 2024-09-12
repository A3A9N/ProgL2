using UnityEngine;

public class CylinderSpawner : MonoBehaviour
{
    public GameObject cylinderPrefab;  
    public GameObject baseObject;     
    public float spawnRangeX = 5f;     
    public float spawnRangeZ = 5f;     
    public float minHeight = 1f;       
    public float maxHeight = 3f;      

    void Update()
    {

        if (Input.GetMouseButtonDown(0))  
        {
            SpawnCylinder();
        }
    }

 
    void SpawnCylinder()
    {
      
        float randomHeight = Random.Range(minHeight, maxHeight);
        float randomWidth = Random.Range(0.5f, 1.5f);

     
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        float randomZ = Random.Range(-spawnRangeZ, spawnRangeZ);

   
        float cylinderYPosition = baseObject.transform.position.y + randomHeight / 2;

       
        Vector3 newPosition = new Vector3(randomX, cylinderYPosition, randomZ);

      
        GameObject newCylinder = Instantiate(cylinderPrefab, newPosition, Quaternion.identity);

       
        newCylinder.transform.localScale = new Vector3(randomWidth, randomHeight, randomWidth);
    }
}

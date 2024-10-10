using UnityEngine;

public class ShootFromCamera : MonoBehaviour
{
    public GameObject projectilePrefab; 

    private Plane floor;

    void Start()
    {
        floor = new Plane(Vector3.up, Vector3.zero);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float distance;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (floor.Raycast(ray, out distance))
            {
                Vector3 targetPosition = ray.GetPoint(distance);
                GameObject p = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                p.transform.LookAt(targetPosition);
                p.AddComponent<MoveProj>();
                Destroy(p, 5f);
            }
        }
    }
}

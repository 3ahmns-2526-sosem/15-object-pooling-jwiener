using UnityEngine;

public class DestroyCubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public Transform cubeParent;

    void Start()
    {
        InvokeRepeating(nameof(SpawnCube), 0f, 1f);
    }

    void SpawnCube()
    {
        GameObject cube = Instantiate(cubePrefab, cubeParent);
        cube.transform.localPosition = Random.insideUnitSphere * 3f;
        Destroy(cube, 2f);
    }
}


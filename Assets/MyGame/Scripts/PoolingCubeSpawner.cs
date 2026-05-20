using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingCubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public Transform cubeParent;
    public int poolSize = 5;

    private List<GameObject> pool = new List<GameObject>();

    void Start()
    {
        CreatePool();
        InvokeRepeating(nameof(SpawnCubeFromPool), 0f, 1f);
    }

    void CreatePool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject cube = Instantiate(cubePrefab, cubeParent);
            cube.SetActive(false);
            pool.Add(cube);
        }
    }

    void SpawnCubeFromPool()
    {
        GameObject cube = GetInactiveCube();

        if (cube == null)
        {
            return;
        }

        cube.transform.localPosition = Random.insideUnitSphere * 3f;
        cube.SetActive(true);

        StartCoroutine(DeactivateAfterSeconds(cube, 2f));
    }

    GameObject GetInactiveCube()
    {
        foreach (GameObject cube in pool)
        {
            if (!cube.activeInHierarchy)
            {
                return cube;
            }
        }

        return null;
    }

    IEnumerator DeactivateAfterSeconds(GameObject cube, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        cube.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject ghostPrefab;
    public Transform SpawnTransform;
    public float spawnInterval = 3f;

    private float spawnTimer = 0;

    void Update()
    {

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            SpawnGhost();
            spawnTimer = 0;
        }
    }

    public void SpawnGhost()
    {
        Instantiate(ghostPrefab, transform.position, Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject ghostPrefab;
    public Transform playerTransform;
    public float spawnInterval = 50f;

    private float spawnTimer;

    void Start()
    {
        spawnTimer = spawnInterval;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            SpawnGhost();
            spawnTimer = spawnInterval;
        }
    }

    void SpawnGhost()
    {
        GameObject ghostInstance = Instantiate(ghostPrefab, transform.position, Quaternion.identity);
        Enemy ghostController = ghostInstance.GetComponent<Enemy>();
        if (ghostController != null && playerTransform != null)
        {
            ghostController.SetTarget(playerTransform);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] private Transform player;

    // Update is called once per frame

    private void Start() {
        player = GameObject.FindWithTag("Player").transform;
        
    }
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }

}

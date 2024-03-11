using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform player;
    //[SerializeField] int health = 100;

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }
    public void SetTarget(Transform newTarget)
    {
        player = newTarget;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Destroy(other.gameObject);
            print("Dead");
        }
    }
    //public void TakeDamage(int damage)
    //{
    //    health -= damage;
    //    if (health <= 0)
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}

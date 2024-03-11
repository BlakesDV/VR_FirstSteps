using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
//    void OnCollisionEnter(Collision collision) {
//        if (collision.gameObject.CompareTag("Enemy")) {
//            Destroy(collision.gameObject);
//            print("Enemy Dead");
//        }
//    }
    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.CompareTag("Enemy")) {
            Destroy(other.gameObject);
            print("Enemy Dead");
        }
    }
}

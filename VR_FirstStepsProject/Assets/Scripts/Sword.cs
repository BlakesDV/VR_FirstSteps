using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script hecho con ayuda de CHATGPT 
public class Sword : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            print("Enemy Dead Meele");
        }
    }
}

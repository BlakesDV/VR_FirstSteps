using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Content.Interaction;

public class CannonsFunc : MonoBehaviour
{
    public GameObject socket;
    public GameObject cannonball;
    public Transform cannonPos;
    public Rigidbody cannon;
    public float cannonballSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CannonBallSpawner() 
    {
        Instantiate(cannonball, cannonPos.position, Quaternion.identity);
        cannonball.transform.Translate(Vector3.forward * cannonballSpeed * Time.deltaTime);

        //script para lanzar la bola con chatgpt ref.
        //Rigidbody cannonballRb = cannonball.GetComponent<Rigidbody>();

        //if (cannonballRb != null) 
        //{
        //    cannonballRb.AddForce(cannonPos.forward * cannonballSpeed, ForceMode.Impulse);
        //}
    }
    public void Shoot() {

        //socket.SetActive(false);
        Instantiate(cannonball, cannonPos.position, Quaternion.identity);
        cannon.AddForce(transform.forward * cannonballSpeed);


    }
}

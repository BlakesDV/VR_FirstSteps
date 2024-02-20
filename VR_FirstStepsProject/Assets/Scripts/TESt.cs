using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class TESt : MonoBehaviour
{
    float sliderValue;
     XRSlider xRSlider;
    public GameObject cow;
    public GameObject socket;

    // Start is called before the first frame update
    void Start()
    {
        xRSlider = GetComponent<XRSlider>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //if (xRSlider.value == 1) {
        //    print("VAlor positivo");
        //}else if(xRSlider.value == 0) {
        //    print("VAlor negativo");
        //}
    }

    public void MovX() {
        print("Movimiento en X");
    }

    public void MovY() {
        print("Movimiento en Y");
    }

    public void ValueChange() {
        print("Value Cange");
    }

    public void ButtonPress() {
        print("button press");
    }

    public void CowSpawner()
    {
        Instantiate(cow, transform.position, Quaternion.identity);
    }

    public void LeverOn()
    {
        socket.SetActive(false);
    }

    public void LeverOff()
    {
        socket.SetActive(true);
    }
}

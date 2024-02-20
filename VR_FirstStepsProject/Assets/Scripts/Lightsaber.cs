using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Lightsaber : MonoBehaviour
{
    public GameObject saber;
    bool TurnOn;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable _interactor = GetComponent<XRGrabInteractable>();
        _interactor.activated.AddListener(TurnOnSaber);
    }

    public void TurnOnSaber(ActivateEventArgs arg) {

        TurnOn = !TurnOn;
        saber.SetActive(TurnOn);

    }



}

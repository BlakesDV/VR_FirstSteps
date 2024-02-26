using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD_Manager : MonoBehaviour
{
    /// <summary>
    /// Singleton HUD Manager instance
    /// </summary>
    public static HUD_Manager instance;

    void Awake() {
        if (instance != null && instance != this) {
            Destroy(this);
        } else {

            instance = this;
        }
    }
}

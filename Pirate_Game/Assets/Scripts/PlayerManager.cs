using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    /// <summary>
    /// Singleton Player Manager Instance
    /// </summary>
    public static PlayerManager instance;

    public void Awake() {
        if (instance != null && instance != this) {
            Destroy(this);
        } else {
            instance = this;
        }
    }
}

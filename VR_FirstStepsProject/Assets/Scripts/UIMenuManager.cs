using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenuManager : MonoBehaviour
{
    public void StartGame() {
        try { 
        SceneManager.LoadScene("GamePlay");
        }
        catch(Exception e) {
            Debug.LogError("Problem Scene" + e);
        }
    }

    public void ExitGame() {
        Application.Quit();
    }
}

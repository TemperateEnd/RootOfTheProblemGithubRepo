using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public GameObject mainMenuCanvas;

    private void OnEnable() {
        EventManager.StartListening("EnableMainMenu", EnableMainMenu);
        EventManager.StartListening("DisableMainMenu", DisableMainMenu);
    }

    void EnableMainMenu() {
        if(mainMenuCanvas.activeInHierarchy == false){
            mainMenuCanvas.SetActive(true);
            Debug.Log("Menu enabled");
        }
    }

    void DisableMainMenu() {
        if(mainMenuCanvas.activeInHierarchy == true) {
            mainMenuCanvas.SetActive(false);
            Debug.Log("Menu disabled");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject levelSelectCanvas;
    public GameObject playerHUD;

    private void OnEnable() {
        EventManager.StartListening("EnableMainMenu", EnableMainMenu);
        EventManager.StartListening("DisableMainMenu", DisableMainMenu);

        EventManager.StartListening("EnableLevelSelection", EnableLevelSelection);
        EventManager.StartListening("DisableLevelSelection", DisableLevelSelection);
    }

    void EnableMainMenu() {
        if(mainMenuCanvas.activeInHierarchy == false){
            mainMenuCanvas.SetActive(true);
        }
    }

    void DisableMainMenu() {
        if(mainMenuCanvas.activeInHierarchy == true) {
            mainMenuCanvas.SetActive(false);
        }
    }

    void EnableLevelSelection() {
        if(levelSelectCanvas.activeInHierarchy == false){
            levelSelectCanvas.SetActive(true);
        }
    }

    void DisableLevelSelection() {
        if(levelSelectCanvas.activeInHierarchy == true) {
            levelSelectCanvas.SetActive(false);
        }
    }
}

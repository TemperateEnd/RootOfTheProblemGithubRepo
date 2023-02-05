using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour {
    public GameObject mainMenuCanvas;
    public GameObject levelSelectCanvas;
    public GameObject playerHUD;
    public GameObject gameOverCanvas;

    private void OnEnable() {
        EventManager.StartListening("EnableMainMenu", EnableMainMenu);
        EventManager.StartListening("DisableMainMenu", DisableMainMenu);

        EventManager.StartListening("EnableLevelSelection", EnableLevelSelection);
        EventManager.StartListening("DisableLevelSelection", DisableLevelSelection);

        EventManager.StartListening("EnableGameOver", EnableGameOver);
        EventManager.StartListening("DisableGameOver", DisableGameOver);

        EventManager.StartListening("EnableCursor", EnableCursor);
        EventManager.StartListening("DisableCursor", DisableCursor);

        EventManager.StartListening("EnablePlayerHUD", EnablePlayerHUD);
        EventManager.StartListening("DisablePlayerHUD", DisablePlayerHUD);
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

    void EnableGameOver() {
        if(gameOverCanvas.activeInHierarchy == false) {
            gameOverCanvas.SetActive(true);
        }
    }

    void DisableGameOver(){
        if(gameOverCanvas.activeInHierarchy == true) {
            gameOverCanvas.SetActive(false);
        }
    }

    void EnablePlayerHUD() {
        if(playerHUD.activeInHierarchy == false) {
            playerHUD.SetActive(true);
        }
    }

    void DisablePlayerHUD() {
        if(playerHUD.activeInHierarchy == true) {
            playerHUD.SetActive(false);
        }
    }

    void EnableCursor() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void DisableCursor() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}

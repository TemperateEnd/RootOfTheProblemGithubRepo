using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour {
    public Level[] levelChoices;
    private void OnEnable() {
        EventManager.StartListening("ReturnToMainMenu", ReturnToMainMenu);
    }

    void SelectLevel(Level chosenLevel) {
        EventManager.TriggerEvent("DisableLevelSelectionMenu");
        //LevelManager.SetSelectedLevel(chosenLevel);
    }

    void ReturnToMainMenu() {
        EventManager.TriggerEvent("DisableLevelSelection");
        EventManager.TriggerEvent("EnableMainMenu");
    }
}
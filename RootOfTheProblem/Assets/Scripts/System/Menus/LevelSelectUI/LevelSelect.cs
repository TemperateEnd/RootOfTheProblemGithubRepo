using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour {
    private void OnEnable() {
        EventManager.StartListening("ReturnToMainMenu", ReturnToMainMenu);
    }

    public void SelectLevel(Level chosenLevel) {
        EventManager.TriggerEvent("DisableLevelSelection");
        LevelManager.SetSelectedLevel(chosenLevel);
        EventManager.TriggerEvent("GenerateLevel");
    }

    public void ReturnToMainMenu() {
        EventManager.TriggerEvent("DisableLevelSelection");
        EventManager.TriggerEvent("EnableMainMenu");
    }
}
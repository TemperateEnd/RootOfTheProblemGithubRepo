using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour {
    public void StartBtnFunct() {
        EventManager.TriggerEvent("StartGame");
    }

    public void QuitBtnFunct() {
        EventManager.TriggerEvent("QuitGame");
    }
}

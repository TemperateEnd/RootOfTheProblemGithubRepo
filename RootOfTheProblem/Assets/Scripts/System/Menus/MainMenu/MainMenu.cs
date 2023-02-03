using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.System.FSM.States;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable() {
        EventManager.StartListening("QuitGame", QuitGame);
        EventManager.StartListening("LevelSelect", LevelSelect);
        EventManager.StartListening("StartGame", StartGame);
    }

    void QuitGame() {
        Application.Quit();
    }

    void LevelSelect() {
        EventManager.TriggerEvent("DisableMainMenu");
    }

    void StartGame() {
        StateManager.InstanceRef.SwitchState(new PlayState(StateManager.InstanceRef));
        EventManager.TriggerEvent("DisableMainMenu");
        EventManager.TriggerEvent("GenerateMostRecentLevel");
    }
}

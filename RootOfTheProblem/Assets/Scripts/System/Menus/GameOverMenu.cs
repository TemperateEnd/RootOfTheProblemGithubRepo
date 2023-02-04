using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.System.FSM.States;

public class GameOverMenu : MonoBehaviour {
    // Start is called before the first frame update
    public void ReturnToMainMenu() {
        EventManager.TriggerEvent("DisableGameOver");
        StateManager.InstanceRef.SwitchState(new BeginState(StateManager.InstanceRef));
    }

    public void RestartLevel() {
        EventManager.TriggerEvent("DisableGameOver");
        StateManager.InstanceRef.SwitchState(new PlayState(StateManager.InstanceRef));
        EventManager.TriggerEvent("GenerateCurrentLevel");
    }
}

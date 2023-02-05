using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.System.FSM.States;

public class PlayerCollision : MonoBehaviour {
    // Start is called before the first frame update
    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "DeathBoundary") {
            StateManager.InstanceRef.SwitchState(new GameOverState(StateManager.InstanceRef));
            EventManager.TriggerEvent("DestroyGeneratedLevel");
            EventManager.TriggerEvent("DisablePlayerHUD");
        } else if (other.gameObject.tag == "LevelEnd") {
            EventManager.TriggerEvent("SetLevelAsComplete");
            StateManager.InstanceRef.SwitchState(new BeginState(StateManager.InstanceRef));
            EventManager.TriggerEvent("DestroyGeneratedLevel");
            EventManager.TriggerEvent("DisablePlayerHUD");
        }
    }
}

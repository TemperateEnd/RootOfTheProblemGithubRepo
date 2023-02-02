using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.System.FSM.Interfaces;

namespace Assets.Scripts.System.FSM.States {
    public class BeginState : IBaseState {
        private StateManager stateManager;
        private Scene scene;

        public BeginState(StateManager stateManagerRef) {
            stateManager = stateManagerRef;
            scene = SceneManager.GetActiveScene();
            if(scene.name != "BeginState") {
                SceneManager.LoadScene("BeginState");
            }
            EventManager.TriggerEvent("EnableMainMenu");
            Debug.Log("Constructing begin state");
        }

        public void StateUpdate() {
            if(Input.GetKeyDown(KeyCode.Space)) { //switch to play state on spacebar press (could implement EventManager?)
                Debug.Log($"RootOfTheProblem was in {SceneManager.GetActiveScene().name} state");
                SwitchOver();
            }
        }

        void SwitchOver() {
            StateManager.InstanceRef.SwitchState(new PlayState(StateManager.InstanceRef));
        }
    }
}
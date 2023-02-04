using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.System.FSM.Interfaces;

namespace Assets.Scripts.System.FSM.States {
    public class GameOverState : IBaseState {
        private StateManager stateManager;
        private Scene scene;
        public GameOverState(StateManager stateManagerRef) {
            stateManager = stateManagerRef;
            scene = SceneManager.GetActiveScene();
            if(scene.name != "GameOverState"){
                SceneManager.LoadScene("GameOverState");
            }
            EventManager.TriggerEvent("EnableGameOver");
            EventManager.TriggerEvent("EnableCursor");
        }

        public void StateUpdate() {
            //update state if something happens
        }

        void SwitchOver(){
        
        }
    }
}

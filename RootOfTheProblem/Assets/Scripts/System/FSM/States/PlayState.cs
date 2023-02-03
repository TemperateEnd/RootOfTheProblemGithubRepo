using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.System.FSM.Interfaces;

namespace Assets.Scripts.System.FSM.States {
    public class PlayState: IBaseState {
        private StateManager stateManager;
        private Scene scene;
        public PlayState(StateManager stateManagerRef) {
            stateManager = stateManagerRef;
            scene = SceneManager.GetActiveScene();
            if(scene.name != "PlayState"){
                SceneManager.LoadScene("PlayState");
            }
        }

        public void StateUpdate() {
            //update state if something happens
        }

        void SwitchOver(){
            
        }
    }
}
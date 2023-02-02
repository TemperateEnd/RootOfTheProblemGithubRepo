using UnityEngine;
using Assets.Scripts.System.FSM.States;
using Assets.Scripts.System.FSM.Interfaces;

public class StateManager : MonoBehaviour {
    private IBaseState iActiveState;
    public static StateManager InstanceRef = null; //{get => instanceRef; }
    private static StateManager instanceRef;

    /**variables that can be access via current instance of StateManager
    can be used to ensure that right data is passed between scenes without issue**/
   
    ///awake is used to establish instance of class. If one doesn't exist, make it
    private void Awake() {
        if(instanceRef != null) {
            DestroyImmediate(gameObject); //if pre-existing instance is found, destroy it
        } else { /**If one doesn't exist, set current instance to statically available instance and keep gameObj 
                    that handles gamestates over scene changes**/
            instanceRef = this;
            DontDestroyOnLoad(instanceRef);
            InstanceRef = instanceRef;
        }
    }

    private void Start() {
        iActiveState = new BeginState(this);
    }

    private void Update() {
        if(iActiveState != null) {
            iActiveState.StateUpdate();
        }
    }

    public void SwitchState(IBaseState newState) {
        iActiveState = newState;
    }
}

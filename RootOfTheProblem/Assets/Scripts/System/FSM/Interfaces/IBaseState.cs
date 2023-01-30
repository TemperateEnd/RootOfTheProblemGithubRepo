using System;

namespace Assets.Scripts.System.FSM.Interfaces {
    public interface IBaseState {
        //must implement method when we inherit interface into any class
        //contractual method below
        void StateUpdate();
        //later: implement UI system alongside this to identify current state
    }
}
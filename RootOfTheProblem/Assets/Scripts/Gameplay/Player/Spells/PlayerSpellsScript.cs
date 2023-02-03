using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpellsScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) {
            EventManager.TriggerEvent("WindRushSpeedBoost");
        } if (Input.GetKeyDown(KeyCode.G)) {
            EventManager.TriggerEvent("ShootFireball");
        }
    }
}

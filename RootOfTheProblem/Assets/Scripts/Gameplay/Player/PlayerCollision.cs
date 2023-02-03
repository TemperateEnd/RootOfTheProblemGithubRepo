using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    // Start is called before the first frame update
    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "DeathBoundary") {
            Debug.Log("Player just died");
        } else if (other.gameObject.tag == "LevelEnd") {
            Debug.Log("Reached end of level");
        }
    }
}

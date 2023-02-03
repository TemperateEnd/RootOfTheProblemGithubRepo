using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpellScript : MonoBehaviour {
    public GameObject projectile;
    public float launchVelocity = 700.0f;
    // Start is called before the first frame update
    void OnEnable() {
        EventManager.StartListening("ShootFireball", ShootFireball);
    }

    // Update is called once per frame
    void ShootFireball() {
        Debug.Log("test");
        GameObject fireBall = Instantiate(projectile, transform.position, transform.rotation);

        fireBall.GetComponent<Rigidbody>().AddForce(fireBall.transform.forward * launchVelocity);
    }
}

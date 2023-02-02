using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour {
    [SerializeField]
    float speed = 0.5f;
    public Vector3 direction;

    void FixedUpdate() {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        direction = new Vector3(horizontal, 0, vertical);

        GetComponent<Rigidbody>().MovePosition(transform.position + direction * Time.deltaTime * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour {
    public float speed;
    CharacterController charController;
    Vector3 direction = Vector3.zero;

    void Start() {
        charController = GetComponent<CharacterController>();
    }

    void FixedUpdate() {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        float currSpeedZ = Input.GetAxis("Vertical") * speed;
        float currSpeedX = Input.GetAxis("Horizontal") * speed;
        float directionY = direction.y;
        direction = (forward * currSpeedZ) + (right * currSpeedX);

        charController.Move(direction * Time.deltaTime);
    }
}

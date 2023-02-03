using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHandler : MonoBehaviour {
    public Camera cam;
    public float rotateSpeed;
    public float rotateYBoundary;
    float rotationY = 0;

    void Start() {
        //Locking cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate() {
        rotationY -= Input.GetAxis("Mouse Y") * rotateSpeed;
        rotationY = Mathf.Clamp(rotationY, -rotateYBoundary, rotateYBoundary);

        cam.transform.localRotation = Quaternion.Euler(rotationY, 0, 0);
        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * rotateSpeed, 0);
    }
}
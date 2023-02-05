using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour {
    [Header("Jumping variables")]
    public float jumpForce = 2.0f;
    public Vector3 jump;
    public bool isGrounded;
    Rigidbody rb;
    [Header("Running variables")]
    public float speed;
    CharacterController charController;
    Vector3 direction = Vector3.zero;

    private void OnEnable() {
        EventManager.StartListening("WindRushSpeedBoost", WindRushSpeedBoost);
    }

    void Start() {
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        rb = GetComponent<Rigidbody>();
        charController = GetComponent<CharacterController>();
    }

    void Update() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * moveHorizontal +
                           transform.forward * moveVertical;

        movement.y = 0.0f;   
        movement.Normalize();

        movement = movement * Time.deltaTime * speed;

        rb.MovePosition(transform.position + movement);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
            isGrounded = false;
            rb.AddForce(transform.up * jumpForce, ForceMode.VelocityChange);
        }
    }

    void OnCollisionEnter() {
        isGrounded = true;
    }

    void WindRushSpeedBoost() {
        speed =25.0f;
        Debug.Log("Wind Rush Activated! You are now faster!");
        StartCoroutine("speedTimer");
    }

    IEnumerator speedTimer() {
        yield return new WaitForSeconds(10);
        speed = 10.0f;
        Debug.Log("Speed returned to normal");
    }
}

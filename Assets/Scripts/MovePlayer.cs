using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float jumpPower = 15.0f;
    public float gravityPower = 15.0f;

    private CharacterController characterController;
    private Vector3 moveDirection;

    // Use this for initialization
    void Start () {
        characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (characterController.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                moveDirection.y = jumpPower;
            }
        }

        moveDirection.y -= gravityPower * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(CharacterController))]
public class LowPolyFirstPersonController : MonoBehaviour
{


	public float movementSpeed = 5.0f;
	public float mouseSensitivity = 5.0f;
	public float jumpSpeed = 10.0f;

	float verticalRotation = 0.0f;
	public float upDownRange = 50.0f;

	float verticalVelocity = 0;

	CharacterController characterController;


	// Use this for initialization
	void Start ()
	{
		//Screen.lockCursor = true;
		characterController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
        

		//Left Right Rotation
		float rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensitivity;
		transform.Rotate (0, rotLeftRight, 0);

		//Up Down Rotation
		verticalRotation = verticalRotation - Input.GetAxis ("Mouse Y") * mouseSensitivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -upDownRange, upDownRange);
		Debug.Log (verticalRotation);
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);



		//Movement
		float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;
		float sideSpeed = Input.GetAxis ("Horizontal") * movementSpeed;

		verticalVelocity = verticalVelocity + Physics.gravity.y * Time.deltaTime;

		if (characterController.isGrounded && Input.GetButton ("Jump")) {
			verticalVelocity = jumpSpeed;
		}

		Vector3 speed = new Vector3 (sideSpeed, verticalVelocity, forwardSpeed);

		speed = transform.rotation * speed;

        

		characterController.Move (speed * Time.deltaTime);

	}
}

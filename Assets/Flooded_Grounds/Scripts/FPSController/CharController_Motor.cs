using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController_Motor : MonoBehaviour {

	public float speed = 10.0f;
	public float sensitivity;
	public float WaterHeight = 15.5f;
	CharacterController character;
	public GameObject cam;
	float moveFB, moveLR, moveUP;
	float rotX, rotY;
	public bool webGLRightClickRotation = true;
	float gravity = -9.8f;
	public float jumpvalue;
	public bool isGrounded=true;
	public float distToGround;


	void Start(){
		//LockCursor ();
		character = GetComponent<CharacterController> ();
		if (Application.isEditor) {
			webGLRightClickRotation = true;
			sensitivity = sensitivity * 1.5f;
		}
	}


	void CheckForWaterHeight(){
		if (transform.position.y < WaterHeight) {
			gravity = 0f;			
		} else {
			gravity = -98f;
		}
	}



	void Update(){
		moveFB = Input.GetAxis ("Horizontal") * speed;
		moveLR = Input.GetAxis ("Vertical") * speed;
		
		if(Input.GetKeyDown("space") && isGrounded)
		{
			moveUP = jumpvalue;
			isGrounded =false;
		}
		else
		{
			GroundCheck();
		}
		

		rotX = Input.GetAxis ("Mouse X") * sensitivity;
		rotY = Input.GetAxis ("Mouse Y") * sensitivity;

		//rotX = Input.GetKey (KeyCode.Joystick1Button4);
		//rotY = Input.GetKey (KeyCode.Joystick1Button5);

		CheckForWaterHeight ();


		Vector3 movement = new Vector3 (moveFB, gravity + moveUP, moveLR);
		if(moveUP>0)
		{
			moveUP -= 50*Time.deltaTime;
		}
		
		

		if (webGLRightClickRotation) {
			if (Input.GetKey (KeyCode.Mouse0)) {
				CameraRotation (cam, rotX, rotY);
			}
		} else if (!webGLRightClickRotation) {
			CameraRotation (cam, rotX, rotY);
		}

		movement = transform.rotation * movement;
		character.Move(movement * Time.deltaTime);
	}


	void CameraRotation(GameObject cam, float rotX, float rotY){		
		transform.Rotate (0, rotX * Time.deltaTime, 0);
		cam.transform.Rotate (-rotY * Time.deltaTime, 0, 0);
	}

	
	void GroundCheck(){
		RaycastHit hit;
		if(Physics.Raycast(transform.position, Vector3.down, out hit, distToGround + 0.1f))
		{
			isGrounded=true;
		}
		else 
		{
			isGrounded = false;
		}
	}




}

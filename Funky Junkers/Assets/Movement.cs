using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	//PUBLIC VARIABLES

	//Ship variables
	public float speed; //ship movement speed
	public float acceleration = 0.2f;
	public float maxSpeed = 2f; //maximum movement speed
	public float rotSpd; //speed at which the ship rotates
	public float hookRotSpd; //speed at which the hook rotates

	//Camera variables
	public float distance = 0.7f;
	public float minDistance = 0.7f;
	public float maxDistance = 4f;
	public Vector3 cameraAngle = new Vector3(0f, 0.1f, -0.02f);

	//Object References
	public GameObject cam;
	public GameObject hookPivot;
	public GameObject thisObj;

	//Keycodes for movement
	public KeyCode keyForward;
	public KeyCode altKeyForward;
	public KeyCode keyBackward;
	public KeyCode altKeyBackward;
	public KeyCode keyLeft;
	public KeyCode altKeyLeft;
	public KeyCode keyRight;
	public KeyCode altKeyRight;
	public KeyCode keyRotateAnchorRight;
	public KeyCode altKeyRotateAnchorRight;
	public KeyCode keyRotateAnchorLeft;
	public KeyCode altKeyRotateAnchorLeft;
	public KeyCode latchHook;
	public KeyCode altLatchHook;

	//PRIVATE VARIABLES
	private bool hookLock; //locks the hook to an object
	private GameObject itemRef; //object reference for hooked item

	// Use this for initialization
	void Start () {
		hookLock = false;
		itemRef = null;
	}
	
	// Update is called once per frame
	void Update () {
		//only use this method for stuff related to graphics (like the UI)
	}

	// FixedUpdate is called when physics updates
	void FixedUpdate() {
		//MOVEMENT
		if(Input.GetKey(keyForward) || Input.GetKey(altKeyForward)) {	//Forward ship movement
			speed += acceleration;
		} else if (Input.GetKey(keyBackward) || Input.GetKey(altKeyBackward)) { //Reverse Ship movement? Brake?
			speed -= acceleration;
		}
		//Correct for maximum/minimum speed
		if(speed > maxSpeed) speed = maxSpeed;
		else if(speed < 0) speed = 0;

		if(Input.GetKey(keyLeft) || Input.GetKey(altKeyLeft)) {	//Ship rotation left
			thisObj.transform.Rotate(new Vector3(0, -rotSpd, 0), Space.World);
		} else if(Input.GetKey(keyRight) || Input.GetKey(altKeyRight)) {	//Ship rotation right
			thisObj.transform.Rotate(new Vector3(0, rotSpd, 0), Space.World);
		}
		if(Input.GetKey(keyRotateAnchorRight) || Input.GetKey(keyRotateAnchorRight)) {
			
		} else if(Input.GetKey(keyRotateAnchorLeft) || Input.GetKey(altKeyRotateAnchorLeft)) {

		}
		if(Input.GetKey(latchHook) || Input.GetKey(altLatchHook)) {

		}

		//scroll to zoom functionality
		float d = Input.GetAxis("Mouse_ScrollWheel");
		distance -= d;
		if(distance>maxDistance) distance=maxDistance;
		else if (distance<minDistance) distance=minDistance;
		//UPDATE CAMERA
		cam.transform.position = new Vector3(0f+thisObj.transform.position.x, (thisObj.transform.position.y + cameraAngle.y)+distance, -0.34f+thisObj.transform.position.z);
		//UPDATE
		thisObj.transform.Translate(thisObj.transform.forward * speed);
	}
}

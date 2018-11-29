using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	[HeaderAttribute("Controls")]
	public KeyCode upKey = KeyCode.W;
	public KeyCode altUpKey = KeyCode.UpArrow;
	public KeyCode downKey = KeyCode.S;
	public KeyCode altDownKey = KeyCode.DownArrow;
	public KeyCode rightKey = KeyCode.D;
	public KeyCode altRightKey = KeyCode.RightArrow;
	public KeyCode leftKey = KeyCode.A;
	public KeyCode altLeftKey = KeyCode.LeftArrow;

	[Header("Ship Variables")]
	public float shipSpeed = 2f;
	/*public float curShipSpeed = 0f;
	public float shipAcceleration = 0.004f;
	public float maxShipSpeed = 4f;*/
	public float shipRotSpeed = 2f;

	[Header("Object References")]
	public Camera cam;
	public GameObject ship;
	public GameObject anchorPivot;

	// Use this for initialization
	void Start () {
		
	}
	
	// FixedUpdate is called when physics updates
	void FixedUpdate() {
		if(Input.GetKey(upKey) || Input.GetKey(altUpKey)) {
			
		}
	}
}

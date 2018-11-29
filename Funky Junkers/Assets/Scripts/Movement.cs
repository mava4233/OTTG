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
	public float shipSpeed = 0.2f;
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
			ship.transform.Translate(ship.transform.forward*shipSpeed, Space.World);
		} else if(Input.GetKey(downKey) || Input.GetKey(altDownKey)) {
			ship.transform.Translate(-ship.transform.forward*shipSpeed, Space.World);
		}
		if(Input.GetKey(rightKey) || Input.GetKey(altRightKey)) {
			ship.transform.Rotate(new Vector3(0,1,0)*shipRotSpeed, Space.World);
		} else if(Input.GetKey(leftKey) || Input.GetKey(altLeftKey)) {
			ship.transform.Rotate(new Vector3(0,1,0)*-shipRotSpeed, Space.World);
		}
	}
}

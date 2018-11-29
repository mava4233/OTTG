using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	[Header("Controls")]
	public KeyCode upKey = KeyCode.W;
	public KeyCode altUpKey = KeyCode.UpArrow;
	public KeyCode downKey = KeyCode.S;
	public KeyCode altDownKey = KeyCode.DownArrow;
	public KeyCode rightKey = KeyCode.D;
	public KeyCode altRightKey = KeyCode.RightArrow;
	public KeyCode leftKey = KeyCode.A;
	public KeyCode altLeftKey = KeyCode.LeftArrow;
	public KeyCode pivotRight = KeyCode.E;
	public KeyCode altPivotRight = KeyCode.Keypad0;
	public KeyCode pivotLeft = KeyCode.Q;
	public KeyCode altPivotLeft = KeyCode.RightControl;

	[Header("Ship Variables")]
	public float shipSpeed = 0.2f;
	public float shipRotSpeed = 2f;
	public float anchorRotSpeed = 2f;

	[Header("Object References")]
	public Camera cam;
	public GameObject ship;
	public GameObject anchorPivot;
	public GameObject anchoredObject;

	// Use this for initialization
	void Start () {
		if(anchoredObject != null) {
			anchoredObject.transform.parent = anchorPivot.transform;
		}
	}
	
	// FixedUpdate is called when physics updates
	void FixedUpdate() {
		if(Input.GetKey(upKey) || Input.GetKey(altUpKey)) {
			ship.transform.Translate(ship.transform.forward*shipSpeed, Space.World);
		} /*else if(Input.GetKey(downKey) || Input.GetKey(altDownKey)) {
			ship.transform.Translate(-ship.transform.forward*shipSpeed, Space.World);
		}*/
		if(Input.GetKey(rightKey) || Input.GetKey(altRightKey)) {
			ship.transform.Rotate(new Vector3(0,1,0)*shipRotSpeed, Space.World);
		} else if(Input.GetKey(leftKey) || Input.GetKey(altLeftKey)) {
			ship.transform.Rotate(new Vector3(0,1,0)*-shipRotSpeed, Space.World);
		}
		if(Input.GetKey(pivotRight) || Input.GetKey(altPivotRight)) {
			anchorPivot.transform.Rotate(new Vector3(0, anchorRotSpeed, 0), Space.World);
		} else if(Input.GetKey(pivotLeft) || Input.GetKey(altPivotLeft)) {
			anchorPivot.transform.Rotate(new Vector3(0, -anchorRotSpeed, 0), Space.World);
		}

		cam.transform.SetPositionAndRotation(new Vector3(ship.transform.position.x,6,ship.transform.position.z), cam.transform.rotation);
	}
}

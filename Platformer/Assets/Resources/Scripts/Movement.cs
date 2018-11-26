using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	//class variables
	public float rotspd = 0.2f;
	public float movspd = 0.2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// FixedUpdate is called when physics updates
	void FixedUpdate() {
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { //Arrow Left/A key
			this.gameObject.transform.Rotate(0f,-rotspd,0f);
		} else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { //Arrow Right/D key
			this.gameObject.transform.Rotate(0f,rotspd,0f);
		}
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) { //Arrow Up/W key
			this.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * movspd, ForceMode.Force);
		} else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) { //Arrow Down/S key
			this.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * movspd, ForceMode.Force);
		}
	}
}

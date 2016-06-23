using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//	
//	}
	
	// Update is called once per frame
	// before rending a frame
	private Rigidbody rb;
	public float speed;

	void Start() { // called when the first frame is active
		rb = GetComponent<Rigidbody> (); // search the object, which this script is attached to, for a rigidbody 

	}
	void Update () {
		
	}
	// before performing any physics update
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 v3 = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (v3 * speed);
	
	}
}

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;

	}
	
	// Update is called once per frame
	void LateUpdate () { // guaranteed to run after all objects have been processed and updated.  
		transform.position = player.transform.position + offset;
	}
}

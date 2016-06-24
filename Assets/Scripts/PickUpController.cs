using UnityEngine;
using System.Collections;

public class PickUpController : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (10, 15, 30) * Time.deltaTime);
	}
}

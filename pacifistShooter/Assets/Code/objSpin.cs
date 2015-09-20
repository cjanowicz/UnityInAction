using UnityEngine;
using System.Collections;

public class objSpin : MonoBehaviour {
	
	public float speed; //Public variable for the speed of rotation.

	// Update is called once per frame
	void Update () {
		transform.Rotate(0, speed, 0, Space.World); //make the rotate run every frame.
	}
}

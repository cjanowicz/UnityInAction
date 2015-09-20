using UnityEngine;
using System.Collections;

public class mouseLook : MonoBehaviour {

	public enum RotationAxes {
		MouseXAndY = 0,
		MouseX = 1,
		MouseY = 2
	}

	public RotationAxes axes = RotationAxes.MouseXAndY;

	public float sensitivityHor = 9.0f;
	public float sensitivityVert = 9.0f;

	public float minimumVert = -45.0f;
	public float maximumVert = 45.0f;

	private float _rotationx = 0;

	// Update is called once per frame
	void Update () {
		if (axes == RotationAxes.MouseX) {
			//horizontal rotation here
			//transform.Rotate(0, sensitivityHor, 0);
			//above line is old code, endless spin in one direction.
			transform.Rotate (0, Input.GetAxis ("Mouse X") * sensitivityHor, 0);
		} else if (axes == RotationAxes.MouseY) {
			//vertical rotation here
			_rotationx -= Input.GetAxis("Mouse Y") * sensitivityVert;
			_rotationx = Mathf.Clamp(_rotationx, minimumVert, maximumVert);

			float rotationY = transform.localEulerAngles.y;

			transform.localEulerAngles = new Vector3(_rotationx, rotationY, 0);
		}
		else {
			//both horizontal and vertical rotation here
		}
	}
}

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]

public class FPSInput : MonoBehaviour {

	public float speed = 20.0f;
	public float gravity = -9.8f;

	private CharacterController _charController;
	
	void Start() {
		_charController = GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update () {
		//transform.Translate (0, speed, 0);
		float deltaX = Input.GetAxis ("Horizontal") * speed;
		float deltaZ = Input.GetAxis ("Vertical") * speed;
		//transform.Translate (deltaX, 0, deltaZ * Time.deltaTime);
		Vector3 movement = new Vector3 (deltaX, 0, deltaZ);
		movement = Vector3.ClampMagnitude (movement, speed);

		//movement.y = gravity;
		movement.y = 0;

		movement = transform.TransformDirection (movement);
		movement += new Vector3 (0, gravity, 0);
		movement *= Time.deltaTime;
		_charController.Move (movement);

		//movement = Vector3.ClampMagnitude (movement, speed)
	}
}

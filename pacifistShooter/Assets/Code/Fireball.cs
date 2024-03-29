﻿using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {

	public float speed = 10.0f;
	public int damage = 1;

	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, speed * Time.deltaTime);
	}

	void OnTriggerEnger(Collider other) {
		PlayerCharacter player = other.GetComponent<PlayerCharacter> ();
		if (player != null) {
			Debug.Log ("Player damaged");
		}
		Destroy (this.gameObject);
}
}
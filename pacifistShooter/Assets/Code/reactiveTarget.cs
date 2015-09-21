using UnityEngine;
using System.Collections;

public class reactiveTarget : MonoBehaviour {

	public void ReactToHit() {
		wanderingAI behaviour = GetComponent<wanderingAI> ();
		if (behaviour != null) {
			behaviour.setAlive (false);
		}
		StartCoroutine (Die ());
	}

	private IEnumerator Die() {
		this.transform.Rotate (-75, 0, 0);

		yield return new WaitForSeconds (1.5f);

		Destroy (this.gameObject);
		}
	}
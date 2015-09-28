using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class rayShooter : MonoBehaviour {

	private Camera _camera;

	// Use this for initialization
	void Start () {
		_camera = GetComponent<Camera> ();
		/*
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false; */
	} 

	void OnGUI() {
		int size = 12;
		float posX = _camera.pixelWidth / 2 - size / 4;
		float posY = _camera.pixelHeight / 2 - size / 2;
		GUI.Label (new Rect (posX, posY, size, size), "*");
	}
	
	// Update is called once per frame
	void Update () {

			if (Input.GetMouseButtonDown(0) &&
			    !EventSystem.current.IsPointerOverGameObject()) {
				Vector3 point = new Vector3(
					GetComponent<Camera>().pixelWidth/2, GetComponent<Camera>().pixelHeight/2, 0);
			}
				if (Input.GetMouseButtonDown (0))
				{
		Vector3 point = new Vector3(_camera.pixelWidth/2, _camera.pixelHeight/2, 0);
			Ray ray = _camera.ScreenPointToRay (point);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				//Debug.Log ("Hit " + hit.point + ", the name was " + hit.collider.gameObject.name);
				GameObject hitObject = hit.transform.gameObject;
				reactiveTarget target = hitObject.GetComponent<reactiveTarget>();
				if (target != null) {
					Debug.Log("Target hit");
					target.ReactToHit(); 
				} else {
				StartCoroutine(SphereIndicator(hit.point));
				}
			}
		}
	}

	private IEnumerator SphereIndicator(Vector3 pos) {
		Debug.Log ("Target Missed");
		GameObject Sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		Sphere.transform.position = pos;
		yield return new WaitForSeconds(1);
		
		Destroy (Sphere);
	}
}

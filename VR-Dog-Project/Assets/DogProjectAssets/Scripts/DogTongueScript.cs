using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class DogTongueScript : MonoBehaviour {

    private Animator tongueAnim;
    private Transform cameraTransform;

	// Use this for initialization
	void Start () {
        cameraTransform = GameObject.Find("MainCamera").transform;
        tongueAnim = GameObject.Find("Tongue").GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (CrossPlatformInputManager.GetButtonDown("Fire1")) {
            tongueAnim.SetTrigger("LickTrigger");
            RaycastHit hit;
            if (Physics.Raycast(cameraTransform.position, cameraTransform.forward,out hit,2f)) {
                hit.transform.SendMessage("GetLicked", SendMessageOptions.DontRequireReceiver);
            }
        }

	}
}

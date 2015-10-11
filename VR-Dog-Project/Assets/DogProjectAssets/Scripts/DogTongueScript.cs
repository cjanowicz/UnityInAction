using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class DogTongueScript : MonoBehaviour {

    private Animator tongueAnim;

	// Use this for initialization
	void Start () {
        tongueAnim = GameObject.Find("Tongue").GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (CrossPlatformInputManager.GetButtonDown("Fire1")) {
            tongueAnim.SetTrigger("LickTrigger");
        }
	}
}

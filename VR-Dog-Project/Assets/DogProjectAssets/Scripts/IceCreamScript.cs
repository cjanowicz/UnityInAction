using UnityEngine;
using System.Collections;

public class IceCreamScript : MonoBehaviour {

    public Transform[] scoops = new Transform[3];
    private float[] scoopSize = new float[3];
    public int licksPerScoop = 3;
    private int totalLicksLeft;

    // Use this for initialization
    void Awake() {
        totalLicksLeft = licksPerScoop * scoops.Length;
        for (int i = 0; i < scoops.Length; i++) {
            scoopSize[i] = scoops[i].localScale.y;
        }
    }

    // Update is called once per frame
    void Update() {

    }

    void GetLicked() {
        if (totalLicksLeft > 0) {
            int index = Mathf.CeilToInt((float)totalLicksLeft / (float)licksPerScoop) -1;
            scoops[index].localScale = new Vector3(scoops[index].localScale.x - scoopSize[index]/licksPerScoop,
                scoops[index].localScale.y - scoopSize[index] / licksPerScoop, scoops[index].localScale.z - scoopSize[index] / licksPerScoop);
            
            totalLicksLeft--;
        }
    }
}

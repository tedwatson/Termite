using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public float growthMultiplier = 1f;
    public float growthSpeed = 1f;

    private GameObject cameraRig;
    private float currentSize;

    public void Grow(Vector3 size)
    {
        currentSize += processSize(size);
        print("currentSize = " + currentSize);
    }

	// Use this for initialization
	void Start () {
        cameraRig = GameObject.Find("[CameraRig]");
        currentSize = cameraRig.transform.localScale.x;
    }
	
	// Update is called once per frame
	void Update () {
		if (cameraRig.transform.localScale.x < currentSize)
        {
            float inc = 0.1f * growthSpeed * Time.deltaTime;
            cameraRig.transform.localScale += new Vector3(inc, inc, inc);
        }
	}

    float processSize(Vector3 size)
    {
        // Finds the average of the 3 extents and returns a Vector3 with 3 equal extents
        float ave = ((size.x + size.y + size.z) / 3f) * growthMultiplier;
        return ave;
    }
}

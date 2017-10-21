using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edibleCubeController : MonoBehaviour {

    public float inc;

    private GameObject cameraRig;

    // Use this for initialization
    void Start () {
        cameraRig = GameObject.Find("[CameraRig]");
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        print("!");
        Vector3 scale = cameraRig.transform.localScale;
        cameraRig.transform.localScale += new Vector3(scale.x + inc, scale.y + inc, scale.z + inc);
        Destroy(this.gameObject);
        
        
        
        
    }
}

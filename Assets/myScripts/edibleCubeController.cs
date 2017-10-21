using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edibleCubeController : MonoBehaviour {

    public float sizeMultiplier = 1f;

    private GameObject cameraRig;
    private MeshRenderer mr;

    // Use this for initialization
    void Start () {
        cameraRig = GameObject.Find("[CameraRig]");
        mr = GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("MainCamera"))
        {
            cameraRig.transform.localScale += mr.bounds.size;
            gameObject.SetActive(false);
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdibleCubeController : MonoBehaviour {

    private GameController gameController;
    private MeshRenderer mr;

    // Use this for initialization
    void Start () {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        mr = GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("MainCamera"))
        {
            gameController.Grow(mr.bounds.size);
            gameObject.SetActive(false);
        }
    }
    
}

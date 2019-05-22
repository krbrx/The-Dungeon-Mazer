using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingFloor : MonoBehaviour {
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empty : MonoBehaviour {
    private void OnTriggerEnter(Collider hit)
    {
       if (hit.gameObject.CompareTag("Player"))
         {
            Destroy(gameObject);
            PlayerStatus health = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatus>();
            health.Damage();
        }
    }
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

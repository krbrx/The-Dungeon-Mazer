using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {
    private bool hit = false;

    private void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.gameObject.CompareTag("Player"))
        {
            hit = true;
        }
    }

    private void OnTriggerExit(Collider obstacle)
    {
        if (obstacle.gameObject.CompareTag("Player"))
        {
            hit = false;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hit)
        {
            PlayerStatus health = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatus>();
            health.Damage();
        }
    }
}

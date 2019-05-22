using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lock : MonoBehaviour {
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            DoorTrigger unlock1 = GameObject.FindGameObjectWithTag("Lock1").GetComponent<DoorTrigger>();
            unlock1.Unlock();
            DoorTrigger1 unlock2 = GameObject.FindGameObjectWithTag("Lock2").GetComponent<DoorTrigger1>();
            unlock2.Unlock();
            DoorTrigger2 unlock3 = GameObject.FindGameObjectWithTag("Lock3").GetComponent<DoorTrigger2>();
            unlock3.Unlock();
            DoorTrigger3 unlock4 = GameObject.FindGameObjectWithTag("Lock4").GetComponent<DoorTrigger3>();
            unlock4.Unlock();
        }
    }

    // Use this for initialization
    void Start () {
   
    }
	
	// Update is called once per frame
	void Update () {
      
    }

}

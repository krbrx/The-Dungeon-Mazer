using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour {
    private void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.gameObject.CompareTag("Player"))
        {
            PlayerStatus health = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatus>();
            health.Heal();
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
    }
}

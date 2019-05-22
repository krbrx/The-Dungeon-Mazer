using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoHealing : MonoBehaviour {
    public Text hintTxt;
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            PlayerStatus health = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatus>();
            health.AddHeal();
            hintTxt.text = "Auto-Healing Ability Active";
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

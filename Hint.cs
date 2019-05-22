using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour {
    public Text hintTxt;
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            hintTxt.text = "There is a puzzle ahead, to solve it." +
                " Guess the meaning for the following texts: "+" --.. "+", ...- "+", ...... "+", --- "
                ;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

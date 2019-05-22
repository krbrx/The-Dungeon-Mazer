using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNav : MonoBehaviour {

    public void LoadGame()
    {
        Debug.Log("test1");
        SceneManager.LoadScene("asg01-outdoor-wip");
    }

    public void Home()
    {
        Debug.Log("home");
        SceneManager.LoadScene("asg01-start-page-wip");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

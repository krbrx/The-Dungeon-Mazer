using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger4 : MonoBehaviour {
    public float speed = 5f;
    public Transform door;

    private bool openDoor = false;

    public bool key = false;

    public float openSpeed = 5f;
    public Vector3 openedPosition = new Vector3(0f, 2f, -0.32f);
    public Vector3 closedPosition = new Vector3(0f, 0.0f, -0.32f);
    

    public void CloseDoor()
    {
        openDoor = false;
    }

    public void OpenDoor()
    {
        openDoor = true;
    }


    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            OpenDoor();
        }
    }

    private void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            CloseDoor();
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (openDoor)
        {
            door.position = Vector3.Lerp(door.position, openedPosition, Time.deltaTime * openSpeed);
            SceneManager.LoadScene("asg01-outdoor-wip");
        }
        else
        {
            door.position = Vector3.Lerp(door.position, closedPosition, Time.deltaTime * openSpeed);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour {
    public float speed = 5f;
    public Transform celling;

    private bool cellingFalling = false;

    public float openSpeed = 5f;
    public Vector3 cellingTopPosition = new Vector3(9.6f, 3.2f, 38.55f);
    public Vector3 cellingBottomPosition = new Vector3(9.6f, 0f, 38.55f);


    public void CellingNotFalling()
    {
        cellingFalling = false;
    }

    public void CellingFalling()
    {
        cellingFalling = true;
    }


    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            CellingFalling();
        }
    }

    private void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            CellingNotFalling();
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cellingFalling)
        {
            celling.position = Vector3.Lerp(celling.position, cellingBottomPosition, Time.deltaTime * openSpeed);
        }
        else
        {
            celling.position = Vector3.Lerp(celling.position, cellingTopPosition, Time.deltaTime * openSpeed);
        }
    }
}

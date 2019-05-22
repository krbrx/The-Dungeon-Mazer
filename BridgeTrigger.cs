using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTrigger : MonoBehaviour {
    public float speed = 5f;
    public Transform bridge;

    private bool bridgeFall = false;

    public float openSpeed = 5f;
    public Vector3 bridgeTopPosition = new Vector3(9.6f, 3.6f, 41.75f);
    public Vector3 bridgeBottomPosition = new Vector3(9.6f, 0f, 41.75f);


    public void BridgeFalling()
    {
        bridgeFall = false;
    }

    public void BridgeNotFalling()
    {
        bridgeFall = true;
    }


    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            BridgeFalling();
        }
    }

    private void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            BridgeNotFalling();
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bridgeFall)
        {
            bridge.position = Vector3.Lerp(bridge.position, bridgeBottomPosition, Time.deltaTime * openSpeed);
        }
        else
        {
            bridge.position = Vector3.Lerp(bridge.position, bridgeTopPosition, Time.deltaTime * openSpeed);
        }
    }
}

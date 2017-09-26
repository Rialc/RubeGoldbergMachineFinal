using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger hit you dumb bitch");
        Destroy(other.gameObject);
    }
    private void OnTriggerStay(Collider other)
    {


    }
    private void OnTriggerExit(Collider other)
    {

    }
}

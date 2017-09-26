using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameratrigger : MonoBehaviour {
    public Transform look, move;
    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
       
        cameracontrol cam = Camera.main.GetComponent<cameracontrol>();
        cam.lookAtTarget = look;
        cam.moveToTarget = move;

    }
    //debug lines
    private void OnDrawGizmos()
    {
        if (look != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, look.position);

        }
        if (move != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, move.position);

        }
    }
}

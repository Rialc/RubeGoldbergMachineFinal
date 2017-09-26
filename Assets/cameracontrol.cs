using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour {

    //
    public Transform lookAtTarget, moveToTarget;

   

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (lookAtTarget != null)
        {
            //calculate the rotation needed 
            Quaternion neededRotation = Quaternion.LookRotation(lookAtTarget.position - transform.position);
            
            //use spherical interpollation over time 
            transform.rotation = Quaternion.Slerp(transform.rotation, neededRotation, .025f);
            //transform.LookAt(lookAtTarget);//Should normalize you
           // transform.rotation = Quaternion.RotateTowards(transform.rotation, lookAtTarget.rotation, 1);
        }
        if (moveToTarget != null)
        {
            //Vector3 moveDirection = moveToTarget.position - transform.position;
            transform.position = Vector3.MoveTowards(transform.position, moveToTarget.position, .025f);//Anything they can do I can do in one line;
        }
    }
    //debug lines
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideRotate : MonoBehaviour {
    bool rotate = false;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            //Debug.Log(this.GetComponentInParent<Transform>().eulerAngles);
            if ((this.GetComponentInParent<Transform>().eulerAngles.z < 10.6 || (this.GetComponentInParent<Transform>().eulerAngles.z > 300)))
            {
                this.GetComponentInParent<Transform>().eulerAngles += new Vector3(0, 0, .1f);
            }
            if ((this.GetComponentInParent<Transform>().eulerAngles.x < 7 || (this.GetComponentInParent<Transform>().eulerAngles.x > 300)))
            {
                this.GetComponentInParent<Transform>().eulerAngles += new Vector3(.1f, 0, 0);
            }
        }
    }
    //void onCollisionEnter(Collider col)
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "launchedSphere")
        {
            Debug.Log("let the rotation commence comrade!");
            rotate = true;
        
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {
     public bool move = false;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponentInParent<Transform>().position.y < 12 && move)
        {
            this.GetComponentInParent<Transform>().position += new Vector3(0, .1f, 0);
        }
        if (this.GetComponentInParent<Transform>().position.y >= 12 && move)
        {
            this.GetComponentInParent<Transform>().eulerAngles += new Vector3(0, 0,.2f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        move = true;
    }
}

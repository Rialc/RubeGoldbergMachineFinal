using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDestroys : MonoBehaviour {
    public UnityEngine.UI.Text text;
    // Use this for initialization
    void Start () {
        text.text = "Press Space to begin";
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            text.text = "";
            Destroy(this.gameObject);
        }
	}
}

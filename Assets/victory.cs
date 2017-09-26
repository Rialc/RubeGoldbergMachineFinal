using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour {
    public UnityEngine.UI.Text text;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        text.text = "You win!";
    }
}

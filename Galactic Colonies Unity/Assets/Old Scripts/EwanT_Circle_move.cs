using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EwanT_Circle_move : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, 1, 0);
        transform.Translate(0.1f, 0, 0);
	}
}

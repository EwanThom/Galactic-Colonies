using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EwanT_Wiggle_Move : MonoBehaviour {

    public bool rotate_bool; 
	// Use this for initialization
	void Start ()
    {
        rotate_bool = true;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (rotate_bool == true)
        {
            rotate_bool = false;
        }
        else
        {
            rotate_bool = true;
        }

        if (rotate_bool == true)
        {
            transform.Rotate(0, 1, 0);
            transform.Translate(0.1f, 0, 0);
        }
        else
        {
            transform.Rotate(0, -1, 0);
            transform.Translate(0.1f, 0, 0);
        }
    }
}

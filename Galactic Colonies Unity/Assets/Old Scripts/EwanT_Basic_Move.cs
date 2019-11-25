using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EwanT_Basic_Move : MonoBehaviour {

    public float fl_MovementSpeed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyUp("h"))
        {
            transform.Translate(0, fl_MovementSpeed, 0);
        }

        if(Input.GetKeyUp("g"))
        {
            transform.Translate(0, -fl_MovementSpeed, 0);
        }

        if (Input.GetKeyUp("l"))
        {
            transform.Translate(fl_MovementSpeed, 0, 0);
        }

        if (Input.GetKeyUp("j"))
        {
            transform.Translate(-fl_MovementSpeed, 0, 0);
        }

        if (Input.GetKeyUp("i"))
        {
            transform.Translate(0, 0, fl_MovementSpeed);
        }

        if (Input.GetKeyUp("k"))
        {
            transform.Translate(0, 0, -fl_MovementSpeed);
        }
    }
}

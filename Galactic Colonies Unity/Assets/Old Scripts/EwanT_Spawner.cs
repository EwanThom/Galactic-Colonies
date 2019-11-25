using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EwanT_Spawner : MonoBehaviour {

    public int int_numberOfTimes = 1;
    public bool bl_infinite = true;
    public float fl_timeBetween = 1f;
    public GameObject go_spawnee;

    private float fl_nextTime;
    private int int_countSoFar = 0;

	// Use this for initialization
	void Start ()
    {
        fl_nextTime = Time.time;	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(go_spawnee != null)
        {
            if(fl_nextTime<Time.time)
            {
                if(bl_infinite || int_countSoFar < int_numberOfTimes)
                {
                    Instantiate(go_spawnee, transform.position, transform.rotation);
                    int_countSoFar++;
                    fl_nextTime = Time.time + fl_timeBetween;
                }
            }
        }
	}
}

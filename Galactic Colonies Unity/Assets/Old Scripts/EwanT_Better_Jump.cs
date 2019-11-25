using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EwanT_Better_Jump : MonoBehaviour {

    public float fallMultiplier = 2.5f;
    public float lowJumpMultipler = 2f;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
		if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton ("Jump"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultipler - 1) * Time.deltaTime;
        }
	}
}

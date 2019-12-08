using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource2Add : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;
    private float timer;
    public bool GainTrue = false;

    // Start is called before the first frame update
    void Start()
    {
        gMScript = GameMaster.GetComponent<gameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            if (GainTrue == true)
            {
                gMScript.resource2 = gMScript.resource2 + (1 * gMScript.popModAdd);
                timer = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ResourceGain")
        {
            GainTrue = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "ResourceGain")
        {
            GainTrue = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource3Add : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;
    private float timer;
    public bool BoostTrue;


    // Start is called before the first frame update
    void Start()
    {
        gMScript = GameMaster.GetComponent<gameMaster>();
        BoostTrue = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer > 1f)
        {
            gMScript.resource3 = gMScript.resource3 + 10;
            if (BoostTrue == true)
            {
                gMScript.resource3 = gMScript.resource3 + 100;
            }
            timer = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "ResourceBoost")
        {
            BoostTrue = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "ResourceBoost")
        {
            BoostTrue = false;
        }
    }
}

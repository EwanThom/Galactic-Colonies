using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource1Add : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;

    void awake()
    {
        if (GameMaster != null)
        {
            gMScript = GameMaster.GetComponent<gameMaster>();
        }
        else
        {
            print("No Object");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gMScript = GameMaster.GetComponent<gameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gMScript != null)
        {
            gMScript.resource1 = gMScript.resource1 + 1;
        }
        else
        {
            print("No GM");
            //gMScript = GameMaster.GetComponent<gameMaster>();
        }
    }
}

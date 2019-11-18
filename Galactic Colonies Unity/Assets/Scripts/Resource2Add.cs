using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource2Add : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;


    // Start is called before the first frame update
    void Start()
    {
        gMScript = GameMaster.GetComponent<gameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        gMScript.resource2 = gMScript.resource2 + 1;
    }
}

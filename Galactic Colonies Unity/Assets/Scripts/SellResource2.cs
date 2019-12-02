using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellResource2 : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;

    private void Start()
    {
        gMScript = GameMaster.GetComponent<gameMaster>();
    }

    public void SellR2()
    {
        if (gMScript.resource2 >= 100)
        {
            gMScript.resource1 = gMScript.resource1 + 100;
            gMScript.resource2 = gMScript.resource2 - 100;
        }
    }
}

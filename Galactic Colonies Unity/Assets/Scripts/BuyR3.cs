using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyR3 : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;

    private void Start()
    {
        gMScript = GameMaster.GetComponent<gameMaster>();
    }

    public void BuyResource3()
    {
        if (gMScript.resource1 >= 100)
        {
            gMScript.resource1 = gMScript.resource1 - 100;
            gMScript.resource3 = gMScript.resource3 + 50;
        }
    }
}

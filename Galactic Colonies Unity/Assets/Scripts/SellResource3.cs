using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellResource3 : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;

    private void Start()
    {
        gMScript = GameMaster.GetComponent<gameMaster>();
    }

    public void SellR2()
    {
        if (gMScript.resource3 >= 100)
        {
            gMScript.resource1 = gMScript.resource1 + 200;
            gMScript.resource3 = gMScript.resource3 - 100;
        }
    }
}

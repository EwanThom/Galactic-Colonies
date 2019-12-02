using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource1Add : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;
    private float timer;

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
            gMScript.resource1 = gMScript.resource1 + 5;
            timer = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{
    public int resource1;
    public int resource2;
    public int resource3;
    private float timer;

    public Text resource1Text;
    public Text resource2Text;
    public Text resource3Text;
    // Start is called before the first frame update
    void Start()
    {
        resource1 = 0;
        resource2 = 200;
        resource3 = 200;
        SetCountText1();
        SetCountText2();
        SetCountText3();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        SetCountText1();
        SetCountText2();
        SetCountText3();
        if (timer > 10)
        {
            resource1 = resource1 + 1;
            resource2 = resource2 + 1;
            resource3 = resource3 + 1;
            timer = 0;
        }

    }

    void SetCountText1()
    {
        resource1Text.text = "Resource 1 = " + resource1.ToString();
    }
    void SetCountText2()
    {
        resource2Text.text = "Resource 2 = " + resource2.ToString();
    }
    void SetCountText3()
    {
        resource3Text.text = "Resource 3 = " + resource3.ToString();
    }
}

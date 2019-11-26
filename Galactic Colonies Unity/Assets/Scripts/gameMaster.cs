using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{
    public int resource1;
    public int resource2;
    public int resource3;

    public Text resource1Text;
    public Text resource2Text;
    public Text resource3Text;
    // Start is called before the first frame update
    void Start()
    {
        resource1 = 0;
        resource2 = 0;
        resource3 = 0;
        SetCountText1();
        SetCountText2();
        SetCountText3();
    }

    // Update is called once per frame
    void Update()
    {
        resource1 = resource1 + 1;
        resource2 = resource2 + 2;
        //resource3 = resource3 + 3;
        SetCountText1();
        SetCountText2();
        SetCountText3();
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

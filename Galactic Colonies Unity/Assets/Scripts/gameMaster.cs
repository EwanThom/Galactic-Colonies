using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour
{
    public int resource1;
    // Start is called before the first frame update
    void Start()
    {
        resource1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
       // resource1 = resource1 + 1;
        print (resource1);
    }
}

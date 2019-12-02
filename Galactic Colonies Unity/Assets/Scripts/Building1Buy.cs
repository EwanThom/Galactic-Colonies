using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building1Buy : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;
    private float startposX;
    private float startposY;
    private bool isClicked = false;
    private bool canBuy = false;
    public GameObject Building1;
    // Start is called before the first frame update
    void Start()
    {
        gMScript = GameMaster.GetComponent<gameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked == true)
        {
            if (canBuy == true)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                gMScript.resource2 = gMScript.resource2 - 100;
                GameObject.Instantiate(Building1, new Vector3 (8, 2, 0), Quaternion.identity);
                canBuy = false;
            }
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            isClicked = true;
            if(gMScript.resource2 >= 100)
            {
                canBuy = true;
            }

        }
    }

    private void OnMouseUp()
    {
        isClicked = false;
    }
}

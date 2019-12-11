using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDrag : MonoBehaviour
{
    private float startposX;
    private float startposY;
    private bool isBeingHeld = false;
    private bool canPickUp = true;



    void Update()
    {
        if (isBeingHeld == true)
        {
            if(canPickUp == true)
            { 
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, -10);
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }

    private void OnMouseDown()
    {
        print("IM CLICKIGN SHTISDBDFKJ");
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            
            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
        canPickUp = false;
        print("mouse released");
        GetComponent<BoxCollider2D>().enabled = true;
    }


/*
//#if UNITY_ANDROID
        void Update()
    {
        if (isBeingHeld == true)
        {
            if(canPickUp == true)
            { 
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
            }
        }
    }

    private void OnMouseDown()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                isBeingHeld = true;
            }
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
        canPickUp = false;
    }

//#endif */
}

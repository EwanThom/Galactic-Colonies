﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBuy : MonoBehaviour
{
    private float startposX;
    private float startposY;
    private bool isBeingHeld = false;
    private bool canPickUp = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isBeingHeld == true)
        {
            if (canPickUp == true)
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
    }
}

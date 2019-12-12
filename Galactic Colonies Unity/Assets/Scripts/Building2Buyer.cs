using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building2Buyer : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;
    private float startposX;
    private float startposY;
    public float price;
    private bool isClicked = false;
    private bool canBuy = false;
    public GameObject Building2;
    public Text priceText;
    // Start is called before the first frame update
    void Start()
    {
        gMScript = GameMaster.GetComponent<gameMaster>();
        SetPriceText();
        price = 100;
    }

    // Update is called once per frame
    void Update()
    {
        SetPriceText();
        if (isClicked == true)
        {
            if (canBuy == true)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                gMScript.resource1 = gMScript.resource1 - price;
                GameObject.Instantiate(Building2, new Vector3(8, -1, -10), Quaternion.identity);
                price = price + (price / 100 * 10);
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
            if (gMScript.resource1 >= price)
            {
                canBuy = true;
            }

        }
    }

    private void OnMouseUp()
    {
        isClicked = false;
    }

    void SetPriceText()
    {
        priceText.text = "Costs :" + price.ToString() + "C";
    }
}

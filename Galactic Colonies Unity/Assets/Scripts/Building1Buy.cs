using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building1Buy : MonoBehaviour
{
    public GameObject GameMaster;
    private gameMaster gMScript;
    private float startposX;
    private float startposY;
    private bool isClicked = false;
    private bool canBuy = false;
    public float price;
    public GameObject Building1;
    public Text PriceText;
    // Start is called before the first frame update
    void Start()
    {
        gMScript = GameMaster.GetComponent<gameMaster>();
        price = 100;
        SetPriceText();
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
                GameObject.Instantiate(Building1, new Vector3 (8, 2, -10), Quaternion.identity);
                price = price + (price / 100 * 10);
                print(price);
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
            if(gMScript.resource1 >= price)
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
        PriceText.text = "Costs :" + price.ToString() + "C";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{
    public float resource1;
    public float resource2;
    public float resource3;
    public float population;
    public float popMod;
    public float popModAdd;
    public bool popAdd;
    public bool popDown;
    public bool popModTrue;
    private float timer;
    private float timer2;
    private float timer3;

    public Text resource1Text;
    public Text resource2Text;
    public Text resource3Text;
    public Text populationText;
    // Start is called before the first frame update
    void Start()
    {
        resource1 = 0;
        resource2 = 200;
        resource3 = 200;
        population = 20;
        popAdd = false;
        popDown = false;
        popModTrue = false;
        SetCountText1();
        SetCountText2();
        SetCountText3();
        SetCountText4();
        timer = 0;
        timer2 = 0;
        timer3 = 0;
        popMod = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;
        popMod = population / 100 * 5;
        print(popMod);

        if(popMod < 1)
        {
            popModTrue = false;
        }
        else
        {
           popModTrue = true; 
        }
        if(popModTrue == true)
        {
            popModAdd = popMod;
        }
        else
        {
            popModAdd = 1;
        }
        if (timer > 10)
        {
            resource2 = resource2 + 1;
            timer = 0;
        }
        if(timer3 > 1)
        {
            SetCountText1();
            SetCountText2();
            SetCountText3();
            SetCountText4();
            resource1 = resource1 + 1;
            timer3 = 0;
        }
        if(population <= resource2 / 10)
        {
            popAdd = true;
        }
        else
        {
            popAdd = false;
        }
        if(population > (resource2 / 10) + 10)
        {
            popDown = true;
        }
        else
        {
            popDown = false;
        }
        if(popAdd == true)
        {
            if (timer2 > 30)
            {
                population = population + 1;
                timer2 = 0;
            }
        }
        if(popDown == true)
        {
            if(timer2 > 60)
            {
                population = population - 1;
                timer2 = 0;
            }
        }
    }

    void SetCountText1()
    {
        resource1Text.text = "Credits = " + resource1.ToString();
    }
    void SetCountText2()
    {
        resource2Text.text = "Food = " + resource2.ToString();
    }
    void SetCountText3()
    {
        resource3Text.text = "Minerals = " + resource3.ToString();
    }
    void SetCountText4()
    {
        populationText.text = "Population = " + population.ToString();
    }
}

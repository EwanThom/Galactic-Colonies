using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EwanT_TriggerWithActivate : MonoBehaviour {

    public bool bl_activate = true;
    public GameObject objectToActivate;

    private EwanT_LevelManager currentLevelManager;

	// Use this for initialization
	void Start ()
    {
        GameObject go = GameObject.Find("LevelManager");
        currentLevelManager = go.GetComponent<EwanT_LevelManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {            
                if (bl_activate == false)
                {
                    objectToActivate.SetActive(true);
                    bl_activate = true;
                }
                else
                {
                    objectToActivate.SetActive(false);
                    bl_activate = false;
                }                       
        }
    }
}

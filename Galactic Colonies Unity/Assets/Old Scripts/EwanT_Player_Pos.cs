using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EwanT_Player_Pos : MonoBehaviour {

    private EwanT_LevelManager gm;

	// Use this for initialization
	void Start ()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<EwanT_LevelManager>();
        transform.position = gm.lastCheckPointPos;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EwanT_Colour_Changer : MonoBehaviour {

    private EwanT_LevelManager gm;
    public Material startMaterial;
    public Material endMaterial;
    public bool hasChanged = false;
    private AudioSource soundController;
    private Renderer _Renderer;

	// Use this for initialization
	void Start ()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<EwanT_LevelManager>();
        _Renderer = gameObject.GetComponent<Renderer>();
        _Renderer.material = startMaterial;
        soundController = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
        if(!hasChanged)
        {
            gm.lastCheckPointPos = transform.position;
            _Renderer.material = endMaterial;
            hasChanged = true;
            soundController.Play();
        }   
        }
       
    }
}

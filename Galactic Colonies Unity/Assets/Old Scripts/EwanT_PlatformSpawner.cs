using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EwanT_PlatformSpawner : MonoBehaviour {

    public GameObject objectToBeSpawned;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToBeSpawned.SetActive(true);
        }
    }
}

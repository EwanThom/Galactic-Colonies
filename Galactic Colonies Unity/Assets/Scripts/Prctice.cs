using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prctice : MonoBehaviour
{
    public bool characterInQuicksand;
    void OnTriggerEnter2D(Collider2D other)
    {
        characterInQuicksand = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour
{
    public float dragSpeed = 2;
    private Vector3 dragOrigin;


#if UNITY_EDITOR_WIN
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);

        transform.Translate(move, Space.World);
    }
#endif

 /*
#if UNITY_ANDROID
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            Vector3 nPos;
            if (touch.phase == TouchPhase.Began)
            {
                dragOrigin = new Vector3(touch.position.x, touch.position.y, 0);
            }

            if (touch.phase == TouchPhase.Moved)
            {
                nPos = new Vector3(touch.position.x, touch.position.y, 0);
                Vector3 pos = Camera.main.ScreenToViewportPoint(nPos - dragOrigin);
                Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);

                transform.Translate(move, Space.World);
            }
        }
    }
#endif*/

}
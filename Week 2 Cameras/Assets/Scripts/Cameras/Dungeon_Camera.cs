using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dungeon_Camera : MonoBehaviour
{
    public bool retroOrtho = false;
    public Camera thisCamera;
    public GameObject target;
    Vector3 offset;
   
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        transform.position = desiredPosition;
        transform.LookAt(target.transform.position);

        if (retroOrtho)
        {
            thisCamera.orthographic = true;
        }
        else
        {
            thisCamera.orthographic = false;
        }
    }
}

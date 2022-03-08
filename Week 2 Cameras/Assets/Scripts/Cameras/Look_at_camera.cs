using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_at_camera : MonoBehaviour
{
    public GameObject target;
    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }
}

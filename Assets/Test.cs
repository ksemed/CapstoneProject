using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void OnCollisionEnter (Collision collision)
    {
        Debug.Log("touched");
    }

    void OnCollisionExit (Collision collision)
    {
        Debug.Log("untouched");
    }
}

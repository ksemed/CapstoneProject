using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Find the middle vector of list of components
        GameObject bottom = GameObject.Find("Middle of Bottom");
        Transform bottomTransform = bottom.transform;
        Vector3 bposition = bottomTransform.position; 

        foreach (Transform child in transform)
        {
            // Vector of specific component
           Vector3 Object = child.position;
           //Debug.Log(bposition.ToString());
           Debug.Log(Object.ToString());
           // Vector Representing Proper Direction
           Vector3 Direction = Object - bposition;
           //Debug.Log(Direction.ToString());
           Direction = Direction * 100;
           //Debug.Log(Direction.ToString());
           child.position += Direction * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

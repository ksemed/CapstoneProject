using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    bool CollisionConfirmation = false;

    public void CollisionDetected(ChildCollision childScript)
    {
        Debug.Log("child collided");
    }

    // Start is called before the first frame update
    void Start()
    {
        // Find the middle vector of list of components
        GameObject bottom = GameObject.Find("Middle of Bottom");
        Transform bottomTransform = bottom.transform;
        Vector3 bposition = bottomTransform.position; 

        Vector3[] positionArray = new Vector3[11];
        int i = 0;
        GameObject Positions = GameObject.Find("Positions");
        // Storing all positions of Objects in array
        foreach (Transform child in Positions.transform)
        {
            positionArray[i] = child.position;
            i++;    
        }

        i = 0;

        foreach (Transform child in transform)
        {
            // Vector of specific component
           Vector3 Object = positionArray[i];
           // Vector Representing Proper Direction
           Vector3 Direction = Object - bposition;
           Direction = Direction * 10;
            while(CollisionConfirmation == true) {
                child.position += Direction * Time.deltaTime;
            }
           i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// Code for amount for later
/*
while(CollisionConfirmation == true) {
    child.position += Direction * Time.deltaTime;
}

*/

// Code for undoing explosion
/*
i = 0;
if sphere is touched:
    foreach(Transform child in transform)
    {
        child.position == positionArray[i];
        i++;
    }
*/


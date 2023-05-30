using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion2Seat : MonoBehaviour
{
    int i = 0;
    Vector3 Direction;
    Vector3 startPos;
    
    public void OnTriggerStay(Collider c)
    {
        // Used to determine if Explosion is activated by user
        GameObject confirm = GameObject.Find("ExplodingConfirmationSeat");
        
        // Find position of colliding object
        GameObject collidingobject = GameObject.Find(c.name);
        Transform collidingTransform = collidingobject.transform;
        Vector3 cposition = collidingTransform.position;

        // Finding position of object being collided with
        string objectname = gameObject.name; // Game Object that this script is attached to   
        GameObject theobject = GameObject.Find(objectname);
        Transform objectTransform = theobject.transform;
        Vector3 oposition = objectTransform.position; 

        // First collision (we want to set up middle vector and direction once)
        if(i == 0) {
            // Find the middle vector of list of components
            GameObject middle = GameObject.Find("BottomSphereLocationSeat");
            Transform middleTransform = middle.transform;
            Vector3 mposition = middleTransform.position; 

            // Vector Representing Proper Direction and Magnitude
            Direction = oposition - mposition;
            Direction = Direction * 15;
            transform.position += Direction * Time.deltaTime;
        }

        // If...
        // User selects Harvester
        // The object is farther out than the colliding object (so it doesn't move to infinity) 
        // It's not the first collision object has gone through
        if(confirm && (cposition.magnitude <= oposition.magnitude) && i > 0) {
                transform.position += Direction * Time.deltaTime;
        }

        i++;
    }
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position; // Logs the original position
    }

    // Update is called once per frame
    void Update()
    {        
        // Determines if the confirmation is turned back off
        GameObject confirm2 = GameObject.Find("ExplodingConfirmationSeat");

        // If confirmation is turned off (user selects sphere to return it back to original position)
        if(confirm2 == null) {
            this.transform.position = startPos; // Use preloaded position to send everything back
        }

    }
}

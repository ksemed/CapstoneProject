using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion2 : MonoBehaviour
{

    int i = 0;
    Vector3 Direction;
    Vector3 startPos;
    
    public void OnTriggerStay(Collider c)
    {
        GameObject confirm = GameObject.Find("Exploding Confirmation");
        
        GameObject collidingobject = GameObject.Find(c.name);
        Transform collidingTransform = collidingobject.transform;
        Vector3 cposition = collidingTransform.position;

        string objectname = gameObject.name;    
        GameObject theobject = GameObject.Find(objectname);
        Transform objectTransform = theobject.transform;
        Vector3 oposition = objectTransform.position; 

        if(confirm && (cposition.magnitude <= oposition.magnitude)) {
            if(i == 0) {
                // Find the middle vector of list of components
                GameObject middle = GameObject.Find("Middle of Bottom");
                Transform middleTransform = middle.transform;
                Vector3 mposition = middleTransform.position; 

                // Vector Representing Proper Direction
                Direction = oposition - mposition;
                Direction = Direction * 2;
                transform.position += Direction * Time.deltaTime;

            }
            if(i > 0){
                transform.position += Direction * Time.deltaTime;
            }

            i++;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {        
        GameObject confirm2 = GameObject.Find("Exploding Confirmation");

        if(confirm2 == null) {
            this.transform.position = startPos;
        }

    }
}


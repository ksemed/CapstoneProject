using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{

    int i = 0;
    Vector3 Direction;
    Vector3 startPos;
    
    public void OnTriggerStay(Collider c)
    {
        GameObject confirm = GameObject.Find("CollisionConfirmation");
        if(confirm) {
            if(i == 0) {
                // Find the middle vector of list of components
                GameObject middle = GameObject.Find("MiddleCube");
                Transform middleTransform = middle.transform;
                Vector3 mposition = middleTransform.position; 

                string objectname = gameObject.name;    
                GameObject cube = GameObject.Find(objectname);
                Transform cubeTransform = cube.transform;
                Vector3 cposition = cubeTransform.position; 

                // Vector Representing Proper Direction
                Direction = cposition - mposition;
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
        GameObject confirm2 = GameObject.Find("CollisionConfirmation");

        if(confirm2 == null) {
            this.transform.position = startPos;
        }

    }
}

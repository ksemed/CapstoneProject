using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion2 : MonoBehaviour
{
    [SerializeField] Vector3 Position;

    public void OnTriggerEnter(Collider c)
    {
        GameObject confirmation = GameObject.Find("Exploding Confirmation");
        
        // Find the middle vector of list of components
        GameObject bottom = GameObject.Find("Middle of Bottom");
        Transform bottomTransform = bottom.transform;
        Vector3 bposition = bottomTransform.position; 

        // Vector Representing Proper Direction
        Vector3 Direction = Position - bposition;
        Direction = Direction * 2;
        transform.position += Direction * Time.deltaTime;
    }

    public void OnTriggerExit(Collider c2)
    {

    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}


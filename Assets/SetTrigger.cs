using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Collider[] ObjectCollider = GetComponents<Collider>();
        GameObject confirm = GameObject.Find("Exploding Confirmation");
/*
        if(confirm) {
            ObjectCollider[1].isTrigger = false;
        } 
        else if (!confirm) {
            ObjectCollider[1].isTrigger = true;
        }
*/
        ObjectCollider[0].isTrigger = false;       
    }
}

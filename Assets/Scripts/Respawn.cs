using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Respawn")
        {
            transform.position = new Vector3(0, 3, 0);
        }
    }
}

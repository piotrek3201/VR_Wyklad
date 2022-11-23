using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidBody;
    [SerializeField] Vector3 myVector;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        //myVector = new Vector3(10.0f, 0.0f, 10.0f);
    }

    // Update is called once per frame  
    void Update()
    {
        Vector3 v = Input.acceleration;
        v = Quaternion.Euler(90, 0, 0) * v;
        v = Vector3.Scale(v, myVector);

        rigidBody.AddForce(v);

        Debug.Log(v);
    }
}

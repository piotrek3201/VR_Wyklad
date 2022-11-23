using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidBody;
    [SerializeField] float speed = 2000.0f;
    private Vector3 myVector;
    void Start()
    {
        speed *= Time.deltaTime;
        rigidBody = GetComponent<Rigidbody>();
        myVector = new Vector3(speed, 0.0f, speed);
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

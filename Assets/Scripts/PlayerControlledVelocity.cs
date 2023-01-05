using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlledVelocity : MonoBehaviour
{

    [SerializeField]
    Vector3 horizontalForce;

    [SerializeField]
    Vector3 verticalForce;

    [SerializeField]
    KeyCode keyHorizontalPlus;
    [SerializeField]
    KeyCode keyHorizontalNegative;
    [SerializeField]
    KeyCode keyVerticalPlus;
    [SerializeField]
    KeyCode keyVerticalNegative;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(keyHorizontalPlus))
            GetComponent<Rigidbody>().velocity += horizontalForce;

        if(Input.GetKey(keyHorizontalNegative))
            GetComponent<Rigidbody>().velocity -= horizontalForce;

        if(Input.GetKey(keyVerticalPlus))
            GetComponent<Rigidbody>().velocity += verticalForce;
        
        if(Input.GetKey(keyVerticalNegative))
            GetComponent<Rigidbody>().velocity -= verticalForce;


    }
}

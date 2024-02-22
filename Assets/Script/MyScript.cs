using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public float speed = 10.0f; //speed วัตถุ
    private Rigidbody rb;
    public Vector3 movement;

    void Start()
    {
        //Debug.Log("Starting Running");
        rb = GetComponent<Rigidbody>();
    }

    /*private void Awake()
    {
        Debug.Log("Awake Running");
    }*/

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update Running");

        //รับค่าจาก Keyboard
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");
        float z = Input.GetAxis("Vertical");

        movement = new Vector3(x, y, z);
    }

    /*private void FixedUpdate(){
        Debug.Log("FixedUpdate Running");
    }*/
}

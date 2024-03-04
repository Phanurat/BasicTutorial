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

        //ทำงานกับ Mouse ซ้าย
        /*if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0f,1f*speed,0f);//0 => 10
        }
        //ทำงานกับ Mouse ขวา
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0f,-1f*speed,0f);
        }
        //ทำงานกับ Mouse กลาง
        if (Input.GetMouseButtonDown(2))
        {
            transform.Rotate(-1f*speed,0f,0f);
        }*/

    }

    private void FixedUpdate(){
        //Debug.Log("FixedUpdate Running");

        //movePlayer(movement);
    }

    void movePlayer(Vector3 direction){
        //rb.velocity = (direction * speed);
        rb.MovePosition(transform.position+(direction * speed * Time.deltaTime));
        //rb.AddForce(direction * speed);
    }
}

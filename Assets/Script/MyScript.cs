using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting Running");
    }

    private void Awake()
    {
        Debug.Log("Awake Running");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update Running");
    }

    private void FixedUpdate(){
        Debug.Log("FixedUpdate Running");
    }
}

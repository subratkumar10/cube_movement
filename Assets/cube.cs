﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0f, Input.GetAxis("Vertical") * Time.deltaTime, 0f) ;
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Input.GetAxis("Vertical"));
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 
    }
}

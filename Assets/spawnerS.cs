﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerS : MonoBehaviour
{
    public GameObject pref;
    public float force;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject buffer = Instantiate<GameObject>(pref);
            buffer.transform.position = gameObject.transform.position;
            buffer.transform.rotation = gameObject.transform.rotation;
            buffer.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward.normalized * force);
        }
    }
}

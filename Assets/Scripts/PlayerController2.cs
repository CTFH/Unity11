﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private CharacterController cc;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal"));
        
        //cc.Move(transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * 5.0f);
        
        cc.SimpleMove(transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * 120.0f);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);//左右キー
        transform.Translate(0, 0, Input.GetAxis("Vertical") * 5.0f * Time.deltaTime);
        //上下キー
    }
}

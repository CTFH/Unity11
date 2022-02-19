using System.Collections;
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
        
        //simpleMoveにすると移動量が減るので掛け算の値を増やす
        cc.SimpleMove(transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * 120.0f);
    }
    //棒をすり抜けるのはTranslateで移動してるから　
    //rigidbodyつけたらFloor外にでたら落ちる
    //Moveだと重力ない
    //SimpleMoveだと重力あるので落ちる　ジャンプできない
    //CharacterControllerつけたらTranslateで動かさない
    //CharacterControllerつけたらMoveかSimpleMoveで動かす
}

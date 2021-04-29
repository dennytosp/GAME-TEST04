﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{// Start is called before the first frame update
    public Animator ani;

    void Start()
    {
        ani = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        //Phải
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime * 2, 0, 0);
            ani.SetBool("set_move", false);
            ani.Play("player_move");
            //Quay đầu
            transform.localScale = new Vector3(3.814139F, 3.814139F, 0);
        }
        //Trái
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime * 3, 0, 0);
            ani.SetBool("set_move", false);
            ani.Play("player_move");
            //Quay đầu
            transform.localScale = new Vector3(-3.814139F, 3.814139F, 0);
        }
        //Bay
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, Time.deltaTime * 10, 0);
            ani.SetBool("set_move", false);
            ani.Play("player_move");
        }

        //Bay qua phải
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime * 2, Time.deltaTime * 10, 0);
            ani.SetBool("set_move", false);
            ani.Play("player_move");
        }
        //Bay qua trái
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime * 2, Time.deltaTime * 10, 0);
            ani.SetBool("set_move", false);
            ani.Play("player_move");
        }
    }
}

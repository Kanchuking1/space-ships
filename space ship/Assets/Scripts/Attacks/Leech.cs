﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leech : MonoBehaviour
{
    public float leechAmount = 2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player script = collision.gameObject.GetComponent<player>();
            script.health -= (int)leechAmount;
            enemy leechBOI = gameObject.GetComponent<enemy>();
            leechBOI.follow = false;
            print("Health = " + script.health);

        }
    }
}


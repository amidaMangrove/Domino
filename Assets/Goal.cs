﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] GameObject goalEffect;
    public void OnTriggerEnter(Collider other)
    {
        Instantiate(goalEffect, new Vector3(0, -10, 10), Quaternion.Euler(-90.0f,0,0));

        Destroy(this.gameObject);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    Animator m_animator;

    void Start()
    {
        m_animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            m_animator.SetTrigger("Shoot");
        }
    }
}
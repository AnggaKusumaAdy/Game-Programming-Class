﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prajurit : Manusia
{
    void Start()
    {
        Debug.Log("Seorang Prajurit dapat melakukan: ");
        Makan();
        Tidur();
        Menyerang();
    }

    void Update()
    {

    }

    void Menyerang()
    {
        Debug.Log("Melakukan gerakan serangan");
    }
}



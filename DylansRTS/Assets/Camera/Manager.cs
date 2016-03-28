﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    private Building buildingClass;
    private Placement placement;
    private bool isClickable;

    void Start()
    {
        placement = GetComponent<Placement>();
        buildingClass = GetComponent<Building>();
        isClickable = true;
    }

    public void SetClickable(bool w)
    {
        isClickable = w;
    }

    void OnGUI()
    {
        for(int i = 0; i < +buildingClass.buildings.Length; i++)
        {
            if(GUI.Button(new Rect(50 * 2 * i, 100, 75, 30),
                          buildingClass.buildings[i].name) && isClickable)
            {
                isClickable = false;
                placement.SetItem(buildingClass.buildings[i]);
            }
        }
    }
}

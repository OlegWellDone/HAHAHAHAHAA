using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using System.Threading; 
using TMPro;

    //[SerializeField] 
public class CSButtonPress : MonoBehaviour
{

    public GameObject GOButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()        
    {

    }
    public void PressButton()
    {
        GOButton.transform.position= new Vector3(0,0,0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

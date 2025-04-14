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
    public float distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()        
    {

    }
    public void PressButton()
    {
        
        GOButton.transform.position = new Vector3( GOButton.transform.position.x - distance,GOButton.transform.position.y, GOButton.transform.position.z);
    }

    public void UnpressButton()
    {
        
        GOButton.transform.position = new Vector3( GOButton.transform.position.x + distance,GOButton.transform.position.y, GOButton.transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

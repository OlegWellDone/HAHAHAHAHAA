using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using System.Threading; 
using TMPro;
using System;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.XR.CoreUtils;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Attachment;
using UnityEngine.XR.Interaction.Toolkit.Gaze;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Transformers;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

public class WoodMove : MonoBehaviour
{
    private bool isMove ;
    public GameObject WoodPlanc;
    public GameObject WoodSoket;
    public GameObject Saw;


    //public static XRGrabInteractable WoodPlanco;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void moveWoodMOOVE()
    {
        
        CSSoketWood SokedWood = WoodSoket.GetComponent<CSSoketWood>();
        if (SokedWood.isWoodPlace == true)
        {
            isMove = true;
        } else
        {
            Debug.Log("ПРОЕБАЛИ Возможно");
        }
        Debug.Log(SokedWood.isWoodPlace);
    }

    public void dontmoveWoodSTOOP()
    {
        isMove = false;
    }
    void Start()
    {
        isMove = false;
        //WoodPlanc.GetComponent<XRGrabInteractable>().enabled = false;
        //XRGrabInteractable compWood = WoodPlanc.GetComponent<XRGrabInteractable>();
        //WoodPlanc.GetComponent<XRGrabInteractable> = !WoodPlanc.GetComponent<XRGrabInteractable>.enabled;
        //WoodPlanc.XRGrabInteractable.enabled = !WoodPlanc.XRGrabInteractable.enabled;
        //XRGrabInteractable lol = WoodPlanc.GetComponent<XRGrabInteractable>();
    }   
    
    public void isDeadTouch()
    {
        if(isMove)
        {
            Debug.Log("ПРОЕБАЛИ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isMove == true)
        {

            Saw.transform.Rotate(0,0,Time.frameCount);
            //Тут если поворот не в позиции смерть
            if (false )  
            {
                Debug.Log("ПРОЕБАЛИ");
                //Добавить частицы только тут
            }
            //!Надо настроить размер сокета и протестить
            Vector3 temp = new Vector3(-0.001f,0,0);
            WoodSoket.transform.position+=temp;
            if(WoodSoket.transform.position.x<-2.75)
            {
                    WoodSoket.transform.position = new Vector3(0.4828106f,WoodSoket.transform.position.y,WoodSoket.transform.position.z);
                    //Отпадает жопа(конц обработки бруса)
            }
        }
    }
}

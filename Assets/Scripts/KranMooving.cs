using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class KranMooving : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Kran;
    private Vector3 startPosition = new Vector3();
    private Vector3 endPosition = new Vector3();
    public Vector3[] positions = {new Vector3(), new Vector3()};
   public float speedKran;
    void Start()
    {
        startPosition = Kran.transform.position;
        endPosition = new Vector3(startPosition.x, startPosition.y, startPosition.z - 20f);


    }

    // Update is called once per frame
    void Update()
    {
        if (Kran.transform.position.z > endPosition.z){
        Kran.transform.position = new Vector3(startPosition.x, startPosition.y, Kran.transform.position.z + speedKran);
        }
       
    }


}

using UnityEngine;

public class CSSoketWood : MonoBehaviour
{
    public bool isWoodPlace;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        isWoodPlace = false;
    }

    public void WoodPlace()
    {
        isWoodPlace = true; 
    }

    public void WoodLeave()
    {
        isWoodPlace = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

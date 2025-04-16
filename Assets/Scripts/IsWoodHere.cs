using UnityEngine;

public class IsWoodHere : MonoBehaviour
{

    public bool WoodHere = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        WoodHere = true;
    }

    void OExit(Collider other)
    {
     WoodHere = false;   
    }
    public void woodHere(){
        WoodHere = true;
    }

    public void woodGone(){
        WoodHere = false;
    }
}

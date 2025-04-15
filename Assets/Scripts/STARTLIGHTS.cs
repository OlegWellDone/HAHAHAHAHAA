using UnityEngine;

public class STARTLIGHTS : MonoBehaviour
{

    public GameObject[] lights;
    public GameObject AnimKran;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightsOn(){
        for (int i = 0; i < lights.Length; i++){
            Light Lightstatus = lights[i].GetComponent<Light>();
            Lightstatus.enabled = true;
        }
    }

    public void LightsOff(){
        for (int i = 0; i < lights.Length; i++){
            Light Lightstatus = lights[i].GetComponent<Light>();
            Lightstatus.enabled = false;
        }
        
    }
}

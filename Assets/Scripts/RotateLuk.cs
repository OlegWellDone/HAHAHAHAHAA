using UnityEngine;

public class RotateLuk : MonoBehaviour
{

    public Transform lukTrans;

    public Transform defTrans;
    private float angleRotate = 5.0f;
    private Quaternion targetRot;
    private bool Rotating = false;
    private bool RotatingDef = false;

    public bool DefIsOn = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lukTrans.rotation = Quaternion.Euler(-90, 0, 0);
        targetRot = Quaternion.Euler(angleRotate, 0, 0);
        defTrans.rotation = Quaternion.Euler(90, -90, 90);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Rotating) {
            lukTrans.Rotate(3.0f * Time.deltaTime, 0, 0);
            if (lukTrans.rotation.x >= 0.0f){
                Rotating = false;
            }
        }

        if(RotatingDef) {
            defTrans.Rotate(0.0f, -180.0f, 0);
                DefIsOn = !DefIsOn;
                RotatingDef = false;
            
        }
    }

    public void OpenLuk(){
        
        Rotating = true;
    } 

    public void CloseDef(){
        
        RotatingDef = true;
    } 
}

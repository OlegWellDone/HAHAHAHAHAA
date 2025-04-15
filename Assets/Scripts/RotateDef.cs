using UnityEngine;

public class RotateDef : MonoBehaviour
{

    public Transform def;
    private float angleRotate = -90.0f;
    private Quaternion targetRot;
    private bool Rotating = false;

    public float rotateSpeed = -12.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        def.rotation = Quaternion.Euler(def.rotation.x, -90, 90);
        targetRot = Quaternion.Euler(angleRotate, -90, 90);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Rotating) {
            def.Rotate(rotateSpeed * Time.deltaTime, 0, 0);
            if (def.rotation.x <= targetRot.x){
                rotateSpeed = rotateSpeed * -1;
                Rotating = false;
                targetRot = Quaternion.Euler(targetRot.x * -1, -90, 90);
            }
        }
    }

    public void MoveDef(){
        Rotating = true;
    }
}

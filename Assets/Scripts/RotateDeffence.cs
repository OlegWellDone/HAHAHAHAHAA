using UnityEngine;

public class RotateDeffence : MonoBehaviour
{
    private bool isRotate;
    public GameObject Deffence;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isRotate = false;
    }
    public void checkRotate()
    {
        isRotate = true;
    }

    public void unCheckRotate()
    {
        isRotate = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isRotate)
        {
            Debug.Log(Deffence.transform.rotation);
            Deffence.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        
    }
}

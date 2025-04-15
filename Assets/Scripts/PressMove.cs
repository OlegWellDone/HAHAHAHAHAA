using UnityEngine;

public class PressMove : MonoBehaviour
{

    private float timer = 0;
    private float speed = 1f;
    private bool isPressMove;
    private Vector3 startPos;
    private Vector3 endtPos;
    public GameObject PressOBJ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = PressOBJ.transform.position;
        endtPos = new Vector3(PressOBJ.transform.position.x,PressOBJ.transform.position.y-0.4f,PressOBJ.transform.position.z);
        isPressMove = false;
    }

    public void MoveP()
    {

        isPressMove = true;
    }

    public void StopP()
    {
        isPressMove = false;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (isPressMove)
        {
            //percent = timer / seconds;
            //Vector3 temp = new Vector3(0,timer / seconds,0);
            //PressOBJ.transform.position = startPos+((startPos+endtPos)*timer/100f);
            PressOBJ.transform.position+= new Vector3(0,-0.001f,0);
        }
    }
}

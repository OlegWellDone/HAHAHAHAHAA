using UnityEngine;

public class MoveCraneStart : MonoBehaviour
{
    private bool isMove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMove = false;
    }

    public void startMove()
    {
        isMove = true;
    }

    public void stopMove()
    {
        isMove = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

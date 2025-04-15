using UnityEngine;
using EzySlice;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SliceObject : MonoBehaviour
{

    public Transform AttachPoint;
    public Material crossed;
    public Transform planeSaw;
    public GameObject target;
    private bool moveAttach = false;
    private Vector3 firstPos;
    public float speedMovin = -0.06f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveAttach){
            AttachPoint.position = new Vector3(speedMovin * Time.deltaTime, firstPos.y, firstPos.z);
            Debug.Log("Ты поэтому двигаешься!");
            if (AttachPoint.position.x <= -2.0f){
                Slice(target);
                AttachPoint.position = firstPos;
                moveAttach = false;
            }
        }
    }

public void StartSaw(){
    firstPos = new Vector3(AttachPoint.position.x, AttachPoint.position.y, AttachPoint.position.z);
    moveAttach = true;
}

    public void Slice (GameObject target){

        SlicedHull hull = target.Slice(planeSaw.position, planeSaw.forward);

        if(hull != null) {
            GameObject upperhull = hull.CreateUpperHull(target, crossed);
            SetUpSlicedComp(upperhull);
            GameObject lowerhull = hull.CreateLowerHull(target, crossed);
            SetUpSlicedComp(lowerhull);

            Destroy(target);
        }
        
        
    }

    public void SetUpSlicedComp(GameObject slicedObject){
        Rigidbody rb = slicedObject.AddComponent<Rigidbody>();
        MeshCollider collider = slicedObject.AddComponent<MeshCollider>();
        collider.convex = true;
        XRGrabInteractable XRGrab = slicedObject.AddComponent<XRGrabInteractable>();

    }

}

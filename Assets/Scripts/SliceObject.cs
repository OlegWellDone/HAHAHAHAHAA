using UnityEngine;
using EzySlice;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SliceObject : MonoBehaviour
{

    public Material crossed;
    public Transform planeSaw;
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame){
            Slice(target);
        }
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

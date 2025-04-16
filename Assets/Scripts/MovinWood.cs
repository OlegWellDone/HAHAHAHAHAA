using System.Numerics;
using UnityEngine;
using EzySlice;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class MovinWood : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    public GameObject wood;

    public Material crossedmaterial;

    public Transform Saw;
    bool Lesgo = false;

    public GameObject Socket;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Lesgo == true){
            wood.transform.position = new UnityEngine.Vector3(wood.transform.position.x - 0.2f,wood.transform.position.y,wood.transform.position.z);
            if(wood.transform.position.x <= -5.0f){
                Lesgo = false;
                Slicer();
                
            }
        }
    }

    public void MoviingWood(){
        if(Socket.GetComponent<IsWoodHere>().WoodHere == true){
            Slicer();
        }
    }

    public void Slicer(){
        SlicedHull hull = wood.Slice(Saw.position, Saw.forward);

        if(hull != null) {
            GameObject upperhull = hull.CreateUpperHull(wood, crossedmaterial);
            SetUpSlicedComp(upperhull);
            GameObject lowerhull = hull.CreateLowerHull(wood, crossedmaterial);
            SetUpSlicedComp(lowerhull);

            Destroy(wood);
        }
    }

    public void SetUpSlicedComp(GameObject slicedObject){
        Rigidbody rb = slicedObject.AddComponent<Rigidbody>();
        MeshCollider collider = slicedObject.AddComponent<MeshCollider>();
        collider.convex = true;
        XRGrabInteractable XRGrab = slicedObject.AddComponent<XRGrabInteractable>();
        rb.AddForce(new UnityEngine.Vector3(10f,5f, 0f));
    }
}

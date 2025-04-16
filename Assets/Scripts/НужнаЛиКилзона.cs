using UnityEngine;

public class НужнаЛиКилзона : MonoBehaviour
{

        public GameObject def;
        public GameObject killzone;

        public ParticleSystem oplki;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        killzone.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckKill(){
        bool che = def.GetComponent<RotateLuk>().DefIsOn;
        Debug.Log(che + " A NICHE");
        if(che == false){
            killzone.SetActive(true);
            oplki.Play();
        }
    }
}

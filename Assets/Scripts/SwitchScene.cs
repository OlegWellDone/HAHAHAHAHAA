using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
public int sceneNumber;
public float TimeDelay;
bool StartTimer = false;
private float ElapsedTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StartTimer){
            ElapsedTime += Time.deltaTime;
            if (ElapsedTime > TimeDelay) {
                SwitchSC(sceneNumber);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        StartTimer = true;
    }

    public void SwitchSC(int scene){
        StartTimer = false;
        SceneManager.UnloadSceneAsync(scene);
        SceneManager.LoadScene(scene);
    }
}

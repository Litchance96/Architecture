using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSingleton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    float startTime;
    
    public string sceneName;
    
    void Start()
    {
        Debug.Log(Singleton.instance.score); //Grace à l'instance "static" dans la class Singleton on peut aller chercher la variable score ("instance" : guichet)
        //Quaternion.LookRotation : ici on a acces a la class Quaternion car elle est en public static
        startTime = Time.time;
    
    
    }

    void Update()
    {
        if (Time.time - startTime > 5f)
        {
            SceneManager.LoadScene(sceneName);
        }
    }


}

using UnityEngine;

public class Singleton : MonoBehaviour //pour instancier un monobehaviour on la met sur un objeeect!
{

    public static Singleton instance;

    public int score; //chaque singleton aura une copie de score

    void Awake() //existe car on ne sait pas quand tout le monde se réveil, pour faire sa propre initialisation (noter nos variables, ... qu'on va utiliser avant de jouer)
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }


    void Update()
    {
        score++;
    }

}

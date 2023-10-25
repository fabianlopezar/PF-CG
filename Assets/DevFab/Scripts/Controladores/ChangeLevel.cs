using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public static ChangeLevel Instance { get;  set; }
    
    public string _sceneName;

    private void Awake()
    {
        Instanciar();
    }

    private void Instanciar()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void Scena1()
    {
        string nameScene = "1";
        SceneManager.LoadScene(nameScene);
    }
    public void Scena2()
    {
        string nameScene = "1";
        SceneManager.LoadScene(nameScene);
    }
    public void Scena3()
    {
        string nameScene = "1";
        SceneManager.LoadScene(nameScene);
    }
    public void Scena4()
    {
        string nameScene = "1";
        SceneManager.LoadScene(nameScene);
    }
}

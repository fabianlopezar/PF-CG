using UnityEngine.SceneManagement;
using UnityEngine;
public class ChangeLevel : MonoBehaviour
{
    public static ChangeLevel Instance { get;  set; }
    
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

    public void ChangeScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
    
}

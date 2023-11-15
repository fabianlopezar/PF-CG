using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("1");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("2");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("3");
    }
    public void Scene4()
    {
        SceneManager.LoadScene("4");
    }

}

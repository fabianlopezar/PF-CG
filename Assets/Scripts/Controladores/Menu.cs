using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public TMP_Text _tmpNombre;
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
    public void T1()
    {
        SceneManager.LoadScene("T1");
    }
    public void T2()
    {
        SceneManager.LoadScene("T2");
    }
    public void T3()
    {
        SceneManager.LoadScene("T3");
    }
    public void T4()
    {
        SceneManager.LoadScene("T4");
    }
    public void Final()
    {
        SceneManager.LoadScene("Final");
    }
    public void Inicio()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void RecibirNombreInputField()
    {
        GameManager.Instance.ObtenerNombrePlayer(_tmpNombre.text);
        Debug.Log("Deberia guardar: " + _tmpNombre.text);
    }
}

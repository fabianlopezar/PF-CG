using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    public string _namePlayer;
    public string _timeLevel1;
    public string _timeLevel2;
    public string _timeLevel3;
    public string _timeLevel4;

    private void Awake()
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
    public void TiempoNivelSuperado(int numeroNivel)
    {
        switch (numeroNivel)
        {
            case 1:
                GameManager.Instance._timeLevel1 = ManejoReloj.Instance.TimeLevel();
                break;
            case 2:
                GameManager.Instance._timeLevel2 = ManejoReloj.Instance.TimeLevel();
                break;
            case 3:
                GameManager.Instance._timeLevel3 = ManejoReloj.Instance.TimeLevel();
                break;
            case 4:
                GameManager.Instance._timeLevel4 = ManejoReloj.Instance.TimeLevel();
                break;
            default:
                Debug.LogWarning("Estado no reconocido.");
                break;
        }
    }
    public void ObtenerNombrePlayer(string nombrePlayer)
    {
        GameManager.Instance._namePlayer = nombrePlayer;
    }

}

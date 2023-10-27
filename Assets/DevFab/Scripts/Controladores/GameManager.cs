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

}

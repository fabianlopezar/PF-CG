using TMPro;
using UnityEngine;
using System.IO;

[SerializeField]
//Craerconstructor 
public class Data
{
    public string _name;
    public  string _level1;
    public string _level2;
    public string _level3;
    public string _level4;
}
public class SaveData : MonoBehaviour
{
    public TMP_Text _nameText, _level1Text, _level2Text, _level3Text, _level4Text;
    private string dataFilePath = "Assets/DataJSON.json";


    public void SaveDataToJson()
    {
        Data data = new Data();
        data._name = GameManager.Instance._namePlayer;
        data._level1 = GameManager.Instance._timeLevel1;
        data._level2 = GameManager.Instance._timeLevel2;
        data._level3 = GameManager.Instance._timeLevel3;
        data._level4 = GameManager.Instance._timeLevel4;
        
        MostrarDatosGuardados();
        string jsonData = JsonUtility.ToJson(data);
        
        File.WriteAllText(dataFilePath, jsonData);

        
    }
    public void MostrarDatosGuardados()
    {
        _nameText.text = "" + GameManager.Instance._namePlayer;
        _level1Text.text = "" + GameManager.Instance._timeLevel1;
        _level2Text.text = "" + GameManager.Instance._timeLevel2;
        _level3Text.text = "" + GameManager.Instance._timeLevel3;
        _level4Text.text = "" + GameManager.Instance._timeLevel4;
    }
    public void LoadDataFrom()
    {
        if (File.Exists(dataFilePath))
        {
            string jsonData = File.ReadAllText(dataFilePath);
            Data data = JsonUtility.FromJson<Data>(jsonData);

            _nameText.text = "" + data._name;
            _level1Text.text = "" + data._level1;
            _level2Text.text = "" + data._level2;
            _level3Text.text = "" + data._level3;
            _level4Text.text = "" + data._level4;
        }
        else
        {
            _nameText.text = "No se encontro :3";
        }
    }

}

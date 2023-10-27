using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//codigo original fabian lopez
public class ManagerT : MonoBehaviour
{
    public bool rojoT;
    public bool azulT;
    public bool verdeT;
    public bool amarilloT;
    public int id;
    public int energy=0;

    public GameObject xd;
    public GameObject[] prefabs;
    private void Start()
    {
   //     varid = FindObjectOfType<Id>();
    }
    private void Update()
    {
     //   energy_text.text = "energy: " + energy.ToString();

        if (id == 1)
        {
       //     Debug.Log("esta funcionando el 1");
            if (rojoT == true && azulT == true && verdeT == true)
            {
                rojoT = false;
                verdeT = false;
                azulT = false;
                StartCoroutine(esperar());
                Destroy(GameObject.FindWithTag("Player"));
                SpawnPrefabs();
                energy +=60;
                id = 0;              
            }
        }

        if (id == 2)
        {
            if (rojoT == true && azulT == true && verdeT == true && amarilloT== true)
            {
                rojoT = false;
                verdeT = false;
                azulT = false;
                amarilloT = false;
                StartCoroutine(esperar());
                Destroy(GameObject.FindWithTag("Player"));
                SpawnPrefabs();
                energy +=60;
                id = 0;
                             
            }
        }
    }
    public IEnumerator esperar()
    {
      //  Debug.Log("sirve");
        yield return new WaitForSeconds(5);
//        SceneManager.LoadScene(1);
    }
    public void SpawnPrefabs()
    {
        //  Instantiate(prefabs[Random.Range(1,4)], transform.position, transform.rotation);
        Instantiate(prefabs[Random.Range(0, 5)], new Vector3(-1.38f ,1.79f,-0.864f),Quaternion.identity);
       // Debug.Log("" +);
    }

}

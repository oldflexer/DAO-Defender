using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneFinal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject[] ObjList;

    public GameObject Creamer;
    public GameObject Cliker;
    public GameObject TextClick;
    public GameObject chat1;
    public GameObject chat2;
    public GameObject chat3;
    public GameObject chat4;

    public int curentChat = 1;
    // Update is called once per frame
    private void OnMouseDown()
    {
        if (curentChat == 1) 
        { 
            chat1.SetActive(false);
            chat2.SetActive(true);
            for(int i=0; i < ObjList.Length; i++) { ObjList[i].SetActive(true); } ; 
            curentChat++;
            Creamer.SetActive(false);
            Cliker.SetActive(false);
            TextClick.SetActive(false);
        }
        else if (curentChat == 2) 
        { 
            chat2.SetActive(false); 
            chat3.SetActive(true); 
            for (int i = 0; i < ObjList.Length; i++) { ObjList[i].SetActive(true); } 
            curentChat++;
            Creamer.SetActive(false);
            Cliker.SetActive(false);
            TextClick.SetActive(false);
        }
        else if (curentChat == 3) 
        { 
            chat3.SetActive(false); chat4.SetActive(true);
            for (int i = 0; i < ObjList.Length; i++) { ObjList[i].SetActive(true); } 
            curentChat++;
            Creamer.SetActive(false);
            Cliker.SetActive(false);
            TextClick.SetActive(false);
        }
        else if (curentChat == 4) 
        { 
            SceneManager.LoadScene(1); 
        }
    }
}

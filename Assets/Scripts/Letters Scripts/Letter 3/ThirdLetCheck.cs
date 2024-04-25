using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdLetCheck : MonoBehaviour //скрипт для письма без ошибок
{
    public GameObject text;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckErrors()
    {
        text.SetActive(true);
        button.interactable = true;
    }
}

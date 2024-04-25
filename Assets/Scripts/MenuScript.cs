using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject let1;
    public GameObject let2;
    public GameObject let3;
    public GameObject let4;
    public GameObject letters;
    public GameObject Win1;
    public GameObject Win2;
    public TextMeshProUGUI Win2_;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        SceneManager.LoadScene(2);
    }

    public void Level1()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToLetter2()
    {
        let1.SetActive(false);
        let2.SetActive(true);
    }

    public void GoToLetter3()
    {
        let2.SetActive(false);
        let3.SetActive(true);
    }

    public void GoToLetter4()
    {
        let3.SetActive(false);
        let4.SetActive(true);
    }

    public void GoToLetterWin()
    {
        letters.SetActive(false);
        Win1.SetActive(true);
        Win2.SetActive(true);
        Win2_.text = "Ты набрал: " + PointsCounter.poits.ToString() + " очков";
    }

    public void StartLetters()
    {
        let1.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}

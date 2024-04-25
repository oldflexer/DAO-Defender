using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Architecture.Controller
{
    public class LevelsController : DaoElement
    {
        public void Start()
        {
            //App.view.levels.gameObject.SetActive(false);
        }

        public void EnterLevel1()
        {
            SceneManager.LoadScene(3);
            //App.view.levels.gameObject.SetActive(false);
            //App.view.level1.gameObject.SetActive(true);
        }
        
        public void EnterLevel2()
        {
            SceneManager.LoadScene(4);
        }

        public void EnterLevel3()
        {
        }

        public void BackToMenu()
        {
            SceneManager.LoadScene(0);
            //App.view.levels.gameObject.SetActive(false);
            //App.view.menu.gameObject.SetActive(true);
        }
    }
}

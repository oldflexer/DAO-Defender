using UnityEngine;
using UnityEngine.SceneManagement;

namespace Architecture.Controller
{
    public class MenuController : DaoElement
    {
        public void Start()
        {
            //App.view.menu.gameObject.SetActive(true);
        }

        public void EnterMainMenu()
        {
            SceneManager.LoadScene(0);
        }

        public void EnterLevelsMenu()
        {
            SceneManager.LoadScene(1);
            //App.view.menu.gameObject.SetActive(false);
            //App.view.levels.gameObject.SetActive(true);
        }
    
        public void EnterSettingsMenu()
        {
            SceneManager.LoadScene(2);
            //App.view.menu.gameObject.SetActive(false);
            //App.view.settings.gameObject.SetActive(true);
        }

        
        public void EnterLevel1()
        {
            SceneManager.LoadScene(3);
        }

        public void EnterLevel2()
        {
            SceneManager.LoadScene(4);
        }

        public void Exit()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
            Application.Quit(0);
        }
    }
}

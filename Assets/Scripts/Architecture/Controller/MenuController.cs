using UnityEngine;
using UnityEngine.SceneManagement;

namespace Architecture.Controller
{
    public class MenuController : DaoElement
    {
        public void EnterMainMenu()
        {
            SceneManager.LoadScene(0);
        }

        public void EnterLevelsMenu()
        {
            SceneManager.LoadScene(1);
        }
    
        public void EnterSettingsMenu()
        {
            SceneManager.LoadScene(2);
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

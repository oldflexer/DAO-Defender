using UnityEngine.SceneManagement;

namespace Architecture.Controller
{
    public class SettingsController : DaoElement
    {
        public void Start()
        {
            //App.view.settings.gameObject.SetActive(false);
        }
        
        public void BackToMenu()
        {
            SceneManager.LoadScene(0);
            //App.view.settings.gameObject.SetActive(false);
            //App.view.menu.gameObject.SetActive(true);
        }
    }
}

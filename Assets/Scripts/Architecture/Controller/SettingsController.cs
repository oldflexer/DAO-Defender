using UnityEngine.SceneManagement;

namespace Architecture.Controller
{
    public class SettingsController : DaoElement
    {
        public void BackToMenu()
        {
            SceneManager.LoadScene(0);
            // SceneManager.LoadSceneAsync(0);
        }
    }
}

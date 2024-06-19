using UnityEngine.SceneManagement;

namespace Architecture.Controller
{
    public class LevelsController : DaoElement
    {
        public void EnterLevel1()
        {
            SceneManager.LoadScene(3);
        }
        
        public void EnterLevel2()
        {
            SceneManager.LoadScene(4);
        }

        public void EnterLevel3()
        {
            SceneManager.LoadScene(5);
        }

        public void BackToMenu()
        {
            SceneManager.LoadScene(0);
        }
    }
}

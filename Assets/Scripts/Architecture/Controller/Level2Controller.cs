using UnityEngine;
using UnityEngine.SceneManagement;

namespace Architecture.Controller
{
    public class Level2Controller : MonoBehaviour
    {
        public GameObject textClickToContinue;
        public GameObject screamer;
        public GameObject background;

        public GameObject frames;
        public GameObject chat1;
        public GameObject chat2;
        public GameObject chat3;
        public GameObject chat4;
        private int _currentChat;
        
        // Start is called before the first frame update
        private void Start()
        {
            _currentChat = 1;
            gameObject.SetActive(false);
            textClickToContinue.SetActive(false);
        }

        private void OnMouseDown()
        {
            switch (_currentChat)
            {
                case 1:
                    chat1.SetActive(false);
                    chat2.SetActive(true);
                    _currentChat = 2;
                    gameObject.SetActive(false);
                    textClickToContinue.SetActive(false);
                    screamer.SetActive(false);
                    background.SetActive(true);
                    frames.SetActive(true);
                    break;
                case 2:
                    chat2.SetActive(false);
                    chat3.SetActive(true);
                    _currentChat = 3;
                    gameObject.SetActive(false);
                    textClickToContinue.SetActive(false);
                    screamer.SetActive(false);
                    background.SetActive(true);
                    frames.SetActive(true);
                    break;
                case 3:
                    chat3.SetActive(false);
                    chat4.SetActive(true);
                    _currentChat = 4;
                    gameObject.SetActive(false);
                    textClickToContinue.SetActive(false);
                    screamer.SetActive(false);
                    background.SetActive(true); 
                    frames.SetActive(true);
                    break;
                case 4:
                    SceneManager.LoadScene(1);
                    background.SetActive(true);
                    break;
            }
        }
    }
}

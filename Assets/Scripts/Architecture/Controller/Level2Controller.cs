using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

namespace Architecture.Controller
{
    public class Level2Controller : MonoBehaviour
    {
        public PlayableDirector playableDirectorAnswerGreetings;
        public PlayableDirector playableDirectorAnswerYes;
        public PlayableDirector playableDirectorAnswerNo;

        // private bool _isLevelCompleted;
        
        // Start is called before the first frame update
        private void Start()
        {
        
        }

        // Update is called once per frame
        private void Update()
        {
        
        }

        public void PerformAnswerGreetings()
        {
            playableDirectorAnswerGreetings.Play();
        }
        
        public void PerformAnswerYes()
        {
            playableDirectorAnswerYes.Play();
        }
        
        public void PerformAnswerNo()
        {
            playableDirectorAnswerNo.Play();
        }

        public void FinishLevel()
        {
            SceneManager.LoadScene(1);
        }
    }
}

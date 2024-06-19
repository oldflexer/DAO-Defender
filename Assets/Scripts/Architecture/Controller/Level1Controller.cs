using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Architecture.Controller
{
    public class Level1Controller : DaoElement
    {
        private int _points;
        public TextMeshProUGUI pointsCounter;
        
        private int _errors;
        public TextMeshProUGUI errorsCounter;
        public TextMeshProUGUI errorsString;
        
        public GameObject letters;
        public GameObject letter1;
        public GameObject letter2;
        public GameObject letter3;
        public GameObject letterWithoutErrors;

        public TextMeshProUGUI congratulation;
        public TextMeshProUGUI result;

        private bool _isLetterChecked;

        private void FixedUpdate()
        {
            _errors = LetterController._errorsAmount;
            errorsCounter.text = _errors.ToString();
            errorsString.text = _errors switch
            {
                0 or >= 5 => "Ошибок",
                1 => "Ошибку",
                _ => "Ошибки"
            };

            pointsCounter.text = _points.ToString();
        }

        public void CheckErrors(int targetErrorsAmount = 0)
        {
            Debug.Log(_errors);
            if (_isLetterChecked) return;
            
            var letterController =
                FindObjectsByType<LetterController>(FindObjectsInactive.Exclude, FindObjectsSortMode.None)[0];

            if (_errors >= targetErrorsAmount)
            {
                letterController.ComputeErrorsColors();
                letterController.ChangeStateNotEnoughErrors(false);
                letterController.ChangeInteractivityButtonNext(true);
                
                _points += _errors + 1;
                _errors = 0;
                
                _isLetterChecked = true;
            }
            else
            {
                letterController.ChangeStateNotEnoughErrors(true);
            }
        }

        public void StartLetters()
        {
            letters.SetActive(true);
        }

        public void StartLetter1()
        {
            letter1.SetActive(true);
            _isLetterChecked = false;
        }
        
        public void StartLetter2()
        {
            letter2.SetActive(true);
            _isLetterChecked = false;
        }
        
        public void StartLetter3()
        {
            letter3.SetActive(true);
            _isLetterChecked = false;
        }
        
        public void StartLetterWithoutErrors()
        {
            letterWithoutErrors.SetActive(true);
            _isLetterChecked = false;
        }

        public void StartConclusion()
        {
            letters.SetActive(false);
            congratulation.gameObject.SetActive(true);
            result.gameObject.SetActive(true);
            result.text = "Твои очки: " + _points;
        }

        public void FinishLevel()
        {
            SceneManager.LoadScene(1);
        }
    }
}

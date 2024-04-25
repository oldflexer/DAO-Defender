using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SecLetterScript : MonoBehaviour //Скрипт для второго письма....... да я знаю что это тотже скрипт, НО легче длеать шаблонные скрипты для писемь......... Прости Ваня, меня ленивого идиота
{
    //Рамки выбора
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;
    //ПРАВИЛЬНЫЙ выбор
    public GameObject ygo1;
    public GameObject ygo2;
    public GameObject ygo3;
    public GameObject ygo4;
    //НЕ ПРАВИЛЬНЫЙ выбор
    public GameObject ngo1;
    public GameObject ngo2;
    public GameObject ngo3;
    public GameObject ngo4;
    //Текст пояснения
    public GameObject Error1Text;
    public GameObject Error2Text;
    public GameObject Error3Text;
    public GameObject Error4Text;
    public GameObject NotEnoughErrors;
    //Кнопка перехода
    public Button button;
    //Кол-во ошибок
    public static int CountOfError;
    //Счётсчики
    public TextMeshProUGUI ErrorCounterInt;//Число
    public TextMeshProUGUI ErrorCounterStr;//Ошибок/Ошибки moment


    // Start is called before the first frame update
    void Start()
    {
        button.interactable = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ErrorCounterInt.text = CountOfError.ToString();
        if (CountOfError == 0) { ErrorCounterStr.text = "Ошибок"; } else if (CountOfError >= 2 & CountOfError <= 4) { ErrorCounterStr.text = "Ошибки"; } else if (CountOfError == 1) { ErrorCounterStr.text = "Ошибку"; }

    }

    public void CheckErrors()
    {
        if (CountOfError >= 3)
        {
            if (go1.active) { go1.SetActive(false); ygo1.SetActive(true); Error1Text.SetActive(true); PointsCounter.poits++; } else { go1.SetActive(false); ngo1.SetActive(true); Error1Text.SetActive(true); }
            if (go2.active) { go2.SetActive(false); ygo2.SetActive(true); Error2Text.SetActive(true); PointsCounter.poits++; } else { go2.SetActive(false); ngo2.SetActive(true); Error2Text.SetActive(true); }
            if (go3.active) { go3.SetActive(false); ygo3.SetActive(true); Error3Text.SetActive(true); PointsCounter.poits++; } else { go3.SetActive(false); ngo3.SetActive(true); Error3Text.SetActive(true); }
            if (go4.active) { go4.SetActive(false); ygo4.SetActive(true); Error4Text.SetActive(true); PointsCounter.poits++; } else { go4.SetActive(false); ngo4.SetActive(true); Error4Text.SetActive(true); }
            button.interactable = true;
            NotEnoughErrors.SetActive(false);
        }
        else
        {
            button.interactable = false;
            NotEnoughErrors.SetActive(true);
        }
    }
}

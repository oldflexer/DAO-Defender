using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FourLetCheck : MonoBehaviour // и ещё раз прости меня Ваня..... Надеюсь интеграция прошла успешно
{//Рамки выбора
    public GameObject go1;
    //ПРАВИЛЬНЫЙ выбор
    public GameObject ygo1;
    //НЕ ПРАВИЛЬНЫЙ выбор
    public GameObject ngo1;
    //Текст пояснения
    public GameObject Error1Text;
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
        if (CountOfError == 0) { ErrorCounterStr.text = "Ошибок"; } else if (CountOfError >= 5) { ErrorCounterStr.text = "Ошибок"; } else if (CountOfError >= 2 & CountOfError <= 4) { ErrorCounterStr.text = "Ошибки"; } else if (CountOfError == 1) { ErrorCounterStr.text = "Ошибку"; }

    }

    public void CheckErrors()
    {
        if (CountOfError == 1)
        {
            if (go1.active) { go1.SetActive(false); ygo1.SetActive(true); Error1Text.SetActive(true); PointsCounter.poits++; } else { go1.SetActive(false); ngo1.SetActive(true); Error1Text.SetActive(true); }
            button.interactable = true;
            NotEnoughErrors.SetActive(false);
            CountOfError = 0;
        }
        else
        {
            button.interactable = false;
            NotEnoughErrors.SetActive(true);
        }
    }
}

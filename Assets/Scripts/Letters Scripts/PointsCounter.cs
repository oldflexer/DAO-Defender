using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    public static int poits;
    public int curentPoints = 0;
    public TextMeshProUGUI PointCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PointCounter.text = PointsCounter.poits.ToString();
        curentPoints = poits;
    }
}

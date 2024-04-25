using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class MoveObj : MonoBehaviour
{
    public GameObject objToMove;
    Vector3 targetPoint;

    // Start is called before the first frame update
    void Start()
    {
        targetPoint = new Vector3(0,0,0);    
    }

    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);
    }
}

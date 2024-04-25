using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public bool test1;
    GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        test = GameObject.Find("FirstErrorBox");
    }

    public GameObject[] ObjToSpawn;
    public GameObject PointToMove;
    public float speed = 2;
    

    // Update is called once per frame
    public void Update()
    {
        test1 = test.active;
        Debug.Log(test1);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int random = Random.Range(0,2);
            GameObject newObj = Instantiate(ObjToSpawn[random], transform);
        }
    }
}

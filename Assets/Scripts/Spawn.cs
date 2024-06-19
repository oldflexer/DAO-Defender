using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float cooldown = 2;
    public float timer = 0;
    public int enemyNum = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    public GameObject[] ObjToSpawn;
    

    // Update is called once per frame
    public void FixedUpdate()
    {
        if (enemyNum <= ObjToSpawn.Length - 1)
        {
            timer += Time.deltaTime;
        }
        if (timer >= cooldown)
        {
            timer = 0;
            GameObject Enemy = Instantiate(ObjToSpawn[enemyNum], gameObject.transform);
            enemyNum++;
        }
        
    }
}

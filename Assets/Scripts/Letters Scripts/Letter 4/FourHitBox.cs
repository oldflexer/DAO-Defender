using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourHitBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        obj.active = false;
    }
    public GameObject obj;

    private void OnMouseDown()
    {
        obj.active = !obj.active;
        if (obj.active) { FourLetCheck.CountOfError++; } else { FourLetCheck.CountOfError--; }
    }
}

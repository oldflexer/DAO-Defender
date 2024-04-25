using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecLetHitBoxes : MonoBehaviour
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
        if (obj.active) { SecLetterScript.CountOfError++; } else { SecLetterScript.CountOfError--; }
    }
}

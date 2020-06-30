using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if (hVal !=0)
        {
            print("hVal is found to be : " + hVal);
        }
        if (vVal !=0)
        {
            print("vVal is found to be : " + vVal);
        }
    }
}

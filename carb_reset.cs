using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carb_reset : MonoBehaviour
{
    GameObject carb;
    // Start is called before the first frame update
    void Start()
    {
        carb = GameObject.Find("total");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void carbreset()
    {
        carb.GetComponent<carb_total>().carbreset();
    }
}

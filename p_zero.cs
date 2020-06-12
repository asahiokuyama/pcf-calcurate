using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_zero : MonoBehaviour
{
    GameObject cal;
    public string count_zero = "0";
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void zero()
    {
        cal.GetComponent<p_cal>().cal = cal.GetComponent<p_cal>().cal + count_zero;
        count_zero = "0";
    }
}

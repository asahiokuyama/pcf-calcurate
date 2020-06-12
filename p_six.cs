using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_six : MonoBehaviour
{
    GameObject cal;
    public string count_six = "6";
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void six()
    {
        cal.GetComponent<p_cal>().cal = cal.GetComponent<p_cal>().cal + count_six;

        count_six = "6";
    }
}

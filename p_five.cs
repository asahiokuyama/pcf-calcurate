using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_five : MonoBehaviour
{
    GameObject cal;
    public string count_five = "5";
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void five()
    {
        cal.GetComponent<p_cal>().cal = cal.GetComponent<p_cal>().cal + count_five;

        count_five = "5";
    }
}

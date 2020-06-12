using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_two : MonoBehaviour
{
    GameObject cal;
    public string count_two;
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void two()
    {
        cal.GetComponent<p_cal>().cal = cal.GetComponent<p_cal>().cal + count_two;

        count_two = "2";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_three : MonoBehaviour
{
    GameObject cal;
    public string count_three = "3";
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void three()
    {
        cal.GetComponent<p_cal>().cal = cal.GetComponent<p_cal>().cal + count_three;
        count_three = "3";
    }
}

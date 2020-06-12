using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_nine : MonoBehaviour
{
    GameObject cal;
    public string count_nine = "9";
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nine()
    {
        cal.GetComponent<p_cal>().cal = cal.GetComponent<p_cal>().cal + count_nine;

        count_nine = "9";
    }
}

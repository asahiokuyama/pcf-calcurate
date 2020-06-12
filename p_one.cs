using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_one : MonoBehaviour
{
    GameObject cal;
    public string count_one;
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void one()
    {
        cal.GetComponent<p_cal>().cal = cal.GetComponent<p_cal>().cal + count_one;

        count_one =  "1";
    }
}

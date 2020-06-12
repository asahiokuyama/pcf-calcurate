using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_eight : MonoBehaviour
{
    GameObject cal;
    public string count_eight = "8";
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void eight()
    {
        cal.GetComponent<p_cal>().cal = cal.GetComponent<p_cal>().cal + count_eight;

        count_eight = "8";
    }
}

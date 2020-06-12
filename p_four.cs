using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_four : MonoBehaviour
{
    GameObject cal;
    public string count_four = "4";
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void four()
    {
        cal.GetComponent<p_cal>().cal = cal.GetComponent<p_cal>().cal + count_four;

        count_four = "4";
    }
}

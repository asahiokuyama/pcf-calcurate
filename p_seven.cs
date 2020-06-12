using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_seven : MonoBehaviour
{
    GameObject cal;
    public string count_seven = "7";
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void seven()
    {
        cal.GetComponent<p_cal>().cal = cal.GetComponent<p_cal>().cal + count_seven;

        count_seven = "7";
    }
}

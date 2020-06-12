using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class protein_total : MonoBehaviour
{
    public string protein_count = "0";

    public static double final_num = 0;

    GameObject total;
    GameObject count;
    // Start is called before the first frame update
    void Start()
    {
        total = GameObject.Find("total");
        count = GameObject.Find("calbox");

        final_num = all_state.getreturnP();
    }

    // Update is called once per frame
    void Update()
    {
    
        total.GetComponent<Text>().text = "protein:" + final_num + "g/212.5g";
    }

    public void countup()
    {
        protein_count = count.GetComponent<p_cal>().cal;
        double num = Convert.ToDouble(protein_count);
        final_num = num + final_num;
    }

    public static double getA()
    {
        return final_num;
    }

    public void reset()
    {
        final_num = 0;
    }
}

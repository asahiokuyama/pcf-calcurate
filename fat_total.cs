using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class fat_total : MonoBehaviour
{
    public string fat_count = "0";

    public static double final_num = 0;

    GameObject total;
    GameObject count;
    // Start is called before the first frame update
    void Start()
    {
        total = GameObject.Find("total");
        count = GameObject.Find("calbox");

        final_num = all_state.getretrunF();
    }

    // Update is called once per frame
    void Update()
    {
        total.GetComponent<Text>().text = "fat:" + final_num + "g/100g";
    }

    public void countup()
    {
        fat_count = count.GetComponent<p_cal>().cal;
        double num = Convert.ToDouble(fat_count);
        final_num = num + final_num;
    }

    public static double getC()
    {
        return final_num;
    }

    public void fatreset()
    {
        final_num = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class carb_total : MonoBehaviour
{
    public string carb_count = "0";

    public static double final_carb = 0;

    GameObject total;
    GameObject count;

    double i;
    // Start is called before the first frame update
    void Start()
    {
        total = GameObject.Find("total");
        count = GameObject.Find("calbox");

        final_carb = all_state.getreturnC();
    }

    // Update is called once per frame
    void Update()
    {
        total.GetComponent<Text>().text = "carbhydrate:" + final_carb + "g/200g";
    }

    public void countup()
    {
        carb_count = count.GetComponent<p_cal>().cal;
        double num = Convert.ToDouble(carb_count);
        final_carb = num + final_carb;
    }

    public static double getB()
    {
        return final_carb;
    }

    public void carbreset()
    {
        final_carb = 0;
    }
}

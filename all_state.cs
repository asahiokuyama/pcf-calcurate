using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class all_state : MonoBehaviour
{
    GameObject cal;
    GameObject protein;
    GameObject carb;
    GameObject fat;

    public static double i = 0;
    public static double j = 0;
    public static double k = 0;

    double all_cal;
    // Start is called before the first frame update
    void Start()
    {
        cal = GameObject.Find("main");
        protein = GameObject.Find("protein");
        carb = GameObject.Find("carbohydrate");
        fat = GameObject.Find("fat");

        i = protein_total.getA();
        j = carb_total.getB();
        k = fat_total.getC();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        all_cal = (i * 4) + (j * 4) + (k * 9);

        cal.GetComponent<Text>().text = "Total calories:"+ "\n" + all_cal + "kcal/2200kcal";
        protein.GetComponent<Text>().text = "protein:" + i + "g";
        carb.GetComponent<Text>().text = "carbohydrate:" + j + "g";
        fat.GetComponent<Text>().text = "fat:" + k + "g";
    }

    public void reset()
    {
        i = 0;
        j = 0;
        k = 0;
        all_cal = 0;
    }

    public static double getreturnC()
    {
        return j;
    }

    public static double getreturnP()
    {
        return i;
    }

    public static double getretrunF()
    {
        return k;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pro_dele : MonoBehaviour
{
    GameObject protein;

    GameObject one;
    GameObject two;
    GameObject three;
    GameObject four;
    GameObject five;
    GameObject six;
    GameObject seven;
    GameObject eight;
    GameObject nine;
    GameObject zero;
    // Start is called before the first frame update
    void Start()
    {
        protein = GameObject.Find("calbox");

        one = GameObject.Find("1");
        two = GameObject.Find("2");
        three = GameObject.Find("3");
        four = GameObject.Find("4");
        five = GameObject.Find("5");
        six = GameObject.Find("6");
        seven = GameObject.Find("7");
        eight = GameObject.Find("8");
        nine = GameObject.Find("9");
        zero = GameObject.Find("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pro_reset()
    {
        protein.GetComponent<p_cal>().cal = "";
        one.GetComponent<p_one>().count_one = "1";
        two.GetComponent<p_two>().count_two = "2";
        three.GetComponent<p_three>().count_three = "3";
        four.GetComponent<p_four>().count_four = "4";
        five.GetComponent<p_five>().count_five = "5";
        six.GetComponent<p_six>().count_six = "6";
        seven.GetComponent<p_seven>().count_seven = "7";
        eight.GetComponent<p_eight>().count_eight = "8";
        nine.GetComponent<p_nine>().count_nine = "9";
        zero.GetComponent<p_zero>().count_zero = "0";
    }
}

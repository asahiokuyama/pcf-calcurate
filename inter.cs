using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inter : MonoBehaviour
{
    GameObject pro_inter;

    GameObject cal;
    // Start is called before the first frame update
    void Start()
    {
        pro_inter = GameObject.Find("interval");

        cal = GameObject.Find("calbox");
    }

    // Update is called once per frame
    void Update()
    {
        pro_inter.GetComponent<Text>().text = cal.GetComponent<p_cal>().cal;
    }

    public void clear()
    {
        cal.GetComponent<p_cal>().cal = "";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p_count : MonoBehaviour
{
    GameObject count;

    GameObject carb;
    GameObject protein;
    GameObject fat;
    // Start is called before the first frame update
    void Start()
    {
        count = GameObject.Find("total");

        carb = GameObject.Find("interval");
        protein = GameObject.Find("interval");
        fat = GameObject.Find("interval");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void plus()
    {
        count.GetComponent<protein_total>().countup();
        protein.GetComponent<inter>().clear();
        
    }

    public void c_puls()
    {
        count.GetComponent<carb_total>().countup();
        carb.GetComponent<inter>().clear();
    }

    public void f_puls()
    {
        count.GetComponent<fat_total>().countup();
        fat.GetComponent<inter>().clear();
    }
}

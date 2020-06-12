using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class protein_reset : MonoBehaviour
{
    GameObject total;
    // Start is called before the first frame update
    void Start()
    {
        total = GameObject.Find("total");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void proteinreset()
    {
        total.GetComponent<protein_total>().reset();
    }
}

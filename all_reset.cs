using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class all_reset : MonoBehaviour
{
    GameObject reset_value;
    // Start is called before the first frame update
    void Start()
    {
        reset_value = GameObject.Find("state");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void allreset()
    {
        reset_value.GetComponent<all_state>().reset();
    }
}

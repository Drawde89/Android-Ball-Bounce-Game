using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public static Counter instance;
    public int count;
    Text instruction;
    void Start()
    {
        instruction = GetComponent<Text>();
        count = 0;
    }

    public void ScoreUp()
    {
        count++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordScramble : MonoBehaviour
{
    public char[] current = new char[5];
    public string answer = "ETHAN";
    public string temp;
    public Image finish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp = new string(current);
        if (answer.Equals(temp))
        {
            Debug.Log("Finished");
            finish.color = Color.green;
        }
    }
}

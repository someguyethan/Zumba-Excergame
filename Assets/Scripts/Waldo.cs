using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Waldo : MonoBehaviour, IPointerClickHandler
{
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public int targetCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            //do this when clicked
        }
    }
}

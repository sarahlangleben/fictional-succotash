using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class DecreaseHair : MonoBehaviour
{
    public Sprite[] hairOpts;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        int index = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        Debug.Log("increase shirt button clicked");
        DecreaseHairOption();
        Debug.Log(index);
    }
    public int DecreaseHairOption()
    {
        if (index <= 0)
        {
            index = hairOpts.Length;
        }
        else
        {
            index--;
        }
        return index;
    }

}

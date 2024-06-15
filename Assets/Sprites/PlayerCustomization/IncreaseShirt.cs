using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class IncreaseShirt : MonoBehaviour
{
    public Sprite[] shirtOpts;
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
        IncreaseShirtOption();
        Debug.Log(index);
    }
    public int IncreaseShirtOption()
    {
        if (index >= shirtOpts.Length - 1)
        {
            index = 0;
        }
        else
        {
            index++;
        }
        return index;
    }

}

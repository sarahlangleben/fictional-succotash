using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class DecreaseShirt : MonoBehaviour
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
        DecreaseShirtOption();
        Debug.Log(index);
    }
    public int DecreaseShirtOption()
    {
        if (index <= 0)
        {
            index = shirtOpts.Length;
        }
        else
        {
            index--;
        }
        return index;
    }

}

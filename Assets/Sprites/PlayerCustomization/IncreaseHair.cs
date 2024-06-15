using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class IncreaseHair : MonoBehaviour
{
    public Sprite[] hairOpts;
    public int index;
    public SpriteRenderer spriteRenderer;
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
        IncreaseHairOption();
        Debug.Log(index);
        spriteRenderer.sprite = hairOpts[index];

    }
    public int IncreaseHairOption()
    {
        if (index >= hairOpts.Length - 1)
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

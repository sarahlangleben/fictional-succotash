using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class IncreasePants : MonoBehaviour
{
    public Sprite[] pantsOpts;
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
        Debug.Log("increase pants button clicked");
        IncreasePantsOption();
        Debug.Log(index);
        spriteRenderer.sprite = pantsOpts[index];

    }
    public int IncreasePantsOption()
    {
        if (index >= pantsOpts.Length - 1)
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

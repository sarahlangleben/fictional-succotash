using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RightButtonShirt : MonoBehaviour
{
    public Sprite[] shirtOptions;
    public SpriteRenderer spriteRenderer;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseDown()
    {
        index = IncreaseIndex();
        Debug.Log(index);
        spriteRenderer.sprite = shirtOptions[index];
    }
    int IncreaseIndex()
    {
        if (index >= shirtOptions.Length - 1)
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

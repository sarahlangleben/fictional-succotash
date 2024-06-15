using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGenderM : MonoBehaviour
{
    public bool isSelected;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        isSelected = false;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected)
        {
            spriteRenderer.color = UnityEngine.Color.gray;
        }
        else
        {
            spriteRenderer.color = UnityEngine.Color.white;
        }
    }
    void OnMouseDown()
    {
        if (isSelected)
        {
            isSelected = false;
        }
        else if (!isSelected) { isSelected = true; }
    }
}

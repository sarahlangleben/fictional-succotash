using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
public class GetSliderValue : MonoBehaviour
{
    public Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
    }
    void Update()
    {
        Debug.Log(slider.value);
        CurrentValue();
    }
    float CurrentValue()
    {
        return slider.value;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectColor : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // [SerializeField]
    public float redValue;
    // [SerializeField]
    public float greenValue;
    // [SerializeField]
    public float blueValue;
    [SerializeField]
    private Slider redSlider;
    [SerializeField]
    private Slider greenSlider;
    [SerializeField]
    private Slider blueSlider;
    // Start is called before the first frame update
    void Start()
    {
        // redSlider = gameObject.GetComponent<Slider>();
        // greenSlider = gameObject.GetComponent<Slider>();
        // blueSlider = gameObject.GetComponent<Slider>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        redSlider.onValueChanged.AddListener(OnRedSliderValueChanged);
        blueSlider.onValueChanged.AddListener(OnBlueSliderValueChanged);
        greenSlider.onValueChanged.AddListener(OnGreenSliderValueChanged);

    }

    void OnRedSliderValueChanged(float value)
    {
        redValue = value;
    }
    void OnBlueSliderValueChanged(float value)
    {
        blueValue = value;
    }
    void OnGreenSliderValueChanged(float value)
    {
        greenValue = value;
    }



    // Update is called once per frame
    void Update()
    {
        redValue = redSlider.value;
        greenValue = greenSlider.value;
        blueValue = blueSlider.value;
        spriteRenderer.color = new UnityEngine.Color(redValue, greenValue, blueValue);
        // spriteRenderer.color = new UnityEngine.Color(redValue, blueValue, greenValue);
    }
}

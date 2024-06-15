using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// what this code should do:
// store info:
// Name
//      check that Name != "". Don't store anything and don't go to next scene 
//      if it is "".
// hair color
// hair option
// shirt option
// pants option
// gender option
// skin color


public class OkPressed : MonoBehaviour
{
    // shirt option logic
    public GameObject shirt;
    private RightButtonShirt shirtScript;
    private int selectedShirt;

    //  pants option logic
    public GameObject pants;
    private IncreasePants pantsScript;
    private int selectedPants;
    // hair options
    // [SerializeField]
    public GameObject hair;
    private IncreaseHair hairScript;
    private int selectedHair;

    // gender selection
    public GameObject genderF;
    private SelectGenderF genderFScript;
    public GameObject genderM;
    private SelectGenderM genderMScript;
    private string selectedGender;
    // M = male, F = female, N = both selected


    // skin color
    public GameObject skColor;
    private SkinColor skColorScript;
    private SpriteRenderer selectedSkColor;

    // name logic
    public TMP_Text myText;
    private GameObject textObj;

    // hair color
    public float redValue;
    public float greenValue;
    public float blueValue;
    [SerializeField]
    private Slider redSlider;
    [SerializeField]
    private Slider greenSlider;
    [SerializeField]
    private Slider blueSlider;

    void Start()
    {
        // playerName = GameObject.Find("Text").GetComponent<TextMeshPro>().text;
        // playerName = nameText.GetComponent<TextMeshPro>().text;
        textObj = GameObject.Find("InputField");
        myText = textObj.GetComponentInChildren<TMP_Text>();
        shirtScript = shirt.GetComponent<RightButtonShirt>();
        hairScript = hair.GetComponent<IncreaseHair>();
        pantsScript = pants.GetComponent<IncreasePants>();
        genderFScript = genderF.GetComponent<SelectGenderF>();
        genderMScript = genderM.GetComponent<SelectGenderM>();
        skColorScript = skColor.GetComponent<SkinColor>();
    }

    // Update is called once per frame
    void Update()
    {
        redValue = redSlider.value;
        greenValue = greenSlider.value;
        blueValue = blueSlider.value;
        selectedShirt = shirtScript.index;
        selectedHair = hairScript.index;
        selectedPants = pantsScript.index;

        // selectedSkColor = skColorScript.spriteRenderer;
        // selectedGender = AssignGender(genderFScript.isSelected, genderMScript.isSelected);
        // selectedSkColor = skColorScript.spriteRenderer.color;
    }

    string AssignGender(bool femaleSelected, bool maleSelected)
    {
        if (femaleSelected && !maleSelected)
        {
            return "F";
        }
        else if (maleSelected && !femaleSelected)
        {
            return "M";
        }
        else if (maleSelected && femaleSelected)
        {
            return "N";
        }
        else return "N";
    }
    void OnMouseDown()
    {
        Debug.Log(myText.text);
        Debug.Log("Red: " + redValue + " green: " + greenValue + " blue: " + blueValue);
        Debug.Log("selected shirt: " + selectedShirt);
        Debug.Log("selected shirt: " + selectedHair);
        Debug.Log("selected pants: " + selectedPants);
        Debug.Log("player gender: " + selectedGender);
        Debug.Log("skincolor: " + selectedSkColor);
    }

}

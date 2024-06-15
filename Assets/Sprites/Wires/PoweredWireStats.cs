using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Color { red, blue, white };
public class PoweredWireStats : MonoBehaviour
{
    public bool movable = false;
    public bool moving = false;
    public bool connected = false;
    public Vector3 startPosition;
    public Color objectColor;
    public Vector3 connectedPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

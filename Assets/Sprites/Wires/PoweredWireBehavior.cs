using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PoweredWireBehavior : MonoBehaviour
{
    bool mouseDown = false;
    public PoweredWireStats powerWireS;
    LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        powerWireS = gameObject.GetComponent<PoweredWireStats>();
        line = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveWire();
        line.SetPosition(3, new UnityEngine.Vector3(gameObject.transform.position.x - .1f, gameObject.transform.position.y - .1f, gameObject.transform.localPosition.z));
        line.SetPosition(2, new UnityEngine.Vector3(gameObject.transform.position.x - .4f, gameObject.transform.position.y - .1f, gameObject.transform.localPosition.z));

    }
    void OnMouseDown()
    {
        mouseDown = true;
    }
    void OnMouseOver()
    {
        powerWireS.movable = true;
    }
    void OnMouseExit()
    {
        if (!powerWireS.moving) { powerWireS.movable = false; }
    }
    void OnMouseUp()
    {
        mouseDown = false;
        if (!powerWireS.connected)
        {
            gameObject.transform.position = powerWireS.startPosition;
        }
        else
        {
            gameObject.transform.position = powerWireS.connectedPosition;
        }
        // gameObject.transform.position = powerWireS.startPosition;
    }
    void MoveWire()
    {
        if (mouseDown && powerWireS.movable)
        {
            powerWireS.moving = true;
            float mouseX = Input.mousePosition.x;
            float mouseY = Input.mousePosition.y;
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(new UnityEngine.Vector3(mouseX, mouseY, transform.position.z));
            gameObject.transform.position = new UnityEngine.Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 1);
            line.SetPosition(3, new UnityEngine.Vector3(gameObject.transform.position.x - .1f, gameObject.transform.position.y - .1f, 1));
            line.SetPosition(2, new UnityEngine.Vector3(gameObject.transform.position.x - .4f, gameObject.transform.position.y - .1f, 1));
        }
        else
        {
            powerWireS.moving = false;
        }

    }
}

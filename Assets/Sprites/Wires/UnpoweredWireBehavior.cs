using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnpoweredWireBehavior : MonoBehaviour
{
    UnpoweredWireStat unpoweredWireS;

    // Start is called before the first frame update
    void Start()
    {
        unpoweredWireS = gameObject.GetComponent<UnpoweredWireStat>();
    }

    // Update is called once per frame
    void Update()
    {
        // ManageLight();

        if (Input.GetKey(KeyCode.Escape)) { SceneManager.LoadScene(0); }
        // how do I store previous sprite location?
    }
    // void ManageLight()
    // {
    //     if (unpoweredWireS.connected)
    //     {
    //         unpoweredWireS.poweredLight.SetActive(true);
    //         unpoweredWireS.unpoweredLight.SetActive(false);
    //     }
    //     else
    //     {
    //         unpoweredWireS.poweredLight.SetActive(false);
    //         unpoweredWireS.unpoweredLight.SetActive(true);
    //     }
    // }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PoweredWireStats>())
        {
            PoweredWireStats poweredWireS = collision.GetComponent<PoweredWireStats>();
            if (poweredWireS.objectColor == unpoweredWireS.objectColor)
            {
                poweredWireS.connected = true;
                unpoweredWireS.connected = true;
                poweredWireS.connectedPosition = gameObject.transform.position;
            }
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        PoweredWireStats poweredWireS = collision.GetComponent<PoweredWireStats>();
        poweredWireS.connected = false;
        unpoweredWireS.connected = false;
    }

}

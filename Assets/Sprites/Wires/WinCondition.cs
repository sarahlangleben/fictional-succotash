using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinCondition : MonoBehaviour
{

    GameObject whiteR;
    GameObject blueR;
    GameObject redR;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (WhiteIsConnected() && RedIsConnected() && BlueIsConnected())
        {
            Debug.Log("car successfully broken into!");
            // Load cutscene once it's ready
            Invoke("LoadCutScene", 3);
        }
    }
    void LoadCutScene()
    {
        SceneManager.LoadScene(0);
    }
    bool WhiteIsConnected()
    {
        whiteR = GameObject.Find("whiteR");
        return whiteR.GetComponent<UnpoweredWireStat>().connected;
    }
    bool RedIsConnected()
    {
        redR = GameObject.Find("redR");
        return redR.GetComponent<UnpoweredWireStat>().connected;
    }
    bool BlueIsConnected()
    {
        blueR = GameObject.Find("blueR");
        return blueR.GetComponent<UnpoweredWireStat>().connected;
    }


}

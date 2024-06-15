using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detecting_Collision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter");
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("collision stay");
        if (Input.GetKey("i"))
        {
            Debug.Log(collision.gameObject.name + " selected");
            SceneManager.LoadScene(1);
        }
        // collision.gameObject.name
    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("entered trigger");
    }
    private void OnTriggerStay(Collider collider)
    {
        Debug.Log("trigger stay");
    }

}

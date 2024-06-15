using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public float moveSpeed = 10.4f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += moveSpeed * Time.deltaTime;
        }
        transform.position = pos;


        Vector2 green_car_location = new Vector2(-3, -3);
        Vector2 pink_car_location = new Vector2(2, 2);
        Vector2 blue_car_location = new Vector2(-3, 2);
        Vector2 yellow_car_location = new Vector2(-2, 0);
        Vector2 red_car_location = new Vector2(2, 0);
        // Vector2 white_car_location = new Vector2(2, 0);
        Vector2 purple_car_location = new Vector2(3, -2);


        (float, string) distance_to_green = (Vector2.Distance(pos, green_car_location), "green");
        (float, string) distance_to_blue = (Vector2.Distance(pos, blue_car_location), "blue");
        (float, string) distance_to_pink = (Vector2.Distance(pos, pink_car_location), "pink");
        (float, string) distance_to_yellow = (Vector2.Distance(pos, yellow_car_location), "yellow");
        (float, string) distance_to_red = (Vector2.Distance(pos, red_car_location), "red");
        (float, string) distance_to_purple = (Vector2.Distance(pos, purple_car_location), "purple");

        List<(float, string)> listOfTuples = new List<(float, string)>
        {
            distance_to_green,
            distance_to_pink,
            distance_to_blue,
            distance_to_yellow,
            distance_to_red,
            // distance_to_white,
            distance_to_purple
        };

        // Debug.Log(distance.ToString());
        if (Input.GetKey("i"))
        {
            (float, string) closestCar = listOfTuples.Min();
            if (closestCar.Item1 < 2.5)
            {
                Debug.Log("player selected " + closestCar.Item2);
            }
            else
            {
                Debug.Log("too far");
            }
        }
    }

}
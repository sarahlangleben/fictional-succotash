using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinColor : MonoBehaviour
{
    Vector2 mousePos;
    public SpriteRenderer spriteRenderer;
    // first letter is column
    // second is row
    UnityEngine.Color color;
    UnityEngine.Color aa = new UnityEngine.Color(254f / 255f, 233f / 255f, 206f / 255f);
    UnityEngine.Color ab = new UnityEngine.Color(254f / 255f, 226f / 255f, 215f / 255f);
    UnityEngine.Color ac = new UnityEngine.Color(254f / 255f, 235f / 255f, 231f / 255f);
    UnityEngine.Color ba = new UnityEngine.Color(253f / 255f, 210f / 255f, 159f / 255f);
    UnityEngine.Color bb = new UnityEngine.Color(245f / 255f, 206f / 255f, 189f / 255f);
    UnityEngine.Color bc = new UnityEngine.Color(237f / 255f, 208f / 255f, 202f / 255f);
    UnityEngine.Color ca = new UnityEngine.Color(239f / 255f, 175f / 255f, 101f / 255f);
    UnityEngine.Color cb = new UnityEngine.Color(222f / 255f, 154f / 255f, 109f / 255f);
    UnityEngine.Color cc = new UnityEngine.Color(208f / 255f, 156f / 255f, 132f / 255f);
    UnityEngine.Color da = new UnityEngine.Color(208f / 255f, 131f / 255f, 63f / 255f);
    UnityEngine.Color db = new UnityEngine.Color(196f / 255f, 107f / 255f, 67f / 255f);
    UnityEngine.Color dc = new UnityEngine.Color(177f / 255f, 113f / 255f, 85f / 255f);
    UnityEngine.Color ea = new UnityEngine.Color(174f / 255f, 95f / 255f, 38f / 255f);
    UnityEngine.Color eb = new UnityEngine.Color(171f / 255f, 83f / 255f, 47f / 255f);
    UnityEngine.Color ec = new UnityEngine.Color(142f / 255f, 86f / 255f, 61f / 255f);
    UnityEngine.Color fa = new UnityEngine.Color(143f / 255f, 76f / 255f, 21f / 255f);
    UnityEngine.Color fb = new UnityEngine.Color(147f / 255f, 64f / 255f, 32f / 255f);
    UnityEngine.Color fc = new UnityEngine.Color(113f / 255f, 68f / 255f, 45f / 255f);
    UnityEngine.Color ga = new UnityEngine.Color(113f / 255f, 59f / 255f, 13f / 255f);
    UnityEngine.Color gb = new UnityEngine.Color(114f / 255f, 52f / 255f, 27f / 255f);
    UnityEngine.Color gc = new UnityEngine.Color(91f / 255f, 56f / 255f, 37f / 255f);
    UnityEngine.Color ha = new UnityEngine.Color(89f / 255f, 45f / 255f, 5f / 255f);
    UnityEngine.Color hb = new UnityEngine.Color(89f / 255f, 40f / 255f, 23f / 255f);
    UnityEngine.Color hc = new UnityEngine.Color(72f / 255f, 43f / 255f, 29f / 255f);
    UnityEngine.Color ia = new UnityEngine.Color(71f / 255f, 35f / 255f, 0f / 255f);
    UnityEngine.Color ib = new UnityEngine.Color(70f / 255f, 30f / 255f, 20f / 255f);
    UnityEngine.Color ic = new UnityEngine.Color(58f / 255f, 33f / 255f, 26f / 255f);
    UnityEngine.Color ja = new UnityEngine.Color(46f / 255f, 21f / 255f, 0f / 255f);
    UnityEngine.Color jb = new UnityEngine.Color(48f / 255f, 20f / 255f, 17f / 255f);
    UnityEngine.Color jc = new UnityEngine.Color(38f / 255f, 22f / 255f, 23f / 255f);
    UnityEngine.Color ka = new UnityEngine.Color(25f / 255f, 11f / 255f, 0f / 255f);
    UnityEngine.Color kb = new UnityEngine.Color(25f / 255f, 10f / 255f, 15f / 255f);
    UnityEngine.Color kc = new UnityEngine.Color(21f / 255f, 11f / 255f, 20f / 255f);

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        mousePos = Input.mousePosition;
        // Debug.Log("x coordinate: " + mousePos.x);
        // Debug.Log("ycoord: " + mousePos.y);
        // Debug.Log(spriteRenderer.color);
        // color = ja;
        // FIRST ROW
        // mousePos.y greater than 430, then its row A. 

        if (mousePos.y > 430)
        // ROW A
        {
            if (mousePos.x >= 480 && mousePos.x <= 500)
            {
                spriteRenderer.color = aa;
            }
            else if (mousePos.x >= 501 && mousePos.x <= 520)
            {
                spriteRenderer.color = ba;
            }
            else if (mousePos.x >= 521 && mousePos.x <= 540)
            {
                spriteRenderer.color = ca;
            }
            else if (mousePos.x >= 541 && mousePos.x <= 560)
            {
                spriteRenderer.color = da;
            }
            else if (mousePos.x >= 561 && mousePos.x <= 580)
            {
                spriteRenderer.color = ea;
            }
            else if (mousePos.x >= 581 && mousePos.x <= 600)
            {
                spriteRenderer.color = fa;
            }
            else if (mousePos.x >= 601 && mousePos.x <= 620)
            {
                spriteRenderer.color = ga;
            }
            else if (mousePos.x >= 621 && mousePos.x <= 640)
            {
                spriteRenderer.color = ha;
            }
            else if (mousePos.x >= 641 && mousePos.x <= 660)
            {
                spriteRenderer.color = ia;
            }
            else if (mousePos.x >= 661 && mousePos.x <= 680)
            {
                spriteRenderer.color = ja;
            }
            else if (mousePos.x >= 681 && mousePos.x <= 700)
            {
                spriteRenderer.color = ka;
            }
        }
        // ROW B
        else if (mousePos.y < 430)
        {
            if (mousePos.x >= 480 && mousePos.x <= 500)
            {
                spriteRenderer.color = ab;
            }
            else if (mousePos.x >= 501 && mousePos.x <= 520)
            {
                spriteRenderer.color = bb;
            }
            else if (mousePos.x >= 521 && mousePos.x <= 540)
            {
                spriteRenderer.color = cb;
            }
            else if (mousePos.x >= 541 && mousePos.x <= 560)
            {
                spriteRenderer.color = db;
            }
            else if (mousePos.x >= 561 && mousePos.x <= 580)
            {
                spriteRenderer.color = eb;
            }
            else if (mousePos.x >= 581 && mousePos.x <= 600)
            {
                spriteRenderer.color = fb;
            }
            else if (mousePos.x >= 601 && mousePos.x <= 620)
            {
                spriteRenderer.color = gb;
            }
            else if (mousePos.x >= 621 && mousePos.x <= 640)
            {
                spriteRenderer.color = hb;
            }
            else if (mousePos.x >= 641 && mousePos.x <= 660)
            {
                spriteRenderer.color = ib;
            }
            else if (mousePos.x >= 661 && mousePos.x <= 680)
            {
                spriteRenderer.color = jb;
            }
            else if (mousePos.x >= 681 && mousePos.x <= 700)
            {
                spriteRenderer.color = kb;
            }
        }
        // ROW C
        else if (mousePos.y < 389)
        {

            if (mousePos.x >= 480 && mousePos.x <= 500)
            {
                spriteRenderer.color = ac;
            }
            else if (mousePos.x >= 501 && mousePos.x <= 520)
            {
                spriteRenderer.color = bc;
            }
            else if (mousePos.x >= 521 && mousePos.x <= 540)
            {
                spriteRenderer.color = cc;
            }
            else if (mousePos.x >= 541 && mousePos.x <= 560)
            {
                spriteRenderer.color = dc;
            }
            else if (mousePos.x >= 561 && mousePos.x <= 580)
            {
                spriteRenderer.color = ec;
            }
            else if (mousePos.x >= 581 && mousePos.x <= 600)
            {
                spriteRenderer.color = fc;
            }
            else if (mousePos.x >= 601 && mousePos.x <= 620)
            {
                spriteRenderer.color = gc;
            }
            else if (mousePos.x >= 621 && mousePos.x <= 640)
            {
                spriteRenderer.color = hc;
            }
            else if (mousePos.x >= 641 && mousePos.x <= 660)
            {
                spriteRenderer.color = ic;
            }
            else if (mousePos.x >= 661 && mousePos.x <= 680)
            {
                spriteRenderer.color = jc;
            }
            else if (mousePos.x >= 681 && mousePos.x <= 700)
            {
                spriteRenderer.color = kc;
            }
        }
    }
}
// if (mousePos.y >= 320)
// {
//     // Row A
//     if (mousePos.x <= 375)
//     {
//         spriteRenderer.color = aa;
//     }
//     else if (mousePos.x >= 376 && mousePos.x <= 400)
//     {
//         spriteRenderer.color = ba;
//     }
//     else if (mousePos.x >= 401 && mousePos.x <= 425)
//     {
//         spriteRenderer.color = ca;
//     }
//     else if (mousePos.x >= 426 && mousePos.x <= 450)
//     {
//         spriteRenderer.color = da;
//     }
//     else if (mousePos.x >= 451 && mousePos.x <= 475)
//     {
//         spriteRenderer.color = ea;
//     }
//     else if (mousePos.x >= 476 && mousePos.x <= 500)
//     {
//         spriteRenderer.color = fa;
//     }
//     else if (mousePos.x >= 501 && mousePos.x <= 525)
//     {
//         spriteRenderer.color = ga;
//     }
//     else if (mousePos.x >= 526 && mousePos.x <= 550)
//     {
//         spriteRenderer.color = ha;
//     }
//     else if (mousePos.x >= 551 && mousePos.x <= 575)
//     {
//         spriteRenderer.color = ia;
//     }
//     else if (mousePos.x >= 576 && mousePos.x <= 600)
//     {
//         spriteRenderer.color = ja;
//     }
//     else if (mousePos.x >= 601 && mousePos.x <= 625)
//     {
//         spriteRenderer.color = ka;
//     };
// }
// else if (mousePos.y <= 320 && mousePos.y >= 290)
// {
//     // row b
//     if (mousePos.x <= 375)
//     {
//         spriteRenderer.color = ab;
//     }
//     else if (mousePos.x >= 376 && mousePos.x <= 400)
//     {
//         spriteRenderer.color = bb;
//     }
//     else if (mousePos.x >= 401 && mousePos.x <= 425)
//     {
//         spriteRenderer.color = cb;
//     }
//     else if (mousePos.x >= 426 && mousePos.x <= 450)
//     {
//         spriteRenderer.color = db;
//     }
//     else if (mousePos.x >= 451 && mousePos.x <= 475)
//     {
//         spriteRenderer.color = eb;
//     }
//     else if (mousePos.x >= 476 && mousePos.x <= 500)
//     {
//         spriteRenderer.color = fb;
//     }
//     else if (mousePos.x >= 501 && mousePos.x <= 525)
//     {
//         spriteRenderer.color = gb;
//     }
//     else if (mousePos.x >= 526 && mousePos.x <= 550)
//     {
//         spriteRenderer.color = hb;
//     }
//     else if (mousePos.x >= 551 && mousePos.x <= 575)
//     {
//         spriteRenderer.color = ib;
//     }
//     else if (mousePos.x >= 576 && mousePos.x <= 600)
//     {
//         spriteRenderer.color = jb;
//     }
//     else if (mousePos.x >= 601 && mousePos.x <= 625)
//     {
//         spriteRenderer.color = kb;
//     };
// }
// else if (mousePos.y <= 290 && mousePos.y >= 260)
// {
//     // row c
//     if (mousePos.x <= 375)
//     {
//         spriteRenderer.color = ac;
//     }
//     else if (mousePos.x >= 376 && mousePos.x <= 400)
//     {
//         spriteRenderer.color = bc;
//     }
//     else if (mousePos.x >= 401 && mousePos.x <= 425)
//     {
//         spriteRenderer.color = cc;
//     }
//     else if (mousePos.x >= 426 && mousePos.x <= 450)
//     {
//         spriteRenderer.color = dc;
//     }
//     else if (mousePos.x >= 451 && mousePos.x <= 475)
//     {
//         spriteRenderer.color = ec;
//     }
//     else if (mousePos.x >= 476 && mousePos.x <= 500)
//     {
//         spriteRenderer.color = fc;
//     }
//     else if (mousePos.x >= 501 && mousePos.x <= 525)
//     {
//         spriteRenderer.color = gc;
//     }
//     else if (mousePos.x >= 526 && mousePos.x <= 550)
//     {
//         spriteRenderer.color = hc;
//     }
//     else if (mousePos.x >= 551 && mousePos.x <= 575)
//     {
//         spriteRenderer.color = ic;
//     }
//     else if (mousePos.x >= 576 && mousePos.x <= 600)
//     {
//         spriteRenderer.color = jc;
//     }
//     else if (mousePos.x >= 601 && mousePos.x <= 625)
//     {
//         spriteRenderer.color = kc;
//     };


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    GameObject[] childs;
    GameObject queenFront;
    GameObject queenBack;
    GameObject queenRight;
    GameObject queenLeft;
    // Start is called before the first frame update
    void Start()
    {
        queenFront = GameObject.Find("QueenFront");
        queenBack = GameObject.Find("QueenBack");
        queenRight = GameObject.Find("QueenRight");
        queenLeft = GameObject.Find("QueenLeft");
        childs = new GameObject[4] { queenFront, queenBack, queenRight, queenLeft };
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject i in childs)
        {
            Vector3 pos = Camera.main.WorldToViewportPoint(i.transform.position);


            if (pos.y > 1f)
            {
                if (ArmourStand.instance.isClothChanged)
                {

                }
            }



            i.transform.position = Camera.main.ViewportToWorldPoint(pos);
        }
    }
}

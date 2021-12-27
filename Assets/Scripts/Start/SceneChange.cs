using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    GameObject[] childs;
    GameObject Front;
    GameObject Back;
    GameObject Left;
    GameObject Right;

    // Start is called before the first frame update
    void Start()
    {
        childs = new GameObject[4] { Front, Back, Left, Right };
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject i in childs)
        {
            Vector3 pos = Camera.main.WorldToViewportPoint(i.transform.position);


            if (pos.y > 1f)
            {
                pos.y = 1f;
            }



            i.transform.position = Camera.main.ViewportToWorldPoint(pos);
        }
    }
}

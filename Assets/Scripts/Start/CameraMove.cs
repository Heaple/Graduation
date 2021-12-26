using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    GameObject[] childs;
    GameObject CharacterFront = Character.instance.CharacterFront;
    GameObject CharacterBack = Character.instance.CharacterBack;
    GameObject CharacterLeft = Character.instance.CharacterLeft;
    GameObject CharacterRight = Character.instance.CharacterRight;
    // Start is called before the first frame update
    void Start()
    {
        childs = new GameObject[4] { CharacterFront, CharacterBack, CharacterRight, CharacterLeft };
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject i in childs)
        {
            Vector3 pos = Camera.main.WorldToViewportPoint(i.transform.position);

            if (pos.x < 0f) pos.x = 0f;

            if (pos.x > 1f) pos.x = 1f;

            if (pos.y < 0f) pos.y = 0f;



            i.transform.position = Camera.main.ViewportToWorldPoint(pos);
        }
    }
}

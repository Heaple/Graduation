using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{
    Vector3 mousePos, transPos;
    GameObject Eraser;
    private void Start()
    {
        Eraser = GameObject.Find("Eraser");
    }
    private void Update()
    {
        mousePos = Input.mousePosition;
        transPos = Camera.main.ScreenToWorldPoint(mousePos);
        Eraser.transform.position = new Vector3(transPos.x, transPos.y, 0);
    }
}

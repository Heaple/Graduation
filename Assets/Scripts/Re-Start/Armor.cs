using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour
{
    GameObject e;
    GameObject Front;
    GameObject Back;
    GameObject Left;
    GameObject Right;
    GameObject PrevArmorStand;
    GameObject ExplorerFront;
    GameObject ExplorerBack;
    GameObject ExplorerLeft;
    GameObject ExplorerRight;
    GameObject ChangedArmorStand;
    // Start is called before the first frame update
    void Start()
    {
        Front = GameObject.Find("Front");
        Back = GameObject.Find("Back");
        Left = GameObject.Find("Left");
        Right = GameObject.Find("Right");
        PrevArmorStand = GameObject.Find("ArmorStand");
        ExplorerFront = GameObject.Find("ExplorerFront");
        ExplorerBack = GameObject.Find("ExplorerBack");
        ExplorerLeft = GameObject.Find("ExplorerLeft");
        ExplorerRight = GameObject.Find("ExplorerRight");
        ChangedArmorStand = GameObject.Find("ChangedArmorStand");
        e = GameObject.Find("e");
        e.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Variable.instance.isClothChanged)
        {
            e.SetActive(true);
        }
        Debug.Log("ENTER");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        e.SetActive(false);
        Debug.Log("EXIT");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("E");
            Front.GetComponent<SpriteRenderer>().sprite = ExplorerFront.GetComponent<SpriteRenderer>().sprite;
            Back.GetComponent<SpriteRenderer>().sprite = ExplorerBack.GetComponent<SpriteRenderer>().sprite;
            Left.GetComponent<SpriteRenderer>().sprite = ExplorerLeft.GetComponent<SpriteRenderer>().sprite;
            Right.GetComponent<SpriteRenderer>().sprite = ExplorerRight.GetComponent<SpriteRenderer>().sprite;
            PrevArmorStand.GetComponent<SpriteRenderer>().sprite = ChangedArmorStand.GetComponent<SpriteRenderer>().sprite;
            Variable.instance.isClothChanged = true;
        }
    }
}

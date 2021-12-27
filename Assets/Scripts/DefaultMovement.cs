using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultMovement : MonoBehaviour
{

    int playerSpeed = 5;
    GameObject Front;
    GameObject Back;
    GameObject Left;
    GameObject Right;
    GameObject nowObj;

    // Start is called before the first frame update
    void Start()
    {
        Front = GameObject.Find("Front");
        Back = GameObject.Find("Back");
        Left = GameObject.Find("Left");
        Right = GameObject.Find("Right");
        nowObj = Front;
        nowObj.transform.position = new Vector3(19, -4, 0);
        ChangeCharacter(nowObj, nowObj);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            ChangeCharacter(nowObj, Back);
            nowObj = Back;
            nowObj.transform.Translate(new Vector3(0, playerSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            ChangeCharacter(nowObj, Front);
            nowObj = Front;
            nowObj.transform.Translate(new Vector3(0, -playerSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            ChangeCharacter(nowObj, Left);
            nowObj = Left;
            nowObj.transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            ChangeCharacter(nowObj, Right);
            nowObj = Right;
            nowObj.transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0, 0));
        }
    }

    void ChangeCharacter(GameObject prevMainObj, GameObject mainObj)
    {
        List<GameObject> characters = new List<GameObject>() { Front, Back, Right, Left };
        mainObj.gameObject.tag = "NowDir";
        prevMainObj.gameObject.tag.Remove(0);
        characters.RemoveAt(characters.IndexOf(mainObj));
        mainObj.transform.position = prevMainObj.transform.position;
        mainObj.SetActive(true);
        this.gameObject.transform.position = mainObj.transform.position;
        foreach (GameObject i in characters)
        {
            i.SetActive(false);
            i.transform.position = mainObj.transform.position;

        }
    }
}

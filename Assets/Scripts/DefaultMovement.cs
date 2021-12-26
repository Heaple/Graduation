using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultMovement : MonoBehaviour
{

    int playerSpeed = 5;
    GameObject CharacterFront = Character.instance.CharacterFront;
    GameObject CharacterBack = Character.instance.CharacterBack;
    GameObject CharacterLeft = Character.instance.CharacterLeft;
    GameObject CharacterRight = Character.instance.CharacterRight;
    GameObject mainObject;

    // Start is called before the first frame update
    void Start()
    {
        CharacterFront = GameObject.Find("QueenFront");
        CharacterBack = GameObject.Find("QueenBack");
        CharacterRight = GameObject.Find("QueenRight");
        CharacterLeft = GameObject.Find("QueenLeft");
        mainObject = CharacterFront;
        ChangeCharacter(mainObject, mainObject);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            ChangeCharacter(mainObject, CharacterBack);
            mainObject = CharacterBack;
            mainObject.transform.Translate(new Vector3(0, playerSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            ChangeCharacter(mainObject, CharacterFront);
            mainObject = CharacterFront;
            mainObject.transform.Translate(new Vector3(0, -playerSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            ChangeCharacter(mainObject, CharacterLeft);
            mainObject = CharacterLeft;
            mainObject.transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            ChangeCharacter(mainObject, CharacterRight);
            mainObject = CharacterRight;
            mainObject.transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0, 0));
        }
    }

    void ChangeCharacter(GameObject prevMainObj, GameObject mainObj)
    {
        List<GameObject> characters = new List<GameObject>() { CharacterFront, CharacterBack, CharacterRight, CharacterLeft };
        characters.RemoveAt(characters.IndexOf(mainObj));
        mainObj.transform.position = prevMainObj.transform.position;
        mainObj.SetActive(true);
        foreach (GameObject i in characters)
        {
            i.SetActive(false);
        }
    }}

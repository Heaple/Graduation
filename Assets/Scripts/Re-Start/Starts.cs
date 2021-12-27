using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Starts : MonoBehaviour
{
    int playerSpeed = 5;
    GameObject Front;
    GameObject Back;
    GameObject Left;
    GameObject Right;
    GameObject outsidE;
    [HideInInspector] public GameObject nowObj;
    GameObject[] CharacterList = new GameObject[4];


    // Start is called before the first frame update
    void Start()
    {
        Front = GameObject.Find("Front");
        Back = GameObject.Find("Back");
        Left = GameObject.Find("Left");
        Right = GameObject.Find("Right");
        outsidE = GameObject.Find("outsidE");
        outsidE.SetActive(false);
        nowObj = Front;
        CharacterList[0] = Front;
        CharacterList[1] = Back;
        CharacterList[2] = Left;
        CharacterList[3] = Right;
        nowObj.transform.position = new Vector3(0.3f, -1.37f, 0);
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
        Vector3 viewPos = Camera.main.WorldToViewportPoint(nowObj.transform.position); //캐릭터의 월드 좌표를 뷰포트 좌표계로 변환해준다.
        viewPos.x = Mathf.Clamp01(viewPos.x); //x값을 0이상, 1이하로 제한한다.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y값을 0이상, 1이하로 제한한다.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos); //다시 월드 좌표로 변환한다.
        nowObj.transform.position = worldPos; //좌표를 적용한다.

        if (viewPos.y == 1f)
        {
            if (Variable.instance.isClothChanged)
            {
                outsidE.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("SelectTown");
                }
            }
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

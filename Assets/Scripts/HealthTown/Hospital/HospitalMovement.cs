using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HospitalMovement : MonoBehaviour
{
    int playerSpeed = 5;
    GameObject Front;
    GameObject Back;
    GameObject Left;
    GameObject Right;
    GameObject CollisionTamji;
    GameObject nowObj;
    GameObject e;
    GameObject milkbox;
    GameObject[] CharacterList = new GameObject[4];


    // Start is called before the first frame update
    void Start()
    {
        SetResolution();
        Front = GameObject.Find("Front");
        Back = GameObject.Find("Back");
        Left = GameObject.Find("Left");
        Right = GameObject.Find("Right");
        CollisionTamji = GameObject.Find("CollisionTamji");
        e = GameObject.Find("e");
        milkbox = GameObject.Find("milkbox");
        nowObj = Back;
        CharacterList[0] = Front;
        CharacterList[1] = Back;
        CharacterList[2] = Left;
        CharacterList[3] = Right;
        ChangeCharacter(nowObj, nowObj);
        if (HealthTownManager.instance.isBoardCleanFinish)
        {
            nowObj.transform.position = new Vector3(6.8f, 2.65f, 0);
        }
        if (HealthTownManager.instance.isQuestFinish) {
            nowObj.transform.position = new Vector3(-0.18f, -3.9f, 0);
        }

        if (HealthTownManager.instance.isMilkTrashFinish) {
            milkbox.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthTownManager.instance.isMilkTrashFinish && HealthTownManager.instance.isBoardCleanFinish)
        {
            HealthTownManager.instance.isQuestFinish = true;
        }

        if (HealthTownManager.instance.canMove)
        {
            if (HealthTownManager.instance.isPullingMilkbox)
            {
                float nowX = nowObj.transform.position.x;
                float nowY = nowObj.transform.position.y;
                milkbox.transform.position = new Vector3(nowX+=0.5f, nowY, 0);
            }
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
            Vector3 viewPos = Camera.main.WorldToViewportPoint(nowObj.transform.position);

            viewPos.x = Mathf.Clamp01(viewPos.x);
            viewPos.y = Mathf.Clamp01(viewPos.y);
            Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);
            nowObj.transform.position = worldPos;
            if (viewPos.y <= 0)
            {
                SceneManager.LoadScene("HealthTown");
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
        CollisionTamji.gameObject.transform.position = mainObj.transform.position;
        this.gameObject.transform.position = mainObj.transform.position;
        foreach (GameObject i in characters)
        {
            i.SetActive(false);
            i.transform.position = mainObj.transform.position;

        }
    }

    public void SetResolution()
    {
        int setWidth = 1920;
        int setHeight = 1080;

        int deviceWidth = Screen.width;
        int deviceHeight = Screen.height;
        
        Screen.SetResolution(setWidth, (int)(((float)deviceHeight / deviceWidth) * setWidth), true);

        if ((float)setWidth / setHeight < (float)deviceWidth / deviceHeight)
        {
            float newWidth = ((float)setWidth / setHeight) / ((float)deviceWidth / deviceHeight);
            Camera.main.rect = new Rect((1f - newWidth) / 2f, 0f, newWidth, 1f);
        }
        else
        {
            float newHeight = ((float)deviceWidth / deviceHeight) / ((float)setWidth / setHeight);
            Camera.main.rect = new Rect(0f, (1f - newHeight) / 2f, 1f, newHeight);
        }
    }
}

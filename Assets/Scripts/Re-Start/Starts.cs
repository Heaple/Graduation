using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Starts : MonoBehaviour
{
    int playerSpeed = 5;
    public GameObject InfoCanvas;
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
        SetResolution();
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
        if (Variable.instance.canMove)
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
            Vector3 viewPos = Camera.main.WorldToViewportPoint(nowObj.transform.position); //ĳ������ ���� ��ǥ�� ����Ʈ ��ǥ��� ��ȯ���ش�.
            viewPos.x = Mathf.Clamp01(viewPos.x); //x���� 0�̻�, 1���Ϸ� �����Ѵ�.
            viewPos.y = Mathf.Clamp01(viewPos.y); //y���� 0�̻�, 1���Ϸ� �����Ѵ�.
            Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos); //�ٽ� ���� ��ǥ�� ��ȯ�Ѵ�.
            nowObj.transform.position = worldPos; //��ǥ�� �����Ѵ�.

            if (viewPos.y == 1f)
            {
                outsidE.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    if (!Variable.instance.isClothChanged)
                    {
                        InfoCanvas.SetActive(true);
                        Variable.instance.canMove = false;
                    }
                    else
                    {
                        SceneManager.LoadScene("SelectTown");
                    }
                }
            } else
            {
                outsidE.SetActive(false);
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

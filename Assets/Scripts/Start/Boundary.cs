using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    GameObject[] CharacterList = new GameObject[4];
    Camera mainCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
    Vector3 screenPoint;
    // Start is called before the first frame update
    void Start()
    {
        CharacterList[0] = GameObject.Find("Front");
        CharacterList[1] = GameObject.Find("Back");
        CharacterList[2] = GameObject.Find("Left");
        CharacterList[3] = GameObject.Find("Right");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject i in CharacterList)
        {
            screenPoint = mainCamera.WorldToViewportPoint(GameObject.FindGameObjectWithTag("NowDir").transform.position);
            // WorldToViewportPoint�� ī�޶� ���� ��ǥ(0~1)������ ��ǥ�� ���� ��ǥ�� ��ȯ�ϴ°�
            if (screenPoint.x > 1f)
            {
                screenPoint.x = 1f;
            }
            if (screenPoint.x < 0f)
            {
                screenPoint.x = 0f;
            }
            if (screenPoint.y > 1f)
            {
                screenPoint.y = 1f;
            }
            if (screenPoint.y < 0f)
            {
                screenPoint.y = 1f;
            }
        }
    }
}

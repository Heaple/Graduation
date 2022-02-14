using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HaonTalk : MonoBehaviour
{
    int clickCount = 0;
    public TextMeshProUGUI HaonText;
    public TextMeshProUGUI HaonName;
    GameObject needTalk;
    public GameObject jihoo;
    public GameObject taemin;
    public GameObject haon;


    // Start is called before the first frame update
    void Start()
    {
        jihoo = GameObject.Find("jihoo");
        taemin = GameObject.Find("taemin");
        needTalk = GameObject.Find("needTalk");
        needTalk.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PETownManager.instance.canMove = false;
        if (!PETownManager.instance.isGaveMap)
        {
            if (Input.GetMouseButtonDown(0))
            {
                clickCount++;
                if (clickCount == 1)
                {
                    HaonText.text = "(하온이네)";
                }
                if (clickCount == 2)
                {
                    HaonText.text = "(얘한테 있다고 했지)";
                }
                if (clickCount == 3)
                {
                    HaonName.text = "나";
                    HaonText.text = "하이 오랜만";
                }
                if (clickCount == 4)
                {
                    HaonName.text = "이하온";
                    HaonText.text = "오! 오랜만이네요!";
                }
                if (clickCount == 5)
                {
                    HaonText.text = "요즘 통 안찾아오시더니! 무슨일이시죠!";
                }
                if (clickCount == 6)
                {
                    HaonName.text = "나";
                    HaonText.text = "(다른애들이랑 놀았거든)";
                }
                if (clickCount == 7)
                {
                    HaonName.text = "나";
                    HaonText.text = "뭐... 요즘 좀 바빴긴 하지 하하";
                }
                if (clickCount == 8)
                {
                    jihoo.transform.position = new Vector3(-5.81f, 1.85f, 0) ;
                    taemin.transform.position = new Vector3(-7.21f, 1.72f, 0);
                    HaonName.text = "신지후";
                    HaonText.text = "하온아 배고파!";
                }
                if (clickCount == 9)
                {
                    HaonName.text = "이하온";
                    HaonText.text = "오";
                }
                if (clickCount == 10)
                {
                    HaonName.text = "김태민";
                    HaonText.text = "오 안녕하세요";
                }
                if (clickCount == 11)
                {
                    HaonName.text = "신지후";
                    HaonText.text = "오! 또보네요!";
                }
                if (clickCount == 12)
                {
                    HaonName.text = "이하온";
                    HaonText.text = "그래서 무슨일이실까요?";
                }
                if (clickCount == 13)
                {
                    HaonName.text = "나";
                    HaonText.text = "예원이한테서 지도빌려갔어?";
                }
                if (clickCount == 14)
                {
                    HaonName.text = "이하온";
                    HaonText.text = "그랬죠";
                }
                if (clickCount == 15)
                {
                    HaonName.text = "나";
                    HaonText.text = "내가 갈곳이 있는데 필요해서. 좀 빌려주라.";
                }
                if (clickCount == 16)
                {
                    HaonName.text = "이하온";
                    HaonText.text = "마침 돌려주려고 했는데! 잘됐네요! 쓰고 바로 예원이한테 돌려주세요!";
                }
                if (clickCount == 17)
                {
                    HaonName.text = "나";
                    HaonText.text = "감사! 다음에 보자!";
                }
                if (clickCount == 18)
                {
                    HaonText.text = "신지후랑 김태민도!";
                }
                if (clickCount == 19)
                {
                    HaonName.text = "김태민, 신지후";
                    HaonText.text = "나중에 봅시다!";
                }
                if (clickCount == 20)
                {
                    HaonName.text = "김태민";
                    HaonText.text = "야 우리 뭐먹을까?";
                }
                if (clickCount == 21)
                {
                    HaonName.text = "신지후";
                    HaonText.text = "하온이가 좋아하는 띠드버거 먹을까?";
                }
                if (clickCount == 22)
                {
                    HaonName.text = "이하온";
                    HaonText.text = "야;;";

                    jihoo.SetActive(false);
                    taemin.SetActive(false);
                    haon.SetActive(false);

                }
                if (clickCount == 23)
                {
                    HaonName.text = "나";
                    HaonText.text = "사이 참 좋네";
                }
                if (clickCount == 24)
                {
                    PETownManager.instance.isGaveMap = true;
                    PETownManager.instance.canMove = true;
                    Manager.instance.isPEFinish = true;
                    this.gameObject.SetActive(false);
                    
                }

            }
        }
    }
}

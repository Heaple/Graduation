using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YeWon : MonoBehaviour
{
    public TextMeshProUGUI YeWonText;
    public TextMeshProUGUI YeWonName;
    public GameObject NameTag;
    int clickCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        HealthTownManager.instance.canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!HealthTownManager.instance.isQuestTalkFinish)
        {
            if (clickCount == 0) {
                YeWonName.text = "나";
                YeWonText.text = "예원아 마침 여기있었네!";
            }
            if (Input.GetMouseButtonDown(0))
            {
                clickCount++;
                if (clickCount == 1)
                {
                    YeWonName.text = "김예원";
                    YeWonText.text = "어! 안녕하세요!";
                }
                if (clickCount == 2)
                {
                    YeWonName.text = "나";
                    YeWonText.text = "안녕!";
                }
                if (clickCount == 3)
                {
                    YeWonName.text = "김예원";
                    YeWonText.text = "그건 그렇고 무슨일로?";
                }

                if (clickCount == 4)
                {
                    YeWonName.text = "나";
                    YeWonText.text = "아 그 고대의 동굴 있는 지도 빌려줘";
                }

                if (clickCount == 5)
                {
                    YeWonName.text = "김예원";
                    YeWonText.text = "내가 대가없이 굳이...?";
                }

                if (clickCount == 6)
                {
                    YeWonName.text = "나";
                    YeWonText.text = "내가 아무리 그래도... 이나라 왕이야... 좀 주라...";
                }

                if (clickCount == 7)
                {
                    YeWonName.text = "김예원";
                    YeWonText.text = "시른데용";
                }

                if (clickCount == 8)
                {
                    YeWonName.text = "나";
                    YeWonText.text = "내가 일 도와줄게. 칠판 지우고 우유 옮기면 되지?";
                }

                if (clickCount == 9)
                {
                    YeWonName.text = "김예원";
                    YeWonText.text = "이제 학습을 하셨네요.";
                }

                if (clickCount == 10)
                {
                    HealthTownManager.instance.canMove = true;
                    HealthTownManager.instance.isQuestTalkFinish = true;
                    this.gameObject.SetActive(false);
                }
            }
        } else if (HealthTownManager.instance.isQuestFinish)
        {
            if (clickCount == 0) {
                YeWonName.text = "김예원";
                YeWonText.text = "벌써 다했네...ㄷ";
            }
            if (Input.GetMouseButtonDown(0))
            {
                clickCount++;
                if (clickCount == 1)
                {
                    YeWonName.text = "나";
                    YeWonText.text = "에헤이. 날 뭘로 보고. 내가 몇번째 해주는건데.";
                }
                if (clickCount == 2)
                {
                    YeWonName.text = "김예원";
                    YeWonText.text = "정확히 말하면 나한테 없어요 ㅎㅎ";
                }
                if (clickCount == 3)
                {
                    YeWonName.text = "나";
                    YeWonText.text = "(저 친구가) 어디있는데 ^^";
                }

                if (clickCount == 4)
                {
                    YeWonName.text = "김예원";
                    YeWonText.text = "이하온한테 있는데요 ㅎㅎ";
                }

                if (clickCount == 5)
                {
                    YeWonName.text = "나";
                    YeWonText.text = "오케. 알려줘서 고맙...(지않)다";
                }

                if (clickCount == 6)
                {
                    YeWonName.text = "김예원";
                    YeWonText.text = "방금 뭐가 들린것 같은데 ^^ 안녕히가세요!";
                }

                if (clickCount == 7)
                {
                    HealthTownManager.instance.canMove = true;
                    Manager.instance.isHealthTownFinish = true;
                    this.gameObject.SetActive(false);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gunoo : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI name_;
    int clickCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        CleantownManager.instance.canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!CleantownManager.instance.isGameFinished)
        {
            if (clickCount == 0) {
                name_.text = "나";
                text.text = "(그래도 역사에 관심 있으니까 알수도)";
            }
            if (Input.GetMouseButtonDown(0))
            {

                clickCount++;
                
                if (clickCount == 1)
                {
                    name_.text = "나";
                    text.text = "야 하이";
                }
                if (clickCount == 2)
                {
                    name_.text = "나";
                    text.text = "고대의 동굴이라고 아냐?";

                }
                if (clickCount == 3)
                {
                    name_.text = "남건우";
                    text.text = "안녕하세요!";

                }
                if (clickCount == 4)
                {
                    name_.text = "남건우";
                    text.text = "고대의 동굴? 몰?루";
                }

                if (clickCount == 5)
                {
                    name_.text = "남건우";
                    text.text = "알만한 사람은 알죠";
                }
                if (clickCount == 6)
                {
                    name_.text = "나";
                    text.text = "누?구";
                }

                if (clickCount == 7)
                {
                    name_.text = "남건우";
                    text.text = "마침 내가 다리가 다쳤네? 청소 도와주면 알려드리죠 ㅎㅎ";
                }

                if (clickCount == 8)
                {
                    name_.text = "나";
                    text.text = "아이고 내가 허리가...";
                }

                if (clickCount == 9)
                {
                    name_.text = "남건우";
                    text.text = "빨리 하세요 ㅎ";
                }
                if (clickCount == 10)
                {
                    name_.text = "나";
                    text.text = "알겠어... 어디에서 하면 되는데...";
                }
                if (clickCount == 11)
                {
                    name_.text = "남건우";
                    text.text = "왼쪽으로 가면 있는 공원! 잘 부탁드립니다!";
                }

                if (clickCount == 12)
                {
                    this.gameObject.SetActive(false);
                    clickCount = 0;
                    CleantownManager.instance.isGunooTalk = true;
                    CleantownManager.instance.canMove = true;
                }
            }
        }
        else if (CleantownManager.instance.isGameFinished)
        {
            if (clickCount == 0) {
                name_.text = "남건우";
                text.text = "빨리 하셨네요?";
            }
            if (Input.GetMouseButtonDown(0))
            {

                clickCount++;


                if (clickCount == 1)
                {
                    name_.text = "나";
                    text.text = "내가 좀 하지!";
                }
                if (clickCount == 2)
                {
                    text.text = "그래서. 누구가 고대의 동굴에 대해 알만하지?";

                }
                if (clickCount == 3)
                {
                    name_.text = "남건우";
                    text.text = "김예원 예전 지도 같은거 모으는거 좋아해요. 걔한테 가보세요.";

                }
                if (clickCount == 4)
                {
                    name_.text = "나";
                    text.text = "알려줘서 고마워!";
                }
                if (clickCount == 5)
                {
                    this.gameObject.SetActive(false);
                    clickCount = 0;
                    CleantownManager.instance.canMove = true;
                    Manager.instance.isCleanTownFinish = true;
                }
            }
        }
    }
}

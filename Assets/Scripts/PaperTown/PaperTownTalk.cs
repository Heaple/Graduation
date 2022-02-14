using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
public class PaperTownTalk : MonoBehaviour
{
    int clickCount = 0;
    public TextMeshProUGUI text;
    public GameObject nameTag;
    public GameObject nightSky;
    public GameObject justBlack;
    public TextMeshProUGUI name_;
    GameObject needTalk;

    // Start is called before the first frame update
    void Start()
    {
            PaperTownManager.instance.canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PaperTownManager.instance.talkCnt == 0) {
            if (clickCount == 0) {
                text.text = "벌써 시간이 이러게 됬네...";
                name_.text = "나";
            }
            if (Input.GetMouseButtonDown(0)) {
                clickCount ++;
                if (clickCount == 1) {
                    text.text = "뭐야... 여기 왜 이렇게 깜깜해.";
                }

                if (clickCount == 2) {
                    text.text = "가로등좀 설치하지. 그건 그렇고 아무도 없나.";
                }
                if (clickCount == 3) {
                    name_.text = "???";
                    text.text = "저...";
                }
                if (clickCount == 4) {
                    name_.text = "나";
                    text.text = "!!!!!!!";
                }
                if (clickCount == 5) {
                    text.text = "...";
                }
                if (clickCount == 6) {
                    name_.text = "???";
                    text.text = "...";
                }
                if (clickCount == 7) {
                    text.text = "센세...?";
                }
                if (clickCount == 8) {
                    name_.text = "나";
                    text.text = "너 누구야...?";
                }
                if (clickCount == 9) {
                    text.text = "(뭐지 목소리가 익숙한데)";
                }
                if (clickCount == 10) {
                    name_.text = "황주하";
                    text.text = "왜 여기 있어요?";
                }
                if (clickCount == 12) {
                    name_.text = "나";
                    text.text = "너구나. 뭐... 심심해서 탐사차 왔는데 너무 늦어서 묵고 가려고.";
                }

                if (clickCount == 13) {
                    name_.text = "황주하";
                    text.text = "근데 여기는 잘 곳 없는데";
                }
                if (clickCount == 14) {
                    name_.text = "황주하";
                    text.text = "그래서 어디가 목적지죠?";
                }
                if (clickCount == 15) {
                    name_.text = "나";
                    text.text = "(지도를 보여준다.)";
                }
                if (clickCount == 16) {
                    name_.text = "황주하";
                    text.text = "아 여기. 왼쪽으로 쭉 가면 있어요";
                }
                if (clickCount == 17) {
                    name_.text = "나";
                    text.text = "고맙다";
                }
                if (clickCount == 18) {
                    text.text = "너가 여기 이장이냐?";
                }
                if (clickCount == 19) {
                    name_.text = "황주하";
                    text.text = "엄밀히 따지면 아니죠.";
                }
                if (clickCount == 20) {
                    text.text = "저는 체육마을 소속이거든요. 근데 이장이 잠수타서 하핳";
                }
                if (clickCount == 21) {
                    name_.text = "나";
                    text.text = "그렇구나... 그럼 가로등좀 달아";
                }
                if (clickCount == 22) {
                    name_.text = "황주하";
                    text.text = "나라에서 돈을 안줘요";
                }
                if (clickCount == 23) {
                    name_.text = "나";
                    text.text = "초콜릿 무역으로 돈 없다고";
                }
                if (clickCount == 24) {
                    text.text = "그러면 나는 여기서 잘테니까 너는 집가서 자.";
                }
                if (clickCount == 25) {
                    text.text = "다음부터 놀래키지좀 마 아까 진짜 심장 떨어질뻔 했어 ㅋㅋ";
                }
                if (clickCount == 26) {
                    name_.text = "황주하";
                    text.text = "뭐 의도한건 아니긴 한데 ㅋㅋ";
                }
                if (clickCount == 27) {
                    name_.text = "나";
                    text.text = "그럼 잘가!";
                }
                if (clickCount == 28) {
                    text.text = "알려줘서 고맙다!";
                }
                if (clickCount == 29) {
                    nameTag.SetActive(false);
                    nightSky.SetActive(true);
                    justBlack.SetActive(true);
                    GameObject.Find("juhwa").SetActive(false);
                    text.text = "...";
                }
                if (clickCount == 30) {
                    text.text = "별보이네...";
                }
                if (clickCount == 31) {
                    text.text = "근데... 이 바이러스 치료하면 조용해지는건가...";
                }
                if (clickCount == 32) {
                    text.text = "조용하겠지만 허전하겠네";
                }
                if (clickCount == 33) {
                    text.text = "재미도 없을것 같고";
                }
                if (clickCount == 34) {
                    text.text = "치료 하는게 맞나";
                }
                if (clickCount == 35) {
                    text.text = "생각해보니 애들이 참 친화력이 다 좋아";
                }
                if (clickCount == 36) {
                    text.text = "어떻게 백성이 왕국에 왕과 같이 놀아";
                }
                if (clickCount == 37) {
                    text.text = "쓸대없는 걱정하지 말고 자야지. 나라 유지가 최선이야.";
                }
                if (clickCount == 38) {
                    text.text = "아침이네...";
                    justBlack.SetActive(false);
                    SpriteRenderer spr = GameObject.Find("papertown").GetComponent<SpriteRenderer>();
                    Color col = spr.color;
                    col.a = 1f;
                    spr.color = col;
                }
                if (clickCount == 40) {
                    PaperTownManager.instance.isQuestTalkFinish = true;
                    this.gameObject.SetActive(false);
                    PaperTownManager.instance.canMove = true;
                    PaperTownManager.instance.isSleep = true;
                }
            }
        }
    }
}

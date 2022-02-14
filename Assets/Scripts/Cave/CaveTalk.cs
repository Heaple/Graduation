using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class CaveTalk : MonoBehaviour
{
    public GameObject TalkCanvas;
    public TextMeshProUGUI name_;
    public TextMeshProUGUI text_;
    public GameObject boonpillbackground;
    public GameObject boonpillbackgroundwithhand;
    public GameObject touchingglowboonpill;
    public GameObject seeingWatch;
    public GameObject a3oclock;
    public GameObject squeezeboonpill;
    public GameObject glowingboonpillbackgroundwithgini;
    public GameObject justBlack;
    public GameObject ceil;
    public int clickCont = 0;


    // Start is called before the first frame update
    void Start()
    {
        CaveManager.instance.canMove = false;
        if (CaveManager.instance.talkMod == 1) {
            text_.text = "이거... 애들이 보건소에서 낙서하던 분필이랑 똑같이 생겼다...";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CaveManager.instance.talkMod == 0) {
            text_.text = "오... 쩐다... 저기 앞에 뭔가 빛나고 있네...";
            if (Input.GetMouseButtonDown(0)) {
                CaveManager.instance.canMove = true;
                this.gameObject.SetActive(false);
            }
        }

        if (CaveManager.instance.talkMod == 1) {
            Debug.Log(clickCont);
            if (Input.GetMouseButtonDown(0)) {
                clickCont ++;
                if (clickCont == 0) {
                    text_.text = "이게 왜 여깄지...";
                }
                if (clickCont == 1) {
                    touchingglowboonpill.SetActive(true);
                    boonpillbackground.SetActive(false);
                    text_.text = "뭐야... 왜 빛이 사라졌어...";
                }
                if (clickCont == 2) {
                    touchingglowboonpill.SetActive(false);
                    boonpillbackgroundwithhand.SetActive(true);
                    text_.text = "이게 소중한 물건?";
                }
                if (clickCont == 3) {
                    text_.text = "생각보다 대단하진 않네...";
                }
                if (clickCont == 4) {
                    text_.text = "이 분필이 소중한 물건이라...";
                }
                if (clickCont == 5) {
                    boonpillbackgroundwithhand.SetActive(false);
                    seeingWatch.SetActive(true);
                }
                if (clickCont == 6) {
                    text_.text = "2시 59분...";
                }
                if (clickCont == 7) {
                    seeingWatch.SetActive(false);
                    squeezeboonpill.SetActive(true);
                    text_.text = "소원... 치료해달라고 빌면 되는거겠지...?";
                }
                if (clickCont == 8) {
                    text_.text = "좀 섭섭하다...";
                }
                if (clickCont == 9) {
                    text_.text = "(3시다.)";
                }
                if (clickCont == 10) {
                    text_.text = "(치료 하는게 맞을까. 치료를 하면 원래대로 돌아오는데...)";
                }
                if (clickCont == 11) {
                    text_.text = "그럼... 병ㅅ";
                }
                if (clickCont == 12) {
                    name_.text = "???";
                    text_.text = "뭐라고?";
                    glowingboonpillbackgroundwithgini.SetActive(true);
                    squeezeboonpill.SetActive(false);
                }
                if (clickCont == 13) {
                    name_.text = "나";
                    text_.text = "병신 바...";
                }
                if (clickCont == 14) {
                    name_.text = "???";
                    text_.text = "병신...? 나한테 한거야...? 마상...";
                }
                if (clickCont == 15) {
                    name_.text = "나";
                    text_.text = "유...유령? 으아아아악!!!!";
                }
                if (clickCont == 16) {
                    glowingboonpillbackgroundwithgini.SetActive(false);
                    justBlack.SetActive(true);
                    name_.text = "???";
                    text_.text = "죽었나?";

                }
                if (clickCont == 17) {
                    TalkCanvas.SetActive(false);
                    Invoke("OnInvoke", 3.0f);
                }
                if (clickCont == 18) {
                    text_.text = "아 까비 깼네.";
                    ceil.SetActive(false);
                    glowingboonpillbackgroundwithgini.SetActive(true);
                }
                if (clickCont == 19) {
                    name_.text = "나";
                    text_.text = "유령!!! 아이고 나죽네에에에";
                }
                if (clickCont == 20) {
                    name_.text = "유령";
                    text_.text = "알겠으니까 좀 조용히 있어봐. 시끄러워.";
                }
                if (clickCont == 21) {
                    name_.text = "나";
                    text_.text = "지금 몇시야...";
                }
                if (clickCont == 22) {
                    name_.text = "유령";
                    text_.text = "4시 30분. 30분 남았어";
                }
                if (clickCont == 23) {
                    name_.text = "나";
                    text_.text = "분필은?";
                }
                if (clickCont == 24) {
                    name_.text = "유령";
                    text_.text = "이게 분필로 보인다면 니 옆에 있다.";
                }
                if (clickCont == 25) {
                    name_.text = "나";
                    text_.text = "너한텐 이게 다르게 보여?";
                }
                if (clickCont == 26) {
                    name_.text = "유령";
                    text_.text = "사람마다 소중한게 다르잖아. 너에겐 니가 말한 분필이 제일 소중한거고.";
                }
                if (clickCont == 27) {
                    name_.text = "나";
                    text_.text = "그렇구나...";
                }
                if (clickCont == 28) {
                    name_.text = "유령";
                    text_.text = "소원 빌러 왔지? 소원은 정했고? 무슨 사연 때문에 온거야? 내가 있는지는 어떻게 알았고?";
                }
                if (clickCont == 29) {
                    name_.text = "나";
                    text_.text = "왜 왔냐면 병신 바이러스가 퍼져서 치료하기 위해 왔고,";
                }
                if (clickCont == 30) {
                    name_.text = "나";
                    text_.text = "어떻게 왔냐면, 예전에 선조님이 남겨주신 책 보고 왔어.";
                }
                if (clickCont == 31) {
                    name_.text = "유령";
                    text_.text = "그렇군... 김씨 가문인가... 시간 별로 없다. 소원이나 빌어.";
                }
                if (clickCont == 32) {
                    name_.text = "나";
                    text_.text = "매달 내가 원하는 만큼의 돈을 줘! 그게 내 소원이야!";
                }
                if (clickCont == 33) {
                    name_.text = "유령";
                    text_.text = "진부하지만... 매달 달라는건 새롭네(욕심도 더 많고). 뭐 내가 내는것도 아니지만.";
                }
                if (clickCont == 34) {
                    name_.text = "나";
                    text_.text = "근데 누구...?";
                }
                if (clickCont == 35) {
                    name_.text = "유령";
                    text_.text = "지니라고 들어 봤니?";
                }
                if (clickCont == 36) {
                    name_.text = "나";
                    text_.text = "오... 심상치 않은데...";
                }
                if (clickCont == 37) {
                    text_.text = "그럼 너가 내 소원을 들어주는거야?";
                }
                if (clickCont == 38) {
                    name_.text = "지니";
                    text_.text = "표면적으로는 그렇게 보이지.";
                }
                if (clickCont == 39) {
                    text_.text = "그럼 소원 성립. 매달 오늘 0시 0분 0초에 너한테 가져다 줄게.";
                }
                if (clickCont == 40) {
                    name_.text = "나";
                    text_.text = "끝이야?";
                }
                if (clickCont == 41) {
                    name_.text = "지니";
                    text_.text = "응요즘은 간편한게 대세라서 핸드폰 어플로 편하게 돼.";
                }
                if (clickCont == 42) {
                    name_.text = "나";
                    text_.text = "그럼 잘 부탁해";
                }

                if (clickCont == 43) {
                    name_.text = "지니";
                    text_.text = "집까지 걸어가기 지쳤을텐데 순간이동 시켜줄게.";
                }
                if (clickCont == 44) {
                    name_.text = "나";
                    text_.text = "그럼 미화마을로 보내줘.";
                }
                if (clickCont == 45) {
                    name_.text = "지니";
                    text_.text = "확인. 근데 왜 하필 미화마을이야?";
                }
                if (clickCont == 46) {
                    name_.text = "나";
                    text_.text = "뭐... 걔네들이랑 같이있는 시간이 제일 많거든. 수요일마다 왕궁에 와서 청소하거든.";
                }
                if (clickCont == 47) {
                    name_.text = "지니";
                    text_.text = "그래... 그냥 궁금했어. 잘가.";
                }
                if (clickCont == 48) {
                    name_.text = "나";
                    text_.text = "그래! 나중에 봐!";
                }

                if (clickCont == 49) {
                    glowingboonpillbackgroundwithgini.SetActive(false);
                    justBlack.SetActive(true);
                }

                if (clickCont == 50) {
                    CaveManager.instance.canMove = true;
                    SceneManager.LoadScene("FinishCleanTown");
                }
            }
        }
    }

    
    void OnInvoke() {
        justBlack.SetActive(false);
        ceil.SetActive(true);
        TalkCanvas.SetActive(true);
        text_.text = "살았나?";
    }
}

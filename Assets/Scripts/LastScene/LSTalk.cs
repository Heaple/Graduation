using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class LSTalk : MonoBehaviour
{
    int ClickCnt = 0;
    public TextMeshProUGUI text_;
    public TextMeshProUGUI name_;
    public GameObject nameTag;
    public GameObject talkPanel;
    GameObject seeingGini;
    GameObject sittingGini;
    GameObject seeingEachother;
    GameObject justBlack;
    GameObject Gini;
    GameObject AlbumFirst;
    GameObject AlbumSecond;
    public GameObject albumCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Gini = GameObject.Find("gini");
        Gini.SetActive(false);
        seeingGini = GameObject.Find("sittingwithginiseeinggini");
        sittingGini = GameObject.Find("sitwithgini");
        seeingEachother = GameObject.Find("sittingwithginiseeingeachother");
        justBlack = GameObject.Find("justblack");
        AlbumFirst = GameObject.Find("albumfirst");
        AlbumSecond = GameObject.Find("albumsecond");
        seeingGini.SetActive(false);
        sittingGini.SetActive(false);
        seeingEachother.SetActive(false);
        justBlack.SetActive(false);
        AlbumFirst.SetActive(false);
        AlbumSecond.SetActive(false);
        LSManager.instance.canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            ClickCnt ++;
            if (!LSManager.instance.isEnd) {
                if (ClickCnt == 1) {
                    Gini.SetActive(true);
                    text_.text = "거 참 살살좀 내려주지";
                }
                if (ClickCnt == 2) {
                    name_.text = "지니";
                    text_.text = "나 니 옆에있다.";
                }
                if (ClickCnt == 3) {
                    name_.text = "나";
                    text_.text = "쳇";
                }
                if (ClickCnt == 4) {
                    name_.text = "나";
                    text_.text = "그럼 다음달에 보자.";
                }
                if (ClickCnt == 5) {
                    name_.text = "지니";
                    text_.text = "그래, 그때보자";
                }
                if (ClickCnt == 6) {
                    name_.text = "나";
                    text_.text = "한번을 안웃네.";
                }
                if (ClickCnt == 7) {
                    name_.text = " ";
                    nameTag.SetActive(false);
                    justBlack.SetActive(true);
                    text_.text = "평소와 다를것 없는 1년이 흘렀다.";
                }
                if (ClickCnt == 8) {
                    text_.text = "지니 덕분에, 나라 상황도 복구 되었고, 애들을 배불리 먹일수 있게 되었다.";
                }
                if (ClickCnt == 9) {
                    text_.text = "지니도 점점 마음을 열어갔다.";
                }
                if (ClickCnt == 10) {
                    text_.text = "지니를 애들에게 소개도 시켜주었고, 지니도 점점 마음을 열어갔다.";
                }
                if (ClickCnt == 11) {
                    nameTag.SetActive(true);
                    justBlack.SetActive(false);
                    name_.text = "지니";
                    text_.text = "야, 그거 알아?";
                    sittingGini.SetActive(true);
                }
                if (ClickCnt == 12) {
                    text_.text = "정확히 1년전, 이 시간에 우리가 처음 만났다?";
                }
                if (ClickCnt == 13) {
                    name_.text = "나";
                    text_.text = "그러게! 생각보다 오래됬구나!";
                    seeingGini.SetActive(true);
                    sittingGini.SetActive(false);
                }
                if (ClickCnt == 14) {
                    text_.text = "그때 내가 너보고 놀래서 기절했잖아 ㅋㅋ";
                }
                if (ClickCnt == 15) {
                    name_.text = "지니";
                    text_.text = "그때 참 재미있었지 ㅋㅋ";
                }
                if (ClickCnt == 16) {
                    name_.text = "나";
                    text_.text = "?";
                }
                if (ClickCnt == 17) {
                    text_.text = "너... 웃었어...";
                }
                if (ClickCnt == 18) {
                    name_.text = "지니";
                    text_.text = "(당황) 그...그러게";
                    seeingGini.SetActive(false);
                    seeingEachother.SetActive(true);
                }
                if (ClickCnt == 19) {
                    name_.text = "나";
                    text_.text = "니가 진짜로 웃은건 이번이 처음이라고!";
                }
                if (ClickCnt == 20) {
                    name_.text = "지니";
                    text_.text = "그러게... 나도 밖에서 이렇게 웃는거는 3년만에 처음이네";
                }
                if (ClickCnt == 21) {
                    text_.text = "맨날 집에만 틀어박혀 있서 하하.";
                }
                if (ClickCnt == 22) {
                    text_.text = "집에서만 웃을일이 있었네";
                }
                if (ClickCnt == 23) {
                    text_.text = "고마워!";
                }
                if (ClickCnt == 24) {
                    name_.text = "나";
                    text_.text = "천만의 말씀!";
                    seeingEachother.SetActive(false);
                    justBlack.SetActive(true);
                }
                if (ClickCnt == 25) {
                    justBlack.SetActive(false);
                    AlbumFirst.SetActive(true);
                    albumCanvas.SetActive(true);
                    ClickCnt = 0;
                    LSManager.instance.canMove = false;
                    this.gameObject.SetActive(false);
                }
            }
        }
    }
}

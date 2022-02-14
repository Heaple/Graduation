using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Talk : MonoBehaviour
{
    int clickCnt = 0; 
    public TextMeshProUGUI text_;
    // Start is called before the first frame update
    void Start()
    {
        Variable.instance.canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            clickCnt ++;
            if (clickCnt == 0) {
                text_.text = "그래서... 고대의 동굴에 가라고?";
            }
            if (clickCnt == 1) {
                text_.text = "거기 가면... 소중하다고 느끼는 물건이 있다...?";
            }
            if (clickCnt == 2) {
                text_.text = "뭔 소리야...";
            }
            if (clickCnt == 3) {
                text_.text = "속는셈 치고 가볼까...";
            }
            if (clickCnt == 4) {
                text_.text = "그리고 그 물건을 잡고 소원을 말해라?";
            }
            if (clickCnt == 5) {
                text_.text = "이거 맞는거야? ;;";
            }
            if (clickCnt == 6) {
                text_.text = "그럼 이 책은 챙겨두고";
            }
            if (clickCnt == 7) {
                text_.text = "뭐... 멍하니 앉아있는것 보단 낫겠지...";
            }
            if (clickCnt == 8) {
                text_.text = "출발... 해볼까?";
            }
            if (clickCnt == 9) {
                Variable.instance.canMove = true;
                this.gameObject.SetActive(false);
            }
        }
    }
}

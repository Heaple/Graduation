using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Jihoo1 : MonoBehaviour
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
        if (Input.GetMouseButtonDown(0))
        {

            clickCount++;
            if (clickCount == 1)
            {
                text.text = "오! 신지후 하이!";
            }
            if (clickCount == 2)
            {
                text.text = "너 고대의 동굴이라고 들어봤어?";

            }
            if (clickCount == 3)
            {
                text.text = "몰?루";
                name_.text = "신지후";

            }
            if (clickCount == 4)
            {
                text.text = "아 배고프다";
            }

            if (clickCount == 5)
            {
                text.text = "점심 안먹었더니 배고파요";
            }

            if (clickCount == 6)
            {
                text.text = "그럼 난 밥먹으러 가요!";
            }

            if (clickCount == 7)
            {
                name_.text = "나";
                text.text = "야! 답은 해줘야지!!!!";
            }
            if (clickCount == 8) {
                text.text = "옆에 건우라도 있네. 쟤한테 물어봐야지...";
            }
            if (clickCount == 9)
            {
                this.gameObject.SetActive(false);
                clickCount = 0;
                CleantownManager.instance.isJihooTalk = true;
                CleantownManager.instance.canMove = true;
            }
        }


    }
}

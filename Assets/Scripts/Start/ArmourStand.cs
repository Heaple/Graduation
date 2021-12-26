using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmourStand : MonoBehaviour
{
    private static ArmourStand Instance;

    public static ArmourStand instance
    {
        get
        {
            if (Instance == null)
                Instance = new ArmourStand();
            return Instance;
        }
    }

    GameObject e;
    GameObject CharacterFront = Character.instance.CharacterFront;
    GameObject CharacterBack = Character.instance.CharacterBack;
    GameObject CharacterLeft = Character.instance.CharacterLeft;
    GameObject CharacterRight = Character.instance.CharacterRight;
    GameObject explorerFront;
    GameObject explorerBack;
    GameObject explorerLeft;
    GameObject explorerRight;
    GameObject changedArmourStand;
    [HideInInspector] public bool isClothChanged;
    // Start is called before the first frame update
    void Start()
    {
        explorerFront = GameObject.Find("ExplorerFront");
        explorerBack = GameObject.Find("ExplorerBack");
        explorerLeft = GameObject.Find("ExplorerLeft");
        explorerRight = GameObject.Find("ExplorerRight");
        changedArmourStand = GameObject.Find("ChangedArmourStand");
        e = GameObject.Find("e");
        e.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D o)
    {
        if (o.gameObject.name == "QueenLeft" || o.gameObject.name == "QueenRight" || o.gameObject.name == "QueenFront" || o.gameObject.name == "QueenBack")
        {
            if (Input.GetKey(KeyCode.E))
            {
                CharacterFront.GetComponent<SpriteRenderer>().sprite = explorerFront.GetComponent<SpriteRenderer>().sprite;
                CharacterBack.GetComponent<SpriteRenderer>().sprite = explorerBack.GetComponent<SpriteRenderer>().sprite;
                CharacterRight.GetComponent<SpriteRenderer>().sprite = explorerRight.GetComponent<SpriteRenderer>().sprite;
                CharacterLeft.GetComponent<SpriteRenderer>().sprite = explorerLeft.GetComponent<SpriteRenderer>().sprite;
                GetComponent<SpriteRenderer>().sprite = changedArmourStand.GetComponent<SpriteRenderer>().sprite;
            }
            e.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D o)
    {
        if (o.gameObject.name == "QueenLeft" || o.gameObject.name == "QueenRight" || o.gameObject.name == "QueenFront" || o.gameObject.name == "QueenBack")
        {
            e.SetActive(false);
        }
    }
}

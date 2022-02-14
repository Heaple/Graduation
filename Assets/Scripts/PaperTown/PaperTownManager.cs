using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTownManager
{
    private static PaperTownManager Instance;

    public static PaperTownManager instance
    {
        get
        {
            if (Instance == null)
                Instance = new PaperTownManager();
            return Instance;
        }
    }

    public bool canMove = true;
    public bool isSleep  = false;
    public bool isQuestTalkFinish = false;
    public int talkCnt = 0;
}

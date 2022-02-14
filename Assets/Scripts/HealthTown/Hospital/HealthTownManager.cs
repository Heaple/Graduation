using System.Collections;
using System.Collections.Generic;

public class HealthTownManager
{
    private static HealthTownManager Instance;

    public static HealthTownManager instance
    {
        get
        {
            if (Instance == null)
                Instance = new HealthTownManager ();
            return Instance;
        } 
    }

    public bool isQuestTalkFinish = false;
    public bool canMove = true;
    public bool isBoardCleanFinish = false;
    public bool isMilkTrashFinish = false;
    public bool isPullingMilkbox = false;
    public bool isPlayerEntered = false;
    public bool isQuestFinish = false;
}

using System;
using UnityEngine;

public class PScoreSystem : MonoBehaviour
{
    private int level = 0;
    private int countAdrenaline;

    private float damage = 20;
    private PHeathSystem heathSystem;

    private void Start()
    {
        heathSystem = GetComponent<PHeathSystem>();
    }
    public void TakeAdrenaline(int count = 1)
    {
        countAdrenaline++;
        switch (countAdrenaline)
        {
            case 1:
                level = 1;
                damage = 25;
                heathSystem.ChangeHealthAmount(25);
                break;
            case 2:
                level = 2;
                damage = 40;
                heathSystem.ChangeHealthAmount(40);
                break;
            case 4:
                level = 3;
                damage = 60;
                heathSystem.ChangeHealthAmount(80);
                break;
            case 10:
                level = 4;
                damage = 100;
                heathSystem.ChangeHealthAmount(120);
                break;
            case 25:
                level = 5;
                damage = 160;
                heathSystem.ChangeHealthAmount(200);
                break;
        }

        // логика смены на UI. эффекты взятия
    }
}
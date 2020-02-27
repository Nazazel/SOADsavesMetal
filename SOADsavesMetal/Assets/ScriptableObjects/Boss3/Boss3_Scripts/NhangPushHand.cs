﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Attack/Nhang/PushStart")]
public class NhangPushHand : NhangAttack
{
    GameObject[] PushHand;

    public override void Initialize(NhangAttackData data)
    {
        PushHand = data.NhangPushHand;
    }

    protected override IEnumerator Execute(float duration)
    {
        yield return null;

        Debug.Log("Push Damn it");
        for (int i = 0; i < PushHand.Length; i++)
        {
            PushHand[i].GetComponent<PushScript>().Push();
        }
    }

    protected override void OnEnd()
    {
    }

    protected override void OnStart()
    {
    }

    
}

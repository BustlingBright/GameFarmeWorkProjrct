using System;
using GameFramework.Entity;
using UnityGameFramework.Runtime;

public class EntityWuShuang:EntityLogic
{
    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
    }
    protected internal override void OnShow(object userData)
    {
        base.OnShow(userData);
        UnityEngine.Debug.Log(111111111111111111);
    }

    protected internal override void OnUpdate(float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(elapseSeconds, realElapseSeconds);
    }
}


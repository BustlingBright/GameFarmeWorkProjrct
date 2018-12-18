using System;
using UnityEngine;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using GameFramework.Fsm;
using UnityEngine.UI;
using GameFramework.DataTable;

public class ProcedureStart : ProcedureBase
{
    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);
        ConfigManger.Instance.LoadConfigs();
        ////////////////////////////


    }


    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        ChangeState<ProcedureMain>(procedureOwner);
  
        SceneManger.Instance._SceneCompent.LoadScene(SceneLoadEnum.MainScene);


    }
}

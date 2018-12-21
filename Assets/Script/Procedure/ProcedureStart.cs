using System;
using UnityEngine;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using GameFramework.Fsm;
using UnityEngine.UI;
using GameFramework.DataTable;
using System.Text.RegularExpressions;

public class ProcedureStart : ProcedureBase
{
    protected override void OnInit(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnInit(procedureOwner);
        ConfigManger.Instance.LoadConfigs();
       


    }

    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);

        
    }


    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        ChangeState<ProcedureMain>(procedureOwner);
        SceneManger.Instance._SceneCompent.LoadScene(SceneLoadEnum.MainScene);


    }
}

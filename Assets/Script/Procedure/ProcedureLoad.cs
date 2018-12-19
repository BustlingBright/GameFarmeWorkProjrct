using System;
using System.Collections.Generic;
using UnityGameFramework.Runtime;
using GameFramework.Procedure;
using GameFramework.Fsm;
using UnityEngine;

class ProcedureLoad: ProcedureBase
{

    public static void LoadScene(SceneLoadEnum configEnum)
    {

    }
    protected override void OnInit(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnInit(procedureOwner);
       
    }
    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);
        UIManger.Instance._UIComponent.OpenUIForm(ConfigEnum.LoadingForm);
    }
    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        //procedureOwner.SetData()
        ChangeState<ProcedureCreatePeople>(procedureOwner);
        SceneManger.Instance._SceneCompent.LoadScene(SceneLoadEnum.CreateRoleScene);
    }

}


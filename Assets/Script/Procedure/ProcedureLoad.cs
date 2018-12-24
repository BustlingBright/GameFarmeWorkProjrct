using System;
using System.Collections.Generic;
using UnityGameFramework.Runtime;
using GameFramework.Procedure;
using GameFramework.Fsm;
using UnityEngine;

class ProcedureLoad: ProcedureBase
{
    protected override void OnInit(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnInit(procedureOwner);
       
    }
    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);
    }
    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        VarString nextScene = procedureOwner.GetData<VarString>("NextScene");
        SceneLoadEnum next = (SceneLoadEnum)Enum.Parse(typeof(SceneLoadEnum), nextScene);
        switch (next)
        {
            case SceneLoadEnum.CreateRoleScene:
                UIManger.Instance._UIComponent.OpenUIForm(ConfigEnum.LoadingForm,ConfigEnum.CreateRoleForm);
                ChangeState<ProcedureCreatePeople>(procedureOwner);
                SceneManger.Instance._SceneCompent.LoadScene(SceneLoadEnum.CreateRoleScene);
                break;
            case SceneLoadEnum.HomeScene:
                UIManger.Instance._UIComponent.OpenUIForm(ConfigEnum.LoadingForm, ConfigEnum.MainForm);
                ChangeState<ProcedureHome>(procedureOwner);
                SceneManger.Instance._SceneCompent.LoadScene(SceneLoadEnum.HomeScene);
                break;
            default:
                break;
        }
       



    }

}


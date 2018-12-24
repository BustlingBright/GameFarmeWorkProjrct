using UnityEngine;
using GameFramework.Fsm;
using GameFramework.Procedure;
using GameFramework.Event;
using UnityGameFramework.Runtime;
using GameFramework.Scene;

class ProcedureMain : ProcedureBase
{
    private bool isLoad = false;
    public void Load()
    {
        isLoad = true;
    }

    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);
        FormConfig _config = ConfigManger.Instance.GetConfig<FormConfig>((int)ConfigEnum.StartForm);
		UIManger.Instance._UIComponent.OpenUIForm (_config.ScenePosition+_config.SceneName, _config.SceneGroup,this);
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        if(isLoad)
        {
            procedureOwner.SetData<VarString>("NextScene", "CreateRoleScene");
            ChangeState<ProcedureLoad>(procedureOwner);
        }
    }
}


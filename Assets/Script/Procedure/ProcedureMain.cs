using UnityEngine;
using GameFramework.Fsm;
using GameFramework.Procedure;
using GameFramework.Event;
using UnityGameFramework.Runtime;

class ProcedureMain : ProcedureBase
{
    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);
		UIComponent _ui = GameEntry.GetComponent<UIComponent> ();
        FormConfig _config = ConfigManger.GetConfig<FormConfig>((int)ConfigEnum.StartForm);
		_ui.OpenUIForm (_config.ScenePosition+_config.SceneName, _config.SceneGroup);
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
		//ChangeState<ProcedureBattle> (procedureOwner);

    }
}


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
		UIComponent ui = GameEntry.GetComponent<UIComponent> ();
		EventComponent event1 = GameEntry.GetComponent<EventComponent> ();
		event1.Subscribe (OpenUIFormSuccessEventArgs.EventId, (sender,e) => {
			Debug.Log ("I am OK");
		}
		);
		ui.OpenUIForm ("Assets/UI/StartForm.prefab", "defaultGroup");
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
		//ChangeState<ProcedureBattle> (procedureOwner);

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;

public class ProcedureBattle : ProcedureBase{

	protected override void OnEnter (GameFramework.Fsm.IFsm<IProcedureManager> procedureOwner)
	{
		base.OnEnter (procedureOwner);
		UIComponent ui = GameEntry.GetComponent<UIComponent> ();
		ui.OpenUIForm ("Assets/UI/StartWnd.prefab", "defaultGroup");
	}

}

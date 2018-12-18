using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using GameFramework.Fsm;

public class ProcedureCreatePeople : ProcedureBase
{

	protected override void OnEnter (GameFramework.Fsm.IFsm<IProcedureManager> procedureOwner)
	{
		base.OnEnter (procedureOwner);
        
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
    }

}

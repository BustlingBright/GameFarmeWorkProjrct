using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using GameFramework.Fsm;

public class ProcedureCreatePeople : ProcedureBase
{
    private static bool isLoad = false;
	protected override void OnEnter (GameFramework.Fsm.IFsm<IProcedureManager> procedureOwner)
	{
		base.OnEnter (procedureOwner);

    }

    public static void Load()
    {
        isLoad = true;
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

        if (isLoad)
        {
            procedureOwner.SetData<VarString>("NextScene", "HomeScene");
            ChangeState<ProcedureLoad>(procedureOwner);
        }

        float mouseX = Input.GetAxis("Mouse X");
        if (Input.GetKey(KeyCode.Mouse1))
        {
            foreach (Entity item in ModelManger.Instance._EntityComponent.GetAllLoadedEntities())
            {
                item.transform.Rotate(Vector3.down * mouseX * 10);
            }
        }
       
    }

}

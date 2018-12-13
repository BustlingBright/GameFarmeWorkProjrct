using System;
using UnityEngine;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using GameFramework.Fsm;
using UnityEngine.UI;
using GameFramework.DataTable;

public class ProcedureStart : ProcedureBase
{
    private DataTableComponent data;
    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);


        data = GameEntry.GetComponent<DataTableComponent>();
        EventComponent event1 = GameEntry.GetComponent<EventComponent>();

        event1.Subscribe(LoadConfigSuccessEventArgs.EventId, Config1);
        data.LoadDataTable<FormConfig>("FormConfig.txt", "Assets/Configs/FormConfig.txt");
    }

    private void Config1(object sender,GameFramework.Event.GameEventArgs e)
    {
        Debug.Log(11111111);
        IDataTable<FormConfig> f= data.GetDataTable<FormConfig>();
        Debug.Log(f.GetDataRow(1).SceneGroup);

    }


    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        ChangeState<ProcedureMain>(procedureOwner);

    }
}

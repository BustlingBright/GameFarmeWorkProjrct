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

        EventComponent event1 = GameEntry.GetComponent<EventComponent>();
        //event1.Subscribe(UnityGameFramework.Runtime.LoadDataTableSuccessEventArgs.EventId, Config1);

        data = GameEntry.GetComponent<DataTableComponent>();
        //data.LoadDataTable<FormConfig>("FormConfig.txt", "Assets/Configs/FormConfig.txt");

        //IDataTable<FormConfig> fg = data.GetDataTable<FormConfig>();
        //FormConfig ff = fg.GetDataRow(10003);
        //Debug.Log(ff.SceneName);


    }

    //private void Config1(object sender, GameFramework.Event.GameEventArgs e)
    //{
    //    Debug.Log(1111111111);
    //    IDataTable<FormConfig> fg = data.GetDataTable<FormConfig>();
    //    FormConfig ff = fg.GetDataRow(10003);
    //    Debug.Log(ff.SceneName);
    //}


    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        ChangeState<ProcedureMain>(procedureOwner);

    }
}

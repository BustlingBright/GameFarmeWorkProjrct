using GameFramework.DataTable;
using System;
using UnityEngine;
using UnityGameFramework.Runtime;

public enum ConfigEnum
{
    StartForm=10001,
    NameLoginForm,
    ResigerForm,
    FastLoginForm,
    LoadingForm,
    CreateRoleForm,
    SeceltRoleForm,
    MainForm
}


public static class ConfigManger
{
    private static string _configPath = "Assets/Configs/";
    private const int _IdFirst = 10001;
    private static DataTableComponent _data;
    private static EventComponent _event = GameEntry.GetComponent<EventComponent>();
    private static bool _isLoad = false;

    public static void LoadConfigs()
    {
        _event.Subscribe(UnityGameFramework.Runtime.LoadDataTableSuccessEventArgs.EventId, LoadDataSetSuccessAction);
        _data = GameEntry.GetComponent<DataTableComponent>();
        _data.LoadDataTable<FormConfig>("FormConfig.txt", _configPath + "FormConfig.txt");
    }

    private static void LoadDataSetSuccessAction(object sender, GameFramework.Event.GameEventArgs e)
    {
        _isLoad = true;
    }

    public static T GetConfig<T>(int Id) where T: IDataRow
    {
        IDataTable<T> config = _data.GetDataTable<T>();
        return config.GetDataRow(Id);
    }

    public static T[] GetConfigs<T>() where T:IDataRow
    {
        IDataTable<T> config = _data.GetDataTable<T>();
        T[] configs = config.GetAllDataRows();
        return configs;
    }


}


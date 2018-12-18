using GameFramework.DataTable;
using System;
using UnityEngine;
using UnityGameFramework.Runtime;



public class ConfigManger:Singleton<ConfigManger>
{
    private string _configPath = "Assets/Configs/";
    private const int _IdFirst = 10001;
    private DataTableComponent _data;
    private EventComponent _event = GameEntry.GetComponent<EventComponent>();
    private bool _isLoad = false;

    public void LoadConfigs()
    {
        _event.Subscribe(UnityGameFramework.Runtime.LoadDataTableSuccessEventArgs.EventId, LoadDataSetSuccessAction);
        _data = GameEntry.GetComponent<DataTableComponent>();
        _data.LoadDataTable<FormConfig>("FormConfig.txt", _configPath + "FormConfig.txt");
        _data.LoadDataTable<ModelConfig>("ModelConfig.txt", _configPath + "ModelConfig.txt");
    }

    private void LoadDataSetSuccessAction(object sender, GameFramework.Event.GameEventArgs e)
    {
        _isLoad = true;
        Debug.Log("数据表加载成功...");
    }

    public T GetConfig<T>(int Id) where T: IDataRow
    {
        IDataTable<T> config = _data.GetDataTable<T>();
        return config.GetDataRow(Id);
    }

    public T[] GetConfigs<T>() where T:IDataRow
    {
        IDataTable<T> config = _data.GetDataTable<T>();
        T[] configs = config.GetAllDataRows();
        return configs;
    }


}


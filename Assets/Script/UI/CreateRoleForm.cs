using UnityGameFramework.Runtime;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CreateRoleForm:UIFormLogic
{
    private Text _introduce;
    private Text _configName;
    private InputField _name;
    private Button _randomName;
    private Button _enter;
    private ModelConfig mc;
    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
        _introduce = transform.Find("introduce/Text").GetComponent<Text>();
        _configName = transform.Find("configName").GetComponent<Text>();
        _name = transform.Find("name").GetComponent<InputField>();
        _randomName = transform.Find("randomName").GetComponent<Button>();
        _enter = transform.Find("enter").GetComponent<Button>();
        mc = ConfigManger.Instance.GetConfig<ModelConfig>((int)CreateRole.无双);
        SetModelThings(mc.NAME, mc.INTRODUCE, mc.MODEL);
    }
    protected internal override void OnOpen(object userData)
    {
        base.OnOpen(userData);
        _randomName.onClick.AddListener(OnRandomNameClick);
        _enter.onClick.AddListener(OnEnterClick);
    }
    public void SetModelThings(string configName,string introduce,string modelName)
    {
        ModelManger.Instance._EntityComponent.ShowEntity<EntityWuShuang>(mc.Id, "Assets/ziyuan/Role/" + mc.MODEL+".prefab", mc.CLASS);
        _configName.text = configName;
        _introduce.text = introduce;
    }

    /// <summary>
    /// 登录按钮响应事件
    /// </summary>
    private void OnEnterClick()
    {
        
    }

    /// <summary>
    /// 随机名字（读表）
    /// </summary>
    private void OnRandomNameClick()
    {
        
    }

    protected internal override void OnClose(object userData)
    {
        base.OnClose(userData);
        _randomName.onClick.RemoveListener(OnRandomNameClick);
        _enter.onClick.RemoveListener(OnEnterClick);
    }
}


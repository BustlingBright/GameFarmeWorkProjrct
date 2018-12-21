using UnityGameFramework.Runtime;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using System.Collections;

public class CreateRoleForm:UIFormLogic
{
    private Text _introduce;
    private Text _configName;
    private InputField _name;
    private Button _randomName;
    private Button _enter;
    private Button _player1;
    private Button _player2;
    private Button _player3;
    private Text _error;
    private ModelConfig mc;

    
    private bool isLoad = false;
    private bool isNameError = false;
    protected internal override void OnInit(object userData)
    {

        base.OnInit(userData);
        _introduce = transform.Find("introduce/Text").GetComponent<Text>();
        _configName = transform.Find("configName").GetComponent<Text>();
        _error = transform.Find("Error").GetComponent<Text>();
        _name = transform.Find("name").GetComponent<InputField>();
        _randomName = transform.Find("randomName").GetComponent<Button>();
        _enter = transform.Find("enter").GetComponent<Button>();
        _player1 = transform.Find("player1").GetComponent<Button>();
        _player2 = transform.Find("player2").GetComponent<Button>();
        _player3 = transform.Find("player3").GetComponent<Button>();
        mc = ConfigManger.Instance.GetConfig<ModelConfig>((int)CreateRole.无双);
        SetModelThings(mc.NAME, mc.INTRODUCE, mc.MODEL);
    }
    protected internal override void OnOpen(object userData)
    {
        base.OnOpen(userData);
        _randomName.onClick.AddListener(OnRandomNameClick);
        _enter.onClick.AddListener(OnEnterClick);
        _player1.onClick.AddListener(OnPlayer1Click);
        _player2.onClick.AddListener(OnPlayer2Click);
    }

    private void OnPlayer1Click()
    {
        foreach (Entity item in ModelManger.Instance._EntityComponent.GetAllLoadedEntities())
        {
            if (item.Id== (int)CreateRole.无双)
            {
                ModelManger.Instance._EntityComponent.HideEntity((int)CreateRole.无双);
                isLoad = false;
            }
            else if(item.Id == (int)CreateRole.上官欢)
            {
                isLoad = true;
                break ;
            }
        }
       if(!isLoad)
        {
            mc = ConfigManger.Instance.GetConfig<ModelConfig>((int)CreateRole.上官欢);
            SetModelThings(mc.NAME, mc.INTRODUCE, mc.MODEL);
        }
    }
    private void OnPlayer2Click()
    {
        foreach (Entity item in ModelManger.Instance._EntityComponent.GetAllLoadedEntities())
        {
            if (item.Id == (int)CreateRole.上官欢)
            {
                ModelManger.Instance._EntityComponent.HideEntity((int)CreateRole.上官欢);
                isLoad = false;
            }
            else if (item.Id == (int)CreateRole.无双)
            {
                isLoad = true;
                break;
            }
        }
        if (!isLoad)
        {
            mc = ConfigManger.Instance.GetConfig<ModelConfig>((int)CreateRole.无双);
            SetModelThings(mc.NAME, mc.INTRODUCE, mc.MODEL);
        }
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
        if (CheckName(_name.text))
        {
            foreach (BanedTextConfig item in ConfigManger.Instance.GetConfigs<BanedTextConfig>())
            {
                if (_name.text.Contains(item.BANEDLIST) )
                {
                    isNameError = true;
                    break;
                }
                    isNameError = false;
            }
            if (isNameError)
            {
                ErrorShowBox(Error.玩家昵称不能包含敏感字符);
            }
            else
            {
                ///////////////////////
            }
        }
        else
        {
            ErrorShowBox(Error.玩家昵称不能为空);
        }
    }

    private void ErrorShowBox(Error error)
    {
        _error.color = Color.red;
        _error.text = error.ToString();
        StartCoroutine(TextDisappear(_error));
    }
    IEnumerator TextDisappear(Text t)
    {
        while (t.color.a > 0)
        {
            t.color -= new Color(0, 0, 0, 0.01f);
            yield return new WaitForSeconds(0.01f);
        }
     
    }

    private bool CheckName(string name)
    {
        Regex reg = new Regex("^[0-9A-Za-z\u4e00-\u9fa5]{4,20}$");
        return reg.IsMatch(name);
    }

    

    /// <summary>
    /// 随机名字（读表）
    /// </summary>
    private void OnRandomNameClick()
    {
        _name.text = string.Empty;
        _name.text += ConfigManger.Instance.GetConfig<NameConfig>(UnityEngine.Random.Range(1000, 1559)).FIRSTNAME;
        _name.text += ConfigManger.Instance.GetConfig<NameConfig>(UnityEngine.Random.Range(1000, 1559)).MIDDLENAME;
        _name.text += ConfigManger.Instance.GetConfig<NameConfig>(UnityEngine.Random.Range(1000, 1559)).LASTNAME;

    }

    protected internal override void OnClose(object userData)
    {
        base.OnClose(userData);
        _randomName.onClick.RemoveListener(OnRandomNameClick);
        _enter.onClick.RemoveListener(OnEnterClick);
    }
}


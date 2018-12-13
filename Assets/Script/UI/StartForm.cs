using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using GameFramework;
using UnityEngine.UI;

public class StartForm :UIFormLogic
{
    private Button _resigerBtn;
    private Button _nameEnterBtn;
    private Button _exitBtn;
    private Button _fastBtn;
    private UIComponent _ui;

    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
        _resigerBtn = transform.Find("Btns/ResigerBtn").GetComponent<Button>();
        _nameEnterBtn = transform.Find("Btns/LoginBtn").GetComponent<Button>();
        _exitBtn = transform.Find("Btns/ExitBtn").GetComponent<Button>();
        _fastBtn = transform.Find("Btns/FastBtn").GetComponent<Button>();
        _ui = GameEntry.GetComponent<UIComponent>();
    }
    protected internal override void OnOpen(object userData)
    {
        base.OnOpen(userData);
		_resigerBtn.onClick.AddListener(OnResigerClick);
		_nameEnterBtn.onClick.AddListener (OnNameLoginClick);
        _exitBtn.onClick.AddListener(OnExitClick);
        //////////////////////////快速游戏

    }

    /// <summary>
    /// 退出游戏
    /// </summary>
    private void OnExitClick()
    {
        _ui.CloseUIForm(UIForm);
        Application.Quit();
    }

    /// <summary>
    /// 打开注册UI
	/// </summary>
	private void OnResigerClick()
	{
		_ui.CloseUIForm (UIForm);
		_ui.OpenUIForm ("Assets/UI/ResigerForm.prefab", "defaultGroup");
	}
    /// <summary>
    /// 打开账号密码登录UI
    /// </summary>
	private void OnNameLoginClick()
	{
		_ui.CloseUIForm (UIForm);
		_ui.OpenUIForm ("Assets/UI/ResigerForm.prefab", "defaultGroup");

	}


    protected  internal override void OnClose(object userData)
    {
        
    }

    protected override void InternalSetVisible(bool visible)
    {
        base.InternalSetVisible(visible);
    }

}

﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;

public class LoadingForm : UIFormLogic
{
    private Slider _loadingSlider;
    private Image _runPerson;

    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
       _loadingSlider= transform.Find("Btns/Slider").GetComponent<Slider>();
        _runPerson = transform.Find("Btns/run").GetComponent<Image>();
        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        while(_loadingSlider.value<0.99f)
        {
            _loadingSlider.value += 0.01f;
            _runPerson.GetComponent<RectTransform>().SetLocalPositionX(-450 + _loadingSlider.value * 900);
            yield return new WaitForSeconds(0.01f);
        }
        UIManger.Instance._UIComponent.CloseUIForm(UIForm);
        UIManger.Instance._UIComponent.OpenUIForm(ConfigEnum.CreateRoleForm);
    }

    protected internal override void OnOpen(object userData)
    {
        base.OnOpen(userData);
    }

    protected internal override void OnClose(object userData)
    {
        base.OnClose(userData);
    }

}
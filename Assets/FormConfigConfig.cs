using System;
using System.Collections.Generic;
using GameFramework.DataTable;
using UnityGameFramework.Runtime;
using UnityEngine;

public class FormConfig:IDataRow
{
    /// <summary>
    /// 场景编号
    /// </summary>
    public int ID
    {
        get;
        protected set;
    }

    /// <summary>
    /// 场景资源位置
    /// </summary>
    public string ScenePosition
    {
        get;
        protected set;
    }

    /// <summary>
    /// 场景名称
    /// </summary>
    public string SceneName
    {
        get;
        protected set;
    }

    /// <summary>
    /// 场景组别
    /// </summary>
    public string SceneGroup
    {
        get;
        protected set;
    }

    public int Id
    {
        get;
        protected set;
    }

    public void ParseDataRow(string dataRowText)
    {
        string[] text = dataRowText.Split('\t');
        int index = 0;
        index++; // 跳过注释列
        Id = int.Parse(text[index++]);
        index++; // 跳过备注列
        //Name = text[index++];
        //AssetName = text[index++];
        //BackgroundMusicId = int.Parse(text[index++]);
        //http://gameframework.cn/archives/235
    }
}

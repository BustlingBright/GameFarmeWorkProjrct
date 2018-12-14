using GameFramework.DataTable;
using System.Collections.Generic;
public class FormConfig : IDataRow
{
  public int Id
  {
    get;
    protected set;
  }

  public string ScenePosition
  {
    get;
    protected set;
  }

  public string SceneName
  {
    get;
    protected set;
  }

  public string SceneGroup
  {
    get;
    protected set;
  }

  public void ParseDataRow(string dataRowText)
  {
    string[] text = dataRowText.Split('\t');
    int index = 0;
    index++;
    Id = int.Parse(text[index++]);
    ScenePosition = text[index++];
    SceneName = text[index++];
    SceneGroup = text[index++];
  }
  private void AvoidJIT()
  {
    new Dictionary<int, FormConfig > ();
  }
}

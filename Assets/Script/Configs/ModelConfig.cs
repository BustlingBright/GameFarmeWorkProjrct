using GameFramework.DataTable;
using System.Collections.Generic;
public class ModelConfig : IDataRow
{
  public int Id
  {
    get;
    protected set;
  }

  public string NAME
  {
    get;
    protected set;
  }

  public string TXT
  {
    get;
    protected set;
  }

  public string INTRODUCE
  {
    get;
    protected set;
  }

  public int PET_TYPE
  {
    get;
    protected set;
  }

  public int RENDER_TYPE
  {
    get;
    protected set;
  }

  public string CLASS
  {
    get;
    protected set;
  }

  public string INFO
  {
    get;
    protected set;
  }

  public string MODEL
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
    NAME = text[index++];
    TXT = text[index++];
    INTRODUCE = text[index++];
    PET_TYPE = int.Parse(text[index++]);
    RENDER_TYPE = int.Parse(text[index++]);
    CLASS = text[index++];
    INFO = text[index++];
    MODEL = text[index++];
  }
  private void AvoidJIT()
  {
    new Dictionary<int, ModelConfig > ();
  }
}

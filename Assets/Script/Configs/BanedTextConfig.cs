using GameFramework.DataTable;
using System.Collections.Generic;
public class BanedTextConfig : IDataRow
{
  public int Id
  {
    get;
    protected set;
  }

  public string BANEDLIST
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
    BANEDLIST = text[index++];
  }
  private void AvoidJIT()
  {
    new Dictionary<int, BanedTextConfig > ();
  }
}

using GameFramework.DataTable;
using System.Collections.Generic;
public class NameConfig : IDataRow
{
  public int Id
  {
    get;
    protected set;
  }

  public string FIRSTNAME
  {
    get;
    protected set;
  }

  public string MIDDLENAME
  {
    get;
    protected set;
  }

  public string LASTNAME
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
    FIRSTNAME = text[index++];
    MIDDLENAME = text[index++];
    LASTNAME = text[index++];
  }
  private void AvoidJIT()
  {
    new Dictionary<int, NameConfig > ();
  }
}


namespace GameCatalog_V2.Core.Helpers;

public struct MultipleSelecterHelperModel
{
    public MultipleSelecterHelperModel(string key,string value)
    {
        Key = key; Value = value;
    }
    public string Key { get; set; }
    public string Value { get; set; }
}


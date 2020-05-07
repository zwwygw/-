using FileCtrl;
using System.IO;
using UnityEngine;

[ExecuteInEditMode]
public class BatCtrl
{
    private string _batPath = "./start.bat";
    private string _ediFilter = "(*.exe)\0 *.exe";
    private string _licFilter = "(*.ulf)\0 *.ulf";
    private string _editorPath = "C:\\Program Files\\Unity\\Editor";
    private string _licPath = @"C:\ProgramData\Unity";
    private const string Copy = "copy \"";
    private const string CDStart = "\ncd ";
    private const string Start = "\nstart ";
    private const string _u3dLicFilePath = @"C:\ProgramData\Unity\Unity_lic.ulf";
    public void SelEdi()
    {   
        FileControllor fileControllor = new FileControllor();
        string s = fileControllor.OpenProject(_ediFilter, _editorPath);
        AddText(_batPath,s);
    }
    public void SelLic()
    {
        FileControllor fileCtrl = new FileControllor();
        string s = fileCtrl.OpenProject(_licFilter, _licPath);
        WriteText(_batPath, s);
    }
    private void AddText(string batPath,string path)
    {
        string disk = path.Substring(0, 1);
        Debug.Log(path.Substring(0, 1));
        string dir = Path.GetDirectoryName(path);
        string file = Path.GetFileName(path);
        if (!File.Exists(_batPath))
        {
            File.Create(_batPath);
            Debug.Log("文件创建成功！");
            File.AppendAllText(batPath,"\n"+disk+":");
            File.AppendAllText(batPath, CDStart + dir);
            File.AppendAllText(batPath, Start + file);
            Debug.Log("写入成功!");
        }
        else
        {
            File.AppendAllText(batPath, "\n" + disk+":");
            File.AppendAllText(batPath, CDStart + dir);
            File.AppendAllText(batPath, Start + file);
            Debug.Log("写入成功!");
        }
    }
    private void WriteText(string batPath, string path)
    {
        if (!File.Exists(_batPath))
        {
            File.Create(_batPath);
            Debug.Log("文件创建成功！");
            File.WriteAllText(batPath, Copy + path + "\" \"" + _u3dLicFilePath + "\"");
            Debug.Log("写入成功!");
        }
        else
        {
            File.WriteAllText(batPath, Copy + path + "\" \"" + _u3dLicFilePath + "\"");
            Debug.Log("写入成功!");
        }
    }

    public void ReadBatFile()
    {
        string text = File.ReadAllText(_batPath);
        Debug.Log(text);
    }
}

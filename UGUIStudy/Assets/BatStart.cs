using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class BatStart{
    public void start()
    {
        BatCtrl batCtrl = new BatCtrl();
        batCtrl.ReadBatFile();
      //  string str2 = this.GetType().Assembly.Location;
        string str1 = Application.dataPath;
        string batName = "start.bat";
       // UnityEngine.Debug.Log(str1);
        Process process = new Process();
        string batDir = Path.GetDirectoryName(str1);
        string batFileName = Path.GetFileName(batName);
        process.StartInfo.WorkingDirectory = batDir;
        process.StartInfo.FileName = batFileName;
  //      process.StartInfo.Arguments = string.Format("10");
      //  process.StartInfo.CreateNoWindow = false;
      //  process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        process.Start();
        process.WaitForExit();
    }
}

using UnityEngine;
using Common;
using System.IO;

namespace FileCtrl
{
    public class FileControllor
    {

        public string OpenProject(string filter,string defDir)
        {
            OpenFileDlg pth = new OpenFileDlg();
            pth.structSize = System.Runtime.InteropServices.Marshal.SizeOf(pth);
            pth.filter = filter;
            pth.file = new string(new char[256]);
            pth.maxFile = pth.file.Length;
            pth.fileTitle = new string(new char[64]);
            pth.maxFileTitle = pth.fileTitle.Length;
            pth.initialDir = defDir;  // default path  
            pth.title = "选择文件";
            pth.defExt = "txt";
            pth.flags = 0x00080000 | 0x00001000 | 0x00000800 | 0x00000200 | 0x00000008;
            string filePath = pth.initialDir;
            Debug.Log(filePath);
            if (filePath == null)
            {

            }
            if (OpenFileDialog.GetOpenFileName(pth))
            {
                filePath = pth.file;//选择的文件路径;  
                Debug.Log(filePath);
            }
            return filePath;
        }
        public void SaveProject()
        {
            SaveFileDlg pth = new SaveFileDlg();
            pth.structSize = System.Runtime.InteropServices.Marshal.SizeOf(pth);
            pth.filter = "(*.exe)\0*.exe";
            pth.file = new string(new char[256]);
            pth.maxFile = pth.file.Length;
            pth.fileTitle = new string(new char[64]);
            pth.maxFileTitle = pth.fileTitle.Length;
            pth.initialDir = Application.dataPath;  // default path  
            pth.title = "保存项目";
            pth.defExt = "txt";

            pth.flags = 0x00080000 | 0x00001000 | 0x00000800 | 0x00000200 | 0x00000008;
            if (SaveFileDialog.GetSaveFileName(pth))
            {
                string filepath = pth.file;//选择的文件路径;  
                Debug.Log(filepath);
            }
        }
    }

}


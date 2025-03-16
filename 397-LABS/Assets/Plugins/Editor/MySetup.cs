using UnityEngine;
using UnityEditor;
using System.IO;


public static class MySetup
{
    [MenuItem("Setup/Create Folders")]
    public static void CreateMyFolders()
    {
        Folder.CreateFolders("_Project", "Animations", "Art", "Audio", "Fonts",
        "Materials", "Prefabs", "ScriptableObjects", "Scripts", "Settings");
    }
    static class Folder
    {
        public static void CreateFolders(string root, params string[] folders)
        {
            var fullPath = Path.Combine(Application.dataPath, root);
            foreach(string folder in folders)
            {
                var folderPath = Path.Combine(fullPath, folder);
                if(!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
        }
    }
}

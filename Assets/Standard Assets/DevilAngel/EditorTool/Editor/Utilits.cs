﻿using System.IO;
using UnityEditor;
using UnityEngine;

namespace DevileAngel.EditorTool
{
    public static class Utilits
    {
        /// <summary>
        /// 获取Project目录下选中对象的 文件夹 路径
        /// </summary>
        /// <returns></returns>
        public static string[] GetSelectionPath()
        {
            var guids = Selection.assetGUIDs;
            if (guids == null) return null;

            for (int i = 0; i < guids.Length; i++)
            {
                string path = AssetDatabase.GUIDToAssetPath(guids[i]);
                if (Directory.Exists(path) == false)
                {
                    int index = path.LastIndexOf('/');
                    path = path.Substring(0, index);
                }
                guids[i] = path;
            }
            return guids;
        }

        public static T GetUnityObjectIndexOf<T>() where T : UnityEngine.Object
        {
            var objs = Resources.FindObjectsOfTypeAll<T>();
            if (objs != null && objs.Length != 0)
            {
                return objs[0];
            }
            return null;
        }
    }
}
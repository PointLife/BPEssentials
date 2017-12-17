﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using static BP_Essentials.EssentialsVariablesPlugin;
using static BP_Essentials.EssentialsMethodsPlugin;
using System.IO;

namespace BP_Essentials
{
    class CheckFiles : EssentialsChatPlugin
    {
        public static void Run(string fileName)
        {
            if (fileName == "all")
            {
                if (!Directory.Exists(FileDirectory))
                {
                    Directory.CreateDirectory(FileDirectory);
                    Debug.Log(FileDirectory + " Does not exist! Creating one.");
                }
                if (!Directory.Exists(LogDirectory))
                {
                    Directory.CreateDirectory(LogDirectory);
                    Debug.Log(LogDirectory + " Does not exist! Creating one.");
                }
                if (!File.Exists(AfkListFile))
                {
                    File.Create(AfkListFile).Close();
                    Debug.Log(AfkListFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(MuteListFile))
                {
                    File.Create(MuteListFile).Close();
                    Debug.Log(MuteListFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(ChatBlockFile))
                {
                    File.Create(ChatBlockFile).Close();
                    CreateFile.Run(ChatBlockFile);
                    Debug.Log(ChatBlockFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(GodListFile))
                {
                    File.Create(GodListFile).Close();
                    Debug.Log(GodListFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(IpListFile))
                {
                    File.Create(IpListFile).Close();
                    Debug.Log(IpListFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(LanguageBlockFile))
                {
                    File.Create(LanguageBlockFile).Close();
                    CreateFile.Run(LanguageBlockFile);
                    Debug.Log(LanguageBlockFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(MuteListFile))
                {
                    File.Create(MuteListFile).Close();
                    Debug.Log(MuteListFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(SettingsFile))
                {
                    File.Create(SettingsFile).Close();
                    CreateFile.Run(SettingsFile);
                    Debug.Log(SettingsFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(CustomCommandsFile))
                {
                    File.Create(CustomCommandsFile).Close();
                    CreateFile.Run(CustomCommandsFile);
                    Debug.Log(CustomCommandsFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(AnnouncementsFile))
                {
                    File.Create(AnnouncementsFile).Close();
                    Debug.Log(AnnouncementsFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(LogFile))
                {
                    File.Create(LogFile).Close();
                    Debug.Log(LogFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(ChatLogFile))
                {
                    File.Create(ChatLogFile).Close();
                    Debug.Log(ChatLogFile + " Does not exist! Creating one.");
                }
                if (!File.Exists(CommandLogFile))
                {
                    File.Create(CommandLogFile).Close();
                    Debug.Log(CommandLogFile + " Does not exist! Creating one.");
                }
            }
            else
            {
                if (!File.Exists(fileName))
                {

                    if (fileName == SettingsFile || fileName == ChatBlockFile || fileName == LanguageBlockFile || fileName == CustomCommandsFile)
                    {
                        File.Create(fileName).Close();
                        CreateFile.Run(fileName);
                        Debug.Log(fileName + " Does not exist! Creating one.");
                    }
                    else
                    {
                        File.Create(fileName).Close();
                        Debug.Log(fileName + " Does not exist! Creating one.");
                    }
                }
            }
        }
    }
}
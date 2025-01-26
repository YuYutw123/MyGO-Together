using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using ModelReplacement;
using BepInEx.Configuration;
using System;
using MygoModelMod.Replacements;

namespace MydoModelMod
{

    [BepInPlugin("MygoModels", "MydoModelMod", "1.0.0")]
    [BepInDependency("meow.ModelReplacementAPI", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigFile config;

        public void InitConfig()
        {
            return;
        }

        private void Awake()
        {
            config = base.Config;
            InitConfig();
            Assets.PopulateAssets();

            ModelReplacementAPI.RegisterSuitModelReplacement("Anon", typeof(AnonReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Tomori", typeof(TomoriReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Taki", typeof(TakiReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Soyo", typeof(SoyoReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Raana", typeof(RaanaReplacement));


            Harmony harmony = new Harmony("MygoModels");
            harmony.PatchAll();
        }
    }
    public static class Assets
    {
        // Replace mbundle with the Asset Bundle Name from your unity project 
        public static string mainAssetBundleName = "mygobundle";
        public static AssetBundle MainAssetBundle = null;

        private static string GetAssemblyName() => Assembly.GetExecutingAssembly().GetName().Name;
        public static void PopulateAssets()
        {
            if (MainAssetBundle == null)
            {
                Console.WriteLine(GetAssemblyName() + "." + mainAssetBundleName);
                using (var assetStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetAssemblyName() + "." + mainAssetBundleName))
                {
                    MainAssetBundle = AssetBundle.LoadFromStream(assetStream);
                }

            }
        }
    }
}
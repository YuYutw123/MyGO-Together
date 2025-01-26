using ModelReplacement;
using MydoModelMod;
using UnityEngine;

namespace MygoModelMod.Replacements
{
    public class AnonReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "Anon";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }
    public class TomoriReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "Tomori";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }
    public class RaanaReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "Raana";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }
    public class SoyoReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "Soyo";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }
    public class TakiReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "Taki";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
            UseNoPostProcessing = true;
        }
    }
}
using BepInEx;
using GorillaNetworking;
using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
//the mod u know
namespace Cosmetics
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin instance;
        void Start()
        {//made by im crab
            instance = this;
            HarmonyPatches.ApplyHarmonyPatches();
        }

        public void UnlockCosmetics()
        {
            MethodInfo UnlockItem = typeof(CosmeticsController).GetMethod("UnlockItem", BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (CosmeticsController.CosmeticItem cosmeticItem in CosmeticsController.instance.allCosmetics)
            {
                if (!CosmeticsController.instance.concatStringCosmeticsAllowed.Contains(cosmeticItem.itemName))
                {//@imcrab
                    try
                    {
                        UnlockItem.Invoke(CosmeticsController.instance, new object[] { cosmeticItem.itemName });
                    } catch { }
                }
            }
            //hi im crab
            CosmeticsController.instance.OnCosmeticsUpdated.Invoke();
        }
    }
}

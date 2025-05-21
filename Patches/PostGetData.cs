using GorillaNetworking;
using GorillaNetworking.Store;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
// do i rlly need to explain this?
namespace Cosmetics.Patches
{
    [HarmonyPatch(typeof(StoreUpdater))]
    [HarmonyPatch("Initialize", MethodType.Normal)]
    public class PostGetData
    {
        private static void Postfix()
        {
            Plugin.instance.UnlockCosmetics();
        }
    }
}

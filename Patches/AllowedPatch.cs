using GorillaNetworking;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
//this is aslo here for crab
namespace Cosmetics.Patches
{
    [HarmonyPatch(typeof(VRRig))]
    [HarmonyPatch("IsItemAllowed", MethodType.Normal)]
    internal class SlidePatch
    {//and fuck u MonkeyGT dumbass
        private static void Postfix(VRRig __instance, ref bool __result)
        {
            __result = true;
        }
    }
}

using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace RemoveMovementTrackingCamera;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
        
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

        // create an instance of Harmony
        var harmony = new Harmony("com.Zeffies.RemoveMovementTrackingCamera");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(MCAAnInputDampened), "UpdateFunction")]
public class MCAAnInputDampened_UpdateFunction
{
    [HarmonyPrefix]
    static void RemoveMovementTrackingCamera(MCAAnInputDampened __instance)
    {
        __instance.camFrontXinputVecDotProductRotateLimit = 3;
    }
}
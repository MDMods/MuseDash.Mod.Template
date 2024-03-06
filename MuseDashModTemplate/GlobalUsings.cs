global using HarmonyLib;
global using MelonLoader;
global using static MuseDashModTemplate.MelonBuildInfo;
#if UseMuseDashMirror
global using MuseDashMirror.Attributes;
global using MuseDashMirror.Attributes.EventAttributes.PatchEvents;
global using MuseDashMirror.Attributes.EventAttributes.SceneEvents;
global using MuseDashMirror.EventArguments;
#endif
#if UseUniTask
global using Cysharp.Threading.Tasks;
global using Cysharp.Threading.Tasks.Linq;
#endif
#if UseZString
global using Cysharp.Text;
#endif
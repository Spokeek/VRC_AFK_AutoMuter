using VRCOSC.Game.Modules;
using VRCOSC.Game.Modules.Avatar;

namespace VRC_AFK_AutoMuterModule
{
    [ModuleTitle("VRC AFK AutoMuter")]
    [ModuleDescription("An OSC tool that automatically mutes when AFK in VRChat.")]
    [ModuleAuthor("Spokeek", "https://shelter.moe/@spokeek", "https://avatars.githubusercontent.com/u/4519853")]
    [ModuleGroup(ModuleType.General)]
    [ModuleInfo("This project is OpenSource and available on Github.", "https://github.com/Spokeek/VRC_AFK_AutoMuter")]
    [ModuleInfo("It is based on an existing project by Sayamame-beans also on Github.", "https://github.com/Sayamame-beans/VRC_AFK_AutoMuter")]
    public partial class VRC_AFK_AutoMuterModule : AvatarModule
    {
        protected override void OnPlayerUpdate()
        {
            // Enable MuteSelf if Player goes in AFK state
            if (Player.AFK.GetValueOrDefault(false))
            {
                SendParameter("MuteSelf", 1);
            }
        }
    }
}

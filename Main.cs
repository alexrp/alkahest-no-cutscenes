using Alkahest.Core.Net.Game.Packets;
using Alkahest.Plugins.CSharp;

namespace Alkahest.Scripts.NoCutscenes
{
    public static class NoCutscenesScript
    {
        public static void __Start__(CSharpScriptContext context)
        {
            context.Dispatch.AddHandler<SPlayMoviePacket>((client, direction, packet, flags) =>
            {
                return false;
            });

            context.Dispatch.AddHandler<CEndMoviePacket>((client, direction, packet, flags) =>
            {
                return false;
            });

            context.Log.Basic("Started no cutscenes script");
        }

        public static void __Stop__(CSharpScriptContext context)
        {
            context.Log.Basic("Stopped no cutscenes script");
        }
    }
}

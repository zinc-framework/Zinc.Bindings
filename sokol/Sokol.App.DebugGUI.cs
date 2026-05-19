using System.Runtime.InteropServices;

namespace Zinc.Internal.Sokol
{
    public static unsafe partial class AppDebugGUI
    {
        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_setup", ExactSpelling = true)]
        public static extern void setup();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_shutdown", ExactSpelling = true)]
        public static extern void shutdown();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_track_frame", ExactSpelling = true)]
        public static extern void track_frame();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_track_event", ExactSpelling = true)]
        public static extern void track_event([NativeTypeName("const sapp_event *")] sapp_event* ev);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw", ExactSpelling = true)]
        public static extern void draw();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw_menu", ExactSpelling = true)]
        public static extern void draw_menu([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw_hud_window_content", ExactSpelling = true)]
        public static extern void draw_hud_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw_publicstate_window_content", ExactSpelling = true)]
        public static extern void draw_publicstate_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw_event_window_content", ExactSpelling = true)]
        public static extern void draw_event_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw_hud_window", ExactSpelling = true)]
        public static extern void draw_hud_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw_publicstate_window", ExactSpelling = true)]
        public static extern void draw_publicstate_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw_event_window", ExactSpelling = true)]
        public static extern void draw_event_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw_hud_menu_item", ExactSpelling = true)]
        public static extern void draw_hud_menu_item([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw_publicstate_menu_item", ExactSpelling = true)]
        public static extern void draw_publicstate_menu_item([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sappimgui_draw_event_menu_item", ExactSpelling = true)]
        public static extern void draw_event_menu_item([NativeTypeName("const char *")] sbyte* label);
    }
}

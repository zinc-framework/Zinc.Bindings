using System.Runtime.InteropServices;

namespace Zinc.Internal.Sokol
{
    public unsafe partial struct sgimgui_allocator_t
    {
        [NativeTypeName("void *(*)(size_t, void *)")]
        public delegate* unmanaged[Cdecl]<nuint, void*, void*> alloc_fn;

        [NativeTypeName("void (*)(void *, void *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, void> free_fn;

        public void* user_data;
    }

    public partial struct sgimgui_desc_t
    {
        public sgimgui_allocator_t allocator;
    }

    public static unsafe partial class GfxDebugGUI
    {
        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_setup([NativeTypeName("const sgimgui_desc_t *")] sgimgui_desc_t* desc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_shutdown();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_menu([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_buffer_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_image_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_sampler_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_shader_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_pipeline_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_view_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_capture_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_capabilities_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_frame_stats_window_content();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_buffer_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_image_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_sampler_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_shader_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_pipeline_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_view_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_capture_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_capabilities_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_frame_stats_window([NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_buffer_menu_item([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_image_menu_item([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_sampler_menu_item([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_shader_menu_item([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_pipeline_menu_item([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_view_menu_item([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_capture_menu_item([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_capabilities_menu_item([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_frame_stats_menu_item([NativeTypeName("const char *")] sbyte* label);
    }
}

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Zinc.Internal.Sokol
{
    public partial struct sgimgui_str_t
    {
        [NativeTypeName("char[96]")]
        public _buf_e__FixedBuffer buf;

        [InlineArray(96)]
        public partial struct _buf_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct sgimgui_buffer_t
    {
        public sg_buffer res_id;

        public sgimgui_str_t label;

        public sg_buffer_desc desc;
    }

    public partial struct sgimgui_image_t
    {
        public sg_image res_id;

        public float ui_scale;

        public sgimgui_str_t label;

        public sg_image_desc desc;

        public simgui_image_t simgui_img;
    }

    public partial struct sgimgui_sampler_t
    {
        public sg_sampler res_id;

        public sgimgui_str_t label;

        public sg_sampler_desc desc;
    }

    public partial struct sgimgui_shader_t
    {
        public sg_shader res_id;

        public sgimgui_str_t label;

        public sgimgui_str_t vs_entry;

        public sgimgui_str_t vs_d3d11_target;

        public sgimgui_str_t fs_entry;

        public sgimgui_str_t fs_d3d11_target;

        [NativeTypeName("sgimgui_str_t[16]")]
        public _glsl_image_sampler_name_e__FixedBuffer glsl_image_sampler_name;

        [NativeTypeName("sgimgui_str_t[8][16]")]
        public _glsl_uniform_name_e__FixedBuffer glsl_uniform_name;

        [NativeTypeName("sgimgui_str_t[16]")]
        public _attr_glsl_name_e__FixedBuffer attr_glsl_name;

        [NativeTypeName("sgimgui_str_t[16]")]
        public _attr_hlsl_sem_name_e__FixedBuffer attr_hlsl_sem_name;

        public sg_shader_desc desc;

        [InlineArray(16)]
        public partial struct _glsl_image_sampler_name_e__FixedBuffer
        {
            public sgimgui_str_t e0;
        }

        [InlineArray(8 * 16)]
        public partial struct _glsl_uniform_name_e__FixedBuffer
        {
            public sgimgui_str_t e0_0;
        }

        [InlineArray(16)]
        public partial struct _attr_glsl_name_e__FixedBuffer
        {
            public sgimgui_str_t e0;
        }

        [InlineArray(16)]
        public partial struct _attr_hlsl_sem_name_e__FixedBuffer
        {
            public sgimgui_str_t e0;
        }
    }

    public partial struct sgimgui_pipeline_t
    {
        public sg_pipeline res_id;

        public sgimgui_str_t label;

        public sg_pipeline_desc desc;
    }

    public partial struct sgimgui_attachments_t
    {
        public sg_attachments res_id;

        public sgimgui_str_t label;

        [NativeTypeName("float[4]")]
        public _color_image_scale_e__FixedBuffer color_image_scale;

        [NativeTypeName("float[4]")]
        public _resolve_image_scale_e__FixedBuffer resolve_image_scale;

        public float ds_image_scale;

        public sg_attachments_desc desc;

        [InlineArray(4)]
        public partial struct _color_image_scale_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(4)]
        public partial struct _resolve_image_scale_e__FixedBuffer
        {
            public float e0;
        }
    }

    public unsafe partial struct sgimgui_buffer_window_t
    {
        [NativeTypeName("bool")]
        public byte open;

        public int num_slots;

        public sg_buffer sel_buf;

        public sgimgui_buffer_t* slots;
    }

    public unsafe partial struct sgimgui_image_window_t
    {
        [NativeTypeName("bool")]
        public byte open;

        public int num_slots;

        public sg_image sel_img;

        public sgimgui_image_t* slots;
    }

    public unsafe partial struct sgimgui_sampler_window_t
    {
        [NativeTypeName("bool")]
        public byte open;

        public int num_slots;

        public sg_sampler sel_smp;

        public sgimgui_sampler_t* slots;
    }

    public unsafe partial struct sgimgui_shader_window_t
    {
        [NativeTypeName("bool")]
        public byte open;

        public int num_slots;

        public sg_shader sel_shd;

        public sgimgui_shader_t* slots;
    }

    public unsafe partial struct sgimgui_pipeline_window_t
    {
        [NativeTypeName("bool")]
        public byte open;

        public int num_slots;

        public sg_pipeline sel_pip;

        public sgimgui_pipeline_t* slots;
    }

    public unsafe partial struct sgimgui_attachments_window_t
    {
        [NativeTypeName("bool")]
        public byte open;

        public int num_slots;

        public sg_attachments sel_atts;

        public sgimgui_attachments_t* slots;
    }

    public enum sgimgui_cmd_t
    {
        SGIMGUI_CMD_INVALID,
        SGIMGUI_CMD_RESET_STATE_CACHE,
        SGIMGUI_CMD_MAKE_BUFFER,
        SGIMGUI_CMD_MAKE_IMAGE,
        SGIMGUI_CMD_MAKE_SAMPLER,
        SGIMGUI_CMD_MAKE_SHADER,
        SGIMGUI_CMD_MAKE_PIPELINE,
        SGIMGUI_CMD_MAKE_ATTACHMENTS,
        SGIMGUI_CMD_DESTROY_BUFFER,
        SGIMGUI_CMD_DESTROY_IMAGE,
        SGIMGUI_CMD_DESTROY_SAMPLER,
        SGIMGUI_CMD_DESTROY_SHADER,
        SGIMGUI_CMD_DESTROY_PIPELINE,
        SGIMGUI_CMD_DESTROY_ATTACHMENTS,
        SGIMGUI_CMD_UPDATE_BUFFER,
        SGIMGUI_CMD_UPDATE_IMAGE,
        SGIMGUI_CMD_APPEND_BUFFER,
        SGIMGUI_CMD_BEGIN_PASS,
        SGIMGUI_CMD_APPLY_VIEWPORT,
        SGIMGUI_CMD_APPLY_SCISSOR_RECT,
        SGIMGUI_CMD_APPLY_PIPELINE,
        SGIMGUI_CMD_APPLY_BINDINGS,
        SGIMGUI_CMD_APPLY_UNIFORMS,
        SGIMGUI_CMD_DRAW,
        SGIMGUI_CMD_END_PASS,
        SGIMGUI_CMD_COMMIT,
        SGIMGUI_CMD_ALLOC_BUFFER,
        SGIMGUI_CMD_ALLOC_IMAGE,
        SGIMGUI_CMD_ALLOC_SAMPLER,
        SGIMGUI_CMD_ALLOC_SHADER,
        SGIMGUI_CMD_ALLOC_PIPELINE,
        SGIMGUI_CMD_ALLOC_ATTACHMENTS,
        SGIMGUI_CMD_DEALLOC_BUFFER,
        SGIMGUI_CMD_DEALLOC_IMAGE,
        SGIMGUI_CMD_DEALLOC_SAMPLER,
        SGIMGUI_CMD_DEALLOC_SHADER,
        SGIMGUI_CMD_DEALLOC_PIPELINE,
        SGIMGUI_CMD_DEALLOC_ATTACHMENTS,
        SGIMGUI_CMD_INIT_BUFFER,
        SGIMGUI_CMD_INIT_IMAGE,
        SGIMGUI_CMD_INIT_SAMPLER,
        SGIMGUI_CMD_INIT_SHADER,
        SGIMGUI_CMD_INIT_PIPELINE,
        SGIMGUI_CMD_INIT_ATTACHMENTS,
        SGIMGUI_CMD_UNINIT_BUFFER,
        SGIMGUI_CMD_UNINIT_IMAGE,
        SGIMGUI_CMD_UNINIT_SAMPLER,
        SGIMGUI_CMD_UNINIT_SHADER,
        SGIMGUI_CMD_UNINIT_PIPELINE,
        SGIMGUI_CMD_UNINIT_ATTACHMENTS,
        SGIMGUI_CMD_FAIL_BUFFER,
        SGIMGUI_CMD_FAIL_IMAGE,
        SGIMGUI_CMD_FAIL_SAMPLER,
        SGIMGUI_CMD_FAIL_SHADER,
        SGIMGUI_CMD_FAIL_PIPELINE,
        SGIMGUI_CMD_FAIL_ATTACHMENTS,
        SGIMGUI_CMD_PUSH_DEBUG_GROUP,
        SGIMGUI_CMD_POP_DEBUG_GROUP,
    }

    public partial struct sgimgui_args_make_buffer_t
    {
        public sg_buffer result;
    }

    public partial struct sgimgui_args_make_image_t
    {
        public sg_image result;
    }

    public partial struct sgimgui_args_make_sampler_t
    {
        public sg_sampler result;
    }

    public partial struct sgimgui_args_make_shader_t
    {
        public sg_shader result;
    }

    public partial struct sgimgui_args_make_pipeline_t
    {
        public sg_pipeline result;
    }

    public partial struct sgimgui_args_make_attachments_t
    {
        public sg_attachments result;
    }

    public partial struct sgimgui_args_destroy_buffer_t
    {
        public sg_buffer buffer;
    }

    public partial struct sgimgui_args_destroy_image_t
    {
        public sg_image image;
    }

    public partial struct sgimgui_args_destroy_sampler_t
    {
        public sg_sampler sampler;
    }

    public partial struct sgimgui_args_destroy_shader_t
    {
        public sg_shader shader;
    }

    public partial struct sgimgui_args_destroy_pipeline_t
    {
        public sg_pipeline pipeline;
    }

    public partial struct sgimgui_args_destroy_attachments_t
    {
        public sg_attachments attachments;
    }

    public partial struct sgimgui_args_update_buffer_t
    {
        public sg_buffer buffer;

        [NativeTypeName("size_t")]
        public nuint data_size;
    }

    public partial struct sgimgui_args_update_image_t
    {
        public sg_image image;
    }

    public partial struct sgimgui_args_append_buffer_t
    {
        public sg_buffer buffer;

        [NativeTypeName("size_t")]
        public nuint data_size;

        public int result;
    }

    public partial struct sgimgui_args_begin_pass_t
    {
        public sg_pass pass;
    }

    public partial struct sgimgui_args_apply_viewport_t
    {
        public int x;

        public int y;

        public int width;

        public int height;

        [NativeTypeName("bool")]
        public byte origin_top_left;
    }

    public partial struct sgimgui_args_apply_scissor_rect_t
    {
        public int x;

        public int y;

        public int width;

        public int height;

        [NativeTypeName("bool")]
        public byte origin_top_left;
    }

    public partial struct sgimgui_args_apply_pipeline_t
    {
        public sg_pipeline pipeline;
    }

    public partial struct sgimgui_args_apply_bindings_t
    {
        public sg_bindings bindings;
    }

    public partial struct sgimgui_args_apply_uniforms_t
    {
        public int ub_slot;

        [NativeTypeName("size_t")]
        public nuint data_size;

        public sg_pipeline pipeline;

        [NativeTypeName("size_t")]
        public nuint ubuf_pos;
    }

    public partial struct sgimgui_args_draw_t
    {
        public int base_element;

        public int num_elements;

        public int num_instances;
    }

    public partial struct sgimgui_args_alloc_buffer_t
    {
        public sg_buffer result;
    }

    public partial struct sgimgui_args_alloc_image_t
    {
        public sg_image result;
    }

    public partial struct sgimgui_args_alloc_sampler_t
    {
        public sg_sampler result;
    }

    public partial struct sgimgui_args_alloc_shader_t
    {
        public sg_shader result;
    }

    public partial struct sgimgui_args_alloc_pipeline_t
    {
        public sg_pipeline result;
    }

    public partial struct sgimgui_args_alloc_attachments_t
    {
        public sg_attachments result;
    }

    public partial struct sgimgui_args_dealloc_buffer_t
    {
        public sg_buffer buffer;
    }

    public partial struct sgimgui_args_dealloc_image_t
    {
        public sg_image image;
    }

    public partial struct sgimgui_args_dealloc_sampler_t
    {
        public sg_sampler sampler;
    }

    public partial struct sgimgui_args_dealloc_shader_t
    {
        public sg_shader shader;
    }

    public partial struct sgimgui_args_dealloc_pipeline_t
    {
        public sg_pipeline pipeline;
    }

    public partial struct sgimgui_args_dealloc_attachments_t
    {
        public sg_attachments attachments;
    }

    public partial struct sgimgui_args_init_buffer_t
    {
        public sg_buffer buffer;
    }

    public partial struct sgimgui_args_init_image_t
    {
        public sg_image image;
    }

    public partial struct sgimgui_args_init_sampler_t
    {
        public sg_sampler sampler;
    }

    public partial struct sgimgui_args_init_shader_t
    {
        public sg_shader shader;
    }

    public partial struct sgimgui_args_init_pipeline_t
    {
        public sg_pipeline pipeline;
    }

    public partial struct sgimgui_args_init_attachments_t
    {
        public sg_attachments attachments;
    }

    public partial struct sgimgui_args_uninit_buffer_t
    {
        public sg_buffer buffer;
    }

    public partial struct sgimgui_args_uninit_image_t
    {
        public sg_image image;
    }

    public partial struct sgimgui_args_uninit_sampler_t
    {
        public sg_sampler sampler;
    }

    public partial struct sgimgui_args_uninit_shader_t
    {
        public sg_shader shader;
    }

    public partial struct sgimgui_args_uninit_pipeline_t
    {
        public sg_pipeline pipeline;
    }

    public partial struct sgimgui_args_uninit_attachments_t
    {
        public sg_attachments attachments;
    }

    public partial struct sgimgui_args_fail_buffer_t
    {
        public sg_buffer buffer;
    }

    public partial struct sgimgui_args_fail_image_t
    {
        public sg_image image;
    }

    public partial struct sgimgui_args_fail_sampler_t
    {
        public sg_sampler sampler;
    }

    public partial struct sgimgui_args_fail_shader_t
    {
        public sg_shader shader;
    }

    public partial struct sgimgui_args_fail_pipeline_t
    {
        public sg_pipeline pipeline;
    }

    public partial struct sgimgui_args_fail_attachments_t
    {
        public sg_attachments attachments;
    }

    public partial struct sgimgui_args_push_debug_group_t
    {
        public sgimgui_str_t name;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct sgimgui_args_t
    {
        [FieldOffset(0)]
        public sgimgui_args_make_buffer_t make_buffer;

        [FieldOffset(0)]
        public sgimgui_args_make_image_t make_image;

        [FieldOffset(0)]
        public sgimgui_args_make_sampler_t make_sampler;

        [FieldOffset(0)]
        public sgimgui_args_make_shader_t make_shader;

        [FieldOffset(0)]
        public sgimgui_args_make_pipeline_t make_pipeline;

        [FieldOffset(0)]
        public sgimgui_args_make_attachments_t make_attachments;

        [FieldOffset(0)]
        public sgimgui_args_destroy_buffer_t destroy_buffer;

        [FieldOffset(0)]
        public sgimgui_args_destroy_image_t destroy_image;

        [FieldOffset(0)]
        public sgimgui_args_destroy_sampler_t destroy_sampler;

        [FieldOffset(0)]
        public sgimgui_args_destroy_shader_t destroy_shader;

        [FieldOffset(0)]
        public sgimgui_args_destroy_pipeline_t destroy_pipeline;

        [FieldOffset(0)]
        public sgimgui_args_destroy_attachments_t destroy_attachments;

        [FieldOffset(0)]
        public sgimgui_args_update_buffer_t update_buffer;

        [FieldOffset(0)]
        public sgimgui_args_update_image_t update_image;

        [FieldOffset(0)]
        public sgimgui_args_append_buffer_t append_buffer;

        [FieldOffset(0)]
        public sgimgui_args_begin_pass_t begin_pass;

        [FieldOffset(0)]
        public sgimgui_args_apply_viewport_t apply_viewport;

        [FieldOffset(0)]
        public sgimgui_args_apply_scissor_rect_t apply_scissor_rect;

        [FieldOffset(0)]
        public sgimgui_args_apply_pipeline_t apply_pipeline;

        [FieldOffset(0)]
        public sgimgui_args_apply_bindings_t apply_bindings;

        [FieldOffset(0)]
        public sgimgui_args_apply_uniforms_t apply_uniforms;

        [FieldOffset(0)]
        public sgimgui_args_draw_t draw;

        [FieldOffset(0)]
        public sgimgui_args_alloc_buffer_t alloc_buffer;

        [FieldOffset(0)]
        public sgimgui_args_alloc_image_t alloc_image;

        [FieldOffset(0)]
        public sgimgui_args_alloc_sampler_t alloc_sampler;

        [FieldOffset(0)]
        public sgimgui_args_alloc_shader_t alloc_shader;

        [FieldOffset(0)]
        public sgimgui_args_alloc_pipeline_t alloc_pipeline;

        [FieldOffset(0)]
        public sgimgui_args_alloc_attachments_t alloc_attachments;

        [FieldOffset(0)]
        public sgimgui_args_dealloc_buffer_t dealloc_buffer;

        [FieldOffset(0)]
        public sgimgui_args_dealloc_image_t dealloc_image;

        [FieldOffset(0)]
        public sgimgui_args_dealloc_sampler_t dealloc_sampler;

        [FieldOffset(0)]
        public sgimgui_args_dealloc_shader_t dealloc_shader;

        [FieldOffset(0)]
        public sgimgui_args_dealloc_pipeline_t dealloc_pipeline;

        [FieldOffset(0)]
        public sgimgui_args_dealloc_attachments_t dealloc_attachments;

        [FieldOffset(0)]
        public sgimgui_args_init_buffer_t init_buffer;

        [FieldOffset(0)]
        public sgimgui_args_init_image_t init_image;

        [FieldOffset(0)]
        public sgimgui_args_init_sampler_t init_sampler;

        [FieldOffset(0)]
        public sgimgui_args_init_shader_t init_shader;

        [FieldOffset(0)]
        public sgimgui_args_init_pipeline_t init_pipeline;

        [FieldOffset(0)]
        public sgimgui_args_init_attachments_t init_attachments;

        [FieldOffset(0)]
        public sgimgui_args_uninit_buffer_t uninit_buffer;

        [FieldOffset(0)]
        public sgimgui_args_uninit_image_t uninit_image;

        [FieldOffset(0)]
        public sgimgui_args_uninit_sampler_t uninit_sampler;

        [FieldOffset(0)]
        public sgimgui_args_uninit_shader_t uninit_shader;

        [FieldOffset(0)]
        public sgimgui_args_uninit_pipeline_t uninit_pipeline;

        [FieldOffset(0)]
        public sgimgui_args_uninit_attachments_t uninit_attachments;

        [FieldOffset(0)]
        public sgimgui_args_fail_buffer_t fail_buffer;

        [FieldOffset(0)]
        public sgimgui_args_fail_image_t fail_image;

        [FieldOffset(0)]
        public sgimgui_args_fail_sampler_t fail_sampler;

        [FieldOffset(0)]
        public sgimgui_args_fail_shader_t fail_shader;

        [FieldOffset(0)]
        public sgimgui_args_fail_pipeline_t fail_pipeline;

        [FieldOffset(0)]
        public sgimgui_args_fail_attachments_t fail_attachments;

        [FieldOffset(0)]
        public sgimgui_args_push_debug_group_t push_debug_group;
    }

    public partial struct sgimgui_capture_item_t
    {
        public sgimgui_cmd_t cmd;

        [NativeTypeName("uint32_t")]
        public uint color;

        public sgimgui_args_t args;
    }

    public unsafe partial struct sgimgui_capture_bucket_t
    {
        [NativeTypeName("size_t")]
        public nuint ubuf_size;

        [NativeTypeName("size_t")]
        public nuint ubuf_pos;

        [NativeTypeName("uint8_t *")]
        public byte* ubuf;

        public int num_items;

        [NativeTypeName("sgimgui_capture_item_t[4096]")]
        public _items_e__FixedBuffer items;

        [InlineArray(4096)]
        public partial struct _items_e__FixedBuffer
        {
            public sgimgui_capture_item_t e0;
        }
    }

    public partial struct sgimgui_capture_window_t
    {
        [NativeTypeName("bool")]
        public byte open;

        public int bucket_index;

        public int sel_item;

        [NativeTypeName("sgimgui_capture_bucket_t[2]")]
        public _bucket_e__FixedBuffer bucket;

        [InlineArray(2)]
        public partial struct _bucket_e__FixedBuffer
        {
            public sgimgui_capture_bucket_t e0;
        }
    }

    public partial struct sgimgui_caps_window_t
    {
        [NativeTypeName("bool")]
        public byte open;
    }

    public partial struct sgimgui_frame_stats_window_t
    {
        [NativeTypeName("bool")]
        public byte open;

        [NativeTypeName("bool")]
        public byte disable_sokol_imgui_stats;

        [NativeTypeName("bool")]
        public byte in_sokol_imgui;

        public sg_frame_stats stats;
    }

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

    public partial struct sgimgui_t
    {
        [NativeTypeName("uint32_t")]
        public uint init_tag;

        public sgimgui_desc_t desc;

        public sgimgui_buffer_window_t buffer_window;

        public sgimgui_image_window_t image_window;

        public sgimgui_sampler_window_t sampler_window;

        public sgimgui_shader_window_t shader_window;

        public sgimgui_pipeline_window_t pipeline_window;

        public sgimgui_attachments_window_t attachments_window;

        public sgimgui_capture_window_t capture_window;

        public sgimgui_caps_window_t caps_window;

        public sgimgui_frame_stats_window_t frame_stats_window;

        public sg_pipeline cur_pipeline;

        public sg_trace_hooks hooks;
    }

    public static unsafe partial class GfxDebugGUI
    {
        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_init(sgimgui_t* ctx, [NativeTypeName("const sgimgui_desc_t *")] sgimgui_desc_t* desc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_discard(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_menu(sgimgui_t* ctx, [NativeTypeName("const char *")] sbyte* title);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_buffer_window_content(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_image_window_content(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_sampler_window_content(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_shader_window_content(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_pipeline_window_content(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_attachments_window_content(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_capture_window_content(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_capabilities_window_content(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_frame_stats_window_content(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_buffer_window(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_image_window(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_sampler_window(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_shader_window(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_pipeline_window(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_attachments_window(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_capture_window(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_capabilities_window(sgimgui_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sgimgui_draw_frame_stats_window(sgimgui_t* ctx);
    }
}

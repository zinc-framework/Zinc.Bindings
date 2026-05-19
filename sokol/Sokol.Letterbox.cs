using System.Runtime.InteropServices;

namespace Zinc.Internal.Sokol
{
    public partial struct slbx_border
    {
        public int left;

        public int right;

        public int top;

        public int bottom;
    }

    [NativeTypeName("unsigned int")]
    public enum slbx_anchor : uint
    {
        SLBX_ANCHOR_CENTER = 0,
        SLBX_ANCHOR_TOP,
        SLBX_ANCHOR_BOTTOM,
        SLBX_ANCHOR_LEFT,
        SLBX_ANCHOR_RIGHT,
        _SLBX_ANCHOR_FORCE_U32 = 0x7FFFFFFF,
    }

    public partial struct slbx_letterbox_desc
    {
        public float content_aspect_ratio;

        public slbx_anchor anchor;

        public slbx_border border;
    }

    public partial struct slbx_viewport
    {
        public int x;

        public int y;

        public int width;

        public int height;
    }

    public static unsafe partial class Letterbox
    {
        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "slbx_letterbox", ExactSpelling = true)]
        public static extern slbx_viewport letterbox(int width, int height, [NativeTypeName("const slbx_letterbox_desc *")] slbx_letterbox_desc* desc);
    }
}

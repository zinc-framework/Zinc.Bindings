using System.Runtime.InteropServices;

namespace Zinc.Internal.Sokol
{
    public static partial class Glue
    {
        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sg_context_desc sapp_sgcontext();
    }
}

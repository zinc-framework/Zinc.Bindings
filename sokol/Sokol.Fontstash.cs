using System.Runtime.InteropServices;

namespace Zinc.Internal.Sokol
{
    public enum FONSflags
    {
        FONS_ZERO_TOPLEFT = 1,
        FONS_ZERO_BOTTOMLEFT = 2,
    }

    public enum FONSalign
    {
        FONS_ALIGN_LEFT = 1 << 0,
        FONS_ALIGN_CENTER = 1 << 1,
        FONS_ALIGN_RIGHT = 1 << 2,
        FONS_ALIGN_TOP = 1 << 3,
        FONS_ALIGN_MIDDLE = 1 << 4,
        FONS_ALIGN_BOTTOM = 1 << 5,
        FONS_ALIGN_BASELINE = 1 << 6,
    }

    public enum FONSerrorCode
    {
        FONS_ATLAS_FULL = 1,
        FONS_SCRATCH_FULL = 2,
        FONS_STATES_OVERFLOW = 3,
        FONS_STATES_UNDERFLOW = 4,
    }

    public unsafe partial struct FONSparams
    {
        public int width;

        public int height;

        [NativeTypeName("unsigned char")]
        public byte flags;

        public void* userPtr;

        [NativeTypeName("int (*)(void *, int, int)")]
        public delegate* unmanaged[Cdecl]<void*, int, int, int> renderCreate;

        [NativeTypeName("int (*)(void *, int, int)")]
        public delegate* unmanaged[Cdecl]<void*, int, int, int> renderResize;

        [NativeTypeName("void (*)(void *, int *, const unsigned char *)")]
        public delegate* unmanaged[Cdecl]<void*, int*, byte*, void> renderUpdate;

        [NativeTypeName("void (*)(void *, const float *, const float *, const unsigned int *, int)")]
        public delegate* unmanaged[Cdecl]<void*, float*, float*, uint*, int, void> renderDraw;

        [NativeTypeName("void (*)(void *)")]
        public delegate* unmanaged[Cdecl]<void*, void> renderDelete;
    }

    public partial struct FONSquad
    {
        public float x0;

        public float y0;

        public float s0;

        public float t0;

        public float x1;

        public float y1;

        public float s1;

        public float t1;
    }

    public unsafe partial struct FONStextIter
    {
        public float x;

        public float y;

        public float nextx;

        public float nexty;

        public float scale;

        public float spacing;

        [NativeTypeName("unsigned int")]
        public uint codepoint;

        public short isize;

        public short iblur;

        [NativeTypeName("struct FONSfont *")]
        public FONSfont* font;

        public int prevGlyphIndex;

        [NativeTypeName("const char *")]
        public sbyte* str;

        [NativeTypeName("const char *")]
        public sbyte* next;

        [NativeTypeName("const char *")]
        public sbyte* end;

        [NativeTypeName("unsigned int")]
        public uint utf8state;

        public partial struct FONSfont
        {
        }
    }

    public partial struct FONScontext
    {
    }

    public unsafe partial struct sfons_allocator_t
    {
        [NativeTypeName("void *(*)(size_t, void *)")]
        public delegate* unmanaged[Cdecl]<nuint, void*, void*> alloc_fn;

        [NativeTypeName("void (*)(void *, void *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, void> free_fn;

        public void* user_data;
    }

    public partial struct sfons_desc_t
    {
        public int width;

        public int height;

        public sfons_allocator_t allocator;
    }

    public static unsafe partial class Fontstash
    {
        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("FONScontext*")]
        public static extern void* fonsCreateInternal(FONSparams* @params);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsDeleteInternal([NativeTypeName("FONScontext*")] void* s);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsSetErrorCallback([NativeTypeName("FONScontext*")] void* s, [NativeTypeName("void (*)(void *, int, int)")] delegate* unmanaged[Cdecl]<void*, int, int, void> callback, void* uptr);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsGetAtlasSize([NativeTypeName("FONScontext*")] void* s, int* width, int* height);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fonsExpandAtlas([NativeTypeName("FONScontext*")] void* s, int width, int height);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fonsResetAtlas([NativeTypeName("FONScontext*")] void* stash, int width, int height);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fonsGetFontByName([NativeTypeName("FONScontext*")] void* s, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fonsAddFallbackFont([NativeTypeName("FONScontext*")] void* stash, int @base, int fallback);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsPushState([NativeTypeName("FONScontext*")] void* s);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsPopState([NativeTypeName("FONScontext*")] void* s);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsClearState([NativeTypeName("FONScontext*")] void* s);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsSetSize([NativeTypeName("FONScontext*")] void* s, float size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsSetColor([NativeTypeName("FONScontext*")] void* s, [NativeTypeName("unsigned int")] uint color);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsSetSpacing([NativeTypeName("FONScontext*")] void* s, float spacing);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsSetBlur([NativeTypeName("FONScontext*")] void* s, float blur);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsSetAlign([NativeTypeName("FONScontext*")] void* s, int align);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsSetFont([NativeTypeName("FONScontext*")] void* s, int font);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float fonsDrawText([NativeTypeName("FONScontext*")] void* s, float x, float y, [NativeTypeName("const char *")] sbyte* @string, [NativeTypeName("const char *")] sbyte* end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float fonsTextBounds([NativeTypeName("FONScontext*")] void* s, float x, float y, [NativeTypeName("const char *")] sbyte* @string, [NativeTypeName("const char *")] sbyte* end, float* bounds);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsLineBounds([NativeTypeName("FONScontext*")] void* s, float y, float* miny, float* maxy);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsVertMetrics([NativeTypeName("FONScontext*")] void* s, float* ascender, float* descender, float* lineh);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fonsTextIterInit([NativeTypeName("FONScontext*")] void* stash, FONStextIter* iter, float x, float y, [NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char *")] sbyte* end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fonsTextIterNext([NativeTypeName("FONScontext*")] void* stash, FONStextIter* iter, [NativeTypeName("struct FONSquad *")] FONSquad* quad);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const unsigned char *")]
        public static extern byte* fonsGetTextureData([NativeTypeName("FONScontext*")] void* stash, int* width, int* height);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int fonsValidateTexture([NativeTypeName("FONScontext*")] void* s, int* dirty);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void fonsDrawDebug([NativeTypeName("FONScontext*")] void* s, float x, float y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sfons_create", ExactSpelling = true)]
        [return: NativeTypeName("FONScontext*")]
        public static extern void* create([NativeTypeName("const sfons_desc_t *")] sfons_desc_t* desc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sfons_destroy", ExactSpelling = true)]
        public static extern void destroy([NativeTypeName("FONScontext*")] void* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sfons_flush", ExactSpelling = true)]
        public static extern void flush([NativeTypeName("FONScontext*")] void* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sfons_rgba", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint rgba([NativeTypeName("uint8_t")] byte r, [NativeTypeName("uint8_t")] byte g, [NativeTypeName("uint8_t")] byte b, [NativeTypeName("uint8_t")] byte a);
    }
}

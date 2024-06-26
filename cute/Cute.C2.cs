using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Zinc.Internal.Cute
{
    public partial struct c2v
    {
        public float x;

        public float y;
    }

    public partial struct c2r
    {
        public float c;

        public float s;
    }

    public partial struct c2m
    {
        public c2v x;

        public c2v y;
    }

    public partial struct c2x
    {
        public c2v p;

        public c2r r;
    }

    public partial struct c2h
    {
        public c2v n;

        public float d;
    }

    public partial struct c2Circle
    {
        public c2v p;

        public float r;
    }

    public partial struct c2AABB
    {
        public c2v min;

        public c2v max;
    }

    public partial struct c2Capsule
    {
        public c2v a;

        public c2v b;

        public float r;
    }

    public partial struct c2Poly
    {
        public int count;

        [NativeTypeName("c2v[8]")]
        public _verts_e__FixedBuffer verts;

        [NativeTypeName("c2v[8]")]
        public _norms_e__FixedBuffer norms;

        [InlineArray(8)]
        public partial struct _verts_e__FixedBuffer
        {
            public c2v e0;
        }

        [InlineArray(8)]
        public partial struct _norms_e__FixedBuffer
        {
            public c2v e0;
        }
    }

    public partial struct c2Ray
    {
        public c2v p;

        public c2v d;

        public float t;
    }

    public partial struct c2Raycast
    {
        public float t;

        public c2v n;
    }

    public partial struct c2Manifold
    {
        public int count;

        [NativeTypeName("float[2]")]
        public _depths_e__FixedBuffer depths;

        [NativeTypeName("c2v[2]")]
        public _contact_points_e__FixedBuffer contact_points;

        public c2v n;

        [InlineArray(2)]
        public partial struct _depths_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(2)]
        public partial struct _contact_points_e__FixedBuffer
        {
            public c2v e0;
        }
    }

    public enum C2_TYPE
    {
        C2_TYPE_CIRCLE,
        C2_TYPE_AABB,
        C2_TYPE_CAPSULE,
        C2_TYPE_POLY,
    }

    public partial struct c2GJKCache
    {
        public float metric;

        public int count;

        [NativeTypeName("int[3]")]
        public _iA_e__FixedBuffer iA;

        [NativeTypeName("int[3]")]
        public _iB_e__FixedBuffer iB;

        public float div;

        [InlineArray(3)]
        public partial struct _iA_e__FixedBuffer
        {
            public int e0;
        }

        [InlineArray(3)]
        public partial struct _iB_e__FixedBuffer
        {
            public int e0;
        }
    }

    public partial struct c2TOIResult
    {
        public int hit;

        public float toi;

        public c2v n;

        public c2v p;

        public int iterations;
    }

    public static unsafe partial class C2
    {
        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2CircletoCircle(c2Circle A, c2Circle B);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2CircletoAABB(c2Circle A, c2AABB B);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2CircletoCapsule(c2Circle A, c2Capsule B);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2AABBtoAABB(c2AABB A, c2AABB B);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2AABBtoCapsule(c2AABB A, c2Capsule B);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2CapsuletoCapsule(c2Capsule A, c2Capsule B);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2CircletoPoly(c2Circle A, [NativeTypeName("const c2Poly *")] c2Poly* B, [NativeTypeName("const c2x *")] c2x* bx);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2AABBtoPoly(c2AABB A, [NativeTypeName("const c2Poly *")] c2Poly* B, [NativeTypeName("const c2x *")] c2x* bx);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2CapsuletoPoly(c2Capsule A, [NativeTypeName("const c2Poly *")] c2Poly* B, [NativeTypeName("const c2x *")] c2x* bx);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2PolytoPoly([NativeTypeName("const c2Poly *")] c2Poly* A, [NativeTypeName("const c2x *")] c2x* ax, [NativeTypeName("const c2Poly *")] c2Poly* B, [NativeTypeName("const c2x *")] c2x* bx);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2RaytoCircle(c2Ray A, c2Circle B, c2Raycast* @out);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2RaytoAABB(c2Ray A, c2AABB B, c2Raycast* @out);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2RaytoCapsule(c2Ray A, c2Capsule B, c2Raycast* @out);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2RaytoPoly(c2Ray A, [NativeTypeName("const c2Poly *")] c2Poly* B, [NativeTypeName("const c2x *")] c2x* bx_ptr, c2Raycast* @out);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2CircletoCircleManifold(c2Circle A, c2Circle B, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2CircletoAABBManifold(c2Circle A, c2AABB B, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2CircletoCapsuleManifold(c2Circle A, c2Capsule B, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2AABBtoAABBManifold(c2AABB A, c2AABB B, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2AABBtoCapsuleManifold(c2AABB A, c2Capsule B, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2CapsuletoCapsuleManifold(c2Capsule A, c2Capsule B, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2CircletoPolyManifold(c2Circle A, [NativeTypeName("const c2Poly *")] c2Poly* B, [NativeTypeName("const c2x *")] c2x* bx, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2AABBtoPolyManifold(c2AABB A, [NativeTypeName("const c2Poly *")] c2Poly* B, [NativeTypeName("const c2x *")] c2x* bx, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2CapsuletoPolyManifold(c2Capsule A, [NativeTypeName("const c2Poly *")] c2Poly* B, [NativeTypeName("const c2x *")] c2x* bx, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2PolytoPolyManifold([NativeTypeName("const c2Poly *")] c2Poly* A, [NativeTypeName("const c2x *")] c2x* ax, [NativeTypeName("const c2Poly *")] c2Poly* B, [NativeTypeName("const c2x *")] c2x* bx, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float c2GJK([NativeTypeName("const void *")] void* A, C2_TYPE typeA, [NativeTypeName("const c2x *")] c2x* ax_ptr, [NativeTypeName("const void *")] void* B, C2_TYPE typeB, [NativeTypeName("const c2x *")] c2x* bx_ptr, c2v* outA, c2v* outB, int use_radius, int* iterations, c2GJKCache* cache);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern c2TOIResult c2TOI([NativeTypeName("const void *")] void* A, C2_TYPE typeA, [NativeTypeName("const c2x *")] c2x* ax_ptr, c2v vA, [NativeTypeName("const void *")] void* B, C2_TYPE typeB, [NativeTypeName("const c2x *")] c2x* bx_ptr, c2v vB, int use_radius);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2Inflate(void* shape, C2_TYPE type, float skin_factor);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2Hull(c2v* verts, int count);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2Norms(c2v* verts, c2v* norms, int count);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2MakePoly(c2Poly* p);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2Collided([NativeTypeName("const void *")] void* A, [NativeTypeName("const c2x *")] c2x* ax, C2_TYPE typeA, [NativeTypeName("const void *")] void* B, [NativeTypeName("const c2x *")] c2x* bx, C2_TYPE typeB);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void c2Collide([NativeTypeName("const void *")] void* A, [NativeTypeName("const c2x *")] c2x* ax, C2_TYPE typeA, [NativeTypeName("const void *")] void* B, [NativeTypeName("const c2x *")] c2x* bx, C2_TYPE typeB, c2Manifold* m);

        [DllImport("cute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int c2CastRay(c2Ray A, [NativeTypeName("const void *")] void* B, [NativeTypeName("const c2x *")] c2x* bx, C2_TYPE typeB, c2Raycast* @out);
    }
}

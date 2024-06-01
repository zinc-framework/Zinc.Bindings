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

        public static void c2SinCos(float radians, float* s, float* c)
        {
            *c = cosf(radians);
            *s = sinf(radians);
        }

        public static c2v c2V(float x, float y)
        {
            c2v a = new c2v();

            a.x = x;
            a.y = y;
            return a;
        }

        public static c2v c2Add(c2v a, c2v b)
        {
            a.x += b.x;
            a.y += b.y;
            return a;
        }

        public static c2v c2Sub(c2v a, c2v b)
        {
            a.x -= b.x;
            a.y -= b.y;
            return a;
        }

        public static float c2Dot(c2v a, c2v b)
        {
            return a.x * b.x + a.y * b.y;
        }

        public static c2v c2Mulvs(c2v a, float b)
        {
            a.x *= b;
            a.y *= b;
            return a;
        }

        public static c2v c2Mulvv(c2v a, c2v b)
        {
            a.x *= b.x;
            a.y *= b.y;
            return a;
        }

        public static c2v c2Div(c2v a, float b)
        {
            return c2Mulvs(a, 1.0f / b);
        }

        public static c2v c2Skew(c2v a)
        {
            c2v b = new c2v();

            b.x = -a.y;
            b.y = a.x;
            return b;
        }

        public static c2v c2CCW90(c2v a)
        {
            c2v b = new c2v();

            b.x = a.y;
            b.y = -a.x;
            return b;
        }

        public static float c2Det2(c2v a, c2v b)
        {
            return a.x * b.y - a.y * b.x;
        }

        public static c2v c2Minv(c2v a, c2v b)
        {
            return c2V(((a.x) < (b.x) ? (a.x) : (b.x)), ((a.y) < (b.y) ? (a.y) : (b.y)));
        }

        public static c2v c2Maxv(c2v a, c2v b)
        {
            return c2V(((a.x) > (b.x) ? (a.x) : (b.x)), ((a.y) > (b.y) ? (a.y) : (b.y)));
        }

        public static c2v c2Clampv(c2v a, c2v lo, c2v hi)
        {
            return c2Maxv(lo, c2Minv(a, hi));
        }

        public static c2v c2Absv(c2v a)
        {
            return c2V(((a.x) < 0 ? -(a.x) : (a.x)), ((a.y) < 0 ? -(a.y) : (a.y)));
        }

        public static float c2Hmin(c2v a)
        {
            return ((a.x) < (a.y) ? (a.x) : (a.y));
        }

        public static float c2Hmax(c2v a)
        {
            return ((a.x) > (a.y) ? (a.x) : (a.y));
        }

        public static float c2Len(c2v a)
        {
            return sqrtf(c2Dot(a, a));
        }

        public static c2v c2Norm(c2v a)
        {
            return c2Div(a, c2Len(a));
        }

        public static c2v c2SafeNorm(c2v a)
        {
            float sq = c2Dot(a, a);

            return sq ? c2Div(a, c2Len(a)) : c2V(0, 0);
        }

        public static c2v c2Neg(c2v a)
        {
            return c2V(-a.x, -a.y);
        }

        public static c2v c2Lerp(c2v a, c2v b, float t)
        {
            return c2Add(a, c2Mulvs(c2Sub(b, a), t));
        }

        public static int c2Parallel(c2v a, c2v b, float kTol)
        {
            float k = c2Len(a) / c2Len(b);

            b = c2Mulvs(b, k);
            if (((a.x - b.x) < 0 ? -(a.x - b.x) : (a.x - b.x)) < kTol && ((a.y - b.y) < 0 ? -(a.y - b.y) : (a.y - b.y)) < kTol)
            {
                return 1;
            }

            return 0;
        }

        public static c2r c2Rot(float radians)
        {
            c2r r = new c2r();

            c2SinCos(radians, &r.s, &r.c);
            return r;
        }

        public static c2r c2RotIdentity()
        {
            c2r r = new c2r();

            r.c = 1.0f;
            r.s = 0;
            return r;
        }

        public static c2v c2RotX(c2r r)
        {
            return c2V(r.c, r.s);
        }

        public static c2v c2RotY(c2r r)
        {
            return c2V(-r.s, r.c);
        }

        public static c2v c2Mulrv(c2r a, c2v b)
        {
            return c2V(a.c * b.x - a.s * b.y, a.s * b.x + a.c * b.y);
        }

        public static c2v c2MulrvT(c2r a, c2v b)
        {
            return c2V(a.c * b.x + a.s * b.y, -a.s * b.x + a.c * b.y);
        }

        public static c2r c2Mulrr(c2r a, c2r b)
        {
            c2r c = new c2r();

            c.c = a.c * b.c - a.s * b.s;
            c.s = a.s * b.c + a.c * b.s;
            return c;
        }

        public static c2r c2MulrrT(c2r a, c2r b)
        {
            c2r c = new c2r();

            c.c = a.c * b.c + a.s * b.s;
            c.s = a.c * b.s - a.s * b.c;
            return c;
        }

        public static c2v c2Mulmv(c2m a, c2v b)
        {
            c2v c = new c2v();

            c.x = a.x.x * b.x + a.y.x * b.y;
            c.y = a.x.y * b.x + a.y.y * b.y;
            return c;
        }

        public static c2v c2MulmvT(c2m a, c2v b)
        {
            c2v c = new c2v();

            c.x = a.x.x * b.x + a.x.y * b.y;
            c.y = a.y.x * b.x + a.y.y * b.y;
            return c;
        }

        public static c2m c2Mulmm(c2m a, c2m b)
        {
            c2m c = new c2m();

            c.x = c2Mulmv(a, b.x);
            c.y = c2Mulmv(a, b.y);
            return c;
        }

        public static c2m c2MulmmT(c2m a, c2m b)
        {
            c2m c = new c2m();

            c.x = c2MulmvT(a, b.x);
            c.y = c2MulmvT(a, b.y);
            return c;
        }

        public static c2x c2xIdentity()
        {
            c2x x = new c2x();

            x.p = c2V(0, 0);
            x.r = c2RotIdentity();
            return x;
        }

        public static c2v c2Mulxv(c2x a, c2v b)
        {
            return c2Add(c2Mulrv(a.r, b), a.p);
        }

        public static c2v c2MulxvT(c2x a, c2v b)
        {
            return c2MulrvT(a.r, c2Sub(b, a.p));
        }

        public static c2x c2Mulxx(c2x a, c2x b)
        {
            c2x c = new c2x();

            c.r = c2Mulrr(a.r, b.r);
            c.p = c2Add(c2Mulrv(a.r, b.p), a.p);
            return c;
        }

        public static c2x c2MulxxT(c2x a, c2x b)
        {
            c2x c = new c2x();

            c.r = c2MulrrT(a.r, b.r);
            c.p = c2MulrvT(a.r, c2Sub(b.p, a.p));
            return c;
        }

        public static c2x c2Transform(c2v p, float radians)
        {
            c2x x = new c2x();

            x.r = c2Rot(radians);
            x.p = p;
            return x;
        }

        public static c2v c2Origin(c2h h)
        {
            return c2Mulvs(h.n, h.d);
        }

        public static float c2Dist(c2h h, c2v p)
        {
            return c2Dot(h.n, p) - h.d;
        }

        public static c2v c2Project(c2h h, c2v p)
        {
            return c2Sub(p, c2Mulvs(h.n, c2Dist(h, p)));
        }

        public static c2h c2Mulxh(c2x a, c2h b)
        {
            c2h c = new c2h();

            c.n = c2Mulrv(a.r, b.n);
            c.d = c2Dot(c2Mulxv(a, c2Origin(b)), c.n);
            return c;
        }

        public static c2h c2MulxhT(c2x a, c2h b)
        {
            c2h c = new c2h();

            c.n = c2MulrvT(a.r, b.n);
            c.d = c2Dot(c2MulxvT(a, c2Origin(b)), c.n);
            return c;
        }

        public static c2v c2Intersect(c2v a, c2v b, float da, float db)
        {
            return c2Add(a, c2Mulvs(c2Sub(b, a), (da / (da - db))));
        }

        public static void c2BBVerts(c2v* @out, c2AABB* bb)
        {
            @out[0] = bb->min;
            @out[1] = c2V(bb->max.x, bb->min.y);
            @out[2] = bb->max;
            @out[3] = c2V(bb->min.x, bb->max.y);
        }
    }
}

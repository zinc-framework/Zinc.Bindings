using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Zinc.Internal.Box2D
{
    public partial struct b2Version
    {
        public int major;

        public int minor;

        public int revision;
    }

    public partial struct b2Vec2
    {
        public float x;

        public float y;
    }

    public partial struct b2CosSin
    {
        public float cosine;

        public float sine;
    }

    public partial struct b2Rot
    {
        public float c;

        public float s;
    }

    public partial struct b2Transform
    {
        public b2Vec2 p;

        public b2Rot q;
    }

    public partial struct b2Mat22
    {
        public b2Vec2 cx;

        public b2Vec2 cy;
    }

    public partial struct b2AABB
    {
        public b2Vec2 lowerBound;

        public b2Vec2 upperBound;
    }

    public partial struct b2Plane
    {
        public b2Vec2 normal;

        public float offset;
    }

    public partial struct b2RayCastInput
    {
        public b2Vec2 origin;

        public b2Vec2 translation;

        public float maxFraction;
    }

    public partial struct b2ShapeProxy
    {
        [NativeTypeName("b2Vec2[8]")]
        public _points_e__FixedBuffer points;

        public int count;

        public float radius;

        [InlineArray(8)]
        public partial struct _points_e__FixedBuffer
        {
            public b2Vec2 e0;
        }
    }

    public partial struct b2ShapeCastInput
    {
        public b2ShapeProxy proxy;

        public b2Vec2 translation;

        public float maxFraction;

        [NativeTypeName("bool")]
        public byte canEncroach;
    }

    public partial struct b2CastOutput
    {
        public b2Vec2 normal;

        public b2Vec2 point;

        public float fraction;

        public int iterations;

        [NativeTypeName("bool")]
        public byte hit;
    }

    public partial struct b2MassData
    {
        public float mass;

        public b2Vec2 center;

        public float rotationalInertia;
    }

    public partial struct b2Circle
    {
        public b2Vec2 center;

        public float radius;
    }

    public partial struct b2Capsule
    {
        public b2Vec2 center1;

        public b2Vec2 center2;

        public float radius;
    }

    public partial struct b2Polygon
    {
        [NativeTypeName("b2Vec2[8]")]
        public _vertices_e__FixedBuffer vertices;

        [NativeTypeName("b2Vec2[8]")]
        public _normals_e__FixedBuffer normals;

        public b2Vec2 centroid;

        public float radius;

        public int count;

        [InlineArray(8)]
        public partial struct _vertices_e__FixedBuffer
        {
            public b2Vec2 e0;
        }

        [InlineArray(8)]
        public partial struct _normals_e__FixedBuffer
        {
            public b2Vec2 e0;
        }
    }

    public partial struct b2Segment
    {
        public b2Vec2 point1;

        public b2Vec2 point2;
    }

    public partial struct b2ChainSegment
    {
        public b2Vec2 ghost1;

        public b2Segment segment;

        public b2Vec2 ghost2;

        public int chainId;
    }

    public partial struct b2Hull
    {
        [NativeTypeName("b2Vec2[8]")]
        public _points_e__FixedBuffer points;

        public int count;

        [InlineArray(8)]
        public partial struct _points_e__FixedBuffer
        {
            public b2Vec2 e0;
        }
    }

    public partial struct b2SegmentDistanceResult
    {
        public b2Vec2 closest1;

        public b2Vec2 closest2;

        public float fraction1;

        public float fraction2;

        public float distanceSquared;
    }

    public partial struct b2SimplexCache
    {
        [NativeTypeName("uint16_t")]
        public ushort count;

        [NativeTypeName("uint8_t[3]")]
        public _indexA_e__FixedBuffer indexA;

        [NativeTypeName("uint8_t[3]")]
        public _indexB_e__FixedBuffer indexB;

        [InlineArray(3)]
        public partial struct _indexA_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(3)]
        public partial struct _indexB_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct b2DistanceInput
    {
        public b2ShapeProxy proxyA;

        public b2ShapeProxy proxyB;

        public b2Transform transformA;

        public b2Transform transformB;

        [NativeTypeName("bool")]
        public byte useRadii;
    }

    public partial struct b2DistanceOutput
    {
        public b2Vec2 pointA;

        public b2Vec2 pointB;

        public b2Vec2 normal;

        public float distance;

        public int iterations;

        public int simplexCount;
    }

    public partial struct b2SimplexVertex
    {
        public b2Vec2 wA;

        public b2Vec2 wB;

        public b2Vec2 w;

        public float a;

        public int indexA;

        public int indexB;
    }

    public partial struct b2Simplex
    {
        public b2SimplexVertex v1;

        public b2SimplexVertex v2;

        public b2SimplexVertex v3;

        public int count;
    }

    public partial struct b2ShapeCastPairInput
    {
        public b2ShapeProxy proxyA;

        public b2ShapeProxy proxyB;

        public b2Transform transformA;

        public b2Transform transformB;

        public b2Vec2 translationB;

        public float maxFraction;

        [NativeTypeName("bool")]
        public byte canEncroach;
    }

    public partial struct b2Sweep
    {
        public b2Vec2 localCenter;

        public b2Vec2 c1;

        public b2Vec2 c2;

        public b2Rot q1;

        public b2Rot q2;
    }

    public partial struct b2TOIInput
    {
        public b2ShapeProxy proxyA;

        public b2ShapeProxy proxyB;

        public b2Sweep sweepA;

        public b2Sweep sweepB;

        public float maxFraction;
    }

    [NativeTypeName("unsigned int")]
    public enum b2TOIState : uint
    {
        b2_toiStateUnknown,
        b2_toiStateFailed,
        b2_toiStateOverlapped,
        b2_toiStateHit,
        b2_toiStateSeparated,
    }

    public partial struct b2TOIOutput
    {
        public b2TOIState state;

        public float fraction;
    }

    public partial struct b2ManifoldPoint
    {
        public b2Vec2 point;

        public b2Vec2 anchorA;

        public b2Vec2 anchorB;

        public float separation;

        public float normalImpulse;

        public float tangentImpulse;

        public float totalNormalImpulse;

        public float normalVelocity;

        [NativeTypeName("uint16_t")]
        public ushort id;

        [NativeTypeName("bool")]
        public byte persisted;
    }

    public partial struct b2Manifold
    {
        public b2Vec2 normal;

        public float rollingImpulse;

        [NativeTypeName("b2ManifoldPoint[2]")]
        public _points_e__FixedBuffer points;

        public int pointCount;

        [InlineArray(2)]
        public partial struct _points_e__FixedBuffer
        {
            public b2ManifoldPoint e0;
        }
    }

    public unsafe partial struct b2DynamicTree
    {
        [NativeTypeName("struct b2TreeNode *")]
        public b2TreeNode* nodes;

        public int root;

        public int nodeCount;

        public int nodeCapacity;

        public int freeList;

        public int proxyCount;

        public int* leafIndices;

        public b2AABB* leafBoxes;

        public b2Vec2* leafCenters;

        public int* binIndices;

        public int rebuildCapacity;

        public partial struct b2TreeNode
        {
        }
    }

    public partial struct b2TreeStats
    {
        public int nodeVisits;

        public int leafVisits;
    }

    public partial struct b2PlaneResult
    {
        public b2Plane plane;

        public b2Vec2 point;

        [NativeTypeName("bool")]
        public byte hit;
    }

    public partial struct b2CollisionPlane
    {
        public b2Plane plane;

        public float pushLimit;

        public float push;

        [NativeTypeName("bool")]
        public byte clipVelocity;
    }

    public partial struct b2PlaneSolverResult
    {
        public b2Vec2 translation;

        public int iterationCount;
    }

    public partial struct b2WorldId
    {
        [NativeTypeName("uint16_t")]
        public ushort index1;

        [NativeTypeName("uint16_t")]
        public ushort generation;
    }

    public partial struct b2BodyId
    {
        [NativeTypeName("int32_t")]
        public int index1;

        [NativeTypeName("uint16_t")]
        public ushort world0;

        [NativeTypeName("uint16_t")]
        public ushort generation;
    }

    public partial struct b2ShapeId
    {
        [NativeTypeName("int32_t")]
        public int index1;

        [NativeTypeName("uint16_t")]
        public ushort world0;

        [NativeTypeName("uint16_t")]
        public ushort generation;
    }

    public partial struct b2ChainId
    {
        [NativeTypeName("int32_t")]
        public int index1;

        [NativeTypeName("uint16_t")]
        public ushort world0;

        [NativeTypeName("uint16_t")]
        public ushort generation;
    }

    public partial struct b2JointId
    {
        [NativeTypeName("int32_t")]
        public int index1;

        [NativeTypeName("uint16_t")]
        public ushort world0;

        [NativeTypeName("uint16_t")]
        public ushort generation;
    }

    public partial struct b2RayResult
    {
        public b2ShapeId shapeId;

        public b2Vec2 point;

        public b2Vec2 normal;

        public float fraction;

        public int nodeVisits;

        public int leafVisits;

        [NativeTypeName("bool")]
        public byte hit;
    }

    public unsafe partial struct b2WorldDef
    {
        public b2Vec2 gravity;

        public float restitutionThreshold;

        public float hitEventThreshold;

        public float contactHertz;

        public float contactDampingRatio;

        public float maxContactPushSpeed;

        public float maximumLinearSpeed;

        [NativeTypeName("b2FrictionCallback *")]
        public delegate* unmanaged[Cdecl]<float, int, float, int, float> frictionCallback;

        [NativeTypeName("b2RestitutionCallback *")]
        public delegate* unmanaged[Cdecl]<float, int, float, int, float> restitutionCallback;

        [NativeTypeName("bool")]
        public byte enableSleep;

        [NativeTypeName("bool")]
        public byte enableContinuous;

        public int workerCount;

        [NativeTypeName("b2EnqueueTaskCallback *")]
        public delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<int, int, uint, void*, void>, int, int, void*, void*, void*> enqueueTask;

        [NativeTypeName("b2FinishTaskCallback *")]
        public delegate* unmanaged[Cdecl]<void*, void*, void> finishTask;

        public void* userTaskContext;

        public void* userData;

        public int internalValue;
    }

    [NativeTypeName("unsigned int")]
    public enum b2BodyType : uint
    {
        b2_staticBody = 0,
        b2_kinematicBody = 1,
        b2_dynamicBody = 2,
        b2_bodyTypeCount,
    }

    public unsafe partial struct b2BodyDef
    {
        public b2BodyType type;

        public b2Vec2 position;

        public b2Rot rotation;

        public b2Vec2 linearVelocity;

        public float angularVelocity;

        public float linearDamping;

        public float angularDamping;

        public float gravityScale;

        public float sleepThreshold;

        [NativeTypeName("const char *")]
        public sbyte* name;

        public void* userData;

        [NativeTypeName("bool")]
        public byte enableSleep;

        [NativeTypeName("bool")]
        public byte isAwake;

        [NativeTypeName("bool")]
        public byte fixedRotation;

        [NativeTypeName("bool")]
        public byte isBullet;

        [NativeTypeName("bool")]
        public byte isEnabled;

        [NativeTypeName("bool")]
        public byte allowFastRotation;

        public int internalValue;
    }

    public partial struct b2Filter
    {
        [NativeTypeName("uint64_t")]
        public ulong categoryBits;

        [NativeTypeName("uint64_t")]
        public ulong maskBits;

        public int groupIndex;
    }

    public partial struct b2QueryFilter
    {
        [NativeTypeName("uint64_t")]
        public ulong categoryBits;

        [NativeTypeName("uint64_t")]
        public ulong maskBits;
    }

    [NativeTypeName("unsigned int")]
    public enum b2ShapeType : uint
    {
        b2_circleShape,
        b2_capsuleShape,
        b2_segmentShape,
        b2_polygonShape,
        b2_chainSegmentShape,
        b2_shapeTypeCount,
    }

    public partial struct b2SurfaceMaterial
    {
        public float friction;

        public float restitution;

        public float rollingResistance;

        public float tangentSpeed;

        public int userMaterialId;

        [NativeTypeName("uint32_t")]
        public uint customColor;
    }

    public unsafe partial struct b2ShapeDef
    {
        public void* userData;

        public b2SurfaceMaterial material;

        public float density;

        public b2Filter filter;

        [NativeTypeName("bool")]
        public byte isSensor;

        [NativeTypeName("bool")]
        public byte enableSensorEvents;

        [NativeTypeName("bool")]
        public byte enableContactEvents;

        [NativeTypeName("bool")]
        public byte enableHitEvents;

        [NativeTypeName("bool")]
        public byte enablePreSolveEvents;

        [NativeTypeName("bool")]
        public byte invokeContactCreation;

        [NativeTypeName("bool")]
        public byte updateBodyMass;

        public int internalValue;
    }

    public unsafe partial struct b2ChainDef
    {
        public void* userData;

        [NativeTypeName("const b2Vec2 *")]
        public b2Vec2* points;

        public int count;

        [NativeTypeName("const b2SurfaceMaterial *")]
        public b2SurfaceMaterial* materials;

        public int materialCount;

        public b2Filter filter;

        [NativeTypeName("bool")]
        public byte isLoop;

        [NativeTypeName("bool")]
        public byte enableSensorEvents;

        public int internalValue;
    }

    public partial struct b2Profile
    {
        public float step;

        public float pairs;

        public float collide;

        public float solve;

        public float mergeIslands;

        public float prepareStages;

        public float solveConstraints;

        public float prepareConstraints;

        public float integrateVelocities;

        public float warmStart;

        public float solveImpulses;

        public float integratePositions;

        public float relaxImpulses;

        public float applyRestitution;

        public float storeImpulses;

        public float splitIslands;

        public float transforms;

        public float hitEvents;

        public float refit;

        public float bullets;

        public float sleepIslands;

        public float sensors;
    }

    public partial struct b2Counters
    {
        public int bodyCount;

        public int shapeCount;

        public int contactCount;

        public int jointCount;

        public int islandCount;

        public int stackUsed;

        public int staticTreeHeight;

        public int treeHeight;

        public int byteCount;

        public int taskCount;

        [NativeTypeName("int[12]")]
        public _colorCounts_e__FixedBuffer colorCounts;

        [InlineArray(12)]
        public partial struct _colorCounts_e__FixedBuffer
        {
            public int e0;
        }
    }

    [NativeTypeName("unsigned int")]
    public enum b2JointType : uint
    {
        b2_distanceJoint,
        b2_filterJoint,
        b2_motorJoint,
        b2_mouseJoint,
        b2_prismaticJoint,
        b2_revoluteJoint,
        b2_weldJoint,
        b2_wheelJoint,
    }

    public unsafe partial struct b2DistanceJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 localAnchorA;

        public b2Vec2 localAnchorB;

        public float length;

        [NativeTypeName("bool")]
        public byte enableSpring;

        public float hertz;

        public float dampingRatio;

        [NativeTypeName("bool")]
        public byte enableLimit;

        public float minLength;

        public float maxLength;

        [NativeTypeName("bool")]
        public byte enableMotor;

        public float maxMotorForce;

        public float motorSpeed;

        [NativeTypeName("bool")]
        public byte collideConnected;

        public void* userData;

        public int internalValue;
    }

    public unsafe partial struct b2MotorJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 linearOffset;

        public float angularOffset;

        public float maxForce;

        public float maxTorque;

        public float correctionFactor;

        [NativeTypeName("bool")]
        public byte collideConnected;

        public void* userData;

        public int internalValue;
    }

    public unsafe partial struct b2MouseJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 target;

        public float hertz;

        public float dampingRatio;

        public float maxForce;

        [NativeTypeName("bool")]
        public byte collideConnected;

        public void* userData;

        public int internalValue;
    }

    public unsafe partial struct b2FilterJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public void* userData;

        public int internalValue;
    }

    public unsafe partial struct b2PrismaticJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 localAnchorA;

        public b2Vec2 localAnchorB;

        public b2Vec2 localAxisA;

        public float referenceAngle;

        public float targetTranslation;

        [NativeTypeName("bool")]
        public byte enableSpring;

        public float hertz;

        public float dampingRatio;

        [NativeTypeName("bool")]
        public byte enableLimit;

        public float lowerTranslation;

        public float upperTranslation;

        [NativeTypeName("bool")]
        public byte enableMotor;

        public float maxMotorForce;

        public float motorSpeed;

        [NativeTypeName("bool")]
        public byte collideConnected;

        public void* userData;

        public int internalValue;
    }

    public unsafe partial struct b2RevoluteJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 localAnchorA;

        public b2Vec2 localAnchorB;

        public float referenceAngle;

        public float targetAngle;

        [NativeTypeName("bool")]
        public byte enableSpring;

        public float hertz;

        public float dampingRatio;

        [NativeTypeName("bool")]
        public byte enableLimit;

        public float lowerAngle;

        public float upperAngle;

        [NativeTypeName("bool")]
        public byte enableMotor;

        public float maxMotorTorque;

        public float motorSpeed;

        public float drawSize;

        [NativeTypeName("bool")]
        public byte collideConnected;

        public void* userData;

        public int internalValue;
    }

    public unsafe partial struct b2WeldJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 localAnchorA;

        public b2Vec2 localAnchorB;

        public float referenceAngle;

        public float linearHertz;

        public float angularHertz;

        public float linearDampingRatio;

        public float angularDampingRatio;

        [NativeTypeName("bool")]
        public byte collideConnected;

        public void* userData;

        public int internalValue;
    }

    public unsafe partial struct b2WheelJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 localAnchorA;

        public b2Vec2 localAnchorB;

        public b2Vec2 localAxisA;

        [NativeTypeName("bool")]
        public byte enableSpring;

        public float hertz;

        public float dampingRatio;

        [NativeTypeName("bool")]
        public byte enableLimit;

        public float lowerTranslation;

        public float upperTranslation;

        [NativeTypeName("bool")]
        public byte enableMotor;

        public float maxMotorTorque;

        public float motorSpeed;

        [NativeTypeName("bool")]
        public byte collideConnected;

        public void* userData;

        public int internalValue;
    }

    public partial struct b2ExplosionDef
    {
        [NativeTypeName("uint64_t")]
        public ulong maskBits;

        public b2Vec2 position;

        public float radius;

        public float falloff;

        public float impulsePerLength;
    }

    public partial struct b2SensorBeginTouchEvent
    {
        public b2ShapeId sensorShapeId;

        public b2ShapeId visitorShapeId;
    }

    public partial struct b2SensorEndTouchEvent
    {
        public b2ShapeId sensorShapeId;

        public b2ShapeId visitorShapeId;
    }

    public unsafe partial struct b2SensorEvents
    {
        public b2SensorBeginTouchEvent* beginEvents;

        public b2SensorEndTouchEvent* endEvents;

        public int beginCount;

        public int endCount;
    }

    public partial struct b2ContactBeginTouchEvent
    {
        public b2ShapeId shapeIdA;

        public b2ShapeId shapeIdB;

        public b2Manifold manifold;
    }

    public partial struct b2ContactEndTouchEvent
    {
        public b2ShapeId shapeIdA;

        public b2ShapeId shapeIdB;
    }

    public partial struct b2ContactHitEvent
    {
        public b2ShapeId shapeIdA;

        public b2ShapeId shapeIdB;

        public b2Vec2 point;

        public b2Vec2 normal;

        public float approachSpeed;
    }

    public unsafe partial struct b2ContactEvents
    {
        public b2ContactBeginTouchEvent* beginEvents;

        public b2ContactEndTouchEvent* endEvents;

        public b2ContactHitEvent* hitEvents;

        public int beginCount;

        public int endCount;

        public int hitCount;
    }

    public unsafe partial struct b2BodyMoveEvent
    {
        public b2Transform transform;

        public b2BodyId bodyId;

        public void* userData;

        [NativeTypeName("bool")]
        public byte fellAsleep;
    }

    public unsafe partial struct b2BodyEvents
    {
        public b2BodyMoveEvent* moveEvents;

        public int moveCount;
    }

    public partial struct b2ContactData
    {
        public b2ShapeId shapeIdA;

        public b2ShapeId shapeIdB;

        public b2Manifold manifold;
    }

    [NativeTypeName("unsigned int")]
    public enum b2HexColor : uint
    {
        b2_colorAliceBlue = 0xF0F8FF,
        b2_colorAntiqueWhite = 0xFAEBD7,
        b2_colorAqua = 0x00FFFF,
        b2_colorAquamarine = 0x7FFFD4,
        b2_colorAzure = 0xF0FFFF,
        b2_colorBeige = 0xF5F5DC,
        b2_colorBisque = 0xFFE4C4,
        b2_colorBlack = 0x000000,
        b2_colorBlanchedAlmond = 0xFFEBCD,
        b2_colorBlue = 0x0000FF,
        b2_colorBlueViolet = 0x8A2BE2,
        b2_colorBrown = 0xA52A2A,
        b2_colorBurlywood = 0xDEB887,
        b2_colorCadetBlue = 0x5F9EA0,
        b2_colorChartreuse = 0x7FFF00,
        b2_colorChocolate = 0xD2691E,
        b2_colorCoral = 0xFF7F50,
        b2_colorCornflowerBlue = 0x6495ED,
        b2_colorCornsilk = 0xFFF8DC,
        b2_colorCrimson = 0xDC143C,
        b2_colorCyan = 0x00FFFF,
        b2_colorDarkBlue = 0x00008B,
        b2_colorDarkCyan = 0x008B8B,
        b2_colorDarkGoldenRod = 0xB8860B,
        b2_colorDarkGray = 0xA9A9A9,
        b2_colorDarkGreen = 0x006400,
        b2_colorDarkKhaki = 0xBDB76B,
        b2_colorDarkMagenta = 0x8B008B,
        b2_colorDarkOliveGreen = 0x556B2F,
        b2_colorDarkOrange = 0xFF8C00,
        b2_colorDarkOrchid = 0x9932CC,
        b2_colorDarkRed = 0x8B0000,
        b2_colorDarkSalmon = 0xE9967A,
        b2_colorDarkSeaGreen = 0x8FBC8F,
        b2_colorDarkSlateBlue = 0x483D8B,
        b2_colorDarkSlateGray = 0x2F4F4F,
        b2_colorDarkTurquoise = 0x00CED1,
        b2_colorDarkViolet = 0x9400D3,
        b2_colorDeepPink = 0xFF1493,
        b2_colorDeepSkyBlue = 0x00BFFF,
        b2_colorDimGray = 0x696969,
        b2_colorDodgerBlue = 0x1E90FF,
        b2_colorFireBrick = 0xB22222,
        b2_colorFloralWhite = 0xFFFAF0,
        b2_colorForestGreen = 0x228B22,
        b2_colorFuchsia = 0xFF00FF,
        b2_colorGainsboro = 0xDCDCDC,
        b2_colorGhostWhite = 0xF8F8FF,
        b2_colorGold = 0xFFD700,
        b2_colorGoldenRod = 0xDAA520,
        b2_colorGray = 0x808080,
        b2_colorGreen = 0x008000,
        b2_colorGreenYellow = 0xADFF2F,
        b2_colorHoneyDew = 0xF0FFF0,
        b2_colorHotPink = 0xFF69B4,
        b2_colorIndianRed = 0xCD5C5C,
        b2_colorIndigo = 0x4B0082,
        b2_colorIvory = 0xFFFFF0,
        b2_colorKhaki = 0xF0E68C,
        b2_colorLavender = 0xE6E6FA,
        b2_colorLavenderBlush = 0xFFF0F5,
        b2_colorLawnGreen = 0x7CFC00,
        b2_colorLemonChiffon = 0xFFFACD,
        b2_colorLightBlue = 0xADD8E6,
        b2_colorLightCoral = 0xF08080,
        b2_colorLightCyan = 0xE0FFFF,
        b2_colorLightGoldenRodYellow = 0xFAFAD2,
        b2_colorLightGray = 0xD3D3D3,
        b2_colorLightGreen = 0x90EE90,
        b2_colorLightPink = 0xFFB6C1,
        b2_colorLightSalmon = 0xFFA07A,
        b2_colorLightSeaGreen = 0x20B2AA,
        b2_colorLightSkyBlue = 0x87CEFA,
        b2_colorLightSlateGray = 0x778899,
        b2_colorLightSteelBlue = 0xB0C4DE,
        b2_colorLightYellow = 0xFFFFE0,
        b2_colorLime = 0x00FF00,
        b2_colorLimeGreen = 0x32CD32,
        b2_colorLinen = 0xFAF0E6,
        b2_colorMagenta = 0xFF00FF,
        b2_colorMaroon = 0x800000,
        b2_colorMediumAquaMarine = 0x66CDAA,
        b2_colorMediumBlue = 0x0000CD,
        b2_colorMediumOrchid = 0xBA55D3,
        b2_colorMediumPurple = 0x9370DB,
        b2_colorMediumSeaGreen = 0x3CB371,
        b2_colorMediumSlateBlue = 0x7B68EE,
        b2_colorMediumSpringGreen = 0x00FA9A,
        b2_colorMediumTurquoise = 0x48D1CC,
        b2_colorMediumVioletRed = 0xC71585,
        b2_colorMidnightBlue = 0x191970,
        b2_colorMintCream = 0xF5FFFA,
        b2_colorMistyRose = 0xFFE4E1,
        b2_colorMoccasin = 0xFFE4B5,
        b2_colorNavajoWhite = 0xFFDEAD,
        b2_colorNavy = 0x000080,
        b2_colorOldLace = 0xFDF5E6,
        b2_colorOlive = 0x808000,
        b2_colorOliveDrab = 0x6B8E23,
        b2_colorOrange = 0xFFA500,
        b2_colorOrangeRed = 0xFF4500,
        b2_colorOrchid = 0xDA70D6,
        b2_colorPaleGoldenRod = 0xEEE8AA,
        b2_colorPaleGreen = 0x98FB98,
        b2_colorPaleTurquoise = 0xAFEEEE,
        b2_colorPaleVioletRed = 0xDB7093,
        b2_colorPapayaWhip = 0xFFEFD5,
        b2_colorPeachPuff = 0xFFDAB9,
        b2_colorPeru = 0xCD853F,
        b2_colorPink = 0xFFC0CB,
        b2_colorPlum = 0xDDA0DD,
        b2_colorPowderBlue = 0xB0E0E6,
        b2_colorPurple = 0x800080,
        b2_colorRebeccaPurple = 0x663399,
        b2_colorRed = 0xFF0000,
        b2_colorRosyBrown = 0xBC8F8F,
        b2_colorRoyalBlue = 0x4169E1,
        b2_colorSaddleBrown = 0x8B4513,
        b2_colorSalmon = 0xFA8072,
        b2_colorSandyBrown = 0xF4A460,
        b2_colorSeaGreen = 0x2E8B57,
        b2_colorSeaShell = 0xFFF5EE,
        b2_colorSienna = 0xA0522D,
        b2_colorSilver = 0xC0C0C0,
        b2_colorSkyBlue = 0x87CEEB,
        b2_colorSlateBlue = 0x6A5ACD,
        b2_colorSlateGray = 0x708090,
        b2_colorSnow = 0xFFFAFA,
        b2_colorSpringGreen = 0x00FF7F,
        b2_colorSteelBlue = 0x4682B4,
        b2_colorTan = 0xD2B48C,
        b2_colorTeal = 0x008080,
        b2_colorThistle = 0xD8BFD8,
        b2_colorTomato = 0xFF6347,
        b2_colorTurquoise = 0x40E0D0,
        b2_colorViolet = 0xEE82EE,
        b2_colorWheat = 0xF5DEB3,
        b2_colorWhite = 0xFFFFFF,
        b2_colorWhiteSmoke = 0xF5F5F5,
        b2_colorYellow = 0xFFFF00,
        b2_colorYellowGreen = 0x9ACD32,
        b2_colorBox2DRed = 0xDC3132,
        b2_colorBox2DBlue = 0x30AEBF,
        b2_colorBox2DGreen = 0x8CC924,
        b2_colorBox2DYellow = 0xFFEE8C,
    }

    public unsafe partial struct b2DebugDraw
    {
        [NativeTypeName("void (*)(const b2Vec2 *, int, b2HexColor, void *)")]
        public delegate* unmanaged[Cdecl]<b2Vec2*, int, b2HexColor, void*, void> DrawPolygonFcn;

        [NativeTypeName("void (*)(b2Transform, const b2Vec2 *, int, float, b2HexColor, void *)")]
        public delegate* unmanaged[Cdecl]<b2Transform, b2Vec2*, int, float, b2HexColor, void*, void> DrawSolidPolygonFcn;

        [NativeTypeName("void (*)(b2Vec2, float, b2HexColor, void *)")]
        public delegate* unmanaged[Cdecl]<b2Vec2, float, b2HexColor, void*, void> DrawCircleFcn;

        [NativeTypeName("void (*)(b2Transform, float, b2HexColor, void *)")]
        public delegate* unmanaged[Cdecl]<b2Transform, float, b2HexColor, void*, void> DrawSolidCircleFcn;

        [NativeTypeName("void (*)(b2Vec2, b2Vec2, float, b2HexColor, void *)")]
        public delegate* unmanaged[Cdecl]<b2Vec2, b2Vec2, float, b2HexColor, void*, void> DrawSolidCapsuleFcn;

        [NativeTypeName("void (*)(b2Vec2, b2Vec2, b2HexColor, void *)")]
        public delegate* unmanaged[Cdecl]<b2Vec2, b2Vec2, b2HexColor, void*, void> DrawSegmentFcn;

        [NativeTypeName("void (*)(b2Transform, void *)")]
        public delegate* unmanaged[Cdecl]<b2Transform, void*, void> DrawTransformFcn;

        [NativeTypeName("void (*)(b2Vec2, float, b2HexColor, void *)")]
        public delegate* unmanaged[Cdecl]<b2Vec2, float, b2HexColor, void*, void> DrawPointFcn;

        [NativeTypeName("void (*)(b2Vec2, const char *, b2HexColor, void *)")]
        public delegate* unmanaged[Cdecl]<b2Vec2, sbyte*, b2HexColor, void*, void> DrawStringFcn;

        public b2AABB drawingBounds;

        [NativeTypeName("bool")]
        public byte useDrawingBounds;

        [NativeTypeName("bool")]
        public byte drawShapes;

        [NativeTypeName("bool")]
        public byte drawJoints;

        [NativeTypeName("bool")]
        public byte drawJointExtras;

        [NativeTypeName("bool")]
        public byte drawBounds;

        [NativeTypeName("bool")]
        public byte drawMass;

        [NativeTypeName("bool")]
        public byte drawBodyNames;

        [NativeTypeName("bool")]
        public byte drawContacts;

        [NativeTypeName("bool")]
        public byte drawGraphColors;

        [NativeTypeName("bool")]
        public byte drawContactNormals;

        [NativeTypeName("bool")]
        public byte drawContactImpulses;

        [NativeTypeName("bool")]
        public byte drawContactFeatures;

        [NativeTypeName("bool")]
        public byte drawFrictionImpulses;

        [NativeTypeName("bool")]
        public byte drawIslands;

        public void* context;
    }

    public static unsafe partial class Box2D
    {
        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2SetAllocator([NativeTypeName("b2AllocFcn *")] delegate* unmanaged[Cdecl]<uint, int, void*> allocFcn, [NativeTypeName("b2FreeFcn *")] delegate* unmanaged[Cdecl]<void*, void> freeFcn);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2GetByteCount();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2SetAssertFcn([NativeTypeName("b2AssertFcn *")] delegate* unmanaged[Cdecl]<sbyte*, sbyte*, int, int> assertFcn);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Version b2GetVersion();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2InternalAssertFcn([NativeTypeName("const char *")] sbyte* condition, [NativeTypeName("const char *")] sbyte* fileName, int lineNumber);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong b2GetTicks();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2GetMilliseconds([NativeTypeName("uint64_t")] ulong ticks);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2GetMillisecondsAndReset([NativeTypeName("uint64_t *")] ulong* ticks);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Yield();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint b2Hash([NativeTypeName("uint32_t")] uint hash, [NativeTypeName("const uint8_t *")] byte* data, int count);

        [NativeTypeName("const b2Vec2")]
        public static readonly b2Vec2 b2Vec2_zero = new b2Vec2
        {
            x = 0.0f,
            y = 0.0f,
        };

        [NativeTypeName("const b2Rot")]
        public static readonly b2Rot b2Rot_identity = new b2Rot
        {
            c = 1.0f,
            s = 0.0f,
        };

        [NativeTypeName("const b2Transform")]
        public static readonly b2Transform b2Transform_identity = new b2Transform
        {
            p = new b2Vec2
            {
                x = 0.0f,
                y = 0.0f,
            },
            q = new b2Rot
            {
                c = 1.0f,
                s = 0.0f,
            },
        };

        [NativeTypeName("const b2Mat22")]
        public static readonly b2Mat22 b2Mat22_zero = new b2Mat22
        {
            cx = new b2Vec2
            {
                x = 0.0f,
                y = 0.0f,
            },
            cy = new b2Vec2
            {
                x = 0.0f,
                y = 0.0f,
            },
        };

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2IsValidFloat(float a);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2IsValidVec2(b2Vec2 v);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2IsValidRotation(b2Rot q);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2IsValidAABB(b2AABB aabb);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2IsValidPlane(b2Plane a);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Atan2(float y, float x);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CosSin b2ComputeCosSin(float radians);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Rot b2ComputeRotationBetweenUnitVectors(b2Vec2 v1, b2Vec2 v2);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void __builtin_trap();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2SetLengthUnitsPerMeter(float lengthUnits);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2GetLengthUnitsPerMeter();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2IsValidRay([NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakePolygon([NativeTypeName("const b2Hull *")] b2Hull* hull, float radius);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeOffsetPolygon([NativeTypeName("const b2Hull *")] b2Hull* hull, b2Vec2 position, b2Rot rotation);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeOffsetRoundedPolygon([NativeTypeName("const b2Hull *")] b2Hull* hull, b2Vec2 position, b2Rot rotation, float radius);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeSquare(float halfWidth);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeBox(float halfWidth, float halfHeight);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeRoundedBox(float halfWidth, float halfHeight, float radius);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeOffsetBox(float halfWidth, float halfHeight, b2Vec2 center, b2Rot rotation);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeOffsetRoundedBox(float halfWidth, float halfHeight, b2Vec2 center, b2Rot rotation, float radius);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2TransformPolygon(b2Transform transform, [NativeTypeName("const b2Polygon *")] b2Polygon* polygon);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MassData b2ComputeCircleMass([NativeTypeName("const b2Circle *")] b2Circle* shape, float density);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MassData b2ComputeCapsuleMass([NativeTypeName("const b2Capsule *")] b2Capsule* shape, float density);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MassData b2ComputePolygonMass([NativeTypeName("const b2Polygon *")] b2Polygon* shape, float density);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2ComputeCircleAABB([NativeTypeName("const b2Circle *")] b2Circle* shape, b2Transform transform);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2ComputeCapsuleAABB([NativeTypeName("const b2Capsule *")] b2Capsule* shape, b2Transform transform);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2ComputePolygonAABB([NativeTypeName("const b2Polygon *")] b2Polygon* shape, b2Transform transform);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2ComputeSegmentAABB([NativeTypeName("const b2Segment *")] b2Segment* shape, b2Transform transform);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2PointInCircle(b2Vec2 point, [NativeTypeName("const b2Circle *")] b2Circle* shape);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2PointInCapsule(b2Vec2 point, [NativeTypeName("const b2Capsule *")] b2Capsule* shape);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2PointInPolygon(b2Vec2 point, [NativeTypeName("const b2Polygon *")] b2Polygon* shape);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2RayCastCircle([NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input, [NativeTypeName("const b2Circle *")] b2Circle* shape);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2RayCastCapsule([NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input, [NativeTypeName("const b2Capsule *")] b2Capsule* shape);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2RayCastSegment([NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input, [NativeTypeName("const b2Segment *")] b2Segment* shape, [NativeTypeName("bool")] byte oneSided);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2RayCastPolygon([NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input, [NativeTypeName("const b2Polygon *")] b2Polygon* shape);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2ShapeCastCircle([NativeTypeName("const b2ShapeCastInput *")] b2ShapeCastInput* input, [NativeTypeName("const b2Circle *")] b2Circle* shape);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2ShapeCastCapsule([NativeTypeName("const b2ShapeCastInput *")] b2ShapeCastInput* input, [NativeTypeName("const b2Capsule *")] b2Capsule* shape);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2ShapeCastSegment([NativeTypeName("const b2ShapeCastInput *")] b2ShapeCastInput* input, [NativeTypeName("const b2Segment *")] b2Segment* shape);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2ShapeCastPolygon([NativeTypeName("const b2ShapeCastInput *")] b2ShapeCastInput* input, [NativeTypeName("const b2Polygon *")] b2Polygon* shape);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Hull b2ComputeHull([NativeTypeName("const b2Vec2 *")] b2Vec2* points, int count);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2ValidateHull([NativeTypeName("const b2Hull *")] b2Hull* hull);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2SegmentDistanceResult b2SegmentDistance(b2Vec2 p1, b2Vec2 q1, b2Vec2 p2, b2Vec2 q2);

        [NativeTypeName("const b2SimplexCache")]
        public static readonly b2SimplexCache b2_emptySimplexCache = new b2SimplexCache
        {
        };

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2DistanceOutput b2ShapeDistance([NativeTypeName("const b2DistanceInput *")] b2DistanceInput* input, b2SimplexCache* cache, b2Simplex* simplexes, int simplexCapacity);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2ShapeCast([NativeTypeName("const b2ShapeCastPairInput *")] b2ShapeCastPairInput* input);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeProxy b2MakeProxy([NativeTypeName("const b2Vec2 *")] b2Vec2* points, int count, float radius);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeProxy b2MakeOffsetProxy([NativeTypeName("const b2Vec2 *")] b2Vec2* points, int count, float radius, b2Vec2 position, b2Rot rotation);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Transform b2GetSweepTransform([NativeTypeName("const b2Sweep *")] b2Sweep* sweep, float time);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2TOIOutput b2TimeOfImpact([NativeTypeName("const b2TOIInput *")] b2TOIInput* input);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideCircles([NativeTypeName("const b2Circle *")] b2Circle* circleA, b2Transform xfA, [NativeTypeName("const b2Circle *")] b2Circle* circleB, b2Transform xfB);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideCapsuleAndCircle([NativeTypeName("const b2Capsule *")] b2Capsule* capsuleA, b2Transform xfA, [NativeTypeName("const b2Circle *")] b2Circle* circleB, b2Transform xfB);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideSegmentAndCircle([NativeTypeName("const b2Segment *")] b2Segment* segmentA, b2Transform xfA, [NativeTypeName("const b2Circle *")] b2Circle* circleB, b2Transform xfB);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollidePolygonAndCircle([NativeTypeName("const b2Polygon *")] b2Polygon* polygonA, b2Transform xfA, [NativeTypeName("const b2Circle *")] b2Circle* circleB, b2Transform xfB);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideCapsules([NativeTypeName("const b2Capsule *")] b2Capsule* capsuleA, b2Transform xfA, [NativeTypeName("const b2Capsule *")] b2Capsule* capsuleB, b2Transform xfB);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideSegmentAndCapsule([NativeTypeName("const b2Segment *")] b2Segment* segmentA, b2Transform xfA, [NativeTypeName("const b2Capsule *")] b2Capsule* capsuleB, b2Transform xfB);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollidePolygonAndCapsule([NativeTypeName("const b2Polygon *")] b2Polygon* polygonA, b2Transform xfA, [NativeTypeName("const b2Capsule *")] b2Capsule* capsuleB, b2Transform xfB);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollidePolygons([NativeTypeName("const b2Polygon *")] b2Polygon* polygonA, b2Transform xfA, [NativeTypeName("const b2Polygon *")] b2Polygon* polygonB, b2Transform xfB);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideSegmentAndPolygon([NativeTypeName("const b2Segment *")] b2Segment* segmentA, b2Transform xfA, [NativeTypeName("const b2Polygon *")] b2Polygon* polygonB, b2Transform xfB);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideChainSegmentAndCircle([NativeTypeName("const b2ChainSegment *")] b2ChainSegment* segmentA, b2Transform xfA, [NativeTypeName("const b2Circle *")] b2Circle* circleB, b2Transform xfB);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideChainSegmentAndCapsule([NativeTypeName("const b2ChainSegment *")] b2ChainSegment* segmentA, b2Transform xfA, [NativeTypeName("const b2Capsule *")] b2Capsule* capsuleB, b2Transform xfB, b2SimplexCache* cache);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideChainSegmentAndPolygon([NativeTypeName("const b2ChainSegment *")] b2ChainSegment* segmentA, b2Transform xfA, [NativeTypeName("const b2Polygon *")] b2Polygon* polygonB, b2Transform xfB, b2SimplexCache* cache);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2DynamicTree b2DynamicTree_Create();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_Destroy(b2DynamicTree* tree);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2DynamicTree_CreateProxy(b2DynamicTree* tree, b2AABB aabb, [NativeTypeName("uint64_t")] ulong categoryBits, [NativeTypeName("uint64_t")] ulong userData);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_DestroyProxy(b2DynamicTree* tree, int proxyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_MoveProxy(b2DynamicTree* tree, int proxyId, b2AABB aabb);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_EnlargeProxy(b2DynamicTree* tree, int proxyId, b2AABB aabb);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_SetCategoryBits(b2DynamicTree* tree, int proxyId, [NativeTypeName("uint64_t")] ulong categoryBits);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong b2DynamicTree_GetCategoryBits(b2DynamicTree* tree, int proxyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2TreeStats b2DynamicTree_Query([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree, b2AABB aabb, [NativeTypeName("uint64_t")] ulong maskBits, [NativeTypeName("b2TreeQueryCallbackFcn *")] delegate* unmanaged[Cdecl]<int, ulong, void*, byte> callback, void* context);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2TreeStats b2DynamicTree_RayCast([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree, [NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input, [NativeTypeName("uint64_t")] ulong maskBits, [NativeTypeName("b2TreeRayCastCallbackFcn *")] delegate* unmanaged[Cdecl]<b2RayCastInput*, int, ulong, void*, float> callback, void* context);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2TreeStats b2DynamicTree_ShapeCast([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree, [NativeTypeName("const b2ShapeCastInput *")] b2ShapeCastInput* input, [NativeTypeName("uint64_t")] ulong maskBits, [NativeTypeName("b2TreeShapeCastCallbackFcn *")] delegate* unmanaged[Cdecl]<b2ShapeCastInput*, int, ulong, void*, float> callback, void* context);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2DynamicTree_GetHeight([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DynamicTree_GetAreaRatio([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2DynamicTree_GetRootBounds([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2DynamicTree_GetProxyCount([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2DynamicTree_Rebuild(b2DynamicTree* tree, [NativeTypeName("bool")] byte fullBuild);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2DynamicTree_GetByteCount([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong b2DynamicTree_GetUserData([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree, int proxyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2DynamicTree_GetAABB([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree, int proxyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_Validate([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_ValidateNoEnlarged([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2PlaneSolverResult b2SolvePlanes(b2Vec2 targetDelta, b2CollisionPlane* planes, int count);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2ClipVector(b2Vec2 vector, [NativeTypeName("const b2CollisionPlane *")] b2CollisionPlane* planes, int count);

        [NativeTypeName("const b2WorldId")]
        public static readonly b2WorldId b2_nullWorldId = new b2WorldId
        {
        };

        [NativeTypeName("const b2BodyId")]
        public static readonly b2BodyId b2_nullBodyId = new b2BodyId
        {
        };

        [NativeTypeName("const b2ShapeId")]
        public static readonly b2ShapeId b2_nullShapeId = new b2ShapeId
        {
        };

        [NativeTypeName("const b2ChainId")]
        public static readonly b2ChainId b2_nullChainId = new b2ChainId
        {
        };

        [NativeTypeName("const b2JointId")]
        public static readonly b2JointId b2_nullJointId = new b2JointId
        {
        };

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WorldDef b2DefaultWorldDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyDef b2DefaultBodyDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Filter b2DefaultFilter();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2QueryFilter b2DefaultQueryFilter();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2SurfaceMaterial b2DefaultSurfaceMaterial();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeDef b2DefaultShapeDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ChainDef b2DefaultChainDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2DistanceJointDef b2DefaultDistanceJointDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MotorJointDef b2DefaultMotorJointDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MouseJointDef b2DefaultMouseJointDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2FilterJointDef b2DefaultFilterJointDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2PrismaticJointDef b2DefaultPrismaticJointDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2RevoluteJointDef b2DefaultRevoluteJointDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WeldJointDef b2DefaultWeldJointDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WheelJointDef b2DefaultWheelJointDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ExplosionDef b2DefaultExplosionDef();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2DebugDraw b2DefaultDebugDraw();

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WorldId b2CreateWorld([NativeTypeName("const b2WorldDef *")] b2WorldDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DestroyWorld(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2World_IsValid(b2WorldId id);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_Step(b2WorldId worldId, float timeStep, int subStepCount);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_Draw(b2WorldId worldId, b2DebugDraw* draw);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyEvents b2World_GetBodyEvents(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2SensorEvents b2World_GetSensorEvents(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ContactEvents b2World_GetContactEvents(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2TreeStats b2World_OverlapAABB(b2WorldId worldId, b2AABB aabb, b2QueryFilter filter, [NativeTypeName("b2OverlapResultFcn *")] delegate* unmanaged[Cdecl]<b2ShapeId, void*, byte> fcn, void* context);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2TreeStats b2World_OverlapShape(b2WorldId worldId, [NativeTypeName("const b2ShapeProxy *")] b2ShapeProxy* proxy, b2QueryFilter filter, [NativeTypeName("b2OverlapResultFcn *")] delegate* unmanaged[Cdecl]<b2ShapeId, void*, byte> fcn, void* context);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2TreeStats b2World_CastRay(b2WorldId worldId, b2Vec2 origin, b2Vec2 translation, b2QueryFilter filter, [NativeTypeName("b2CastResultFcn *")] delegate* unmanaged[Cdecl]<b2ShapeId, b2Vec2, b2Vec2, float, void*, float> fcn, void* context);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2RayResult b2World_CastRayClosest(b2WorldId worldId, b2Vec2 origin, b2Vec2 translation, b2QueryFilter filter);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2TreeStats b2World_CastShape(b2WorldId worldId, [NativeTypeName("const b2ShapeProxy *")] b2ShapeProxy* proxy, b2Vec2 translation, b2QueryFilter filter, [NativeTypeName("b2CastResultFcn *")] delegate* unmanaged[Cdecl]<b2ShapeId, b2Vec2, b2Vec2, float, void*, float> fcn, void* context);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2World_CastMover(b2WorldId worldId, [NativeTypeName("const b2Capsule *")] b2Capsule* mover, b2Vec2 translation, b2QueryFilter filter);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_CollideMover(b2WorldId worldId, [NativeTypeName("const b2Capsule *")] b2Capsule* mover, b2QueryFilter filter, [NativeTypeName("b2PlaneResultFcn *")] delegate* unmanaged[Cdecl]<b2ShapeId, b2PlaneResult*, void*, byte> fcn, void* context);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_EnableSleeping(b2WorldId worldId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2World_IsSleepingEnabled(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_EnableContinuous(b2WorldId worldId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2World_IsContinuousEnabled(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetRestitutionThreshold(b2WorldId worldId, float value);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2World_GetRestitutionThreshold(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetHitEventThreshold(b2WorldId worldId, float value);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2World_GetHitEventThreshold(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetCustomFilterCallback(b2WorldId worldId, [NativeTypeName("b2CustomFilterFcn *")] delegate* unmanaged[Cdecl]<b2ShapeId, b2ShapeId, void*, byte> fcn, void* context);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetPreSolveCallback(b2WorldId worldId, [NativeTypeName("b2PreSolveFcn *")] delegate* unmanaged[Cdecl]<b2ShapeId, b2ShapeId, b2Manifold*, void*, byte> fcn, void* context);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetGravity(b2WorldId worldId, b2Vec2 gravity);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2World_GetGravity(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_Explode(b2WorldId worldId, [NativeTypeName("const b2ExplosionDef *")] b2ExplosionDef* explosionDef);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetContactTuning(b2WorldId worldId, float hertz, float dampingRatio, float pushSpeed);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetMaximumLinearSpeed(b2WorldId worldId, float maximumLinearSpeed);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2World_GetMaximumLinearSpeed(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_EnableWarmStarting(b2WorldId worldId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2World_IsWarmStartingEnabled(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2World_GetAwakeBodyCount(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Profile b2World_GetProfile(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Counters b2World_GetCounters(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetUserData(b2WorldId worldId, void* userData);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* b2World_GetUserData(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetFrictionCallback(b2WorldId worldId, [NativeTypeName("b2FrictionCallback *")] delegate* unmanaged[Cdecl]<float, int, float, int, float> callback);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetRestitutionCallback(b2WorldId worldId, [NativeTypeName("b2RestitutionCallback *")] delegate* unmanaged[Cdecl]<float, int, float, int, float> callback);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_DumpMemoryStats(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_RebuildStaticTree(b2WorldId worldId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_EnableSpeculative(b2WorldId worldId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyId b2CreateBody(b2WorldId worldId, [NativeTypeName("const b2BodyDef *")] b2BodyDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DestroyBody(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Body_IsValid(b2BodyId id);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyType b2Body_GetType(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetType(b2BodyId bodyId, b2BodyType type);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetName(b2BodyId bodyId, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* b2Body_GetName(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetUserData(b2BodyId bodyId, void* userData);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* b2Body_GetUserData(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetPosition(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Rot b2Body_GetRotation(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Transform b2Body_GetTransform(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetTransform(b2BodyId bodyId, b2Vec2 position, b2Rot rotation);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetLocalPoint(b2BodyId bodyId, b2Vec2 worldPoint);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetWorldPoint(b2BodyId bodyId, b2Vec2 localPoint);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetLocalVector(b2BodyId bodyId, b2Vec2 worldVector);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetWorldVector(b2BodyId bodyId, b2Vec2 localVector);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetLinearVelocity(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetAngularVelocity(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetLinearVelocity(b2BodyId bodyId, b2Vec2 linearVelocity);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetAngularVelocity(b2BodyId bodyId, float angularVelocity);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetTargetTransform(b2BodyId bodyId, b2Transform target, float timeStep);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetLocalPointVelocity(b2BodyId bodyId, b2Vec2 localPoint);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetWorldPointVelocity(b2BodyId bodyId, b2Vec2 worldPoint);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyForce(b2BodyId bodyId, b2Vec2 force, b2Vec2 point, [NativeTypeName("bool")] byte wake);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyForceToCenter(b2BodyId bodyId, b2Vec2 force, [NativeTypeName("bool")] byte wake);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyTorque(b2BodyId bodyId, float torque, [NativeTypeName("bool")] byte wake);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyLinearImpulse(b2BodyId bodyId, b2Vec2 impulse, b2Vec2 point, [NativeTypeName("bool")] byte wake);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyLinearImpulseToCenter(b2BodyId bodyId, b2Vec2 impulse, [NativeTypeName("bool")] byte wake);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyAngularImpulse(b2BodyId bodyId, float impulse, [NativeTypeName("bool")] byte wake);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetMass(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetRotationalInertia(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetLocalCenterOfMass(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetWorldCenterOfMass(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetMassData(b2BodyId bodyId, b2MassData massData);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MassData b2Body_GetMassData(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyMassFromShapes(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetLinearDamping(b2BodyId bodyId, float linearDamping);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetLinearDamping(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetAngularDamping(b2BodyId bodyId, float angularDamping);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetAngularDamping(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetGravityScale(b2BodyId bodyId, float gravityScale);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetGravityScale(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Body_IsAwake(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetAwake(b2BodyId bodyId, [NativeTypeName("bool")] byte awake);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_EnableSleep(b2BodyId bodyId, [NativeTypeName("bool")] byte enableSleep);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Body_IsSleepEnabled(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetSleepThreshold(b2BodyId bodyId, float sleepThreshold);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetSleepThreshold(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Body_IsEnabled(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_Disable(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_Enable(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetFixedRotation(b2BodyId bodyId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Body_IsFixedRotation(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetBullet(b2BodyId bodyId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Body_IsBullet(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_EnableContactEvents(b2BodyId bodyId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_EnableHitEvents(b2BodyId bodyId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WorldId b2Body_GetWorld(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetShapeCount(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetShapes(b2BodyId bodyId, b2ShapeId* shapeArray, int capacity);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetJointCount(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetJoints(b2BodyId bodyId, b2JointId* jointArray, int capacity);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetContactCapacity(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetContactData(b2BodyId bodyId, b2ContactData* contactData, int capacity);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2Body_ComputeAABB(b2BodyId bodyId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeId b2CreateCircleShape(b2BodyId bodyId, [NativeTypeName("const b2ShapeDef *")] b2ShapeDef* def, [NativeTypeName("const b2Circle *")] b2Circle* circle);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeId b2CreateSegmentShape(b2BodyId bodyId, [NativeTypeName("const b2ShapeDef *")] b2ShapeDef* def, [NativeTypeName("const b2Segment *")] b2Segment* segment);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeId b2CreateCapsuleShape(b2BodyId bodyId, [NativeTypeName("const b2ShapeDef *")] b2ShapeDef* def, [NativeTypeName("const b2Capsule *")] b2Capsule* capsule);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeId b2CreatePolygonShape(b2BodyId bodyId, [NativeTypeName("const b2ShapeDef *")] b2ShapeDef* def, [NativeTypeName("const b2Polygon *")] b2Polygon* polygon);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DestroyShape(b2ShapeId shapeId, [NativeTypeName("bool")] byte updateBodyMass);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Shape_IsValid(b2ShapeId id);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeType b2Shape_GetType(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyId b2Shape_GetBody(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WorldId b2Shape_GetWorld(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Shape_IsSensor(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetUserData(b2ShapeId shapeId, void* userData);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* b2Shape_GetUserData(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetDensity(b2ShapeId shapeId, float density, [NativeTypeName("bool")] byte updateBodyMass);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Shape_GetDensity(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetFriction(b2ShapeId shapeId, float friction);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Shape_GetFriction(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetRestitution(b2ShapeId shapeId, float restitution);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Shape_GetRestitution(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetMaterial(b2ShapeId shapeId, int material);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Shape_GetMaterial(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetSurfaceMaterial(b2ShapeId shapeId, b2SurfaceMaterial surfaceMaterial);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2SurfaceMaterial b2Shape_GetSurfaceMaterial(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Filter b2Shape_GetFilter(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetFilter(b2ShapeId shapeId, b2Filter filter);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_EnableSensorEvents(b2ShapeId shapeId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Shape_AreSensorEventsEnabled(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_EnableContactEvents(b2ShapeId shapeId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Shape_AreContactEventsEnabled(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_EnablePreSolveEvents(b2ShapeId shapeId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Shape_ArePreSolveEventsEnabled(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_EnableHitEvents(b2ShapeId shapeId, [NativeTypeName("bool")] byte flag);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Shape_AreHitEventsEnabled(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Shape_TestPoint(b2ShapeId shapeId, b2Vec2 point);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2Shape_RayCast(b2ShapeId shapeId, [NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Circle b2Shape_GetCircle(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Segment b2Shape_GetSegment(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ChainSegment b2Shape_GetChainSegment(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Capsule b2Shape_GetCapsule(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2Shape_GetPolygon(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetCircle(b2ShapeId shapeId, [NativeTypeName("const b2Circle *")] b2Circle* circle);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetCapsule(b2ShapeId shapeId, [NativeTypeName("const b2Capsule *")] b2Capsule* capsule);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetSegment(b2ShapeId shapeId, [NativeTypeName("const b2Segment *")] b2Segment* segment);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetPolygon(b2ShapeId shapeId, [NativeTypeName("const b2Polygon *")] b2Polygon* polygon);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ChainId b2Shape_GetParentChain(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Shape_GetContactCapacity(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Shape_GetContactData(b2ShapeId shapeId, b2ContactData* contactData, int capacity);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Shape_GetSensorCapacity(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Shape_GetSensorOverlaps(b2ShapeId shapeId, b2ShapeId* overlaps, int capacity);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2Shape_GetAABB(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MassData b2Shape_GetMassData(b2ShapeId shapeId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Shape_GetClosestPoint(b2ShapeId shapeId, b2Vec2 target);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ChainId b2CreateChain(b2BodyId bodyId, [NativeTypeName("const b2ChainDef *")] b2ChainDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DestroyChain(b2ChainId chainId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WorldId b2Chain_GetWorld(b2ChainId chainId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Chain_GetSegmentCount(b2ChainId chainId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Chain_GetSegments(b2ChainId chainId, b2ShapeId* segmentArray, int capacity);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Chain_SetFriction(b2ChainId chainId, float friction);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Chain_GetFriction(b2ChainId chainId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Chain_SetRestitution(b2ChainId chainId, float restitution);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Chain_GetRestitution(b2ChainId chainId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Chain_SetMaterial(b2ChainId chainId, int material);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Chain_GetMaterial(b2ChainId chainId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Chain_IsValid(b2ChainId id);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DestroyJoint(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Joint_IsValid(b2JointId id);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointType b2Joint_GetType(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyId b2Joint_GetBodyA(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyId b2Joint_GetBodyB(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WorldId b2Joint_GetWorld(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_SetLocalAnchorA(b2JointId jointId, b2Vec2 localAnchor);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Joint_GetLocalAnchorA(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_SetLocalAnchorB(b2JointId jointId, b2Vec2 localAnchor);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Joint_GetLocalAnchorB(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Joint_GetReferenceAngle(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_SetReferenceAngle(b2JointId jointId, float angleInRadians);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_SetLocalAxisA(b2JointId jointId, b2Vec2 localAxis);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Joint_GetLocalAxisA(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_SetCollideConnected(b2JointId jointId, [NativeTypeName("bool")] byte shouldCollide);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2Joint_GetCollideConnected(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_SetUserData(b2JointId jointId, void* userData);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* b2Joint_GetUserData(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_WakeBodies(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Joint_GetConstraintForce(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Joint_GetConstraintTorque(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Joint_GetLinearSeparation(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Joint_GetAngularSeparation(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_GetConstraintTuning(b2JointId jointId, float* hertz, float* dampingRatio);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_SetConstraintTuning(b2JointId jointId, float hertz, float dampingRatio);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateDistanceJoint(b2WorldId worldId, [NativeTypeName("const b2DistanceJointDef *")] b2DistanceJointDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetLength(b2JointId jointId, float length);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetLength(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_EnableSpring(b2JointId jointId, [NativeTypeName("bool")] byte enableSpring);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2DistanceJoint_IsSpringEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetSpringHertz(b2JointId jointId, float hertz);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetSpringDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetSpringHertz(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetSpringDampingRatio(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_EnableLimit(b2JointId jointId, [NativeTypeName("bool")] byte enableLimit);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2DistanceJoint_IsLimitEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetLengthRange(b2JointId jointId, float minLength, float maxLength);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetMinLength(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetMaxLength(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetCurrentLength(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_EnableMotor(b2JointId jointId, [NativeTypeName("bool")] byte enableMotor);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2DistanceJoint_IsMotorEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetMotorSpeed(b2JointId jointId, float motorSpeed);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetMotorSpeed(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetMaxMotorForce(b2JointId jointId, float force);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetMaxMotorForce(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetMotorForce(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateMotorJoint(b2WorldId worldId, [NativeTypeName("const b2MotorJointDef *")] b2MotorJointDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MotorJoint_SetLinearOffset(b2JointId jointId, b2Vec2 linearOffset);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2MotorJoint_GetLinearOffset(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MotorJoint_SetAngularOffset(b2JointId jointId, float angularOffset);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MotorJoint_GetAngularOffset(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MotorJoint_SetMaxForce(b2JointId jointId, float maxForce);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MotorJoint_GetMaxForce(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MotorJoint_SetMaxTorque(b2JointId jointId, float maxTorque);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MotorJoint_GetMaxTorque(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MotorJoint_SetCorrectionFactor(b2JointId jointId, float correctionFactor);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MotorJoint_GetCorrectionFactor(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateMouseJoint(b2WorldId worldId, [NativeTypeName("const b2MouseJointDef *")] b2MouseJointDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MouseJoint_SetTarget(b2JointId jointId, b2Vec2 target);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2MouseJoint_GetTarget(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MouseJoint_SetSpringHertz(b2JointId jointId, float hertz);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MouseJoint_GetSpringHertz(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MouseJoint_SetSpringDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MouseJoint_GetSpringDampingRatio(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MouseJoint_SetMaxForce(b2JointId jointId, float maxForce);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MouseJoint_GetMaxForce(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateFilterJoint(b2WorldId worldId, [NativeTypeName("const b2FilterJointDef *")] b2FilterJointDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreatePrismaticJoint(b2WorldId worldId, [NativeTypeName("const b2PrismaticJointDef *")] b2PrismaticJointDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_EnableSpring(b2JointId jointId, [NativeTypeName("bool")] byte enableSpring);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2PrismaticJoint_IsSpringEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetSpringHertz(b2JointId jointId, float hertz);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetSpringHertz(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetSpringDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetSpringDampingRatio(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetTargetTranslation(b2JointId jointId, float translation);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetTargetTranslation(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_EnableLimit(b2JointId jointId, [NativeTypeName("bool")] byte enableLimit);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2PrismaticJoint_IsLimitEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetLowerLimit(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetUpperLimit(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetLimits(b2JointId jointId, float lower, float upper);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_EnableMotor(b2JointId jointId, [NativeTypeName("bool")] byte enableMotor);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2PrismaticJoint_IsMotorEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetMotorSpeed(b2JointId jointId, float motorSpeed);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetMotorSpeed(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetMaxMotorForce(b2JointId jointId, float force);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetMaxMotorForce(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetMotorForce(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetTranslation(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetSpeed(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateRevoluteJoint(b2WorldId worldId, [NativeTypeName("const b2RevoluteJointDef *")] b2RevoluteJointDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_EnableSpring(b2JointId jointId, [NativeTypeName("bool")] byte enableSpring);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2RevoluteJoint_IsSpringEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetSpringHertz(b2JointId jointId, float hertz);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetSpringHertz(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetSpringDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetSpringDampingRatio(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetTargetAngle(b2JointId jointId, float angle);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetTargetAngle(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetAngle(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_EnableLimit(b2JointId jointId, [NativeTypeName("bool")] byte enableLimit);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2RevoluteJoint_IsLimitEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetLowerLimit(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetUpperLimit(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetLimits(b2JointId jointId, float lower, float upper);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_EnableMotor(b2JointId jointId, [NativeTypeName("bool")] byte enableMotor);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2RevoluteJoint_IsMotorEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetMotorSpeed(b2JointId jointId, float motorSpeed);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetMotorSpeed(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetMotorTorque(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetMaxMotorTorque(b2JointId jointId, float torque);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetMaxMotorTorque(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateWeldJoint(b2WorldId worldId, [NativeTypeName("const b2WeldJointDef *")] b2WeldJointDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WeldJoint_SetLinearHertz(b2JointId jointId, float hertz);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WeldJoint_GetLinearHertz(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WeldJoint_SetLinearDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WeldJoint_GetLinearDampingRatio(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WeldJoint_SetAngularHertz(b2JointId jointId, float hertz);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WeldJoint_GetAngularHertz(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WeldJoint_SetAngularDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WeldJoint_GetAngularDampingRatio(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateWheelJoint(b2WorldId worldId, [NativeTypeName("const b2WheelJointDef *")] b2WheelJointDef* def);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_EnableSpring(b2JointId jointId, [NativeTypeName("bool")] byte enableSpring);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2WheelJoint_IsSpringEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_SetSpringHertz(b2JointId jointId, float hertz);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetSpringHertz(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_SetSpringDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetSpringDampingRatio(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_EnableLimit(b2JointId jointId, [NativeTypeName("bool")] byte enableLimit);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2WheelJoint_IsLimitEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetLowerLimit(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetUpperLimit(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_SetLimits(b2JointId jointId, float lower, float upper);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_EnableMotor(b2JointId jointId, [NativeTypeName("bool")] byte enableMotor);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte b2WheelJoint_IsMotorEnabled(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_SetMotorSpeed(b2JointId jointId, float motorSpeed);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetMotorSpeed(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_SetMaxMotorTorque(b2JointId jointId, float torque);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetMaxMotorTorque(b2JointId jointId);

        [DllImport("box2d", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetMotorTorque(b2JointId jointId);
    }
}

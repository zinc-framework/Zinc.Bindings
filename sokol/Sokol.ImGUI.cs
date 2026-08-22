using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Zinc.Internal.Sokol
{
    public partial struct ImDrawListSharedData_t
    {
    }

    public partial struct ImFontAtlasBuilder_t
    {
    }

    public partial struct ImFontLoader_t
    {
    }

    public partial struct ImGuiContext_t
    {
    }

    public partial struct ImVec2_t
    {
        public float x;

        public float y;
    }

    public partial struct ImVec4_t
    {
        public float x;

        public float y;

        public float z;

        public float w;
    }

    public unsafe partial struct ImTextureRef_t
    {
        [NativeTypeName("ImTextureData *")]
        public ImTextureData_t* _TexData;

        [NativeTypeName("ImTextureID")]
        public ulong _TexID;
    }

    public enum ImGuiWindowFlags_
    {
        ImGuiWindowFlags_None = 0,
        ImGuiWindowFlags_NoTitleBar = 1 << 0,
        ImGuiWindowFlags_NoResize = 1 << 1,
        ImGuiWindowFlags_NoMove = 1 << 2,
        ImGuiWindowFlags_NoScrollbar = 1 << 3,
        ImGuiWindowFlags_NoScrollWithMouse = 1 << 4,
        ImGuiWindowFlags_NoCollapse = 1 << 5,
        ImGuiWindowFlags_AlwaysAutoResize = 1 << 6,
        ImGuiWindowFlags_NoBackground = 1 << 7,
        ImGuiWindowFlags_NoSavedSettings = 1 << 8,
        ImGuiWindowFlags_NoMouseInputs = 1 << 9,
        ImGuiWindowFlags_MenuBar = 1 << 10,
        ImGuiWindowFlags_HorizontalScrollbar = 1 << 11,
        ImGuiWindowFlags_NoFocusOnAppearing = 1 << 12,
        ImGuiWindowFlags_NoBringToFrontOnFocus = 1 << 13,
        ImGuiWindowFlags_AlwaysVerticalScrollbar = 1 << 14,
        ImGuiWindowFlags_AlwaysHorizontalScrollbar = 1 << 15,
        ImGuiWindowFlags_NoNavInputs = 1 << 16,
        ImGuiWindowFlags_NoNavFocus = 1 << 17,
        ImGuiWindowFlags_UnsavedDocument = 1 << 18,
        ImGuiWindowFlags_NoDocking = 1 << 19,
        ImGuiWindowFlags_NoNav = ImGuiWindowFlags_NoNavInputs | ImGuiWindowFlags_NoNavFocus,
        ImGuiWindowFlags_NoDecoration = ImGuiWindowFlags_NoTitleBar | ImGuiWindowFlags_NoResize | ImGuiWindowFlags_NoScrollbar | ImGuiWindowFlags_NoCollapse,
        ImGuiWindowFlags_NoInputs = ImGuiWindowFlags_NoMouseInputs | ImGuiWindowFlags_NoNavInputs | ImGuiWindowFlags_NoNavFocus,
        ImGuiWindowFlags_DockNodeHost = 1 << 23,
        ImGuiWindowFlags_ChildWindow = 1 << 24,
        ImGuiWindowFlags_Tooltip = 1 << 25,
        ImGuiWindowFlags_Popup = 1 << 26,
        ImGuiWindowFlags_Modal = 1 << 27,
        ImGuiWindowFlags_ChildMenu = 1 << 28,
    }

    public enum ImGuiChildFlags_
    {
        ImGuiChildFlags_None = 0,
        ImGuiChildFlags_Borders = 1 << 0,
        ImGuiChildFlags_AlwaysUseWindowPadding = 1 << 1,
        ImGuiChildFlags_ResizeX = 1 << 2,
        ImGuiChildFlags_ResizeY = 1 << 3,
        ImGuiChildFlags_AutoResizeX = 1 << 4,
        ImGuiChildFlags_AutoResizeY = 1 << 5,
        ImGuiChildFlags_AlwaysAutoResize = 1 << 6,
        ImGuiChildFlags_FrameStyle = 1 << 7,
        ImGuiChildFlags_NavFlattened = 1 << 8,
    }

    public enum ImGuiItemFlags_
    {
        ImGuiItemFlags_None = 0,
        ImGuiItemFlags_NoTabStop = 1 << 0,
        ImGuiItemFlags_NoNav = 1 << 1,
        ImGuiItemFlags_NoNavDefaultFocus = 1 << 2,
        ImGuiItemFlags_ButtonRepeat = 1 << 3,
        ImGuiItemFlags_AutoClosePopups = 1 << 4,
        ImGuiItemFlags_AllowDuplicateId = 1 << 5,
        ImGuiItemFlags_Disabled = 1 << 6,
        ImGuiItemFlags_LiveEditOnInputText = 1 << 7,
        ImGuiItemFlags_LiveEditOnInputScalar = 1 << 8,
        ImGuiItemFlags_LiveEditOnInput = ImGuiItemFlags_LiveEditOnInputText | ImGuiItemFlags_LiveEditOnInputScalar,
    }

    public enum ImGuiInputTextFlags_
    {
        ImGuiInputTextFlags_None = 0,
        ImGuiInputTextFlags_CharsDecimal = 1 << 0,
        ImGuiInputTextFlags_CharsHexadecimal = 1 << 1,
        ImGuiInputTextFlags_CharsScientific = 1 << 2,
        ImGuiInputTextFlags_CharsUppercase = 1 << 3,
        ImGuiInputTextFlags_CharsNoBlank = 1 << 4,
        ImGuiInputTextFlags_AllowTabInput = 1 << 5,
        ImGuiInputTextFlags_EnterReturnsTrue = 1 << 6,
        ImGuiInputTextFlags_EscapeClearsAll = 1 << 7,
        ImGuiInputTextFlags_CtrlEnterForNewLine = 1 << 8,
        ImGuiInputTextFlags_ReadOnly = 1 << 9,
        ImGuiInputTextFlags_Password = 1 << 10,
        ImGuiInputTextFlags_AlwaysOverwrite = 1 << 11,
        ImGuiInputTextFlags_AutoSelectAll = 1 << 12,
        ImGuiInputTextFlags_ParseEmptyRefVal = 1 << 13,
        ImGuiInputTextFlags_DisplayEmptyRefVal = 1 << 14,
        ImGuiInputTextFlags_NoHorizontalScroll = 1 << 15,
        ImGuiInputTextFlags_NoUndoRedo = 1 << 16,
        ImGuiInputTextFlags_ElideLeft = 1 << 17,
        ImGuiInputTextFlags_CallbackCompletion = 1 << 18,
        ImGuiInputTextFlags_CallbackHistory = 1 << 19,
        ImGuiInputTextFlags_CallbackAlways = 1 << 20,
        ImGuiInputTextFlags_CallbackCharFilter = 1 << 21,
        ImGuiInputTextFlags_CallbackResize = 1 << 22,
        ImGuiInputTextFlags_CallbackEdit = 1 << 23,
        ImGuiInputTextFlags_WordWrap = 1 << 24,
    }

    public enum ImGuiTreeNodeFlags_
    {
        ImGuiTreeNodeFlags_None = 0,
        ImGuiTreeNodeFlags_Selected = 1 << 0,
        ImGuiTreeNodeFlags_Framed = 1 << 1,
        ImGuiTreeNodeFlags_AllowOverlap = 1 << 2,
        ImGuiTreeNodeFlags_NoTreePushOnOpen = 1 << 3,
        ImGuiTreeNodeFlags_NoAutoOpenOnLog = 1 << 4,
        ImGuiTreeNodeFlags_DefaultOpen = 1 << 5,
        ImGuiTreeNodeFlags_OpenOnDoubleClick = 1 << 6,
        ImGuiTreeNodeFlags_OpenOnArrow = 1 << 7,
        ImGuiTreeNodeFlags_Leaf = 1 << 8,
        ImGuiTreeNodeFlags_Bullet = 1 << 9,
        ImGuiTreeNodeFlags_FramePadding = 1 << 10,
        ImGuiTreeNodeFlags_SpanAvailWidth = 1 << 11,
        ImGuiTreeNodeFlags_SpanFullWidth = 1 << 12,
        ImGuiTreeNodeFlags_SpanLabelWidth = 1 << 13,
        ImGuiTreeNodeFlags_SpanAllColumns = 1 << 14,
        ImGuiTreeNodeFlags_LabelSpanAllColumns = 1 << 15,
        ImGuiTreeNodeFlags_NavLeftJumpsToParent = 1 << 17,
        ImGuiTreeNodeFlags_CollapsingHeader = ImGuiTreeNodeFlags_Framed | ImGuiTreeNodeFlags_NoTreePushOnOpen | ImGuiTreeNodeFlags_NoAutoOpenOnLog,
        ImGuiTreeNodeFlags_DrawLinesNone = 1 << 18,
        ImGuiTreeNodeFlags_DrawLinesFull = 1 << 19,
        ImGuiTreeNodeFlags_DrawLinesToNodes = 1 << 20,
        ImGuiTreeNodeFlags_NavLeftJumpsBackHere = ImGuiTreeNodeFlags_NavLeftJumpsToParent,
    }

    public enum ImGuiPopupFlags_
    {
        ImGuiPopupFlags_None = 0,
        ImGuiPopupFlags_MouseButtonLeft = 1 << 2,
        ImGuiPopupFlags_MouseButtonRight = 2 << 2,
        ImGuiPopupFlags_MouseButtonMiddle = 3 << 2,
        ImGuiPopupFlags_NoReopen = 1 << 5,
        ImGuiPopupFlags_NoOpenOverExistingPopup = 1 << 7,
        ImGuiPopupFlags_NoOpenOverItems = 1 << 8,
        ImGuiPopupFlags_AnyPopupId = 1 << 10,
        ImGuiPopupFlags_AnyPopupLevel = 1 << 11,
        ImGuiPopupFlags_AnyPopup = ImGuiPopupFlags_AnyPopupId | ImGuiPopupFlags_AnyPopupLevel,
        ImGuiPopupFlags_MouseButtonShift_ = 2,
        ImGuiPopupFlags_MouseButtonMask_ = 0x0C,
        ImGuiPopupFlags_InvalidMask_ = 0x03,
    }

    public enum ImGuiSelectableFlags_
    {
        ImGuiSelectableFlags_None = 0,
        ImGuiSelectableFlags_NoAutoClosePopups = 1 << 0,
        ImGuiSelectableFlags_SpanAllColumns = 1 << 1,
        ImGuiSelectableFlags_AllowDoubleClick = 1 << 2,
        ImGuiSelectableFlags_Disabled = 1 << 3,
        ImGuiSelectableFlags_AllowOverlap = 1 << 4,
        ImGuiSelectableFlags_Highlight = 1 << 5,
        ImGuiSelectableFlags_SelectOnNav = 1 << 6,
        ImGuiSelectableFlags_DontClosePopups = ImGuiSelectableFlags_NoAutoClosePopups,
    }

    public enum ImGuiComboFlags_
    {
        ImGuiComboFlags_None = 0,
        ImGuiComboFlags_PopupAlignLeft = 1 << 0,
        ImGuiComboFlags_HeightSmall = 1 << 1,
        ImGuiComboFlags_HeightRegular = 1 << 2,
        ImGuiComboFlags_HeightLarge = 1 << 3,
        ImGuiComboFlags_HeightLargest = 1 << 4,
        ImGuiComboFlags_NoArrowButton = 1 << 5,
        ImGuiComboFlags_NoPreview = 1 << 6,
        ImGuiComboFlags_WidthFitPreview = 1 << 7,
        ImGuiComboFlags_HeightMask_ = ImGuiComboFlags_HeightSmall | ImGuiComboFlags_HeightRegular | ImGuiComboFlags_HeightLarge | ImGuiComboFlags_HeightLargest,
    }

    public enum ImGuiTabBarFlags_
    {
        ImGuiTabBarFlags_None = 0,
        ImGuiTabBarFlags_Reorderable = 1 << 0,
        ImGuiTabBarFlags_AutoSelectNewTabs = 1 << 1,
        ImGuiTabBarFlags_TabListPopupButton = 1 << 2,
        ImGuiTabBarFlags_NoCloseWithMiddleMouseButton = 1 << 3,
        ImGuiTabBarFlags_NoTabListScrollingButtons = 1 << 4,
        ImGuiTabBarFlags_NoTooltip = 1 << 5,
        ImGuiTabBarFlags_DrawSelectedOverline = 1 << 6,
        ImGuiTabBarFlags_FittingPolicyMixed = 1 << 7,
        ImGuiTabBarFlags_FittingPolicyShrink = 1 << 8,
        ImGuiTabBarFlags_FittingPolicyScroll = 1 << 9,
        ImGuiTabBarFlags_FittingPolicyMask_ = ImGuiTabBarFlags_FittingPolicyMixed | ImGuiTabBarFlags_FittingPolicyShrink | ImGuiTabBarFlags_FittingPolicyScroll,
        ImGuiTabBarFlags_FittingPolicyDefault_ = ImGuiTabBarFlags_FittingPolicyMixed,
        ImGuiTabBarFlags_FittingPolicyResizeDown = ImGuiTabBarFlags_FittingPolicyShrink,
    }

    public enum ImGuiTabItemFlags_
    {
        ImGuiTabItemFlags_None = 0,
        ImGuiTabItemFlags_UnsavedDocument = 1 << 0,
        ImGuiTabItemFlags_SetSelected = 1 << 1,
        ImGuiTabItemFlags_NoCloseWithMiddleMouseButton = 1 << 2,
        ImGuiTabItemFlags_NoPushId = 1 << 3,
        ImGuiTabItemFlags_NoTooltip = 1 << 4,
        ImGuiTabItemFlags_NoReorder = 1 << 5,
        ImGuiTabItemFlags_Leading = 1 << 6,
        ImGuiTabItemFlags_Trailing = 1 << 7,
        ImGuiTabItemFlags_NoAssumedClosure = 1 << 8,
    }

    public enum ImGuiFocusedFlags_
    {
        ImGuiFocusedFlags_None = 0,
        ImGuiFocusedFlags_ChildWindows = 1 << 0,
        ImGuiFocusedFlags_RootWindow = 1 << 1,
        ImGuiFocusedFlags_AnyWindow = 1 << 2,
        ImGuiFocusedFlags_NoPopupHierarchy = 1 << 3,
        ImGuiFocusedFlags_DockHierarchy = 1 << 4,
        ImGuiFocusedFlags_RootAndChildWindows = ImGuiFocusedFlags_RootWindow | ImGuiFocusedFlags_ChildWindows,
    }

    public enum ImGuiHoveredFlags_
    {
        ImGuiHoveredFlags_None = 0,
        ImGuiHoveredFlags_ChildWindows = 1 << 0,
        ImGuiHoveredFlags_RootWindow = 1 << 1,
        ImGuiHoveredFlags_AnyWindow = 1 << 2,
        ImGuiHoveredFlags_NoPopupHierarchy = 1 << 3,
        ImGuiHoveredFlags_DockHierarchy = 1 << 4,
        ImGuiHoveredFlags_AllowWhenBlockedByPopup = 1 << 5,
        ImGuiHoveredFlags_AllowWhenBlockedByActiveItem = 1 << 7,
        ImGuiHoveredFlags_AllowWhenOverlappedByItem = 1 << 8,
        ImGuiHoveredFlags_AllowWhenOverlappedByWindow = 1 << 9,
        ImGuiHoveredFlags_AllowWhenDisabled = 1 << 10,
        ImGuiHoveredFlags_NoNavOverride = 1 << 11,
        ImGuiHoveredFlags_AllowWhenOverlapped = ImGuiHoveredFlags_AllowWhenOverlappedByItem | ImGuiHoveredFlags_AllowWhenOverlappedByWindow,
        ImGuiHoveredFlags_RectOnly = ImGuiHoveredFlags_AllowWhenBlockedByPopup | ImGuiHoveredFlags_AllowWhenBlockedByActiveItem | ImGuiHoveredFlags_AllowWhenOverlapped,
        ImGuiHoveredFlags_RootAndChildWindows = ImGuiHoveredFlags_RootWindow | ImGuiHoveredFlags_ChildWindows,
        ImGuiHoveredFlags_ForTooltip = 1 << 12,
        ImGuiHoveredFlags_Stationary = 1 << 13,
        ImGuiHoveredFlags_DelayNone = 1 << 14,
        ImGuiHoveredFlags_DelayShort = 1 << 15,
        ImGuiHoveredFlags_DelayNormal = 1 << 16,
        ImGuiHoveredFlags_NoSharedDelay = 1 << 17,
    }

    public enum ImGuiDockNodeFlags_
    {
        ImGuiDockNodeFlags_None = 0,
        ImGuiDockNodeFlags_KeepAliveOnly = 1 << 0,
        ImGuiDockNodeFlags_NoDockingOverCentralNode = 1 << 2,
        ImGuiDockNodeFlags_PassthruCentralNode = 1 << 3,
        ImGuiDockNodeFlags_NoDockingSplit = 1 << 4,
        ImGuiDockNodeFlags_NoResize = 1 << 5,
        ImGuiDockNodeFlags_AutoHideTabBar = 1 << 6,
        ImGuiDockNodeFlags_NoUndocking = 1 << 7,
        ImGuiDockNodeFlags_NoSplit = ImGuiDockNodeFlags_NoDockingSplit,
        ImGuiDockNodeFlags_NoDockingInCentralNode = ImGuiDockNodeFlags_NoDockingOverCentralNode,
    }

    public enum ImGuiDragDropFlags_
    {
        ImGuiDragDropFlags_None = 0,
        ImGuiDragDropFlags_SourceNoPreviewTooltip = 1 << 0,
        ImGuiDragDropFlags_SourceNoDisableHover = 1 << 1,
        ImGuiDragDropFlags_SourceNoHoldToOpenOthers = 1 << 2,
        ImGuiDragDropFlags_SourceAllowNullID = 1 << 3,
        ImGuiDragDropFlags_SourceExtern = 1 << 4,
        ImGuiDragDropFlags_PayloadAutoExpire = 1 << 5,
        ImGuiDragDropFlags_PayloadNoCrossContext = 1 << 6,
        ImGuiDragDropFlags_PayloadNoCrossProcess = 1 << 7,
        ImGuiDragDropFlags_AcceptBeforeDelivery = 1 << 10,
        ImGuiDragDropFlags_AcceptNoDrawDefaultRect = 1 << 11,
        ImGuiDragDropFlags_AcceptNoPreviewTooltip = 1 << 12,
        ImGuiDragDropFlags_AcceptDrawAsHovered = 1 << 13,
        ImGuiDragDropFlags_AcceptPeekOnly = ImGuiDragDropFlags_AcceptBeforeDelivery | ImGuiDragDropFlags_AcceptNoDrawDefaultRect,
    }

    public enum ImGuiDataType_
    {
        ImGuiDataType_S8,
        ImGuiDataType_U8,
        ImGuiDataType_S16,
        ImGuiDataType_U16,
        ImGuiDataType_S32,
        ImGuiDataType_U32,
        ImGuiDataType_S64,
        ImGuiDataType_U64,
        ImGuiDataType_Float,
        ImGuiDataType_Double,
        ImGuiDataType_Bool,
        ImGuiDataType_String,
        ImGuiDataType_COUNT,
    }

    public enum ImGuiInputFlags_
    {
        ImGuiInputFlags_None = 0,
        ImGuiInputFlags_Repeat = 1 << 0,
        ImGuiInputFlags_RouteActive = 1 << 10,
        ImGuiInputFlags_RouteFocused = 1 << 11,
        ImGuiInputFlags_RouteGlobal = 1 << 12,
        ImGuiInputFlags_RouteAlways = 1 << 13,
        ImGuiInputFlags_RouteOverFocused = 1 << 14,
        ImGuiInputFlags_RouteOverActive = 1 << 15,
        ImGuiInputFlags_RouteUnlessBgFocused = 1 << 16,
        ImGuiInputFlags_RouteFromRootWindow = 1 << 17,
        ImGuiInputFlags_Tooltip = 1 << 18,
    }

    public enum ImGuiConfigFlags_
    {
        ImGuiConfigFlags_None = 0,
        ImGuiConfigFlags_NavEnableKeyboard = 1 << 0,
        ImGuiConfigFlags_NavEnableGamepad = 1 << 1,
        ImGuiConfigFlags_NoMouse = 1 << 4,
        ImGuiConfigFlags_NoMouseCursorChange = 1 << 5,
        ImGuiConfigFlags_NoKeyboard = 1 << 6,
        ImGuiConfigFlags_DockingEnable = 1 << 7,
        ImGuiConfigFlags_ViewportsEnable = 1 << 10,
        ImGuiConfigFlags_IsSRGB = 1 << 20,
        ImGuiConfigFlags_IsTouchScreen = 1 << 21,
        ImGuiConfigFlags_NavEnableSetMousePos = 1 << 2,
        ImGuiConfigFlags_NavNoCaptureKeyboard = 1 << 3,
        ImGuiConfigFlags_DpiEnableScaleFonts = 1 << 14,
        ImGuiConfigFlags_DpiEnableScaleViewports = 1 << 15,
    }

    public enum ImGuiBackendFlags_
    {
        ImGuiBackendFlags_None = 0,
        ImGuiBackendFlags_HasGamepad = 1 << 0,
        ImGuiBackendFlags_HasMouseCursors = 1 << 1,
        ImGuiBackendFlags_HasSetMousePos = 1 << 2,
        ImGuiBackendFlags_RendererHasVtxOffset = 1 << 3,
        ImGuiBackendFlags_RendererHasTextures = 1 << 4,
        ImGuiBackendFlags_RendererHasViewports = 1 << 10,
        ImGuiBackendFlags_PlatformHasViewports = 1 << 11,
        ImGuiBackendFlags_HasMouseHoveredViewport = 1 << 12,
        ImGuiBackendFlags_HasParentViewport = 1 << 13,
    }

    public enum ImGuiCol_
    {
        ImGuiCol_Text,
        ImGuiCol_TextDisabled,
        ImGuiCol_WindowBg,
        ImGuiCol_ChildBg,
        ImGuiCol_PopupBg,
        ImGuiCol_Border,
        ImGuiCol_BorderShadow,
        ImGuiCol_FrameBg,
        ImGuiCol_FrameBgHovered,
        ImGuiCol_FrameBgActive,
        ImGuiCol_TitleBg,
        ImGuiCol_TitleBgActive,
        ImGuiCol_TitleBgCollapsed,
        ImGuiCol_MenuBarBg,
        ImGuiCol_ScrollbarBg,
        ImGuiCol_ScrollbarGrab,
        ImGuiCol_ScrollbarGrabHovered,
        ImGuiCol_ScrollbarGrabActive,
        ImGuiCol_CheckMark,
        ImGuiCol_CheckboxSelectedBg,
        ImGuiCol_SliderGrab,
        ImGuiCol_SliderGrabActive,
        ImGuiCol_Button,
        ImGuiCol_ButtonHovered,
        ImGuiCol_ButtonActive,
        ImGuiCol_Header,
        ImGuiCol_HeaderHovered,
        ImGuiCol_HeaderActive,
        ImGuiCol_Separator,
        ImGuiCol_SeparatorHovered,
        ImGuiCol_SeparatorActive,
        ImGuiCol_ResizeGrip,
        ImGuiCol_ResizeGripHovered,
        ImGuiCol_ResizeGripActive,
        ImGuiCol_InputTextCursor,
        ImGuiCol_TabHovered,
        ImGuiCol_Tab,
        ImGuiCol_TabSelected,
        ImGuiCol_TabSelectedOverline,
        ImGuiCol_TabDimmed,
        ImGuiCol_TabDimmedSelected,
        ImGuiCol_TabDimmedSelectedOverline,
        ImGuiCol_DockingPreview,
        ImGuiCol_DockingEmptyBg,
        ImGuiCol_PlotLines,
        ImGuiCol_PlotLinesHovered,
        ImGuiCol_PlotHistogram,
        ImGuiCol_PlotHistogramHovered,
        ImGuiCol_TableHeaderBg,
        ImGuiCol_TableBorderStrong,
        ImGuiCol_TableBorderLight,
        ImGuiCol_TableRowBg,
        ImGuiCol_TableRowBgAlt,
        ImGuiCol_TextLink,
        ImGuiCol_TextSelectedBg,
        ImGuiCol_TreeLines,
        ImGuiCol_DragDropTarget,
        ImGuiCol_DragDropTargetBg,
        ImGuiCol_UnsavedMarker,
        ImGuiCol_NavCursor,
        ImGuiCol_NavWindowingHighlight,
        ImGuiCol_NavWindowingDimBg,
        ImGuiCol_ModalWindowDimBg,
        ImGuiCol_COUNT,
        ImGuiCol_TabActive = ImGuiCol_TabSelected,
        ImGuiCol_TabUnfocused = ImGuiCol_TabDimmed,
        ImGuiCol_TabUnfocusedActive = ImGuiCol_TabDimmedSelected,
        ImGuiCol_NavHighlight = ImGuiCol_NavCursor,
    }

    public enum ImGuiStyleVar_
    {
        ImGuiStyleVar_Alpha,
        ImGuiStyleVar_DisabledAlpha,
        ImGuiStyleVar_WindowPadding,
        ImGuiStyleVar_WindowRounding,
        ImGuiStyleVar_WindowBorderSize,
        ImGuiStyleVar_WindowMinSize,
        ImGuiStyleVar_WindowTitleAlign,
        ImGuiStyleVar_ChildRounding,
        ImGuiStyleVar_ChildBorderSize,
        ImGuiStyleVar_PopupRounding,
        ImGuiStyleVar_PopupBorderSize,
        ImGuiStyleVar_FramePadding,
        ImGuiStyleVar_FrameRounding,
        ImGuiStyleVar_FrameBorderSize,
        ImGuiStyleVar_ItemSpacing,
        ImGuiStyleVar_ItemInnerSpacing,
        ImGuiStyleVar_IndentSpacing,
        ImGuiStyleVar_CellPadding,
        ImGuiStyleVar_ScrollbarSize,
        ImGuiStyleVar_ScrollbarRounding,
        ImGuiStyleVar_ScrollbarPadding,
        ImGuiStyleVar_GrabMinSize,
        ImGuiStyleVar_GrabRounding,
        ImGuiStyleVar_ImageRounding,
        ImGuiStyleVar_ImageBorderSize,
        ImGuiStyleVar_TabRounding,
        ImGuiStyleVar_TabBorderSize,
        ImGuiStyleVar_TabMinWidthBase,
        ImGuiStyleVar_TabMinWidthShrink,
        ImGuiStyleVar_TabBarBorderSize,
        ImGuiStyleVar_TabBarOverlineSize,
        ImGuiStyleVar_TableAngledHeadersAngle,
        ImGuiStyleVar_TableAngledHeadersTextAlign,
        ImGuiStyleVar_TreeLinesSize,
        ImGuiStyleVar_TreeLinesRounding,
        ImGuiStyleVar_MenuItemRounding,
        ImGuiStyleVar_SelectableRounding,
        ImGuiStyleVar_DragDropTargetRounding,
        ImGuiStyleVar_ButtonTextAlign,
        ImGuiStyleVar_SelectableTextAlign,
        ImGuiStyleVar_SeparatorSize,
        ImGuiStyleVar_SeparatorTextBorderSize,
        ImGuiStyleVar_SeparatorTextAlign,
        ImGuiStyleVar_SeparatorTextPadding,
        ImGuiStyleVar_DockingSeparatorSize,
        ImGuiStyleVar_COUNT,
    }

    public enum ImGuiButtonFlags_
    {
        ImGuiButtonFlags_None = 0,
        ImGuiButtonFlags_MouseButtonLeft = 1 << 0,
        ImGuiButtonFlags_MouseButtonRight = 1 << 1,
        ImGuiButtonFlags_MouseButtonMiddle = 1 << 2,
        ImGuiButtonFlags_MouseButtonMask_ = ImGuiButtonFlags_MouseButtonLeft | ImGuiButtonFlags_MouseButtonRight | ImGuiButtonFlags_MouseButtonMiddle,
        ImGuiButtonFlags_EnableNav = 1 << 3,
        ImGuiButtonFlags_AllowOverlap = 1 << 12,
    }

    public enum ImGuiColorEditFlags_
    {
        ImGuiColorEditFlags_None = 0,
        ImGuiColorEditFlags_NoAlpha = 1 << 1,
        ImGuiColorEditFlags_NoPicker = 1 << 2,
        ImGuiColorEditFlags_NoOptions = 1 << 3,
        ImGuiColorEditFlags_NoSmallPreview = 1 << 4,
        ImGuiColorEditFlags_NoInputs = 1 << 5,
        ImGuiColorEditFlags_NoTooltip = 1 << 6,
        ImGuiColorEditFlags_NoLabel = 1 << 7,
        ImGuiColorEditFlags_NoSidePreview = 1 << 8,
        ImGuiColorEditFlags_NoDragDrop = 1 << 9,
        ImGuiColorEditFlags_NoBorder = 1 << 10,
        ImGuiColorEditFlags_NoColorMarkers = 1 << 11,
        ImGuiColorEditFlags_AlphaOpaque = 1 << 12,
        ImGuiColorEditFlags_AlphaNoBg = 1 << 13,
        ImGuiColorEditFlags_AlphaPreviewHalf = 1 << 14,
        ImGuiColorEditFlags_AlphaBar = 1 << 18,
        ImGuiColorEditFlags_HDR = 1 << 19,
        ImGuiColorEditFlags_DisplayRGB = 1 << 20,
        ImGuiColorEditFlags_DisplayHSV = 1 << 21,
        ImGuiColorEditFlags_DisplayHex = 1 << 22,
        ImGuiColorEditFlags_Uint8 = 1 << 23,
        ImGuiColorEditFlags_Float = 1 << 24,
        ImGuiColorEditFlags_PickerHueBar = 1 << 25,
        ImGuiColorEditFlags_PickerHueWheel = 1 << 26,
        ImGuiColorEditFlags_PickerNoRotate = 1 << 27,
        ImGuiColorEditFlags_InputRGB = 1 << 28,
        ImGuiColorEditFlags_InputHSV = 1 << 29,
        ImGuiColorEditFlags_DefaultOptions_ = ImGuiColorEditFlags_Uint8 | ImGuiColorEditFlags_DisplayRGB | ImGuiColorEditFlags_InputRGB | ImGuiColorEditFlags_PickerHueBar,
        ImGuiColorEditFlags_AlphaMask_ = ImGuiColorEditFlags_NoAlpha | ImGuiColorEditFlags_AlphaOpaque | ImGuiColorEditFlags_AlphaNoBg | ImGuiColorEditFlags_AlphaPreviewHalf,
        ImGuiColorEditFlags_DisplayMask_ = ImGuiColorEditFlags_DisplayRGB | ImGuiColorEditFlags_DisplayHSV | ImGuiColorEditFlags_DisplayHex,
        ImGuiColorEditFlags_DataTypeMask_ = ImGuiColorEditFlags_Uint8 | ImGuiColorEditFlags_Float,
        ImGuiColorEditFlags_PickerMask_ = ImGuiColorEditFlags_PickerHueWheel | ImGuiColorEditFlags_PickerHueBar,
        ImGuiColorEditFlags_InputMask_ = ImGuiColorEditFlags_InputRGB | ImGuiColorEditFlags_InputHSV,
        ImGuiColorEditFlags_AlphaPreview = 0,
    }

    public enum ImGuiSliderFlags_
    {
        ImGuiSliderFlags_None = 0,
        ImGuiSliderFlags_Logarithmic = 1 << 5,
        ImGuiSliderFlags_NoRoundToFormat = 1 << 6,
        ImGuiSliderFlags_NoInput = 1 << 7,
        ImGuiSliderFlags_WrapAround = 1 << 8,
        ImGuiSliderFlags_ClampOnInput = 1 << 9,
        ImGuiSliderFlags_ClampZeroRange = 1 << 10,
        ImGuiSliderFlags_NoSpeedTweaks = 1 << 11,
        ImGuiSliderFlags_ColorMarkers = 1 << 12,
        ImGuiSliderFlags_AlwaysClamp = ImGuiSliderFlags_ClampOnInput | ImGuiSliderFlags_ClampZeroRange,
        ImGuiSliderFlags_InvalidMask_ = 0x7000000F,
    }

    public enum ImGuiMouseButton_
    {
        ImGuiMouseButton_Left = 0,
        ImGuiMouseButton_Right = 1,
        ImGuiMouseButton_Middle = 2,
        ImGuiMouseButton_COUNT = 5,
    }

    public enum ImGuiMouseCursor_
    {
        ImGuiMouseCursor_None = -1,
        ImGuiMouseCursor_Arrow = 0,
        ImGuiMouseCursor_TextInput,
        ImGuiMouseCursor_ResizeAll,
        ImGuiMouseCursor_ResizeNS,
        ImGuiMouseCursor_ResizeEW,
        ImGuiMouseCursor_ResizeNESW,
        ImGuiMouseCursor_ResizeNWSE,
        ImGuiMouseCursor_Hand,
        ImGuiMouseCursor_Wait,
        ImGuiMouseCursor_Progress,
        ImGuiMouseCursor_NotAllowed,
        ImGuiMouseCursor_COUNT,
    }

    public enum ImGuiCond_
    {
        ImGuiCond_None = 0,
        ImGuiCond_Always = 1 << 0,
        ImGuiCond_Once = 1 << 1,
        ImGuiCond_FirstUseEver = 1 << 2,
        ImGuiCond_Appearing = 1 << 3,
    }

    public enum ImGuiTableFlags_
    {
        ImGuiTableFlags_None = 0,
        ImGuiTableFlags_Resizable = 1 << 0,
        ImGuiTableFlags_Reorderable = 1 << 1,
        ImGuiTableFlags_Hideable = 1 << 2,
        ImGuiTableFlags_Sortable = 1 << 3,
        ImGuiTableFlags_NoSavedSettings = 1 << 4,
        ImGuiTableFlags_ContextMenuInBody = 1 << 5,
        ImGuiTableFlags_RowBg = 1 << 6,
        ImGuiTableFlags_BordersInnerH = 1 << 7,
        ImGuiTableFlags_BordersOuterH = 1 << 8,
        ImGuiTableFlags_BordersInnerV = 1 << 9,
        ImGuiTableFlags_BordersOuterV = 1 << 10,
        ImGuiTableFlags_BordersH = ImGuiTableFlags_BordersInnerH | ImGuiTableFlags_BordersOuterH,
        ImGuiTableFlags_BordersV = ImGuiTableFlags_BordersInnerV | ImGuiTableFlags_BordersOuterV,
        ImGuiTableFlags_BordersInner = ImGuiTableFlags_BordersInnerV | ImGuiTableFlags_BordersInnerH,
        ImGuiTableFlags_BordersOuter = ImGuiTableFlags_BordersOuterV | ImGuiTableFlags_BordersOuterH,
        ImGuiTableFlags_Borders = ImGuiTableFlags_BordersInner | ImGuiTableFlags_BordersOuter,
        ImGuiTableFlags_NoBordersInBody = 1 << 11,
        ImGuiTableFlags_NoBordersInBodyUntilResize = 1 << 12,
        ImGuiTableFlags_SizingFixedFit = 1 << 13,
        ImGuiTableFlags_SizingFixedSame = 2 << 13,
        ImGuiTableFlags_SizingStretchProp = 3 << 13,
        ImGuiTableFlags_SizingStretchSame = 4 << 13,
        ImGuiTableFlags_NoHostExtendX = 1 << 16,
        ImGuiTableFlags_NoHostExtendY = 1 << 17,
        ImGuiTableFlags_NoKeepColumnsVisible = 1 << 18,
        ImGuiTableFlags_PreciseWidths = 1 << 19,
        ImGuiTableFlags_NoClip = 1 << 20,
        ImGuiTableFlags_PadOuterX = 1 << 21,
        ImGuiTableFlags_NoPadOuterX = 1 << 22,
        ImGuiTableFlags_NoPadInnerX = 1 << 23,
        ImGuiTableFlags_ScrollX = 1 << 24,
        ImGuiTableFlags_ScrollY = 1 << 25,
        ImGuiTableFlags_SortMulti = 1 << 26,
        ImGuiTableFlags_SortTristate = 1 << 27,
        ImGuiTableFlags_HighlightHoveredColumn = 1 << 28,
        ImGuiTableFlags_SizingMask_ = ImGuiTableFlags_SizingFixedFit | ImGuiTableFlags_SizingFixedSame | ImGuiTableFlags_SizingStretchProp | ImGuiTableFlags_SizingStretchSame,
    }

    public enum ImGuiTableColumnFlags_
    {
        ImGuiTableColumnFlags_None = 0,
        ImGuiTableColumnFlags_Disabled = 1 << 0,
        ImGuiTableColumnFlags_DefaultHide = 1 << 1,
        ImGuiTableColumnFlags_DefaultSort = 1 << 2,
        ImGuiTableColumnFlags_WidthStretch = 1 << 3,
        ImGuiTableColumnFlags_WidthFixed = 1 << 4,
        ImGuiTableColumnFlags_NoResize = 1 << 5,
        ImGuiTableColumnFlags_NoReorder = 1 << 6,
        ImGuiTableColumnFlags_NoHide = 1 << 7,
        ImGuiTableColumnFlags_NoClip = 1 << 8,
        ImGuiTableColumnFlags_NoSort = 1 << 9,
        ImGuiTableColumnFlags_NoSortAscending = 1 << 10,
        ImGuiTableColumnFlags_NoSortDescending = 1 << 11,
        ImGuiTableColumnFlags_NoHeaderLabel = 1 << 12,
        ImGuiTableColumnFlags_NoHeaderWidth = 1 << 13,
        ImGuiTableColumnFlags_PreferSortAscending = 1 << 14,
        ImGuiTableColumnFlags_PreferSortDescending = 1 << 15,
        ImGuiTableColumnFlags_IndentEnable = 1 << 16,
        ImGuiTableColumnFlags_IndentDisable = 1 << 17,
        ImGuiTableColumnFlags_AngledHeader = 1 << 18,
        ImGuiTableColumnFlags_IsEnabled = 1 << 24,
        ImGuiTableColumnFlags_IsVisible = 1 << 25,
        ImGuiTableColumnFlags_IsSorted = 1 << 26,
        ImGuiTableColumnFlags_IsHovered = 1 << 27,
        ImGuiTableColumnFlags_WidthMask_ = ImGuiTableColumnFlags_WidthStretch | ImGuiTableColumnFlags_WidthFixed,
        ImGuiTableColumnFlags_IndentMask_ = ImGuiTableColumnFlags_IndentEnable | ImGuiTableColumnFlags_IndentDisable,
        ImGuiTableColumnFlags_StatusMask_ = ImGuiTableColumnFlags_IsEnabled | ImGuiTableColumnFlags_IsVisible | ImGuiTableColumnFlags_IsSorted | ImGuiTableColumnFlags_IsHovered,
        ImGuiTableColumnFlags_NoDirectResize_ = 1 << 30,
    }

    public enum ImGuiTableRowFlags_
    {
        ImGuiTableRowFlags_None = 0,
        ImGuiTableRowFlags_Headers = 1 << 0,
    }

    public enum ImGuiTableBgTarget_
    {
        ImGuiTableBgTarget_None = 0,
        ImGuiTableBgTarget_RowBg0 = 1,
        ImGuiTableBgTarget_RowBg1 = 2,
        ImGuiTableBgTarget_CellBg = 3,
    }

    public unsafe partial struct ImGuiTableSortSpecs_t
    {
        [NativeTypeName("const ImGuiTableColumnSortSpecs *")]
        public ImGuiTableColumnSortSpecs_t* Specs;

        public int SpecsCount;

        [NativeTypeName("bool")]
        public byte SpecsDirty;
    }

    public partial struct ImGuiTableColumnSortSpecs_t
    {
        [NativeTypeName("ImGuiID")]
        public uint ColumnUserID;

        [NativeTypeName("ImS16")]
        public short ColumnIndex;

        [NativeTypeName("ImS16")]
        public short SortOrder;

        [NativeTypeName("ImGuiSortDirection")]
        public byte SortDirection;
    }

    public unsafe partial struct ImVector_ImGuiTextRange_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImGuiTextFilter_ImGuiTextRange *")]
        public ImGuiTextFilter_ImGuiTextRange_t* Data;
    }

    public unsafe partial struct ImVector_char_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("char *")]
        public sbyte* Data;
    }

    public unsafe partial struct ImVector_ImGuiStoragePair_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImGuiStoragePair *")]
        public ImGuiStoragePair_t* Data;
    }

    public unsafe partial struct ImVector_ImGuiSelectionRequest_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImGuiSelectionRequest *")]
        public ImGuiSelectionRequest_t* Data;
    }

    public unsafe partial struct ImVector_ImDrawChannel_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImDrawChannel *")]
        public ImDrawChannel_t* Data;
    }

    public unsafe partial struct ImVector_ImDrawCmd_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImDrawCmd *")]
        public ImDrawCmd_t* Data;
    }

    public unsafe partial struct ImVector_ImDrawIdx_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImDrawIdx *")]
        public ushort* Data;
    }

    public unsafe partial struct ImVector_ImDrawVert_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImDrawVert *")]
        public ImDrawVert_t* Data;
    }

    public unsafe partial struct ImVector_ImVec2_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImVec2 *")]
        public ImVec2_t* Data;
    }

    public unsafe partial struct ImVector_ImVec4_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImVec4 *")]
        public ImVec4_t* Data;
    }

    public unsafe partial struct ImVector_ImTextureRef_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImTextureRef *")]
        public ImTextureRef_t* Data;
    }

    public unsafe partial struct ImVector_ImU8_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImU8 *")]
        public byte* Data;
    }

    public unsafe partial struct ImVector_ImDrawListPtr_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImDrawList **")]
        public ImDrawList_t** Data;
    }

    public unsafe partial struct ImVector_ImTextureRect_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImTextureRect *")]
        public ImTextureRect_t* Data;
    }

    public unsafe partial struct ImVector_ImU32_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImU32 *")]
        public uint* Data;
    }

    public unsafe partial struct ImVector_ImWchar_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImWchar *")]
        public ushort* Data;
    }

    public unsafe partial struct ImVector_ImFontPtr_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImFont **")]
        public ImFont_t** Data;
    }

    public unsafe partial struct ImVector_ImFontConfig_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImFontConfig *")]
        public ImFontConfig_t* Data;
    }

    public unsafe partial struct ImVector_ImDrawListSharedDataPtr_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImDrawListSharedData **")]
        public ImDrawListSharedData_t** Data;
    }

    public unsafe partial struct ImVector_float_t
    {
        public int Size;

        public int Capacity;

        public float* Data;
    }

    public unsafe partial struct ImVector_ImU16_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImU16 *")]
        public ushort* Data;
    }

    public unsafe partial struct ImVector_ImFontGlyph_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImFontGlyph *")]
        public ImFontGlyph_t* Data;
    }

    public unsafe partial struct ImVector_ImFontConfigPtr_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImFontConfig **")]
        public ImFontConfig_t** Data;
    }

    public unsafe partial struct ImVector_ImGuiPlatformMonitor_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImGuiPlatformMonitor *")]
        public ImGuiPlatformMonitor_t* Data;
    }

    public unsafe partial struct ImVector_ImTextureDataPtr_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImTextureData **")]
        public ImTextureData_t** Data;
    }

    public unsafe partial struct ImVector_ImGuiViewportPtr_t
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImGuiViewport **")]
        public ImGuiViewport_t** Data;
    }

    public partial struct ImGuiStyle_t
    {
        public float FontSizeBase;

        public float FontScaleMain;

        public float FontScaleDpi;

        public float Alpha;

        public float DisabledAlpha;

        [NativeTypeName("ImVec2")]
        public ImVec2_t WindowPadding;

        public float WindowRounding;

        public float WindowBorderSize;

        public float WindowBorderHoverPadding;

        [NativeTypeName("ImVec2")]
        public ImVec2_t WindowMinSize;

        [NativeTypeName("ImVec2")]
        public ImVec2_t WindowTitleAlign;

        [NativeTypeName("ImGuiDir")]
        public int WindowMenuButtonPosition;

        public float ChildRounding;

        public float ChildBorderSize;

        public float PopupRounding;

        public float PopupBorderSize;

        [NativeTypeName("ImVec2")]
        public ImVec2_t FramePadding;

        public float FrameRounding;

        public float FrameBorderSize;

        [NativeTypeName("ImVec2")]
        public ImVec2_t ItemSpacing;

        [NativeTypeName("ImVec2")]
        public ImVec2_t ItemInnerSpacing;

        [NativeTypeName("ImVec2")]
        public ImVec2_t CellPadding;

        [NativeTypeName("ImVec2")]
        public ImVec2_t TouchExtraPadding;

        public float IndentSpacing;

        public float ColumnsMinSpacing;

        public float ScrollbarSize;

        public float ScrollbarRounding;

        public float ScrollbarPadding;

        public float GrabMinSize;

        public float GrabRounding;

        public float LogSliderDeadzone;

        public float ImageRounding;

        public float ImageBorderSize;

        public float TabRounding;

        public float TabBorderSize;

        public float TabMinWidthBase;

        public float TabMinWidthShrink;

        public float TabCloseButtonMinWidthSelected;

        public float TabCloseButtonMinWidthUnselected;

        public float TabBarBorderSize;

        public float TabBarOverlineSize;

        public float TableAngledHeadersAngle;

        [NativeTypeName("ImVec2")]
        public ImVec2_t TableAngledHeadersTextAlign;

        [NativeTypeName("ImGuiTreeNodeFlags")]
        public int TreeLinesFlags;

        public float TreeLinesSize;

        public float TreeLinesRounding;

        public float MenuItemRounding;

        public float SelectableRounding;

        public float DragDropTargetRounding;

        public float DragDropTargetBorderSize;

        public float DragDropTargetPadding;

        public float ColorMarkerSize;

        [NativeTypeName("ImGuiDir")]
        public int ColorButtonPosition;

        [NativeTypeName("ImVec2")]
        public ImVec2_t ButtonTextAlign;

        [NativeTypeName("ImVec2")]
        public ImVec2_t SelectableTextAlign;

        public float InputTextCursorSize;

        public float SeparatorSize;

        public float SeparatorTextBorderSize;

        [NativeTypeName("ImVec2")]
        public ImVec2_t SeparatorTextAlign;

        [NativeTypeName("ImVec2")]
        public ImVec2_t SeparatorTextPadding;

        [NativeTypeName("ImVec2")]
        public ImVec2_t DisplayWindowPadding;

        [NativeTypeName("ImVec2")]
        public ImVec2_t DisplaySafeAreaPadding;

        [NativeTypeName("bool")]
        public byte DockingNodeHasCloseButton;

        public float DockingSeparatorSize;

        public float MouseCursorScale;

        [NativeTypeName("bool")]
        public byte AntiAliasedLines;

        [NativeTypeName("bool")]
        public byte AntiAliasedLinesUseTex;

        [NativeTypeName("bool")]
        public byte AntiAliasedFill;

        public float CurveTessellationTol;

        public float CircleTessellationMaxError;

        [NativeTypeName("ImVec4[63]")]
        public _Colors_e__FixedBuffer Colors;

        public float HoverStationaryDelay;

        public float HoverDelayShort;

        public float HoverDelayNormal;

        [NativeTypeName("ImGuiHoveredFlags")]
        public int HoverFlagsForTooltipMouse;

        [NativeTypeName("ImGuiHoveredFlags")]
        public int HoverFlagsForTooltipNav;

        public float _MainScale;

        public float _NextFrameFontSizeBase;

        [InlineArray(63)]
        public partial struct _Colors_e__FixedBuffer
        {
            public ImVec4_t e0;
        }
    }

    public partial struct ImGuiKeyData_t
    {
        [NativeTypeName("bool")]
        public byte Down;

        public float DownDuration;

        public float DownDurationPrev;

        public float AnalogValue;
    }

    public unsafe partial struct ImGuiIO_t
    {
        [NativeTypeName("ImGuiConfigFlags")]
        public int ConfigFlags;

        [NativeTypeName("ImGuiBackendFlags")]
        public int BackendFlags;

        [NativeTypeName("ImVec2")]
        public ImVec2_t DisplaySize;

        [NativeTypeName("ImVec2")]
        public ImVec2_t DisplayFramebufferScale;

        public float DeltaTime;

        public float IniSavingRate;

        [NativeTypeName("const char *")]
        public sbyte* IniFilename;

        [NativeTypeName("const char *")]
        public sbyte* LogFilename;

        public void* UserData;

        [NativeTypeName("ImFontAtlas *")]
        public ImFontAtlas_t* Fonts;

        [NativeTypeName("ImFont *")]
        public ImFont_t* FontDefault;

        [NativeTypeName("bool")]
        public byte FontAllowUserScaling;

        [NativeTypeName("bool")]
        public byte ConfigNavSwapGamepadButtons;

        [NativeTypeName("bool")]
        public byte ConfigNavMoveSetMousePos;

        [NativeTypeName("bool")]
        public byte ConfigNavCaptureKeyboard;

        [NativeTypeName("bool")]
        public byte ConfigNavEscapeClearFocusItem;

        [NativeTypeName("bool")]
        public byte ConfigNavEscapeClearFocusWindow;

        [NativeTypeName("bool")]
        public byte ConfigNavCursorVisibleAuto;

        [NativeTypeName("bool")]
        public byte ConfigNavCursorVisibleAlways;

        [NativeTypeName("bool")]
        public byte ConfigDockingNoSplit;

        [NativeTypeName("bool")]
        public byte ConfigDockingNoDockingOver;

        [NativeTypeName("bool")]
        public byte ConfigDockingWithShift;

        [NativeTypeName("bool")]
        public byte ConfigDockingAlwaysTabBar;

        [NativeTypeName("bool")]
        public byte ConfigDockingTransparentPayload;

        [NativeTypeName("bool")]
        public byte ConfigViewportsNoAutoMerge;

        [NativeTypeName("bool")]
        public byte ConfigViewportsNoTaskBarIcon;

        [NativeTypeName("bool")]
        public byte ConfigViewportsNoDecoration;

        [NativeTypeName("bool")]
        public byte ConfigViewportsNoDefaultParent;

        [NativeTypeName("bool")]
        public byte ConfigViewportsPlatformFocusSetsImGuiFocus;

        [NativeTypeName("bool")]
        public byte ConfigDpiScaleFonts;

        [NativeTypeName("bool")]
        public byte ConfigDpiScaleViewports;

        [NativeTypeName("bool")]
        public byte ConfigMacOSXBehaviors;

        [NativeTypeName("bool")]
        public byte ConfigInputTrickleEventQueue;

        [NativeTypeName("bool")]
        public byte ConfigInputTextCursorBlink;

        [NativeTypeName("bool")]
        public byte ConfigInputTextEnterKeepActive;

        [NativeTypeName("ImGuiColorEditFlags")]
        public int ConfigColorEditFlags;

        [NativeTypeName("bool")]
        public byte ConfigDragClickToInputText;

        [NativeTypeName("bool")]
        public byte ConfigWindowsResizeFromEdges;

        [NativeTypeName("bool")]
        public byte ConfigWindowsMoveFromTitleBarOnly;

        [NativeTypeName("bool")]
        public byte ConfigWindowsCopyContentsWithCtrlC;

        [NativeTypeName("bool")]
        public byte ConfigScrollbarScrollByPage;

        [NativeTypeName("bool")]
        public byte ConfigIniSettingsSaveLastUsedDate;

        public int ConfigIniSettingsAutoDiscardMonths;

        [NativeTypeName("bool")]
        public byte ConfigDebugIniSettings;

        [NativeTypeName("bool")]
        public byte MouseDrawCursor;

        public float ConfigMemoryCompactTimer;

        public float MouseDoubleClickTime;

        public float MouseDoubleClickMaxDist;

        public float MouseSingleClickDelay;

        public float MouseDragThreshold;

        public float KeyRepeatDelay;

        public float KeyRepeatRate;

        [NativeTypeName("bool")]
        public byte ConfigErrorRecovery;

        [NativeTypeName("bool")]
        public byte ConfigErrorRecoveryEnableAssert;

        [NativeTypeName("bool")]
        public byte ConfigErrorRecoveryEnableDebugLog;

        [NativeTypeName("bool")]
        public byte ConfigErrorRecoveryEnableTooltip;

        [NativeTypeName("bool")]
        public byte ConfigDebugIsDebuggerPresent;

        [NativeTypeName("bool")]
        public byte ConfigDebugHighlightIdConflicts;

        [NativeTypeName("bool")]
        public byte ConfigDebugHighlightIdConflictsShowItemPicker;

        [NativeTypeName("bool")]
        public byte ConfigDebugBeginReturnValueOnce;

        [NativeTypeName("bool")]
        public byte ConfigDebugBeginReturnValueLoop;

        [NativeTypeName("bool")]
        public byte ConfigDebugIgnoreFocusLoss;

        [NativeTypeName("const char *")]
        public sbyte* BackendPlatformName;

        [NativeTypeName("const char *")]
        public sbyte* BackendRendererName;

        public void* BackendPlatformUserData;

        public void* BackendRendererUserData;

        public void* BackendLanguageUserData;

        [NativeTypeName("bool")]
        public byte WantCaptureMouse;

        [NativeTypeName("bool")]
        public byte WantCaptureKeyboard;

        [NativeTypeName("bool")]
        public byte WantTextInput;

        [NativeTypeName("bool")]
        public byte WantSetMousePos;

        [NativeTypeName("bool")]
        public byte WantSaveIniSettings;

        [NativeTypeName("bool")]
        public byte NavActive;

        [NativeTypeName("bool")]
        public byte NavVisible;

        public float Framerate;

        public int MetricsRenderVertices;

        public int MetricsRenderIndices;

        public int MetricsRenderWindows;

        public int MetricsActiveWindows;

        [NativeTypeName("ImVec2")]
        public ImVec2_t MouseDelta;

        [NativeTypeName("ImGuiContext *")]
        public ImGuiContext_t* Ctx;

        [NativeTypeName("ImVec2")]
        public ImVec2_t MousePos;

        [NativeTypeName("bool[5]")]
        public _MouseDown_e__FixedBuffer MouseDown;

        public float MouseWheel;

        public float MouseWheelH;

        [NativeTypeName("ImGuiMouseSource")]
        public int MouseSource;

        [NativeTypeName("ImGuiID")]
        public uint MouseHoveredViewport;

        [NativeTypeName("bool")]
        public byte KeyCtrl;

        [NativeTypeName("bool")]
        public byte KeyShift;

        [NativeTypeName("bool")]
        public byte KeyAlt;

        [NativeTypeName("bool")]
        public byte KeySuper;

        [NativeTypeName("ImGuiKeyChord")]
        public int KeyMods;

        [NativeTypeName("ImGuiKeyData[155]")]
        public _KeysData_e__FixedBuffer KeysData;

        [NativeTypeName("bool")]
        public byte WantCaptureMouseUnlessPopupClose;

        [NativeTypeName("ImVec2")]
        public ImVec2_t MousePosPrev;

        [NativeTypeName("ImVec2[5]")]
        public _MouseClickedPos_e__FixedBuffer MouseClickedPos;

        [NativeTypeName("double[5]")]
        public _MouseClickedTime_e__FixedBuffer MouseClickedTime;

        [NativeTypeName("bool[5]")]
        public _MouseClicked_e__FixedBuffer MouseClicked;

        [NativeTypeName("bool[5]")]
        public _MouseDoubleClicked_e__FixedBuffer MouseDoubleClicked;

        [NativeTypeName("ImU16[5]")]
        public _MouseClickedCount_e__FixedBuffer MouseClickedCount;

        [NativeTypeName("ImU16[5]")]
        public _MouseClickedLastCount_e__FixedBuffer MouseClickedLastCount;

        [NativeTypeName("bool[5]")]
        public _MouseReleased_e__FixedBuffer MouseReleased;

        [NativeTypeName("double[5]")]
        public _MouseReleasedTime_e__FixedBuffer MouseReleasedTime;

        [NativeTypeName("bool[5]")]
        public _MouseDownOwned_e__FixedBuffer MouseDownOwned;

        [NativeTypeName("bool[5]")]
        public _MouseDownOwnedUnlessPopupClose_e__FixedBuffer MouseDownOwnedUnlessPopupClose;

        [NativeTypeName("bool")]
        public byte MouseWheelRequestAxisSwap;

        [NativeTypeName("bool")]
        public byte MouseCtrlLeftAsRightClick;

        [NativeTypeName("float[5]")]
        public _MouseDownDuration_e__FixedBuffer MouseDownDuration;

        [NativeTypeName("float[5]")]
        public _MouseDownDurationPrev_e__FixedBuffer MouseDownDurationPrev;

        [NativeTypeName("ImVec2[5]")]
        public _MouseDragMaxDistanceAbs_e__FixedBuffer MouseDragMaxDistanceAbs;

        [NativeTypeName("float[5]")]
        public _MouseDragMaxDistanceSqr_e__FixedBuffer MouseDragMaxDistanceSqr;

        public float PenPressure;

        [NativeTypeName("bool")]
        public byte AppFocusLost;

        [NativeTypeName("bool")]
        public byte AppAcceptingEvents;

        [NativeTypeName("ImWchar16")]
        public ushort InputQueueSurrogate;

        [NativeTypeName("ImVector_ImWchar")]
        public ImVector_ImWchar_t InputQueueCharacters;

        public float FontGlobalScale;

        [NativeTypeName("const char *(*)(void *)")]
        public delegate* unmanaged[Cdecl]<void*, sbyte*> GetClipboardTextFn;

        [NativeTypeName("void (*)(void *, const char *)")]
        public delegate* unmanaged[Cdecl]<void*, sbyte*, void> SetClipboardTextFn;

        public void* ClipboardUserData;

        [InlineArray(5)]
        public partial struct _MouseDown_e__FixedBuffer
        {
            public bool e0;
        }

        [InlineArray(155)]
        public partial struct _KeysData_e__FixedBuffer
        {
            public ImGuiKeyData_t e0;
        }

        [InlineArray(5)]
        public partial struct _MouseClickedPos_e__FixedBuffer
        {
            public ImVec2_t e0;
        }

        [InlineArray(5)]
        public partial struct _MouseClickedTime_e__FixedBuffer
        {
            public double e0;
        }

        [InlineArray(5)]
        public partial struct _MouseClicked_e__FixedBuffer
        {
            public bool e0;
        }

        [InlineArray(5)]
        public partial struct _MouseDoubleClicked_e__FixedBuffer
        {
            public bool e0;
        }

        [InlineArray(5)]
        public partial struct _MouseClickedCount_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(5)]
        public partial struct _MouseClickedLastCount_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(5)]
        public partial struct _MouseReleased_e__FixedBuffer
        {
            public bool e0;
        }

        [InlineArray(5)]
        public partial struct _MouseReleasedTime_e__FixedBuffer
        {
            public double e0;
        }

        [InlineArray(5)]
        public partial struct _MouseDownOwned_e__FixedBuffer
        {
            public bool e0;
        }

        [InlineArray(5)]
        public partial struct _MouseDownOwnedUnlessPopupClose_e__FixedBuffer
        {
            public bool e0;
        }

        [InlineArray(5)]
        public partial struct _MouseDownDuration_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(5)]
        public partial struct _MouseDownDurationPrev_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(5)]
        public partial struct _MouseDragMaxDistanceAbs_e__FixedBuffer
        {
            public ImVec2_t e0;
        }

        [InlineArray(5)]
        public partial struct _MouseDragMaxDistanceSqr_e__FixedBuffer
        {
            public float e0;
        }
    }

    public unsafe partial struct ImGuiInputTextCallbackData_t
    {
        [NativeTypeName("ImGuiContext *")]
        public ImGuiContext_t* Ctx;

        [NativeTypeName("ImGuiInputTextFlags")]
        public int EventFlag;

        [NativeTypeName("ImGuiInputTextFlags")]
        public int Flags;

        public void* UserData;

        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiKey")]
        public int EventKey;

        [NativeTypeName("ImWchar")]
        public ushort EventChar;

        [NativeTypeName("bool")]
        public byte EventActivated;

        [NativeTypeName("bool")]
        public byte BufDirty;

        [NativeTypeName("char *")]
        public sbyte* Buf;

        public int BufTextLen;

        public int BufSize;

        public int CursorPos;

        public int SelectionStart;

        public int SelectionEnd;
    }

    public unsafe partial struct ImGuiSizeCallbackData_t
    {
        public void* UserData;

        [NativeTypeName("ImVec2")]
        public ImVec2_t Pos;

        [NativeTypeName("ImVec2")]
        public ImVec2_t CurrentSize;

        [NativeTypeName("ImVec2")]
        public ImVec2_t DesiredSize;
    }

    public unsafe partial struct ImGuiWindowClass_t
    {
        [NativeTypeName("ImGuiID")]
        public uint ClassId;

        [NativeTypeName("ImGuiID")]
        public uint ParentViewportId;

        [NativeTypeName("ImGuiID")]
        public uint FocusRouteParentWindowId;

        [NativeTypeName("ImGuiViewportFlags")]
        public int ViewportFlagsOverrideSet;

        [NativeTypeName("ImGuiViewportFlags")]
        public int ViewportFlagsOverrideClear;

        [NativeTypeName("ImGuiTabItemFlags")]
        public int TabItemFlagsOverrideSet;

        [NativeTypeName("ImGuiDockNodeFlags")]
        public int DockNodeFlagsOverrideSet;

        [NativeTypeName("bool")]
        public byte DockingAlwaysTabBar;

        [NativeTypeName("bool")]
        public byte DockingAllowUnclassed;

        public void* PlatformIconData;
    }

    public unsafe partial struct ImGuiPayload_t
    {
        public void* Data;

        public int DataSize;

        [NativeTypeName("ImGuiID")]
        public uint SourceId;

        [NativeTypeName("ImGuiID")]
        public uint SourceParentId;

        public int DataFrameCount;

        [NativeTypeName("char[33]")]
        public _DataType_e__FixedBuffer DataType;

        [NativeTypeName("bool")]
        public byte Preview;

        [NativeTypeName("bool")]
        public byte Delivery;

        [InlineArray(33)]
        public partial struct _DataType_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public unsafe partial struct ImGuiTextFilter_ImGuiTextRange_t
    {
        [NativeTypeName("const char *")]
        public sbyte* b;

        [NativeTypeName("const char *")]
        public sbyte* e;
    }

    public partial struct ImGuiTextFilter_t
    {
        [NativeTypeName("char[256]")]
        public _InputBuf_e__FixedBuffer InputBuf;

        [NativeTypeName("ImVector_ImGuiTextRange")]
        public ImVector_ImGuiTextRange_t Filters;

        public int CountGrep;

        [InlineArray(256)]
        public partial struct _InputBuf_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct ImGuiTextBuffer_t
    {
        [NativeTypeName("ImVector_char")]
        public ImVector_char_t Buf;
    }

    public unsafe partial struct ImGuiStoragePair_t
    {
        [NativeTypeName("ImGuiID")]
        public uint key;

        [NativeTypeName("__AnonymousRecord_cimgui_L3048_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref int val_i
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.val_i;
            }
        }

        [UnscopedRef]
        public ref float val_f
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.val_f;
            }
        }

        [UnscopedRef]
        public ref void* val_p
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.val_p;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public int val_i;

            [FieldOffset(0)]
            public float val_f;

            [FieldOffset(0)]
            public void* val_p;
        }
    }

    public partial struct ImGuiStorage_t
    {
        [NativeTypeName("ImVector_ImGuiStoragePair")]
        public ImVector_ImGuiStoragePair_t Data;
    }

    public enum ImGuiListClipperFlags_
    {
        ImGuiListClipperFlags_None = 0,
        ImGuiListClipperFlags_NoSetTableRowCounters = 1 << 0,
    }

    public unsafe partial struct ImGuiListClipper_t
    {
        public int DisplayStart;

        public int DisplayEnd;

        public int UserIndex;

        public int ItemsCount;

        public float ItemsHeight;

        [NativeTypeName("ImGuiListClipperFlags")]
        public int Flags;

        public double StartPosY;

        public double StartSeekOffsetY;

        [NativeTypeName("ImGuiContext *")]
        public ImGuiContext_t* Ctx;

        public void* TempData;
    }

    public partial struct ImColor_t
    {
        [NativeTypeName("ImVec4")]
        public ImVec4_t Value;
    }

    public enum ImGuiMultiSelectFlags_
    {
        ImGuiMultiSelectFlags_None = 0,
        ImGuiMultiSelectFlags_SingleSelect = 1 << 0,
        ImGuiMultiSelectFlags_NoSelectAll = 1 << 1,
        ImGuiMultiSelectFlags_NoRangeSelect = 1 << 2,
        ImGuiMultiSelectFlags_NoAutoSelect = 1 << 3,
        ImGuiMultiSelectFlags_NoAutoClear = 1 << 4,
        ImGuiMultiSelectFlags_NoAutoClearOnReselect = 1 << 5,
        ImGuiMultiSelectFlags_BoxSelect1d = 1 << 6,
        ImGuiMultiSelectFlags_BoxSelect2d = 1 << 7,
        ImGuiMultiSelectFlags_BoxSelectNoScroll = 1 << 8,
        ImGuiMultiSelectFlags_ClearOnEscape = 1 << 9,
        ImGuiMultiSelectFlags_ClearOnClickVoid = 1 << 10,
        ImGuiMultiSelectFlags_ScopeWindow = 1 << 11,
        ImGuiMultiSelectFlags_ScopeRect = 1 << 12,
        ImGuiMultiSelectFlags_SelectOnAuto = 1 << 13,
        ImGuiMultiSelectFlags_SelectOnClickAlways = 1 << 14,
        ImGuiMultiSelectFlags_SelectOnClickRelease = 1 << 15,
        ImGuiMultiSelectFlags_NavWrapX = 1 << 16,
        ImGuiMultiSelectFlags_NoSelectOnRightClick = 1 << 17,
        ImGuiMultiSelectFlags_SelectOnMask_ = ImGuiMultiSelectFlags_SelectOnAuto | ImGuiMultiSelectFlags_SelectOnClickAlways | ImGuiMultiSelectFlags_SelectOnClickRelease,
        ImGuiMultiSelectFlags_CheckboxMode_ = 1 << 20,
        ImGuiMultiSelectFlags_SelectOnClick = ImGuiMultiSelectFlags_SelectOnAuto,
    }

    public partial struct ImGuiMultiSelectIO_t
    {
        [NativeTypeName("ImVector_ImGuiSelectionRequest")]
        public ImVector_ImGuiSelectionRequest_t Requests;

        [NativeTypeName("ImGuiSelectionUserData")]
        public long RangeSrcItem;

        [NativeTypeName("ImGuiSelectionUserData")]
        public long NavIdItem;

        [NativeTypeName("bool")]
        public byte NavIdSelected;

        [NativeTypeName("bool")]
        public byte RangeSrcReset;

        public int ItemsCount;
    }

    public enum ImGuiSelectionRequestType
    {
        ImGuiSelectionRequestType_None = 0,
        ImGuiSelectionRequestType_SetAll,
        ImGuiSelectionRequestType_SetRange,
    }

    public partial struct ImGuiSelectionRequest_t
    {
        public ImGuiSelectionRequestType Type;

        [NativeTypeName("bool")]
        public byte Selected;

        [NativeTypeName("ImS8")]
        public sbyte RangeDirection;

        [NativeTypeName("ImGuiSelectionUserData")]
        public long RangeFirstItem;

        [NativeTypeName("ImGuiSelectionUserData")]
        public long RangeLastItem;
    }

    public unsafe partial struct ImGuiSelectionBasicStorage_t
    {
        public int Size;

        [NativeTypeName("bool")]
        public byte PreserveOrder;

        public void* UserData;

        [NativeTypeName("ImGuiID (*)(ImGuiSelectionBasicStorage *, int)")]
        public delegate* unmanaged[Cdecl]<ImGuiSelectionBasicStorage_t*, int, uint> AdapterIndexToStorageId;

        public int _SelectionOrder;

        [NativeTypeName("ImGuiStorage")]
        public ImGuiStorage_t _Storage;
    }

    public unsafe partial struct ImGuiSelectionExternalStorage_t
    {
        public void* UserData;

        [NativeTypeName("void (*)(ImGuiSelectionExternalStorage *, int, bool)")]
        public delegate* unmanaged[Cdecl]<ImGuiSelectionExternalStorage_t*, int, byte, void> AdapterSetItemSelected;
    }

    public unsafe partial struct ImDrawCmd_t
    {
        [NativeTypeName("ImVec4")]
        public ImVec4_t ClipRect;

        [NativeTypeName("ImTextureRef")]
        public ImTextureRef_t TexRef;

        [NativeTypeName("unsigned int")]
        public uint VtxOffset;

        [NativeTypeName("unsigned int")]
        public uint IdxOffset;

        [NativeTypeName("unsigned int")]
        public uint ElemCount;

        [NativeTypeName("ImDrawCallback")]
        public delegate* unmanaged[Cdecl]<ImDrawList_t*, ImDrawCmd_t*, void> UserCallback;

        public void* UserCallbackData;

        public int UserCallbackDataSize;

        public int UserCallbackDataOffset;
    }

    public partial struct ImDrawVert_t
    {
        [NativeTypeName("ImVec2")]
        public ImVec2_t pos;

        [NativeTypeName("ImVec2")]
        public ImVec2_t uv;

        [NativeTypeName("ImU32")]
        public uint col;
    }

    public partial struct ImDrawCmdHeader_t
    {
        [NativeTypeName("ImVec4")]
        public ImVec4_t ClipRect;

        [NativeTypeName("ImTextureRef")]
        public ImTextureRef_t TexRef;

        [NativeTypeName("unsigned int")]
        public uint VtxOffset;
    }

    public partial struct ImDrawChannel_t
    {
        [NativeTypeName("ImVector_ImDrawCmd")]
        public ImVector_ImDrawCmd_t _CmdBuffer;

        [NativeTypeName("ImVector_ImDrawIdx")]
        public ImVector_ImDrawIdx_t _IdxBuffer;
    }

    public partial struct ImDrawListSplitter_t
    {
        public int _Current;

        public int _Count;

        [NativeTypeName("ImVector_ImDrawChannel")]
        public ImVector_ImDrawChannel_t _Channels;
    }

    public enum ImDrawFlags_
    {
        ImDrawFlags_None = 0,
        ImDrawFlags_RoundCornersTopLeft = 1 << 4,
        ImDrawFlags_RoundCornersTopRight = 1 << 5,
        ImDrawFlags_RoundCornersBottomLeft = 1 << 6,
        ImDrawFlags_RoundCornersBottomRight = 1 << 7,
        ImDrawFlags_RoundCornersNone = 1 << 8,
        ImDrawFlags_RoundCornersAll = ImDrawFlags_RoundCornersTopLeft | ImDrawFlags_RoundCornersTopRight | ImDrawFlags_RoundCornersBottomLeft | ImDrawFlags_RoundCornersBottomRight,
        ImDrawFlags_RoundCornersDefault_ = ImDrawFlags_RoundCornersAll,
        ImDrawFlags_RoundCornersTop = ImDrawFlags_RoundCornersTopLeft | ImDrawFlags_RoundCornersTopRight,
        ImDrawFlags_RoundCornersBottom = ImDrawFlags_RoundCornersBottomLeft | ImDrawFlags_RoundCornersBottomRight,
        ImDrawFlags_RoundCornersLeft = ImDrawFlags_RoundCornersBottomLeft | ImDrawFlags_RoundCornersTopLeft,
        ImDrawFlags_RoundCornersRight = ImDrawFlags_RoundCornersBottomRight | ImDrawFlags_RoundCornersTopRight,
        ImDrawFlags_RoundCornersMask_ = ImDrawFlags_RoundCornersAll | ImDrawFlags_RoundCornersNone,
        ImDrawFlags_Closed = 1 << 9,
        ImDrawFlags_InvalidMask_ = ~0x7FFFFFF0,
    }

    public enum ImDrawListFlags_
    {
        ImDrawListFlags_None = 0,
        ImDrawListFlags_AntiAliasedLines = 1 << 0,
        ImDrawListFlags_AntiAliasedLinesUseTex = 1 << 1,
        ImDrawListFlags_AntiAliasedFill = 1 << 2,
        ImDrawListFlags_AllowVtxOffset = 1 << 3,
        ImDrawListFlags_TextNoPixelSnap = 1 << 4,
    }

    public unsafe partial struct ImDrawList_t
    {
        [NativeTypeName("ImVector_ImDrawCmd")]
        public ImVector_ImDrawCmd_t CmdBuffer;

        [NativeTypeName("ImVector_ImDrawIdx")]
        public ImVector_ImDrawIdx_t IdxBuffer;

        [NativeTypeName("ImVector_ImDrawVert")]
        public ImVector_ImDrawVert_t VtxBuffer;

        [NativeTypeName("ImDrawListFlags")]
        public int Flags;

        [NativeTypeName("unsigned int")]
        public uint _VtxCurrentIdx;

        [NativeTypeName("ImDrawListSharedData *")]
        public ImDrawListSharedData_t* _Data;

        [NativeTypeName("ImDrawVert *")]
        public ImDrawVert_t* _VtxWritePtr;

        [NativeTypeName("ImDrawIdx *")]
        public ushort* _IdxWritePtr;

        [NativeTypeName("ImVector_ImVec2")]
        public ImVector_ImVec2_t _Path;

        [NativeTypeName("ImDrawCmdHeader")]
        public ImDrawCmdHeader_t _CmdHeader;

        [NativeTypeName("ImDrawListSplitter")]
        public ImDrawListSplitter_t _Splitter;

        [NativeTypeName("ImVector_ImVec4")]
        public ImVector_ImVec4_t _ClipRectStack;

        [NativeTypeName("ImVector_ImTextureRef")]
        public ImVector_ImTextureRef_t _TextureStack;

        [NativeTypeName("ImVector_ImU8")]
        public ImVector_ImU8_t _CallbacksDataBuf;

        public float _FringeScale;

        [NativeTypeName("const char *")]
        public sbyte* _OwnerName;
    }

    public unsafe partial struct ImDrawData_t
    {
        [NativeTypeName("bool")]
        public byte Valid;

        public int FrameCount;

        public int TotalIdxCount;

        public int TotalVtxCount;

        [NativeTypeName("ImVector_ImDrawListPtr")]
        public ImVector_ImDrawListPtr_t CmdLists;

        [NativeTypeName("ImVec2")]
        public ImVec2_t DisplayPos;

        [NativeTypeName("ImVec2")]
        public ImVec2_t DisplaySize;

        [NativeTypeName("ImVec2")]
        public ImVec2_t FramebufferScale;

        [NativeTypeName("ImGuiViewport *")]
        public ImGuiViewport_t* OwnerViewport;

        [NativeTypeName("ImVector_ImTextureDataPtr *")]
        public ImVector_ImTextureDataPtr_t* Textures;

        public int CmdListsCount;
    }

    public enum ImTextureFormat
    {
        ImTextureFormat_RGBA32,
        ImTextureFormat_Alpha8,
    }

    public enum ImTextureStatus
    {
        ImTextureStatus_OK,
        ImTextureStatus_Destroyed,
        ImTextureStatus_WantCreate,
        ImTextureStatus_WantUpdates,
        ImTextureStatus_WantDestroy,
    }

    public partial struct ImTextureRect_t
    {
        [NativeTypeName("unsigned short")]
        public ushort x;

        [NativeTypeName("unsigned short")]
        public ushort y;

        [NativeTypeName("unsigned short")]
        public ushort w;

        [NativeTypeName("unsigned short")]
        public ushort h;
    }

    public unsafe partial struct ImTextureData_t
    {
        public int UniqueID;

        public ImTextureStatus Status;

        public void* BackendUserData;

        public void* QueueUserData;

        [NativeTypeName("ImTextureID")]
        public ulong TexID;

        public ImTextureFormat Format;

        public int Width;

        public int Height;

        public int BytesPerPixel;

        [NativeTypeName("unsigned char *")]
        public byte* Pixels;

        [NativeTypeName("ImTextureRect")]
        public ImTextureRect_t UsedRect;

        [NativeTypeName("ImTextureRect")]
        public ImTextureRect_t UpdateRect;

        [NativeTypeName("ImVector_ImTextureRect")]
        public ImVector_ImTextureRect_t Updates;

        public int UnusedFrames;

        [NativeTypeName("unsigned short")]
        public ushort RefCount;

        [NativeTypeName("bool")]
        public byte UseColors;

        [NativeTypeName("bool")]
        public byte WantDestroyNextFrame;
    }

    public unsafe partial struct ImFontConfig_t
    {
        [NativeTypeName("char[40]")]
        public _Name_e__FixedBuffer Name;

        public void* FontData;

        public int FontDataSize;

        [NativeTypeName("bool")]
        public byte FontDataOwnedByAtlas;

        [NativeTypeName("bool")]
        public byte MergeMode;

        [NativeTypeName("bool")]
        public byte PixelSnapH;

        [NativeTypeName("ImS8")]
        public sbyte OversampleH;

        [NativeTypeName("ImS8")]
        public sbyte OversampleV;

        [NativeTypeName("ImWchar")]
        public ushort EllipsisChar;

        public float SizePixels;

        [NativeTypeName("const ImWchar *")]
        public ushort* GlyphRanges;

        [NativeTypeName("const ImWchar *")]
        public ushort* GlyphExcludeRanges;

        [NativeTypeName("ImVec2")]
        public ImVec2_t GlyphOffset;

        public float GlyphMinAdvanceX;

        public float GlyphMaxAdvanceX;

        public float GlyphExtraAdvanceX;

        [NativeTypeName("ImU32")]
        public uint FontNo;

        [NativeTypeName("unsigned int")]
        public uint FontLoaderFlags;

        public float RasterizerMultiply;

        public float RasterizerDensity;

        public float ExtraSizeScale;

        [NativeTypeName("ImFontFlags")]
        public int Flags;

        [NativeTypeName("ImFont *")]
        public ImFont_t* DstFont;

        [NativeTypeName("const ImFontLoader *")]
        public ImFontLoader_t* FontLoader;

        public void* FontLoaderData;

        [NativeTypeName("bool")]
        public byte PixelSnapV;

        [InlineArray(40)]
        public partial struct _Name_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct ImFontGlyph_t
    {
        public uint _bitfield;

        [NativeTypeName("unsigned int : 1")]
        public uint Colored
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _bitfield & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        [NativeTypeName("unsigned int : 1")]
        public uint Visible
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 1) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
            }
        }

        [NativeTypeName("unsigned int : 4")]
        public uint SourceIdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 2) & 0xFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFu << 2)) | ((value & 0xFu) << 2);
            }
        }

        [NativeTypeName("unsigned int : 26")]
        public uint Codepoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 6) & 0x3FFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFu << 6)) | ((value & 0x3FFFFFFu) << 6);
            }
        }

        public float AdvanceX;

        public float X0;

        public float Y0;

        public float X1;

        public float Y1;

        public float U0;

        public float V0;

        public float U1;

        public float V1;

        public int PackId;
    }

    public partial struct ImFontGlyphRangesBuilder_t
    {
        [NativeTypeName("ImVector_ImU32")]
        public ImVector_ImU32_t UsedChars;
    }

    public partial struct ImFontAtlasRect_t
    {
        [NativeTypeName("unsigned short")]
        public ushort x;

        [NativeTypeName("unsigned short")]
        public ushort y;

        [NativeTypeName("unsigned short")]
        public ushort w;

        [NativeTypeName("unsigned short")]
        public ushort h;

        [NativeTypeName("ImVec2")]
        public ImVec2_t uv0;

        [NativeTypeName("ImVec2")]
        public ImVec2_t uv1;
    }

    public enum ImFontAtlasFlags_
    {
        ImFontAtlasFlags_None = 0,
        ImFontAtlasFlags_NoPowerOfTwoHeight = 1 << 0,
        ImFontAtlasFlags_NoMouseCursors = 1 << 1,
        ImFontAtlasFlags_NoBakedLines = 1 << 2,
    }

    public unsafe partial struct ImFontAtlas_t
    {
        [NativeTypeName("ImFontAtlasFlags")]
        public int Flags;

        public ImTextureFormat TexDesiredFormat;

        public int TexGlyphPadding;

        public int TexMinWidth;

        public int TexMinHeight;

        public int TexMaxWidth;

        public int TexMaxHeight;

        public void* UserData;

        [NativeTypeName("__AnonymousRecord_cimgui_L3884_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ImTextureData *")]
        public ImTextureData_t* TexData;

        [NativeTypeName("ImVector_ImTextureDataPtr")]
        public ImVector_ImTextureDataPtr_t TexList;

        [NativeTypeName("bool")]
        public byte Locked;

        [NativeTypeName("bool")]
        public byte RendererHasTextures;

        [NativeTypeName("bool")]
        public byte TexIsBuilt;

        [NativeTypeName("bool")]
        public byte TexPixelsUseColors;

        [NativeTypeName("ImVec2")]
        public ImVec2_t TexUvScale;

        [NativeTypeName("ImVec2")]
        public ImVec2_t TexUvWhitePixel;

        [NativeTypeName("ImVector_ImFontPtr")]
        public ImVector_ImFontPtr_t Fonts;

        [NativeTypeName("ImVector_ImFontConfig")]
        public ImVector_ImFontConfig_t Sources;

        [NativeTypeName("ImVec4[33]")]
        public _TexUvLines_e__FixedBuffer TexUvLines;

        public int TexNextUniqueID;

        public int FontNextUniqueID;

        [NativeTypeName("ImVector_ImDrawListSharedDataPtr")]
        public ImVector_ImDrawListSharedDataPtr_t DrawListSharedDatas;

        [NativeTypeName("ImFontAtlasBuilder *")]
        public ImFontAtlasBuilder_t* Builder;

        [NativeTypeName("const ImFontLoader *")]
        public ImFontLoader_t* FontLoader;

        [NativeTypeName("const char *")]
        public sbyte* FontLoaderName;

        public void* FontLoaderData;

        [NativeTypeName("unsigned int")]
        public uint FontLoaderFlags;

        public int RefCount;

        [NativeTypeName("ImGuiContext *")]
        public ImGuiContext_t* OwnerContext;

        [NativeTypeName("ImFontAtlasRect")]
        public ImFontAtlasRect_t TempRect;

        [UnscopedRef]
        public ref ImTextureRef_t TexRef
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.TexRef;
            }
        }

        [UnscopedRef]
        public ref ImTextureRef_t TexID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.TexID;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ImTextureRef")]
            public ImTextureRef_t TexRef;

            [FieldOffset(0)]
            [NativeTypeName("ImTextureRef")]
            public ImTextureRef_t TexID;
        }

        [InlineArray(33)]
        public partial struct _TexUvLines_e__FixedBuffer
        {
            public ImVec4_t e0;
        }
    }

    public unsafe partial struct ImFontBaked_t
    {
        [NativeTypeName("ImVector_float")]
        public ImVector_float_t IndexAdvanceX;

        public float FallbackAdvanceX;

        public float Size;

        public float RasterizerDensity;

        [NativeTypeName("ImVector_ImU16")]
        public ImVector_ImU16_t IndexLookup;

        [NativeTypeName("ImVector_ImFontGlyph")]
        public ImVector_ImFontGlyph_t Glyphs;

        public int FallbackGlyphIndex;

        public float Ascent;

        public float Descent;

        public uint _bitfield;

        [NativeTypeName("unsigned int : 26")]
        public uint MetricsTotalSurface
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _bitfield & 0x3FFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x3FFFFFFu) | (value & 0x3FFFFFFu);
            }
        }

        [NativeTypeName("unsigned int : 1")]
        public uint WantDestroy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 26) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 26)) | ((value & 0x1u) << 26);
            }
        }

        [NativeTypeName("unsigned int : 1")]
        public uint LoadNoFallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 27) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 27)) | ((value & 0x1u) << 27);
            }
        }

        [NativeTypeName("unsigned int : 1")]
        public uint LoadNoRenderOnLayout
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 28) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 28)) | ((value & 0x1u) << 28);
            }
        }

        public int LastUsedFrame;

        [NativeTypeName("ImGuiID")]
        public uint BakedId;

        [NativeTypeName("ImFont *")]
        public ImFont_t* OwnerFont;

        public void* FontLoaderDatas;
    }

    public enum ImFontFlags_
    {
        ImFontFlags_None = 0,
        ImFontFlags_NoLoadError = 1 << 1,
        ImFontFlags_NoLoadGlyphs = 1 << 2,
        ImFontFlags_LockBakedSizes = 1 << 3,
        ImFontFlags_ImplicitRefSize = 1 << 4,
    }

    public unsafe partial struct ImFont_t
    {
        [NativeTypeName("ImFontBaked *")]
        public ImFontBaked_t* LastBaked;

        [NativeTypeName("ImFontAtlas *")]
        public ImFontAtlas_t* OwnerAtlas;

        [NativeTypeName("ImFontFlags")]
        public int Flags;

        public float CurrentRasterizerDensity;

        [NativeTypeName("ImGuiID")]
        public uint FontId;

        public float LegacySize;

        [NativeTypeName("ImVector_ImFontConfigPtr")]
        public ImVector_ImFontConfigPtr_t Sources;

        [NativeTypeName("ImWchar")]
        public ushort EllipsisChar;

        [NativeTypeName("ImWchar")]
        public ushort FallbackChar;

        [NativeTypeName("ImU8[1]")]
        public _Used8kPagesMap_e__FixedBuffer Used8kPagesMap;

        [NativeTypeName("bool")]
        public byte EllipsisAutoBake;

        [NativeTypeName("ImGuiStorage")]
        public ImGuiStorage_t RemapPairs;

        public float Scale;

        public partial struct _Used8kPagesMap_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public enum ImGuiViewportFlags_
    {
        ImGuiViewportFlags_None = 0,
        ImGuiViewportFlags_IsPlatformWindow = 1 << 0,
        ImGuiViewportFlags_IsPlatformMonitor = 1 << 1,
        ImGuiViewportFlags_OwnedByApp = 1 << 2,
        ImGuiViewportFlags_NoDecoration = 1 << 3,
        ImGuiViewportFlags_NoTaskBarIcon = 1 << 4,
        ImGuiViewportFlags_NoFocusOnAppearing = 1 << 5,
        ImGuiViewportFlags_NoFocusOnClick = 1 << 6,
        ImGuiViewportFlags_NoInputs = 1 << 7,
        ImGuiViewportFlags_NoRendererClear = 1 << 8,
        ImGuiViewportFlags_NoAutoMerge = 1 << 9,
        ImGuiViewportFlags_TopMost = 1 << 10,
        ImGuiViewportFlags_CanHostOtherWindows = 1 << 11,
        ImGuiViewportFlags_IsMinimized = 1 << 12,
        ImGuiViewportFlags_IsFocused = 1 << 13,
    }

    public unsafe partial struct ImGuiViewport_t
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiViewportFlags")]
        public int Flags;

        [NativeTypeName("ImVec2")]
        public ImVec2_t Pos;

        [NativeTypeName("ImVec2")]
        public ImVec2_t Size;

        [NativeTypeName("ImVec2")]
        public ImVec2_t FramebufferScale;

        [NativeTypeName("ImVec2")]
        public ImVec2_t WorkPos;

        [NativeTypeName("ImVec2")]
        public ImVec2_t WorkSize;

        public float DpiScale;

        [NativeTypeName("ImGuiID")]
        public uint ParentViewportId;

        [NativeTypeName("ImGuiViewport *")]
        public ImGuiViewport_t* ParentViewport;

        [NativeTypeName("ImDrawData *")]
        public ImDrawData_t* DrawData;

        public void* RendererUserData;

        public void* PlatformUserData;

        public void* PlatformIconData;

        public void* PlatformHandle;

        public void* PlatformHandleRaw;

        [NativeTypeName("bool")]
        public byte PlatformWindowCreated;

        [NativeTypeName("bool")]
        public byte PlatformRequestMove;

        [NativeTypeName("bool")]
        public byte PlatformRequestResize;

        [NativeTypeName("bool")]
        public byte PlatformRequestClose;
    }

    public unsafe partial struct ImGuiPlatformIO_t
    {
        [NativeTypeName("const char *(*)(ImGuiContext *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext_t*, sbyte*> Platform_GetClipboardTextFn;

        [NativeTypeName("void (*)(ImGuiContext *, const char *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext_t*, sbyte*, void> Platform_SetClipboardTextFn;

        public void* Platform_ClipboardUserData;

        [NativeTypeName("bool (*)(ImGuiContext *, const char *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext_t*, sbyte*, byte> Platform_OpenInShellFn;

        public void* Platform_OpenInShellUserData;

        [NativeTypeName("void (*)(ImGuiContext *, ImGuiViewport *, ImGuiPlatformImeData *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext_t*, ImGuiViewport_t*, ImGuiPlatformImeData_t*, void> Platform_SetImeDataFn;

        public void* Platform_ImeUserData;

        [NativeTypeName("ImWchar")]
        public ushort Platform_LocaleDecimalPoint;

        public int Platform_SessionDate;

        public int Renderer_TextureMaxWidth;

        public int Renderer_TextureMaxHeight;

        public void* Renderer_RenderState;

        [NativeTypeName("ImDrawCallback")]
        public delegate* unmanaged[Cdecl]<ImDrawList_t*, ImDrawCmd_t*, void> DrawCallback_ResetRenderState;

        [NativeTypeName("ImDrawCallback")]
        public delegate* unmanaged[Cdecl]<ImDrawList_t*, ImDrawCmd_t*, void> DrawCallback_SetSamplerLinear;

        [NativeTypeName("ImDrawCallback")]
        public delegate* unmanaged[Cdecl]<ImDrawList_t*, ImDrawCmd_t*, void> DrawCallback_SetSamplerNearest;

        [NativeTypeName("void (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void> Platform_CreateWindow;

        [NativeTypeName("void (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void> Platform_DestroyWindow;

        [NativeTypeName("void (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void> Platform_ShowWindow;

        [NativeTypeName("void (*)(ImGuiViewport *, ImVec2)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec2_t, void> Platform_SetWindowPos;

        [NativeTypeName("ImVec2 (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec2_t> Platform_GetWindowPos;

        [NativeTypeName("void (*)(ImGuiViewport *, ImVec2)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec2_t, void> Platform_SetWindowSize;

        [NativeTypeName("ImVec2 (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec2_t> Platform_GetWindowSize;

        [NativeTypeName("ImVec2 (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec2_t> Platform_GetWindowFramebufferScale;

        [NativeTypeName("void (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void> Platform_SetWindowFocus;

        [NativeTypeName("bool (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, byte> Platform_GetWindowFocus;

        [NativeTypeName("bool (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, byte> Platform_GetWindowMinimized;

        [NativeTypeName("void (*)(ImGuiViewport *, const char *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, sbyte*, void> Platform_SetWindowTitle;

        [NativeTypeName("void (*)(ImGuiViewport *, float)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, float, void> Platform_SetWindowAlpha;

        [NativeTypeName("void (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void> Platform_UpdateWindow;

        [NativeTypeName("void (*)(ImGuiViewport *, void *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void*, void> Platform_RenderWindow;

        [NativeTypeName("void (*)(ImGuiViewport *, void *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void*, void> Platform_SwapBuffers;

        [NativeTypeName("float (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, float> Platform_GetWindowDpiScale;

        [NativeTypeName("void (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void> Platform_OnChangedViewport;

        [NativeTypeName("ImVec4 (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec4_t> Platform_GetWindowWorkAreaInsets;

        [NativeTypeName("int (*)(ImGuiViewport *, ImU64, const void *, ImU64 *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ulong, void*, ulong*, int> Platform_CreateVkSurface;

        [NativeTypeName("void (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void> Renderer_CreateWindow;

        [NativeTypeName("void (*)(ImGuiViewport *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void> Renderer_DestroyWindow;

        [NativeTypeName("void (*)(ImGuiViewport *, ImVec2)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec2_t, void> Renderer_SetWindowSize;

        [NativeTypeName("void (*)(ImGuiViewport *, void *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void*, void> Renderer_RenderWindow;

        [NativeTypeName("void (*)(ImGuiViewport *, void *)")]
        public delegate* unmanaged[Cdecl]<ImGuiViewport_t*, void*, void> Renderer_SwapBuffers;

        [NativeTypeName("ImVector_ImGuiPlatformMonitor")]
        public ImVector_ImGuiPlatformMonitor_t Monitors;

        [NativeTypeName("ImVector_ImTextureDataPtr")]
        public ImVector_ImTextureDataPtr_t Textures;

        [NativeTypeName("ImVector_ImGuiViewportPtr")]
        public ImVector_ImGuiViewportPtr_t Viewports;
    }

    public unsafe partial struct ImGuiPlatformMonitor_t
    {
        [NativeTypeName("ImVec2")]
        public ImVec2_t MainPos;

        [NativeTypeName("ImVec2")]
        public ImVec2_t MainSize;

        [NativeTypeName("ImVec2")]
        public ImVec2_t WorkPos;

        [NativeTypeName("ImVec2")]
        public ImVec2_t WorkSize;

        public float DpiScale;

        public void* PlatformHandle;
    }

    public partial struct ImGuiPlatformImeData_t
    {
        [NativeTypeName("bool")]
        public byte WantVisible;

        [NativeTypeName("bool")]
        public byte WantTextInput;

        [NativeTypeName("ImVec2")]
        public ImVec2_t InputPos;

        public float InputLineHeight;

        [NativeTypeName("ImGuiID")]
        public uint ViewportId;
    }

    public enum simgui_log_item_t
    {
        SIMGUI_LOGITEM_OK,
        SIMGUI_LOGITEM_MALLOC_FAILED,
        SIMGUI_LOGITEM_BUFFER_OVERFLOW,
    }

    public unsafe partial struct simgui_allocator_t
    {
        [NativeTypeName("void *(*)(size_t, void *)")]
        public delegate* unmanaged[Cdecl]<nuint, void*, void*> alloc_fn;

        [NativeTypeName("void (*)(void *, void *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, void> free_fn;

        public void* user_data;
    }

    public unsafe partial struct simgui_logger_t
    {
        [NativeTypeName("void (*)(const char *, uint32_t, uint32_t, const char *, uint32_t, const char *, void *)")]
        public delegate* unmanaged[Cdecl]<sbyte*, uint, uint, sbyte*, uint, sbyte*, void*, void> func;

        public void* user_data;
    }

    public unsafe partial struct simgui_desc_t
    {
        public int max_vertices;

        public sg_pixel_format color_format;

        public sg_pixel_format depth_format;

        public int sample_count;

        [NativeTypeName("const char *")]
        public sbyte* ini_filename;

        [NativeTypeName("bool")]
        public byte no_default_font;

        [NativeTypeName("bool")]
        public byte disable_paste_override;

        [NativeTypeName("bool")]
        public byte disable_set_mouse_cursor;

        [NativeTypeName("bool")]
        public byte disable_windows_resize_from_edges;

        [NativeTypeName("bool")]
        public byte write_alpha_channel;

        public simgui_allocator_t allocator;

        public simgui_logger_t logger;
    }

    public partial struct simgui_frame_desc_t
    {
        public int width;

        public int height;

        public double delta_time;

        public float dpi_scale;
    }

    public partial struct simgui_font_tex_desc_t
    {
        public sg_filter min_filter;

        public sg_filter mag_filter;
    }

    public static unsafe partial class ImGUI
    {
        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImTextureID")]
        public static extern ulong ImTextureRef_GetTexID([NativeTypeName("const ImTextureRef *")] ImTextureRef_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiContext *")]
        public static extern ImGuiContext_t* igCreateContext([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* shared_font_atlas);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDestroyContext([NativeTypeName("ImGuiContext *")] ImGuiContext_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiContext *")]
        public static extern ImGuiContext_t* igGetCurrentContext();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCurrentContext([NativeTypeName("ImGuiContext *")] ImGuiContext_t* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiIO *")]
        public static extern ImGuiIO_t* igGetIO();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiPlatformIO *")]
        public static extern ImGuiPlatformIO_t* igGetPlatformIO();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiStyle *")]
        public static extern ImGuiStyle_t* igGetStyle();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNewFrame();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndFrame();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRender();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImDrawData *")]
        public static extern ImDrawData_t* igGetDrawData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowDemoWindow(bool* p_open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowMetricsWindow(bool* p_open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowDebugLogWindow(bool* p_open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowIDStackToolWindow();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowIDStackToolWindowEx(bool* p_open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowAboutWindow(bool* p_open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowStyleEditor([NativeTypeName("ImGuiStyle *")] ImGuiStyle_t* @ref);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igShowStyleSelector([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowFontSelector([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowUserGuide();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igGetVersion();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igStyleColorsDark([NativeTypeName("ImGuiStyle *")] ImGuiStyle_t* dst);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igStyleColorsLight([NativeTypeName("ImGuiStyle *")] ImGuiStyle_t* dst);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igStyleColorsClassic([NativeTypeName("ImGuiStyle *")] ImGuiStyle_t* dst);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBegin([NativeTypeName("const char *")] sbyte* name, bool* p_open, [NativeTypeName("ImGuiWindowFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEnd();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginChild([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImVec2")] ImVec2_t size, [NativeTypeName("ImGuiChildFlags")] int child_flags, [NativeTypeName("ImGuiWindowFlags")] int window_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginChildID([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImVec2")] ImVec2_t size, [NativeTypeName("ImGuiChildFlags")] int child_flags, [NativeTypeName("ImGuiWindowFlags")] int window_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndChild();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsWindowAppearing();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsWindowCollapsed();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsWindowFocused([NativeTypeName("ImGuiFocusedFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsWindowHovered([NativeTypeName("ImGuiHoveredFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImDrawList *")]
        public static extern ImDrawList_t* igGetWindowDrawList();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetWindowDpiScale();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetWindowPos();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetWindowSize();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetWindowWidth();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetWindowHeight();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiViewport *")]
        public static extern ImGuiViewport_t* igGetWindowViewport();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowPos([NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowPosEx([NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImGuiCond")] int cond, [NativeTypeName("ImVec2")] ImVec2_t pivot);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowSize([NativeTypeName("ImVec2")] ImVec2_t size, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowSizeConstraints([NativeTypeName("ImVec2")] ImVec2_t size_min, [NativeTypeName("ImVec2")] ImVec2_t size_max, [NativeTypeName("ImGuiSizeCallback")] delegate* unmanaged[Cdecl]<ImGuiSizeCallbackData_t*, void> custom_callback, void* custom_callback_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowContentSize([NativeTypeName("ImVec2")] ImVec2_t size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowCollapsed([NativeTypeName("bool")] byte collapsed, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowFocus();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowScroll([NativeTypeName("ImVec2")] ImVec2_t scroll);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowBgAlpha(float alpha);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowViewport([NativeTypeName("ImGuiID")] uint viewport_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowPos([NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowSize([NativeTypeName("ImVec2")] ImVec2_t size, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowCollapsed([NativeTypeName("bool")] byte collapsed, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowFocus();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowPosStr([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowSizeStr([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("ImVec2")] ImVec2_t size, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowCollapsedStr([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("bool")] byte collapsed, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowFocusStr([NativeTypeName("const char *")] sbyte* name);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetScrollX();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetScrollY();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollX(float scroll_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollY(float scroll_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetScrollMaxX();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetScrollMaxY();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollHereX(float center_x_ratio);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollHereY(float center_y_ratio);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollFromPosX(float local_x, float center_x_ratio);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollFromPosY(float local_y, float center_y_ratio);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushFontFloat([NativeTypeName("ImFont *")] ImFont_t* font, float font_size_base_unscaled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopFont();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFont *")]
        public static extern ImFont_t* igGetFont();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetFontSize();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFontBaked *")]
        public static extern ImFontBaked_t* igGetFontBaked();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleColor([NativeTypeName("ImGuiCol")] int idx, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleColorImVec4([NativeTypeName("ImGuiCol")] int idx, [NativeTypeName("ImVec4")] ImVec4_t col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopStyleColor();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopStyleColorEx(int count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleVar([NativeTypeName("ImGuiStyleVar")] int idx, float val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleVarImVec2([NativeTypeName("ImGuiStyleVar")] int idx, [NativeTypeName("ImVec2")] ImVec2_t val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleVarX([NativeTypeName("ImGuiStyleVar")] int idx, float val_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleVarY([NativeTypeName("ImGuiStyleVar")] int idx, float val_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopStyleVar();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopStyleVarEx(int count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushItemFlag([NativeTypeName("ImGuiItemFlags")] int option, [NativeTypeName("bool")] byte enabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopItemFlag();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushItemWidth(float item_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopItemWidth();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemWidth(float item_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igCalcItemWidth();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushTextWrapPos(float wrap_local_pos_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopTextWrapPos();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetFontTexUvWhitePixel();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igGetColorU32([NativeTypeName("ImGuiCol")] int idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igGetColorU32Ex([NativeTypeName("ImGuiCol")] int idx, float alpha_mul);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igGetColorU32ImVec4([NativeTypeName("ImVec4")] ImVec4_t col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igGetColorU32ImU32([NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igGetColorU32ImU32Ex([NativeTypeName("ImU32")] uint col, float alpha_mul);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImVec4 *")]
        public static extern ImVec4_t* igGetStyleColorVec4([NativeTypeName("ImGuiCol")] int idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetCursorScreenPos();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCursorScreenPos([NativeTypeName("ImVec2")] ImVec2_t pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetContentRegionAvail();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetCursorPos();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetCursorPosX();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetCursorPosY();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCursorPos([NativeTypeName("ImVec2")] ImVec2_t local_pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCursorPosX(float local_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCursorPosY(float local_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetCursorStartPos();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSeparator();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSameLine();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSameLineEx(float offset_from_start_x, float spacing);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNewLine();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSpacing();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDummy([NativeTypeName("ImVec2")] ImVec2_t size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igIndent();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igIndentEx(float indent_w);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igUnindent();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igUnindentEx(float indent_w);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBeginGroup();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndGroup();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igAlignTextToFramePadding();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetTextLineHeight();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetTextLineHeightWithSpacing();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetFrameHeight();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetFrameHeightWithSpacing();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushID([NativeTypeName("const char *")] sbyte* str_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushIDStr([NativeTypeName("const char *")] sbyte* str_id_begin, [NativeTypeName("const char *")] sbyte* str_id_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushIDPtr([NativeTypeName("const void *")] void* ptr_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushIDInt(int int_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopID();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetID([NativeTypeName("const char *")] sbyte* str_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetIDStr([NativeTypeName("const char *")] sbyte* str_id_begin, [NativeTypeName("const char *")] sbyte* str_id_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetIDPtr([NativeTypeName("const void *")] void* ptr_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetIDInt(int int_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextUnformatted([NativeTypeName("const char *")] sbyte* text);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextUnformattedEx([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igText([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextColored([NativeTypeName("ImVec4")] ImVec4_t col, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextColoredV([NativeTypeName("ImVec4")] ImVec4_t col, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextDisabled([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextDisabledV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextWrapped([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextWrappedV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLabelText([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLabelTextV([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBulletText([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBulletTextV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSeparatorText([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igButton([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igButtonEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImVec2")] ImVec2_t size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSmallButton([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInvisibleButton([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImVec2")] ImVec2_t size, [NativeTypeName("ImGuiButtonFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igArrowButton([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiDir")] int dir);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCheckbox([NativeTypeName("const char *")] sbyte* label, bool* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCheckboxFlagsIntPtr([NativeTypeName("const char *")] sbyte* label, int* flags, int flags_value);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCheckboxFlagsUintPtr([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("unsigned int *")] uint* flags, [NativeTypeName("unsigned int")] uint flags_value);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igRadioButton([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("bool")] byte active);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igRadioButtonIntPtr([NativeTypeName("const char *")] sbyte* label, int* v, int v_button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igProgressBar(float fraction, [NativeTypeName("ImVec2")] ImVec2_t size_arg, [NativeTypeName("const char *")] sbyte* overlay);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBullet();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTextLink([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTextLinkOpenURL([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTextLinkOpenURLEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* url);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImage([NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t image_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImageEx([NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t image_size, [NativeTypeName("ImVec2")] ImVec2_t uv0, [NativeTypeName("ImVec2")] ImVec2_t uv1);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImageWithBg([NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t image_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImageWithBgEx([NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t image_size, [NativeTypeName("ImVec2")] ImVec2_t uv0, [NativeTypeName("ImVec2")] ImVec2_t uv1, [NativeTypeName("ImVec4")] ImVec4_t bg_col, [NativeTypeName("ImVec4")] ImVec4_t tint_col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImageButton([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t image_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImageButtonEx([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t image_size, [NativeTypeName("ImVec2")] ImVec2_t uv0, [NativeTypeName("ImVec2")] ImVec2_t uv1, [NativeTypeName("ImVec4")] ImVec4_t bg_col, [NativeTypeName("ImVec4")] ImVec4_t tint_col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginCombo([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* preview_value, [NativeTypeName("ImGuiComboFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndCombo();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igComboChar([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *const[]")] sbyte** items, int items_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igComboCharEx([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *const[]")] sbyte** items, int items_count, int popup_max_height_in_items);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCombo([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *")] sbyte* items_separated_by_zeros);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igComboEx([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *")] sbyte* items_separated_by_zeros, int popup_max_height_in_items);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igComboCallback([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *(*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, sbyte*> getter, void* user_data, int items_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igComboCallbackEx([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *(*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, sbyte*> getter, void* user_data, int items_count, int popup_max_height_in_items);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat([NativeTypeName("const char *")] sbyte* label, float* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloatEx([NativeTypeName("const char *")] sbyte* label, float* v, float v_speed, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[2]")] float* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat2Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[2]")] float* v, float v_speed, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat3Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* v, float v_speed, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat4Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* v, float v_speed, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloatRange2([NativeTypeName("const char *")] sbyte* label, float* v_current_min, float* v_current_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloatRange2Ex([NativeTypeName("const char *")] sbyte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("const char *")] sbyte* format_max, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt([NativeTypeName("const char *")] sbyte* label, int* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragIntEx([NativeTypeName("const char *")] sbyte* label, int* v, float v_speed, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[2]")] int* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt2Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[2]")] int* v, float v_speed, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[3]")] int* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt3Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[3]")] int* v, float v_speed, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[4]")] int* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt4Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[4]")] int* v, float v_speed, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragIntRange2([NativeTypeName("const char *")] sbyte* label, int* v_current_min, int* v_current_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragIntRange2Ex([NativeTypeName("const char *")] sbyte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("const char *")] sbyte* format_max, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragScalar([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragScalarEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, float v_speed, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragScalarN([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, int components);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragScalarNEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, int components, float v_speed, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat([NativeTypeName("const char *")] sbyte* label, float* v, float v_min, float v_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloatEx([NativeTypeName("const char *")] sbyte* label, float* v, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[2]")] float* v, float v_min, float v_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat2Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[2]")] float* v, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* v, float v_min, float v_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat3Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* v, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* v, float v_min, float v_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat4Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* v, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderAngle([NativeTypeName("const char *")] sbyte* label, float* v_rad);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderAngleEx([NativeTypeName("const char *")] sbyte* label, float* v_rad, float v_degrees_min, float v_degrees_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt([NativeTypeName("const char *")] sbyte* label, int* v, int v_min, int v_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderIntEx([NativeTypeName("const char *")] sbyte* label, int* v, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[2]")] int* v, int v_min, int v_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt2Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[2]")] int* v, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[3]")] int* v, int v_min, int v_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt3Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[3]")] int* v, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[4]")] int* v, int v_min, int v_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt4Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[4]")] int* v, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderScalar([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderScalarEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderScalarN([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, int components, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderScalarNEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, int components, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igVSliderFloat([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImVec2")] ImVec2_t size, float* v, float v_min, float v_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igVSliderFloatEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImVec2")] ImVec2_t size, float* v, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igVSliderInt([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImVec2")] ImVec2_t size, int* v, int v_min, int v_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igVSliderIntEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImVec2")] ImVec2_t size, int* v, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igVSliderScalar([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImVec2")] ImVec2_t size, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igVSliderScalarEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImVec2")] ImVec2_t size, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputText([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputTextEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("ImGuiInputTextFlags")] int flags, [NativeTypeName("ImGuiInputTextCallback")] delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData_t*, int> callback, void* user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputTextMultiline([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputTextMultilineEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("ImVec2")] ImVec2_t size, [NativeTypeName("ImGuiInputTextFlags")] int flags, [NativeTypeName("ImGuiInputTextCallback")] delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData_t*, int> callback, void* user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputTextWithHint([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* hint, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputTextWithHintEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* hint, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("ImGuiInputTextFlags")] int flags, [NativeTypeName("ImGuiInputTextCallback")] delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData_t*, int> callback, void* user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat([NativeTypeName("const char *")] sbyte* label, float* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloatEx([NativeTypeName("const char *")] sbyte* label, float* v, float step, float step_fast, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[2]")] float* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat2Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[2]")] float* v, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat3Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* v, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat4Ex([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* v, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputInt([NativeTypeName("const char *")] sbyte* label, int* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputIntEx([NativeTypeName("const char *")] sbyte* label, int* v, int step, int step_fast, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputInt2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[2]")] int* v, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputInt3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[3]")] int* v, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputInt4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[4]")] int* v, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputDouble([NativeTypeName("const char *")] sbyte* label, double* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputDoubleEx([NativeTypeName("const char *")] sbyte* label, double* v, double step, double step_fast, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputScalar([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputScalarEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const void *")] void* p_step, [NativeTypeName("const void *")] void* p_step_fast, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputScalarN([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, int components);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputScalarNEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, int components, [NativeTypeName("const void *")] void* p_step, [NativeTypeName("const void *")] void* p_step_fast, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igColorEdit3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* col, [NativeTypeName("ImGuiColorEditFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igColorEdit4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* col, [NativeTypeName("ImGuiColorEditFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igColorPicker3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* col, [NativeTypeName("ImGuiColorEditFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igColorPicker4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* col, [NativeTypeName("ImGuiColorEditFlags")] int flags, [NativeTypeName("const float *")] float* ref_col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igColorButton([NativeTypeName("const char *")] sbyte* desc_id, [NativeTypeName("ImVec4")] ImVec4_t col, [NativeTypeName("ImGuiColorEditFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igColorButtonEx([NativeTypeName("const char *")] sbyte* desc_id, [NativeTypeName("ImVec4")] ImVec4_t col, [NativeTypeName("ImGuiColorEditFlags")] int flags, [NativeTypeName("ImVec2")] ImVec2_t size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNode([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeStr([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodePtr([NativeTypeName("const void *")] void* ptr_id, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeV([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeVPtr([NativeTypeName("const void *")] void* ptr_id, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiTreeNodeFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeExStr([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiTreeNodeFlags")] int flags, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeExPtr([NativeTypeName("const void *")] void* ptr_id, [NativeTypeName("ImGuiTreeNodeFlags")] int flags, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeExV([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiTreeNodeFlags")] int flags, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeExVPtr([NativeTypeName("const void *")] void* ptr_id, [NativeTypeName("ImGuiTreeNodeFlags")] int flags, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTreePush([NativeTypeName("const char *")] sbyte* str_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTreePushPtr([NativeTypeName("const void *")] void* ptr_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTreePop();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetTreeNodeToLabelSpacing();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCollapsingHeader([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiTreeNodeFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCollapsingHeaderBoolPtr([NativeTypeName("const char *")] sbyte* label, bool* p_visible, [NativeTypeName("ImGuiTreeNodeFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemOpen([NativeTypeName("bool")] byte is_open, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemStorageID([NativeTypeName("ImGuiID")] uint storage_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeGetOpen([NativeTypeName("ImGuiID")] uint storage_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSelectable([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSelectableEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("bool")] byte selected, [NativeTypeName("ImGuiSelectableFlags")] int flags, [NativeTypeName("ImVec2")] ImVec2_t size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSelectableBoolPtr([NativeTypeName("const char *")] sbyte* label, bool* p_selected, [NativeTypeName("ImGuiSelectableFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSelectableBoolPtrEx([NativeTypeName("const char *")] sbyte* label, bool* p_selected, [NativeTypeName("ImGuiSelectableFlags")] int flags, [NativeTypeName("ImVec2")] ImVec2_t size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiMultiSelectIO *")]
        public static extern ImGuiMultiSelectIO_t* igBeginMultiSelect([NativeTypeName("ImGuiMultiSelectFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiMultiSelectIO *")]
        public static extern ImGuiMultiSelectIO_t* igBeginMultiSelectEx([NativeTypeName("ImGuiMultiSelectFlags")] int flags, int selection_size, int items_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiMultiSelectIO *")]
        public static extern ImGuiMultiSelectIO_t* igEndMultiSelect();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemSelectionUserData([NativeTypeName("ImGuiSelectionUserData")] long selection_user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemToggledSelection();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginListBox([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImVec2")] ImVec2_t size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndListBox();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igListBox([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *const[]")] sbyte** items, int items_count, int height_in_items);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igListBoxCallback([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *(*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, sbyte*> getter, void* user_data, int items_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igListBoxCallbackEx([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *(*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, sbyte*> getter, void* user_data, int items_count, int height_in_items);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotLines([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const float *")] float* values, int values_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotLinesEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const float *")] float* values, int values_count, int values_offset, [NativeTypeName("const char *")] sbyte* overlay_text, float scale_min, float scale_max, [NativeTypeName("ImVec2")] ImVec2_t graph_size, int stride);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotLinesCallback([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float (*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, float> values_getter, void* data, int values_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotLinesCallbackEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float (*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, float> values_getter, void* data, int values_count, int values_offset, [NativeTypeName("const char *")] sbyte* overlay_text, float scale_min, float scale_max, [NativeTypeName("ImVec2")] ImVec2_t graph_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotHistogram([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const float *")] float* values, int values_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotHistogramEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const float *")] float* values, int values_count, int values_offset, [NativeTypeName("const char *")] sbyte* overlay_text, float scale_min, float scale_max, [NativeTypeName("ImVec2")] ImVec2_t graph_size, int stride);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotHistogramCallback([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float (*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, float> values_getter, void* data, int values_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotHistogramCallbackEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float (*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, float> values_getter, void* data, int values_count, int values_offset, [NativeTypeName("const char *")] sbyte* overlay_text, float scale_min, float scale_max, [NativeTypeName("ImVec2")] ImVec2_t graph_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginMenuBar();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndMenuBar();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginMainMenuBar();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndMainMenuBar();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginMenu([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginMenuEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("bool")] byte enabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndMenu();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igMenuItem([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igMenuItemEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* shortcut, [NativeTypeName("bool")] byte selected, [NativeTypeName("bool")] byte enabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igMenuItemBoolPtr([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* shortcut, bool* p_selected, [NativeTypeName("bool")] byte enabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTooltip();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndTooltip();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetTooltip([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetTooltipV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginItemTooltip();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetItemTooltip([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetItemTooltipV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopup([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiWindowFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupModal([NativeTypeName("const char *")] sbyte* name, bool* p_open, [NativeTypeName("ImGuiWindowFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndPopup();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igOpenPopup([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igOpenPopupID([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igOpenPopupOnItemClick([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igCloseCurrentPopup();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupContextItem();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupContextItemEx([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupContextWindow();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupContextWindowEx([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupContextVoid();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupContextVoidEx([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsPopupOpen([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTable([NativeTypeName("const char *")] sbyte* str_id, int columns, [NativeTypeName("ImGuiTableFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTableEx([NativeTypeName("const char *")] sbyte* str_id, int columns, [NativeTypeName("ImGuiTableFlags")] int flags, [NativeTypeName("ImVec2")] ImVec2_t outer_size, float inner_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndTable();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableNextRow();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableNextRowEx([NativeTypeName("ImGuiTableRowFlags")] int row_flags, float min_row_height);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTableNextColumn();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTableSetColumnIndex(int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetupColumn([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiTableColumnFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetupColumnEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiTableColumnFlags")] int flags, float init_width_or_weight, [NativeTypeName("ImGuiID")] uint user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetupScrollFreeze(int cols, int rows);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableHeader([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableHeadersRow();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableAngledHeadersRow();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiTableSortSpecs *")]
        public static extern ImGuiTableSortSpecs_t* igTableGetSortSpecs();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTableGetColumnCount();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTableGetColumnIndex();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTableGetRowIndex();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igTableGetColumnName(int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiTableColumnFlags")]
        public static extern int igTableGetColumnFlags(int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetColumnEnabled(int column_n, [NativeTypeName("bool")] byte v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTableGetHoveredColumn();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetBgColor([NativeTypeName("ImGuiTableBgTarget")] int target, [NativeTypeName("ImU32")] uint color, int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igColumns();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igColumnsEx(int count, [NativeTypeName("const char *")] sbyte* id, [NativeTypeName("bool")] byte borders);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNextColumn();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igGetColumnIndex();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetColumnWidth(int column_index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetColumnWidth(int column_index, float width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetColumnOffset(int column_index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetColumnOffset(int column_index, float offset_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igGetColumnsCount();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTabBar([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiTabBarFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndTabBar();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTabItem([NativeTypeName("const char *")] sbyte* label, bool* p_open, [NativeTypeName("ImGuiTabItemFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndTabItem();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTabItemButton([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiTabItemFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetTabItemClosed([NativeTypeName("const char *")] sbyte* tab_or_docked_window_label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igDockSpace([NativeTypeName("ImGuiID")] uint dockspace_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igDockSpaceEx([NativeTypeName("ImGuiID")] uint dockspace_id, [NativeTypeName("ImVec2")] ImVec2_t size, [NativeTypeName("ImGuiDockNodeFlags")] int flags, [NativeTypeName("const ImGuiWindowClass *")] ImGuiWindowClass_t* window_class);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igDockSpaceOverViewport();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igDockSpaceOverViewportEx([NativeTypeName("ImGuiID")] uint dockspace_id, [NativeTypeName("const ImGuiViewport *")] ImGuiViewport_t* viewport, [NativeTypeName("ImGuiDockNodeFlags")] int flags, [NativeTypeName("const ImGuiWindowClass *")] ImGuiWindowClass_t* window_class);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowDockID([NativeTypeName("ImGuiID")] uint dock_id, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowClass([NativeTypeName("const ImGuiWindowClass *")] ImGuiWindowClass_t* window_class);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetWindowDockID();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsWindowDocked();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogToTTY(int auto_open_depth);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogToFile(int auto_open_depth, [NativeTypeName("const char *")] sbyte* filename);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogToClipboard(int auto_open_depth);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogFinish();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogButtons();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogText([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogTextV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginDragDropSource([NativeTypeName("ImGuiDragDropFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSetDragDropPayload([NativeTypeName("const char *")] sbyte* type, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint sz, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndDragDropSource();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginDragDropTarget();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImGuiPayload *")]
        public static extern ImGuiPayload_t* igAcceptDragDropPayload([NativeTypeName("const char *")] sbyte* type, [NativeTypeName("ImGuiDragDropFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndDragDropTarget();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImGuiPayload *")]
        public static extern ImGuiPayload_t* igGetDragDropPayload();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBeginDisabled([NativeTypeName("bool")] byte disabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndDisabled();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushClipRect([NativeTypeName("ImVec2")] ImVec2_t clip_rect_min, [NativeTypeName("ImVec2")] ImVec2_t clip_rect_max, [NativeTypeName("bool")] byte intersect_with_current_clip_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopClipRect();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetItemDefaultFocus();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetKeyboardFocusHere();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetKeyboardFocusHereEx(int offset);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNavCursorVisible([NativeTypeName("bool")] byte visible);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemAllowOverlap();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemHovered([NativeTypeName("ImGuiHoveredFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemActive();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemFocused();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemClicked();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemClickedEx([NativeTypeName("ImGuiMouseButton")] int mouse_button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemVisible();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemEdited();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemActivated();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemDeactivated();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemDeactivatedAfterEdit();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemToggledOpen();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsAnyItemHovered();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsAnyItemActive();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsAnyItemFocused();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetItemID();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetItemRectMin();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetItemRectMax();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetItemRectSize();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiItemFlags")]
        public static extern int igGetItemFlags();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igGetItemClickedCountWithSingleClickDelay();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igGetItemClickedCountWithSingleClickDelayEx([NativeTypeName("ImGuiMouseButton")] int mouse_button, float delay);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiViewport *")]
        public static extern ImGuiViewport_t* igGetMainViewport();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImDrawList *")]
        public static extern ImDrawList_t* igGetBackgroundDrawList();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImDrawList *")]
        public static extern ImDrawList_t* igGetBackgroundDrawListEx([NativeTypeName("ImGuiViewport *")] ImGuiViewport_t* viewport);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImDrawList *")]
        public static extern ImDrawList_t* igGetForegroundDrawList();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImDrawList *")]
        public static extern ImDrawList_t* igGetForegroundDrawListEx([NativeTypeName("ImGuiViewport *")] ImGuiViewport_t* viewport);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsRectVisibleBySize([NativeTypeName("ImVec2")] ImVec2_t size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsRectVisible([NativeTypeName("ImVec2")] ImVec2_t rect_min, [NativeTypeName("ImVec2")] ImVec2_t rect_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double igGetTime();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igGetFrameCount();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImDrawListSharedData *")]
        public static extern ImDrawListSharedData_t* igGetDrawListSharedData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igGetStyleColorName([NativeTypeName("ImGuiCol")] int idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetStateStorage([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* storage);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiStorage *")]
        public static extern ImGuiStorage_t* igGetStateStorage();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igCalcTextSize([NativeTypeName("const char *")] sbyte* text);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igCalcTextSizeEx([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, [NativeTypeName("bool")] byte hide_text_after_double_hash, float wrap_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec4")]
        public static extern ImVec4_t igColorConvertU32ToFloat4([NativeTypeName("ImU32")] uint @in);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igColorConvertFloat4ToU32([NativeTypeName("ImVec4")] ImVec4_t @in);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyDown([NativeTypeName("ImGuiKey")] int key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyPressed([NativeTypeName("ImGuiKey")] int key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyPressedEx([NativeTypeName("ImGuiKey")] int key, [NativeTypeName("bool")] byte repeat);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyReleased([NativeTypeName("ImGuiKey")] int key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyChordPressed([NativeTypeName("ImGuiKeyChord")] int key_chord);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igGetKeyPressedAmount([NativeTypeName("ImGuiKey")] int key, float repeat_delay, float rate);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igGetKeyName([NativeTypeName("ImGuiKey")] int key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextFrameWantCaptureKeyboard([NativeTypeName("bool")] byte want_capture_keyboard);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igShortcut([NativeTypeName("ImGuiKeyChord")] int key_chord, [NativeTypeName("ImGuiInputFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemShortcut([NativeTypeName("ImGuiKeyChord")] int key_chord, [NativeTypeName("ImGuiInputFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSetItemKeyOwner([NativeTypeName("ImGuiKey")] int key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseDown([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseClicked([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseClickedEx([NativeTypeName("ImGuiMouseButton")] int button, [NativeTypeName("bool")] byte repeat);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseReleased([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseDoubleClicked([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseReleasedWithDelay([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseReleasedWithDelayEx([NativeTypeName("ImGuiMouseButton")] int button, float delay);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igGetMouseClickedCount([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseHoveringRect([NativeTypeName("ImVec2")] ImVec2_t r_min, [NativeTypeName("ImVec2")] ImVec2_t r_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseHoveringRectEx([NativeTypeName("ImVec2")] ImVec2_t r_min, [NativeTypeName("ImVec2")] ImVec2_t r_max, [NativeTypeName("bool")] byte clip);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMousePosValid([NativeTypeName("const ImVec2 *")] ImVec2_t* mouse_pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsAnyMouseDown();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetMousePos();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetMousePosOnOpeningCurrentPopup();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseDragging([NativeTypeName("ImGuiMouseButton")] int button, float lock_threshold);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetMouseDragDelta([NativeTypeName("ImGuiMouseButton")] int button, float lock_threshold);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igResetMouseDragDelta();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igResetMouseDragDeltaEx([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiMouseCursor")]
        public static extern int igGetMouseCursor();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetMouseCursor([NativeTypeName("ImGuiMouseCursor")] int cursor_type);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextFrameWantCaptureMouse([NativeTypeName("bool")] byte want_capture_mouse);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igGetClipboardText();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetClipboardText([NativeTypeName("const char *")] sbyte* text);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLoadIniSettingsFromDisk([NativeTypeName("const char *")] sbyte* ini_filename);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLoadIniSettingsFromMemory([NativeTypeName("const char *")] sbyte* ini_data, [NativeTypeName("size_t")] nuint ini_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSaveIniSettingsToDisk([NativeTypeName("const char *")] sbyte* ini_filename);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igSaveIniSettingsToMemory([NativeTypeName("size_t *")] nuint* out_ini_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugTextEncoding([NativeTypeName("const char *")] sbyte* text);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugFlashStyleColor([NativeTypeName("ImGuiCol")] int idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugStartItemPicker();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDebugCheckVersionAndDataLayout([NativeTypeName("const char *")] sbyte* version_str, [NativeTypeName("size_t")] nuint sz_io, [NativeTypeName("size_t")] nuint sz_style, [NativeTypeName("size_t")] nuint sz_vec2, [NativeTypeName("size_t")] nuint sz_vec4, [NativeTypeName("size_t")] nuint sz_drawvert, [NativeTypeName("size_t")] nuint sz_drawidx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugLog([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugLogV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetAllocatorFunctions([NativeTypeName("ImGuiMemAllocFunc")] delegate* unmanaged[Cdecl]<nuint, void*, void*> alloc_func, [NativeTypeName("ImGuiMemFreeFunc")] delegate* unmanaged[Cdecl]<void*, void*, void> free_func, void* user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetAllocatorFunctions([NativeTypeName("ImGuiMemAllocFunc *")] delegate* unmanaged[Cdecl]<nuint, void*, void*>* p_alloc_func, [NativeTypeName("ImGuiMemFreeFunc *")] delegate* unmanaged[Cdecl]<void*, void*, void>* p_free_func, void** p_user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* igMemAlloc([NativeTypeName("size_t")] nuint size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igMemFree(void* ptr);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igUpdatePlatformWindows();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderPlatformWindowsDefault();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderPlatformWindowsDefaultEx(void* platform_render_arg, void* renderer_render_arg);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDestroyPlatformWindows();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiViewport *")]
        public static extern ImGuiViewport_t* igFindViewportByID([NativeTypeName("ImGuiID")] uint viewport_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiViewport *")]
        public static extern ImGuiViewport_t* igFindViewportByPlatformHandle(void* platform_handle);

        public const int ImGuiDir_None = -1;
        public const int ImGuiDir_Left = 0;
        public const int ImGuiDir_Right = 1;
        public const int ImGuiDir_Up = 2;
        public const int ImGuiDir_Down = 3;
        public const int ImGuiDir_COUNT = 4;

        public const int ImGuiSortDirection_None = 0;
        public const int ImGuiSortDirection_Ascending = 1;
        public const int ImGuiSortDirection_Descending = 2;

        public const int ImGuiKey_None = 0;
        public const int ImGuiKey_NamedKey_BEGIN = 512;
        public const int ImGuiKey_Tab = 512;
        public const int ImGuiKey_LeftArrow = 513;
        public const int ImGuiKey_RightArrow = 514;
        public const int ImGuiKey_UpArrow = 515;
        public const int ImGuiKey_DownArrow = 516;
        public const int ImGuiKey_PageUp = 517;
        public const int ImGuiKey_PageDown = 518;
        public const int ImGuiKey_Home = 519;
        public const int ImGuiKey_End = 520;
        public const int ImGuiKey_Insert = 521;
        public const int ImGuiKey_Delete = 522;
        public const int ImGuiKey_Backspace = 523;
        public const int ImGuiKey_Space = 524;
        public const int ImGuiKey_Enter = 525;
        public const int ImGuiKey_Escape = 526;
        public const int ImGuiKey_LeftCtrl = 527;
        public const int ImGuiKey_LeftShift = 528;
        public const int ImGuiKey_LeftAlt = 529;
        public const int ImGuiKey_LeftSuper = 530;
        public const int ImGuiKey_RightCtrl = 531;
        public const int ImGuiKey_RightShift = 532;
        public const int ImGuiKey_RightAlt = 533;
        public const int ImGuiKey_RightSuper = 534;
        public const int ImGuiKey_Menu = 535;
        public const int ImGuiKey_0 = 536;
        public const int ImGuiKey_1 = 537;
        public const int ImGuiKey_2 = 538;
        public const int ImGuiKey_3 = 539;
        public const int ImGuiKey_4 = 540;
        public const int ImGuiKey_5 = 541;
        public const int ImGuiKey_6 = 542;
        public const int ImGuiKey_7 = 543;
        public const int ImGuiKey_8 = 544;
        public const int ImGuiKey_9 = 545;
        public const int ImGuiKey_A = 546;
        public const int ImGuiKey_B = 547;
        public const int ImGuiKey_C = 548;
        public const int ImGuiKey_D = 549;
        public const int ImGuiKey_E = 550;
        public const int ImGuiKey_F = 551;
        public const int ImGuiKey_G = 552;
        public const int ImGuiKey_H = 553;
        public const int ImGuiKey_I = 554;
        public const int ImGuiKey_J = 555;
        public const int ImGuiKey_K = 556;
        public const int ImGuiKey_L = 557;
        public const int ImGuiKey_M = 558;
        public const int ImGuiKey_N = 559;
        public const int ImGuiKey_O = 560;
        public const int ImGuiKey_P = 561;
        public const int ImGuiKey_Q = 562;
        public const int ImGuiKey_R = 563;
        public const int ImGuiKey_S = 564;
        public const int ImGuiKey_T = 565;
        public const int ImGuiKey_U = 566;
        public const int ImGuiKey_V = 567;
        public const int ImGuiKey_W = 568;
        public const int ImGuiKey_X = 569;
        public const int ImGuiKey_Y = 570;
        public const int ImGuiKey_Z = 571;
        public const int ImGuiKey_F1 = 572;
        public const int ImGuiKey_F2 = 573;
        public const int ImGuiKey_F3 = 574;
        public const int ImGuiKey_F4 = 575;
        public const int ImGuiKey_F5 = 576;
        public const int ImGuiKey_F6 = 577;
        public const int ImGuiKey_F7 = 578;
        public const int ImGuiKey_F8 = 579;
        public const int ImGuiKey_F9 = 580;
        public const int ImGuiKey_F10 = 581;
        public const int ImGuiKey_F11 = 582;
        public const int ImGuiKey_F12 = 583;
        public const int ImGuiKey_F13 = 584;
        public const int ImGuiKey_F14 = 585;
        public const int ImGuiKey_F15 = 586;
        public const int ImGuiKey_F16 = 587;
        public const int ImGuiKey_F17 = 588;
        public const int ImGuiKey_F18 = 589;
        public const int ImGuiKey_F19 = 590;
        public const int ImGuiKey_F20 = 591;
        public const int ImGuiKey_F21 = 592;
        public const int ImGuiKey_F22 = 593;
        public const int ImGuiKey_F23 = 594;
        public const int ImGuiKey_F24 = 595;
        public const int ImGuiKey_Apostrophe = 596;
        public const int ImGuiKey_Comma = 597;
        public const int ImGuiKey_Minus = 598;
        public const int ImGuiKey_Period = 599;
        public const int ImGuiKey_Slash = 600;
        public const int ImGuiKey_Semicolon = 601;
        public const int ImGuiKey_Equal = 602;
        public const int ImGuiKey_LeftBracket = 603;
        public const int ImGuiKey_Backslash = 604;
        public const int ImGuiKey_RightBracket = 605;
        public const int ImGuiKey_GraveAccent = 606;
        public const int ImGuiKey_CapsLock = 607;
        public const int ImGuiKey_ScrollLock = 608;
        public const int ImGuiKey_NumLock = 609;
        public const int ImGuiKey_PrintScreen = 610;
        public const int ImGuiKey_Pause = 611;
        public const int ImGuiKey_Keypad0 = 612;
        public const int ImGuiKey_Keypad1 = 613;
        public const int ImGuiKey_Keypad2 = 614;
        public const int ImGuiKey_Keypad3 = 615;
        public const int ImGuiKey_Keypad4 = 616;
        public const int ImGuiKey_Keypad5 = 617;
        public const int ImGuiKey_Keypad6 = 618;
        public const int ImGuiKey_Keypad7 = 619;
        public const int ImGuiKey_Keypad8 = 620;
        public const int ImGuiKey_Keypad9 = 621;
        public const int ImGuiKey_KeypadDecimal = 622;
        public const int ImGuiKey_KeypadDivide = 623;
        public const int ImGuiKey_KeypadMultiply = 624;
        public const int ImGuiKey_KeypadSubtract = 625;
        public const int ImGuiKey_KeypadAdd = 626;
        public const int ImGuiKey_KeypadEnter = 627;
        public const int ImGuiKey_KeypadEqual = 628;
        public const int ImGuiKey_AppBack = 629;
        public const int ImGuiKey_AppForward = 630;
        public const int ImGuiKey_Oem102 = 631;
        public const int ImGuiKey_GamepadStart = 632;
        public const int ImGuiKey_GamepadBack = 633;
        public const int ImGuiKey_GamepadFaceLeft = 634;
        public const int ImGuiKey_GamepadFaceRight = 635;
        public const int ImGuiKey_GamepadFaceUp = 636;
        public const int ImGuiKey_GamepadFaceDown = 637;
        public const int ImGuiKey_GamepadDpadLeft = 638;
        public const int ImGuiKey_GamepadDpadRight = 639;
        public const int ImGuiKey_GamepadDpadUp = 640;
        public const int ImGuiKey_GamepadDpadDown = 641;
        public const int ImGuiKey_GamepadL1 = 642;
        public const int ImGuiKey_GamepadR1 = 643;
        public const int ImGuiKey_GamepadL2 = 644;
        public const int ImGuiKey_GamepadR2 = 645;
        public const int ImGuiKey_GamepadL3 = 646;
        public const int ImGuiKey_GamepadR3 = 647;
        public const int ImGuiKey_GamepadLStickLeft = 648;
        public const int ImGuiKey_GamepadLStickRight = 649;
        public const int ImGuiKey_GamepadLStickUp = 650;
        public const int ImGuiKey_GamepadLStickDown = 651;
        public const int ImGuiKey_GamepadRStickLeft = 652;
        public const int ImGuiKey_GamepadRStickRight = 653;
        public const int ImGuiKey_GamepadRStickUp = 654;
        public const int ImGuiKey_GamepadRStickDown = 655;
        public const int ImGuiKey_MouseLeft = 656;
        public const int ImGuiKey_MouseRight = 657;
        public const int ImGuiKey_MouseMiddle = 658;
        public const int ImGuiKey_MouseX1 = 659;
        public const int ImGuiKey_MouseX2 = 660;
        public const int ImGuiKey_MouseWheelX = 661;
        public const int ImGuiKey_MouseWheelY = 662;
        public const int ImGuiKey_ReservedForModCtrl = 663;
        public const int ImGuiKey_ReservedForModShift = 664;
        public const int ImGuiKey_ReservedForModAlt = 665;
        public const int ImGuiKey_ReservedForModSuper = 666;
        public const int ImGuiKey_NamedKey_END = 667;
        public const int ImGuiKey_NamedKey_COUNT = ImGuiKey_NamedKey_END - ImGuiKey_NamedKey_BEGIN;
        public const int ImGuiMod_None = 0;
        public const int ImGuiMod_Ctrl = 1 << 12;
        public const int ImGuiMod_Shift = 1 << 13;
        public const int ImGuiMod_Alt = 1 << 14;
        public const int ImGuiMod_Super = 1 << 15;
        public const int ImGuiMod_Mask_ = 0xF000;
        public const int ImGuiKey_COUNT = ImGuiKey_NamedKey_END;
        public const int ImGuiMod_Shortcut = ImGuiMod_Ctrl;

        public const int ImGuiMouseSource_Mouse = 0;
        public const int ImGuiMouseSource_TouchScreen = 1;
        public const int ImGuiMouseSource_Pen = 2;
        public const int ImGuiMouseSource_COUNT = 3;

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImVector_Construct(void* vector);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImVector_Destruct(void* vector);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPlatformIO_SetPlatform_GetWindowWorkAreaInsets([NativeTypeName("void (*)(ImGuiViewport *, ImVec4 *)")] delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec4_t*, void> getWindowWorkAreaInsetsFunc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPlatformIO_SetPlatform_GetWindowFramebufferScale([NativeTypeName("void (*)(ImGuiViewport *, ImVec2 *)")] delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec2_t*, void> getWindowFramebufferScaleFunc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPlatformIO_SetPlatform_GetWindowPos([NativeTypeName("void (*)(ImGuiViewport *, ImVec2 *)")] delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec2_t*, void> getWindowPosFunc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPlatformIO_SetPlatform_GetWindowSize([NativeTypeName("void (*)(ImGuiViewport *, ImVec2 *)")] delegate* unmanaged[Cdecl]<ImGuiViewport_t*, ImVec2_t*, void> getWindowSizeFunc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStyle_ScaleAllSizes([NativeTypeName("ImGuiStyle *")] ImGuiStyle_t* self, float scale_factor);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddKeyEvent([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("ImGuiKey")] int key, [NativeTypeName("bool")] byte down);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddKeyAnalogEvent([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("ImGuiKey")] int key, [NativeTypeName("bool")] byte down, float v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddMousePosEvent([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, float x, float y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddMouseButtonEvent([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, int button, [NativeTypeName("bool")] byte down);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddMouseWheelEvent([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, float wheel_x, float wheel_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddMouseSourceEvent([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("ImGuiMouseSource")] int source);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddMouseViewportEvent([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddFocusEvent([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("bool")] byte focused);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddInputCharacter([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("unsigned int")] uint c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddInputCharacterUTF16([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("ImWchar16")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddInputCharactersUTF8([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("const char *")] sbyte* str);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_SetKeyEventNativeData([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("ImGuiKey")] int key, int native_keycode, int native_scancode);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_SetKeyEventNativeDataEx([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("ImGuiKey")] int key, int native_keycode, int native_scancode, int native_legacy_index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_SetAppAcceptingEvents([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self, [NativeTypeName("bool")] byte accepting_events);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_ClearEventsQueue([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_ClearInputKeys([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_ClearInputMouse([NativeTypeName("ImGuiIO *")] ImGuiIO_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars([NativeTypeName("ImGuiInputTextCallbackData *")] ImGuiInputTextCallbackData_t* self, int pos, int bytes_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextCallbackData_InsertChars([NativeTypeName("ImGuiInputTextCallbackData *")] ImGuiInputTextCallbackData_t* self, int pos, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextCallbackData_SelectAll([NativeTypeName("ImGuiInputTextCallbackData *")] ImGuiInputTextCallbackData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextCallbackData_SetSelection([NativeTypeName("ImGuiInputTextCallbackData *")] ImGuiInputTextCallbackData_t* self, int s, int e);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextCallbackData_ClearSelection([NativeTypeName("ImGuiInputTextCallbackData *")] ImGuiInputTextCallbackData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiInputTextCallbackData_HasSelection([NativeTypeName("const ImGuiInputTextCallbackData *")] ImGuiInputTextCallbackData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPayload_Clear([NativeTypeName("ImGuiPayload *")] ImGuiPayload_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiPayload_IsDataType([NativeTypeName("const ImGuiPayload *")] ImGuiPayload_t* self, [NativeTypeName("const char *")] sbyte* type);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiPayload_IsPreview([NativeTypeName("const ImGuiPayload *")] ImGuiPayload_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiPayload_IsDelivery([NativeTypeName("const ImGuiPayload *")] ImGuiPayload_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiTextFilter_ImGuiTextRange_empty([NativeTypeName("const ImGuiTextFilter_ImGuiTextRange *")] ImGuiTextFilter_ImGuiTextRange_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextFilter_ImGuiTextRange_split([NativeTypeName("const ImGuiTextFilter_ImGuiTextRange *")] ImGuiTextFilter_ImGuiTextRange_t* self, [NativeTypeName("char")] sbyte separator, [NativeTypeName("ImVector_ImGuiTextRange *")] ImVector_ImGuiTextRange_t* @out);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiTextFilter_Draw([NativeTypeName("ImGuiTextFilter *")] ImGuiTextFilter_t* self, [NativeTypeName("const char *")] sbyte* label, float width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiTextFilter_PassFilter([NativeTypeName("const ImGuiTextFilter *")] ImGuiTextFilter_t* self, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextFilter_Build([NativeTypeName("ImGuiTextFilter *")] ImGuiTextFilter_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextFilter_Clear([NativeTypeName("ImGuiTextFilter *")] ImGuiTextFilter_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiTextFilter_IsActive([NativeTypeName("const ImGuiTextFilter *")] ImGuiTextFilter_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImGuiTextBuffer_begin([NativeTypeName("const ImGuiTextBuffer *")] ImGuiTextBuffer_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImGuiTextBuffer_end([NativeTypeName("const ImGuiTextBuffer *")] ImGuiTextBuffer_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImGuiTextBuffer_size([NativeTypeName("const ImGuiTextBuffer *")] ImGuiTextBuffer_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiTextBuffer_empty([NativeTypeName("const ImGuiTextBuffer *")] ImGuiTextBuffer_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_clear([NativeTypeName("ImGuiTextBuffer *")] ImGuiTextBuffer_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_resize([NativeTypeName("ImGuiTextBuffer *")] ImGuiTextBuffer_t* self, int size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_reserve([NativeTypeName("ImGuiTextBuffer *")] ImGuiTextBuffer_t* self, int capacity);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImGuiTextBuffer_c_str([NativeTypeName("const ImGuiTextBuffer *")] ImGuiTextBuffer_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_append([NativeTypeName("ImGuiTextBuffer *")] ImGuiTextBuffer_t* self, [NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char *")] sbyte* str_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_appendf([NativeTypeName("ImGuiTextBuffer *")] ImGuiTextBuffer_t* self, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_appendfv([NativeTypeName("ImGuiTextBuffer *")] ImGuiTextBuffer_t* self, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_Clear([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImGuiStorage_GetInt([NativeTypeName("const ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, int default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_SetInt([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, int val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiStorage_GetBool([NativeTypeName("const ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, [NativeTypeName("bool")] byte default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_SetBool([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, [NativeTypeName("bool")] byte val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float ImGuiStorage_GetFloat([NativeTypeName("const ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, float default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_SetFloat([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, float val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* ImGuiStorage_GetVoidPtr([NativeTypeName("const ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_SetVoidPtr([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, void* val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* ImGuiStorage_GetIntRef([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, int default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern bool* ImGuiStorage_GetBoolRef([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, [NativeTypeName("bool")] byte default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float* ImGuiStorage_GetFloatRef([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, float default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void** ImGuiStorage_GetVoidPtrRef([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self, [NativeTypeName("ImGuiID")] uint key, void* default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_BuildSortByKey([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_SetAllInt([NativeTypeName("ImGuiStorage *")] ImGuiStorage_t* self, int val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_Begin([NativeTypeName("ImGuiListClipper *")] ImGuiListClipper_t* self, int items_count, float items_height);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_End([NativeTypeName("ImGuiListClipper *")] ImGuiListClipper_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiListClipper_Step([NativeTypeName("ImGuiListClipper *")] ImGuiListClipper_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_IncludeItemByIndex([NativeTypeName("ImGuiListClipper *")] ImGuiListClipper_t* self, int item_index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_IncludeItemsByIndex([NativeTypeName("ImGuiListClipper *")] ImGuiListClipper_t* self, int item_begin, int item_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_SeekCursorForItem([NativeTypeName("ImGuiListClipper *")] ImGuiListClipper_t* self, int item_index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImColor_SetHSV([NativeTypeName("ImColor *")] ImColor_t* self, float h, float s, float v, float a);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImColor")]
        public static extern ImColor_t ImColor_HSV(float h, float s, float v, float a);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionBasicStorage_ApplyRequests([NativeTypeName("ImGuiSelectionBasicStorage *")] ImGuiSelectionBasicStorage_t* self, [NativeTypeName("ImGuiMultiSelectIO *")] ImGuiMultiSelectIO_t* ms_io);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiSelectionBasicStorage_Contains([NativeTypeName("const ImGuiSelectionBasicStorage *")] ImGuiSelectionBasicStorage_t* self, [NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionBasicStorage_Clear([NativeTypeName("ImGuiSelectionBasicStorage *")] ImGuiSelectionBasicStorage_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionBasicStorage_Swap([NativeTypeName("ImGuiSelectionBasicStorage *")] ImGuiSelectionBasicStorage_t* self, [NativeTypeName("ImGuiSelectionBasicStorage *")] ImGuiSelectionBasicStorage_t* r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionBasicStorage_SetItemSelected([NativeTypeName("ImGuiSelectionBasicStorage *")] ImGuiSelectionBasicStorage_t* self, [NativeTypeName("ImGuiID")] uint id, [NativeTypeName("bool")] byte selected);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiSelectionBasicStorage_GetNextSelectedItem([NativeTypeName("ImGuiSelectionBasicStorage *")] ImGuiSelectionBasicStorage_t* self, void** opaque_it, [NativeTypeName("ImGuiID *")] uint* out_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint ImGuiSelectionBasicStorage_GetStorageIdFromIndex([NativeTypeName("ImGuiSelectionBasicStorage *")] ImGuiSelectionBasicStorage_t* self, int idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionExternalStorage_ApplyRequests([NativeTypeName("ImGuiSelectionExternalStorage *")] ImGuiSelectionExternalStorage_t* self, [NativeTypeName("ImGuiMultiSelectIO *")] ImGuiMultiSelectIO_t* ms_io);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImTextureID")]
        public static extern ulong ImDrawCmd_GetTexID([NativeTypeName("const ImDrawCmd *")] ImDrawCmd_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_Clear([NativeTypeName("ImDrawListSplitter *")] ImDrawListSplitter_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_ClearFreeMemory([NativeTypeName("ImDrawListSplitter *")] ImDrawListSplitter_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_Split([NativeTypeName("ImDrawListSplitter *")] ImDrawListSplitter_t* self, [NativeTypeName("ImDrawList *")] ImDrawList_t* draw_list, int count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_Merge([NativeTypeName("ImDrawListSplitter *")] ImDrawListSplitter_t* self, [NativeTypeName("ImDrawList *")] ImDrawList_t* draw_list);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_SetCurrentChannel([NativeTypeName("ImDrawListSplitter *")] ImDrawListSplitter_t* self, [NativeTypeName("ImDrawList *")] ImDrawList_t* draw_list, int channel_idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PushClipRect([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t clip_rect_min, [NativeTypeName("ImVec2")] ImVec2_t clip_rect_max, [NativeTypeName("bool")] byte intersect_with_current_clip_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PushClipRectFullScreen([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PopClipRect([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PushTexture([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PopTexture([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t ImDrawList_GetClipRectMin([NativeTypeName("const ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t ImDrawList_GetClipRectMax([NativeTypeName("const ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddLine([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddLineEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImU32")] uint col, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddLineH([NativeTypeName("ImDrawList *")] ImDrawList_t* self, float min_x, float max_x, float y, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddLineHEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, float min_x, float max_x, float y, [NativeTypeName("ImU32")] uint col, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddLineV([NativeTypeName("ImDrawList *")] ImDrawList_t* self, float x, float min_y, float max_y, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddLineVEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, float x, float min_y, float max_y, [NativeTypeName("ImU32")] uint col, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddRect([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p_min, [NativeTypeName("ImVec2")] ImVec2_t p_max, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddRectEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p_min, [NativeTypeName("ImVec2")] ImVec2_t p_max, [NativeTypeName("ImU32")] uint col, float rounding, float thickness, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddRectFilled([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p_min, [NativeTypeName("ImVec2")] ImVec2_t p_max, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddRectFilledEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p_min, [NativeTypeName("ImVec2")] ImVec2_t p_max, [NativeTypeName("ImU32")] uint col, float rounding, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddRectFilledMultiColor([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p_min, [NativeTypeName("ImVec2")] ImVec2_t p_max, [NativeTypeName("ImU32")] uint col_upr_left, [NativeTypeName("ImU32")] uint col_upr_right, [NativeTypeName("ImU32")] uint col_bot_right, [NativeTypeName("ImU32")] uint col_bot_left);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddQuad([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImVec2")] ImVec2_t p4, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddQuadEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImVec2")] ImVec2_t p4, [NativeTypeName("ImU32")] uint col, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddQuadFilled([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImVec2")] ImVec2_t p4, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddTriangle([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddTriangleEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImU32")] uint col, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddTriangleFilled([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddCircle([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, float radius, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddCircleEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, float radius, [NativeTypeName("ImU32")] uint col, int num_segments, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddCircleFilled([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, float radius, [NativeTypeName("ImU32")] uint col, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddNgon([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, float radius, [NativeTypeName("ImU32")] uint col, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddNgonEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, float radius, [NativeTypeName("ImU32")] uint col, int num_segments, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddNgonFilled([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, float radius, [NativeTypeName("ImU32")] uint col, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddEllipse([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, [NativeTypeName("ImVec2")] ImVec2_t radius, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddEllipseEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, [NativeTypeName("ImVec2")] ImVec2_t radius, [NativeTypeName("ImU32")] uint col, float rot, int num_segments, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddEllipseFilled([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, [NativeTypeName("ImVec2")] ImVec2_t radius, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddEllipseFilledEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, [NativeTypeName("ImVec2")] ImVec2_t radius, [NativeTypeName("ImU32")] uint col, float rot, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddText([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("const char *")] sbyte* text_begin);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddTextEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("const char *")] sbyte* text_begin, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddTextImFontPtr([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImFont *")] ImFont_t* font, float font_size, [NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("const char *")] sbyte* text_begin);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddTextImFontPtrEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImFont *")] ImFont_t* font, float font_size, [NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("const char *")] sbyte* text_begin, [NativeTypeName("const char *")] sbyte* text_end, float wrap_width, [NativeTypeName("const ImVec4 *")] ImVec4_t* cpu_fine_clip_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddBezierCubic([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImVec2")] ImVec2_t p4, [NativeTypeName("ImU32")] uint col, float thickness, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddBezierQuadratic([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImU32")] uint col, float thickness, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddPolyline([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("const ImVec2 *")] ImVec2_t* points, int num_points, [NativeTypeName("ImU32")] uint col, float thickness, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddConvexPolyFilled([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("const ImVec2 *")] ImVec2_t* points, int num_points, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddConcavePolyFilled([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("const ImVec2 *")] ImVec2_t* points, int num_points, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddImage([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t p_min, [NativeTypeName("ImVec2")] ImVec2_t p_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddImageEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t p_min, [NativeTypeName("ImVec2")] ImVec2_t p_max, [NativeTypeName("ImVec2")] ImVec2_t uv_min, [NativeTypeName("ImVec2")] ImVec2_t uv_max, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddImageQuad([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImVec2")] ImVec2_t p4);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddImageQuadEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t p1, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImVec2")] ImVec2_t p4, [NativeTypeName("ImVec2")] ImVec2_t uv1, [NativeTypeName("ImVec2")] ImVec2_t uv2, [NativeTypeName("ImVec2")] ImVec2_t uv3, [NativeTypeName("ImVec2")] ImVec2_t uv4, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddImageRounded([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t p_min, [NativeTypeName("ImVec2")] ImVec2_t p_max, [NativeTypeName("ImVec2")] ImVec2_t uv_min, [NativeTypeName("ImVec2")] ImVec2_t uv_max, [NativeTypeName("ImU32")] uint col, float rounding, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathClear([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathLineTo([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathLineToMergeDuplicate([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathFillConvex([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathFillConcave([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathStroke([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImU32")] uint col, float thickness, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathArcTo([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, float radius, float a_min, float a_max, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathArcToFast([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, float radius, int a_min_of_12, int a_max_of_12);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathEllipticalArcTo([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, [NativeTypeName("ImVec2")] ImVec2_t radius, float rot, float a_min, float a_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathEllipticalArcToEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, [NativeTypeName("ImVec2")] ImVec2_t radius, float rot, float a_min, float a_max, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathBezierCubicCurveTo([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, [NativeTypeName("ImVec2")] ImVec2_t p4, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathBezierQuadraticCurveTo([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p2, [NativeTypeName("ImVec2")] ImVec2_t p3, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathRect([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t rect_min, [NativeTypeName("ImVec2")] ImVec2_t rect_max, float rounding, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddCallback([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImDrawCallback")] delegate* unmanaged[Cdecl]<ImDrawList_t*, ImDrawCmd_t*, void> callback);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddCallbackEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImDrawCallback")] delegate* unmanaged[Cdecl]<ImDrawList_t*, ImDrawCmd_t*, void> callback, void* userdata, [NativeTypeName("size_t")] nuint userdata_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddDrawCmd([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImDrawList *")]
        public static extern ImDrawList_t* ImDrawList_CloneOutput([NativeTypeName("const ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_ChannelsSplit([NativeTypeName("ImDrawList *")] ImDrawList_t* self, int count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_ChannelsMerge([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_ChannelsSetCurrent([NativeTypeName("ImDrawList *")] ImDrawList_t* self, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimReserve([NativeTypeName("ImDrawList *")] ImDrawList_t* self, int idx_count, int vtx_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimUnreserve([NativeTypeName("ImDrawList *")] ImDrawList_t* self, int idx_count, int vtx_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimRect([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t a, [NativeTypeName("ImVec2")] ImVec2_t b, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimRectUV([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t a, [NativeTypeName("ImVec2")] ImVec2_t b, [NativeTypeName("ImVec2")] ImVec2_t uv_a, [NativeTypeName("ImVec2")] ImVec2_t uv_b, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimQuadUV([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t a, [NativeTypeName("ImVec2")] ImVec2_t b, [NativeTypeName("ImVec2")] ImVec2_t c, [NativeTypeName("ImVec2")] ImVec2_t d, [NativeTypeName("ImVec2")] ImVec2_t uv_a, [NativeTypeName("ImVec2")] ImVec2_t uv_b, [NativeTypeName("ImVec2")] ImVec2_t uv_c, [NativeTypeName("ImVec2")] ImVec2_t uv_d, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimWriteVtx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImVec2")] ImVec2_t uv, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimWriteIdx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImDrawIdx")] ushort idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimVtx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImVec2")] ImVec2_t uv, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddRectImDrawFlags([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t p_min, [NativeTypeName("ImVec2")] ImVec2_t p_max, [NativeTypeName("ImU32")] uint col, float rounding, [NativeTypeName("ImDrawFlags")] int flags, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddPolylineImDrawFlags([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("const ImVec2 *")] ImVec2_t* points, int num_points, [NativeTypeName("ImU32")] uint col, [NativeTypeName("ImDrawFlags")] int flags, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathStrokeImDrawFlags([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImU32")] uint col, [NativeTypeName("ImDrawFlags")] int flags, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PushTextureID([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PopTextureID([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__SetDrawListSharedData([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImDrawListSharedData *")] ImDrawListSharedData_t* data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__ResetForNewFrame([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__ClearFreeMemory([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__PopUnusedDrawCmd([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__TryMergeDrawCmds([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__OnChangedClipRect([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__OnChangedTexture([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__OnChangedVtxOffset([NativeTypeName("ImDrawList *")] ImDrawList_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__SetTexture([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImDrawList__CalcCircleAutoSegmentCount([NativeTypeName("const ImDrawList *")] ImDrawList_t* self, float radius);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__PathArcToFastEx([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, float radius, int a_min_sample, int a_max_sample, int a_step);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__PathArcToN([NativeTypeName("ImDrawList *")] ImDrawList_t* self, [NativeTypeName("ImVec2")] ImVec2_t center, float radius, float a_min, float a_max, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawData_Clear([NativeTypeName("ImDrawData *")] ImDrawData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawData_AddDrawList([NativeTypeName("ImDrawData *")] ImDrawData_t* self, [NativeTypeName("ImDrawList *")] ImDrawList_t* draw_list);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawData_DeIndexAllBuffers([NativeTypeName("ImDrawData *")] ImDrawData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawData_ScaleClipRects([NativeTypeName("ImDrawData *")] ImDrawData_t* self, [NativeTypeName("ImVec2")] ImVec2_t fb_scale);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImTextureData_Create([NativeTypeName("ImTextureData *")] ImTextureData_t* self, ImTextureFormat format, int w, int h);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImTextureData_DestroyPixels([NativeTypeName("ImTextureData *")] ImTextureData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* ImTextureData_GetPixels([NativeTypeName("ImTextureData *")] ImTextureData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* ImTextureData_GetPixelsAt([NativeTypeName("ImTextureData *")] ImTextureData_t* self, int x, int y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImTextureData_GetSizeInBytes([NativeTypeName("const ImTextureData *")] ImTextureData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImTextureData_GetPitch([NativeTypeName("const ImTextureData *")] ImTextureData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImTextureRef")]
        public static extern ImTextureRef_t ImTextureData_GetTexRef([NativeTypeName("ImTextureData *")] ImTextureData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImTextureID")]
        public static extern ulong ImTextureData_GetTexID([NativeTypeName("const ImTextureData *")] ImTextureData_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImTextureData_SetTexID([NativeTypeName("ImTextureData *")] ImTextureData_t* self, [NativeTypeName("ImTextureID")] ulong tex_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImTextureData_SetStatus([NativeTypeName("ImTextureData *")] ImTextureData_t* self, ImTextureStatus status);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_Clear([NativeTypeName("ImFontGlyphRangesBuilder *")] ImFontGlyphRangesBuilder_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFontGlyphRangesBuilder_GetBit([NativeTypeName("const ImFontGlyphRangesBuilder *")] ImFontGlyphRangesBuilder_t* self, [NativeTypeName("size_t")] nuint n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_SetBit([NativeTypeName("ImFontGlyphRangesBuilder *")] ImFontGlyphRangesBuilder_t* self, [NativeTypeName("size_t")] nuint n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_AddChar([NativeTypeName("ImFontGlyphRangesBuilder *")] ImFontGlyphRangesBuilder_t* self, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_AddText([NativeTypeName("ImFontGlyphRangesBuilder *")] ImFontGlyphRangesBuilder_t* self, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges([NativeTypeName("ImFontGlyphRangesBuilder *")] ImFontGlyphRangesBuilder_t* self, [NativeTypeName("const ImWchar *")] ushort* ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges([NativeTypeName("ImFontGlyphRangesBuilder *")] ImFontGlyphRangesBuilder_t* self, [NativeTypeName("ImVector_ImWchar *")] ImVector_ImWchar_t* out_ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFont *")]
        public static extern ImFont_t* ImFontAtlas_AddFont([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("const ImFontConfig *")] ImFontConfig_t* font_cfg);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFont *")]
        public static extern ImFont_t* ImFontAtlas_AddFontDefault([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("const ImFontConfig *")] ImFontConfig_t* font_cfg);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFont *")]
        public static extern ImFont_t* ImFontAtlas_AddFontDefaultVector([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("const ImFontConfig *")] ImFontConfig_t* font_cfg);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFont *")]
        public static extern ImFont_t* ImFontAtlas_AddFontDefaultBitmap([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("const ImFontConfig *")] ImFontConfig_t* font_cfg);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFont *")]
        public static extern ImFont_t* ImFontAtlas_AddFontFromFileTTF([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("const char *")] sbyte* filename, float size_pixels, [NativeTypeName("const ImFontConfig *")] ImFontConfig_t* font_cfg, [NativeTypeName("const ImWchar *")] ushort* glyph_ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFont *")]
        public static extern ImFont_t* ImFontAtlas_AddFontFromMemoryTTF([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, void* font_data, int font_data_size, float size_pixels, [NativeTypeName("const ImFontConfig *")] ImFontConfig_t* font_cfg, [NativeTypeName("const ImWchar *")] ushort* glyph_ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFont *")]
        public static extern ImFont_t* ImFontAtlas_AddFontFromMemoryCompressedTTF([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("const void *")] void* compressed_font_data, int compressed_font_data_size, float size_pixels, [NativeTypeName("const ImFontConfig *")] ImFontConfig_t* font_cfg, [NativeTypeName("const ImWchar *")] ushort* glyph_ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFont *")]
        public static extern ImFont_t* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("const char *")] sbyte* compressed_font_data_base85, float size_pixels, [NativeTypeName("const ImFontConfig *")] ImFontConfig_t* font_cfg, [NativeTypeName("const ImWchar *")] ushort* glyph_ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_RemoveFont([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("ImFont *")] ImFont_t* font);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_CompactCache([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_SetFontLoader([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("const ImFontLoader *")] ImFontLoader_t* font_loader);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_Clear([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_ClearFonts([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_ClearInputData([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_ClearTexData([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFontAtlas_Build([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("unsigned char **")] byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("unsigned char **")] byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_SetTexID([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("ImTextureID")] ulong id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_SetTexIDImTextureRef([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("ImTextureRef")] ImTextureRef_t id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFontAtlas_IsBuilt([NativeTypeName("const ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesDefault([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesGreek([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesKorean([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesJapanese([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseFull([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesCyrillic([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesThai([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesVietnamese([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFontAtlasRectId")]
        public static extern int ImFontAtlas_AddCustomRect([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, int width, int height, [NativeTypeName("ImFontAtlasRect *")] ImFontAtlasRect_t* out_r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_RemoveCustomRect([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("ImFontAtlasRectId")] int id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFontAtlas_GetCustomRect([NativeTypeName("const ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("ImFontAtlasRectId")] int id, [NativeTypeName("ImFontAtlasRect *")] ImFontAtlasRect_t* out_r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFontAtlasRectId")]
        public static extern int ImFontAtlas_AddCustomRectRegular([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, int w, int h);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImFontAtlasRect *")]
        public static extern ImFontAtlasRect_t* ImFontAtlas_GetCustomRectByIndex([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("ImFontAtlasRectId")] int id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_CalcCustomRectUV([NativeTypeName("const ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("const ImFontAtlasRect *")] ImFontAtlasRect_t* r, [NativeTypeName("ImVec2 *")] ImVec2_t* out_uv_min, [NativeTypeName("ImVec2 *")] ImVec2_t* out_uv_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFontAtlasRectId")]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("ImFont *")] ImFont_t* font, [NativeTypeName("ImWchar")] ushort codepoint, int w, int h, float advance_x, [NativeTypeName("ImVec2")] ImVec2_t offset);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFontAtlasRectId")]
        public static extern int ImFontAtlas_AddCustomRectFontGlyphForSize([NativeTypeName("ImFontAtlas *")] ImFontAtlas_t* self, [NativeTypeName("ImFont *")] ImFont_t* font, float font_size, [NativeTypeName("ImWchar")] ushort codepoint, int w, int h, float advance_x, [NativeTypeName("ImVec2")] ImVec2_t offset);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontBaked_ClearOutputData([NativeTypeName("ImFontBaked *")] ImFontBaked_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFontGlyph *")]
        public static extern ImFontGlyph_t* ImFontBaked_FindGlyph([NativeTypeName("ImFontBaked *")] ImFontBaked_t* self, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFontGlyph *")]
        public static extern ImFontGlyph_t* ImFontBaked_FindGlyphNoFallback([NativeTypeName("ImFontBaked *")] ImFontBaked_t* self, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float ImFontBaked_GetCharAdvance([NativeTypeName("ImFontBaked *")] ImFontBaked_t* self, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFontBaked_IsGlyphLoaded([NativeTypeName("ImFontBaked *")] ImFontBaked_t* self, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFont_IsGlyphInFont([NativeTypeName("ImFont *")] ImFont_t* self, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFont_IsLoaded([NativeTypeName("const ImFont *")] ImFont_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImFont_GetDebugName([NativeTypeName("const ImFont *")] ImFont_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFontBaked *")]
        public static extern ImFontBaked_t* ImFont_GetFontBaked([NativeTypeName("ImFont *")] ImFont_t* self, float font_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFontBaked *")]
        public static extern ImFontBaked_t* ImFont_GetFontBakedEx([NativeTypeName("ImFont *")] ImFont_t* self, float font_size, float density);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t ImFont_CalcTextSizeA([NativeTypeName("ImFont *")] ImFont_t* self, float size, float max_width, float wrap_width, [NativeTypeName("const char *")] sbyte* text_begin);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t ImFont_CalcTextSizeAEx([NativeTypeName("ImFont *")] ImFont_t* self, float size, float max_width, float wrap_width, [NativeTypeName("const char *")] sbyte* text_begin, [NativeTypeName("const char *")] sbyte* text_end, [NativeTypeName("const char **")] sbyte** out_remaining);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImFont_CalcWordWrapPosition([NativeTypeName("ImFont *")] ImFont_t* self, float size, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, float wrap_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_RenderChar([NativeTypeName("ImFont *")] ImFont_t* self, [NativeTypeName("ImDrawList *")] ImDrawList_t* draw_list, float size, [NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_RenderCharEx([NativeTypeName("ImFont *")] ImFont_t* self, [NativeTypeName("ImDrawList *")] ImDrawList_t* draw_list, float size, [NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("ImWchar")] ushort c, [NativeTypeName("const ImVec4 *")] ImVec4_t* cpu_fine_clip);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_RenderText([NativeTypeName("ImFont *")] ImFont_t* self, [NativeTypeName("ImDrawList *")] ImDrawList_t* draw_list, float size, [NativeTypeName("ImVec2")] ImVec2_t pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("ImVec4")] ImVec4_t clip_rect, [NativeTypeName("const char *")] sbyte* text_begin, [NativeTypeName("const char *")] sbyte* text_end, float wrap_width, [NativeTypeName("ImDrawTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImFont_CalcWordWrapPositionA([NativeTypeName("ImFont *")] ImFont_t* self, float scale, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, float wrap_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_ClearOutputData([NativeTypeName("ImFont *")] ImFont_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_AddRemapChar([NativeTypeName("ImFont *")] ImFont_t* self, [NativeTypeName("ImWchar")] ushort from_codepoint, [NativeTypeName("ImWchar")] ushort to_codepoint);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFont_IsGlyphRangeUnused([NativeTypeName("ImFont *")] ImFont_t* self, [NativeTypeName("unsigned int")] uint c_begin, [NativeTypeName("unsigned int")] uint c_last);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t ImGuiViewport_GetCenter([NativeTypeName("const ImGuiViewport *")] ImGuiViewport_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t ImGuiViewport_GetWorkCenter([NativeTypeName("const ImGuiViewport *")] ImGuiViewport_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImGuiViewport_GetDebugName([NativeTypeName("const ImGuiViewport *")] ImGuiViewport_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPlatformIO_ClearPlatformHandlers([NativeTypeName("ImGuiPlatformIO *")] ImGuiPlatformIO_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPlatformIO_ClearRendererHandlers([NativeTypeName("ImGuiPlatformIO *")] ImGuiPlatformIO_t* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetColorEditOptions([NativeTypeName("ImGuiColorEditFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushFont([NativeTypeName("ImFont *")] ImFont_t* font);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowFontScale(float scale);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImageImVec4([NativeTypeName("ImTextureRef")] ImTextureRef_t tex_ref, [NativeTypeName("ImVec2")] ImVec2_t image_size, [NativeTypeName("ImVec2")] ImVec2_t uv0, [NativeTypeName("ImVec2")] ImVec2_t uv1, [NativeTypeName("ImVec4")] ImVec4_t tint_col, [NativeTypeName("ImVec4")] ImVec4_t border_col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushButtonRepeat([NativeTypeName("bool")] byte repeat);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopButtonRepeat();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushTabStop([NativeTypeName("bool")] byte tab_stop);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopTabStop();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetContentRegionMax();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetWindowContentRegionMin();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImVec2")]
        public static extern ImVec2_t igGetWindowContentRegionMax();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_setup", ExactSpelling = true)]
        public static extern void setup([NativeTypeName("const simgui_desc_t *")] simgui_desc_t* desc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_new_frame", ExactSpelling = true)]
        public static extern void new_frame([NativeTypeName("const simgui_frame_desc_t *")] simgui_frame_desc_t* desc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_render", ExactSpelling = true)]
        public static extern void render();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_imtextureid", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong imtextureid(sg_view tex_view);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_imtextureid_with_sampler", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong imtextureid_with_sampler(sg_view tex_view, sg_sampler smp);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_texture_view_from_imtextureid", ExactSpelling = true)]
        public static extern sg_view texture_view_from_imtextureid([NativeTypeName("uint64_t")] ulong imtex_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_sampler_from_imtextureid", ExactSpelling = true)]
        public static extern sg_sampler sampler_from_imtextureid([NativeTypeName("uint64_t")] ulong imtex_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_add_focus_event", ExactSpelling = true)]
        public static extern void add_focus_event([NativeTypeName("bool")] byte focus);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_add_mouse_pos_event", ExactSpelling = true)]
        public static extern void add_mouse_pos_event(float x, float y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_add_touch_pos_event", ExactSpelling = true)]
        public static extern void add_touch_pos_event(float x, float y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_add_mouse_button_event", ExactSpelling = true)]
        public static extern void add_mouse_button_event(int mouse_button, [NativeTypeName("bool")] byte down);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_add_mouse_wheel_event", ExactSpelling = true)]
        public static extern void add_mouse_wheel_event(float wheel_x, float wheel_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_add_key_event", ExactSpelling = true)]
        public static extern void add_key_event(int imgui_key, [NativeTypeName("bool")] byte down);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_add_input_character", ExactSpelling = true)]
        public static extern void add_input_character([NativeTypeName("uint32_t")] uint c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_add_input_characters_utf8", ExactSpelling = true)]
        public static extern void add_input_characters_utf8([NativeTypeName("const char *")] sbyte* c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_add_touch_button_event", ExactSpelling = true)]
        public static extern void add_touch_button_event(int mouse_button, [NativeTypeName("bool")] byte down);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_handle_event", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte handle_event([NativeTypeName("const sapp_event *")] sapp_event* ev);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_map_keycode", ExactSpelling = true)]
        public static extern int map_keycode(sapp_keycode keycode);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_shutdown", ExactSpelling = true)]
        public static extern void shutdown();
    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Zinc.Internal.Sokol.ImGuiDataType_;
using static Zinc.Internal.Sokol.ImGuiHoveredFlags_;
using static Zinc.Internal.Sokol.ImGuiInputFlags_;
using static Zinc.Internal.Sokol.ImGuiItemFlags_;
using static Zinc.Internal.Sokol.ImGuiTabItemFlags_;
using static Zinc.Internal.Sokol.ImGuiTreeNodeFlags_;

namespace Zinc.Internal.Sokol
{
    public partial struct ImGuiInputTextDeactivateData
    {
    }

    public partial struct ImGuiInputTextDeactivateData
    {
    }

    public partial struct ImGuiTableColumnsSettings
    {
    }

    public partial struct ImGuiTableColumnsSettings
    {
    }

    public partial struct STB_TexteditState
    {
    }

    public partial struct STB_TexteditState
    {
    }

    public partial struct ImVec2
    {
        public float x;

        public float y;
    }

    public partial struct ImVec4
    {
        public float x;

        public float y;

        public float z;

        public float w;
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
        ImGuiWindowFlags_NoNav = ImGuiWindowFlags_NoNavInputs | ImGuiWindowFlags_NoNavFocus,
        ImGuiWindowFlags_NoDecoration = ImGuiWindowFlags_NoTitleBar | ImGuiWindowFlags_NoResize | ImGuiWindowFlags_NoScrollbar | ImGuiWindowFlags_NoCollapse,
        ImGuiWindowFlags_NoInputs = ImGuiWindowFlags_NoMouseInputs | ImGuiWindowFlags_NoNavInputs | ImGuiWindowFlags_NoNavFocus,
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
        ImGuiInputTextFlags_CallbackCompletion = 1 << 17,
        ImGuiInputTextFlags_CallbackHistory = 1 << 18,
        ImGuiInputTextFlags_CallbackAlways = 1 << 19,
        ImGuiInputTextFlags_CallbackCharFilter = 1 << 20,
        ImGuiInputTextFlags_CallbackResize = 1 << 21,
        ImGuiInputTextFlags_CallbackEdit = 1 << 22,
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
        ImGuiTreeNodeFlags_SpanTextWidth = 1 << 13,
        ImGuiTreeNodeFlags_SpanAllColumns = 1 << 14,
        ImGuiTreeNodeFlags_NavLeftJumpsBackHere = 1 << 15,
        ImGuiTreeNodeFlags_CollapsingHeader = ImGuiTreeNodeFlags_Framed | ImGuiTreeNodeFlags_NoTreePushOnOpen | ImGuiTreeNodeFlags_NoAutoOpenOnLog,
    }

    public enum ImGuiPopupFlags_
    {
        ImGuiPopupFlags_None = 0,
        ImGuiPopupFlags_MouseButtonLeft = 0,
        ImGuiPopupFlags_MouseButtonRight = 1,
        ImGuiPopupFlags_MouseButtonMiddle = 2,
        ImGuiPopupFlags_MouseButtonMask_ = 0x1F,
        ImGuiPopupFlags_MouseButtonDefault_ = 1,
        ImGuiPopupFlags_NoReopen = 1 << 5,
        ImGuiPopupFlags_NoOpenOverExistingPopup = 1 << 7,
        ImGuiPopupFlags_NoOpenOverItems = 1 << 8,
        ImGuiPopupFlags_AnyPopupId = 1 << 10,
        ImGuiPopupFlags_AnyPopupLevel = 1 << 11,
        ImGuiPopupFlags_AnyPopup = ImGuiPopupFlags_AnyPopupId | ImGuiPopupFlags_AnyPopupLevel,
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
        ImGuiTabBarFlags_FittingPolicyResizeDown = 1 << 7,
        ImGuiTabBarFlags_FittingPolicyScroll = 1 << 8,
        ImGuiTabBarFlags_FittingPolicyMask_ = ImGuiTabBarFlags_FittingPolicyResizeDown | ImGuiTabBarFlags_FittingPolicyScroll,
        ImGuiTabBarFlags_FittingPolicyDefault_ = ImGuiTabBarFlags_FittingPolicyResizeDown,
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
        ImGuiFocusedFlags_RootAndChildWindows = ImGuiFocusedFlags_RootWindow | ImGuiFocusedFlags_ChildWindows,
    }

    public enum ImGuiHoveredFlags_
    {
        ImGuiHoveredFlags_None = 0,
        ImGuiHoveredFlags_ChildWindows = 1 << 0,
        ImGuiHoveredFlags_RootWindow = 1 << 1,
        ImGuiHoveredFlags_AnyWindow = 1 << 2,
        ImGuiHoveredFlags_NoPopupHierarchy = 1 << 3,
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
        ImGuiDataType_COUNT,
    }

    public enum ImGuiDir
    {
        ImGuiDir_None = -1,
        ImGuiDir_Left = 0,
        ImGuiDir_Right = 1,
        ImGuiDir_Up = 2,
        ImGuiDir_Down = 3,
        ImGuiDir_COUNT = 4,
    }

    public enum ImGuiSortDirection
    {
        ImGuiSortDirection_None = 0,
        ImGuiSortDirection_Ascending = 1,
        ImGuiSortDirection_Descending = 2,
    }

    public enum ImGuiKey
    {
        ImGuiKey_None = 0,
        ImGuiKey_NamedKey_BEGIN = 512,
        ImGuiKey_Tab = 512,
        ImGuiKey_LeftArrow = 513,
        ImGuiKey_RightArrow = 514,
        ImGuiKey_UpArrow = 515,
        ImGuiKey_DownArrow = 516,
        ImGuiKey_PageUp = 517,
        ImGuiKey_PageDown = 518,
        ImGuiKey_Home = 519,
        ImGuiKey_End = 520,
        ImGuiKey_Insert = 521,
        ImGuiKey_Delete = 522,
        ImGuiKey_Backspace = 523,
        ImGuiKey_Space = 524,
        ImGuiKey_Enter = 525,
        ImGuiKey_Escape = 526,
        ImGuiKey_LeftCtrl = 527,
        ImGuiKey_LeftShift = 528,
        ImGuiKey_LeftAlt = 529,
        ImGuiKey_LeftSuper = 530,
        ImGuiKey_RightCtrl = 531,
        ImGuiKey_RightShift = 532,
        ImGuiKey_RightAlt = 533,
        ImGuiKey_RightSuper = 534,
        ImGuiKey_Menu = 535,
        ImGuiKey_0 = 536,
        ImGuiKey_1 = 537,
        ImGuiKey_2 = 538,
        ImGuiKey_3 = 539,
        ImGuiKey_4 = 540,
        ImGuiKey_5 = 541,
        ImGuiKey_6 = 542,
        ImGuiKey_7 = 543,
        ImGuiKey_8 = 544,
        ImGuiKey_9 = 545,
        ImGuiKey_A = 546,
        ImGuiKey_B = 547,
        ImGuiKey_C = 548,
        ImGuiKey_D = 549,
        ImGuiKey_E = 550,
        ImGuiKey_F = 551,
        ImGuiKey_G = 552,
        ImGuiKey_H = 553,
        ImGuiKey_I = 554,
        ImGuiKey_J = 555,
        ImGuiKey_K = 556,
        ImGuiKey_L = 557,
        ImGuiKey_M = 558,
        ImGuiKey_N = 559,
        ImGuiKey_O = 560,
        ImGuiKey_P = 561,
        ImGuiKey_Q = 562,
        ImGuiKey_R = 563,
        ImGuiKey_S = 564,
        ImGuiKey_T = 565,
        ImGuiKey_U = 566,
        ImGuiKey_V = 567,
        ImGuiKey_W = 568,
        ImGuiKey_X = 569,
        ImGuiKey_Y = 570,
        ImGuiKey_Z = 571,
        ImGuiKey_F1 = 572,
        ImGuiKey_F2 = 573,
        ImGuiKey_F3 = 574,
        ImGuiKey_F4 = 575,
        ImGuiKey_F5 = 576,
        ImGuiKey_F6 = 577,
        ImGuiKey_F7 = 578,
        ImGuiKey_F8 = 579,
        ImGuiKey_F9 = 580,
        ImGuiKey_F10 = 581,
        ImGuiKey_F11 = 582,
        ImGuiKey_F12 = 583,
        ImGuiKey_F13 = 584,
        ImGuiKey_F14 = 585,
        ImGuiKey_F15 = 586,
        ImGuiKey_F16 = 587,
        ImGuiKey_F17 = 588,
        ImGuiKey_F18 = 589,
        ImGuiKey_F19 = 590,
        ImGuiKey_F20 = 591,
        ImGuiKey_F21 = 592,
        ImGuiKey_F22 = 593,
        ImGuiKey_F23 = 594,
        ImGuiKey_F24 = 595,
        ImGuiKey_Apostrophe = 596,
        ImGuiKey_Comma = 597,
        ImGuiKey_Minus = 598,
        ImGuiKey_Period = 599,
        ImGuiKey_Slash = 600,
        ImGuiKey_Semicolon = 601,
        ImGuiKey_Equal = 602,
        ImGuiKey_LeftBracket = 603,
        ImGuiKey_Backslash = 604,
        ImGuiKey_RightBracket = 605,
        ImGuiKey_GraveAccent = 606,
        ImGuiKey_CapsLock = 607,
        ImGuiKey_ScrollLock = 608,
        ImGuiKey_NumLock = 609,
        ImGuiKey_PrintScreen = 610,
        ImGuiKey_Pause = 611,
        ImGuiKey_Keypad0 = 612,
        ImGuiKey_Keypad1 = 613,
        ImGuiKey_Keypad2 = 614,
        ImGuiKey_Keypad3 = 615,
        ImGuiKey_Keypad4 = 616,
        ImGuiKey_Keypad5 = 617,
        ImGuiKey_Keypad6 = 618,
        ImGuiKey_Keypad7 = 619,
        ImGuiKey_Keypad8 = 620,
        ImGuiKey_Keypad9 = 621,
        ImGuiKey_KeypadDecimal = 622,
        ImGuiKey_KeypadDivide = 623,
        ImGuiKey_KeypadMultiply = 624,
        ImGuiKey_KeypadSubtract = 625,
        ImGuiKey_KeypadAdd = 626,
        ImGuiKey_KeypadEnter = 627,
        ImGuiKey_KeypadEqual = 628,
        ImGuiKey_AppBack = 629,
        ImGuiKey_AppForward = 630,
        ImGuiKey_GamepadStart = 631,
        ImGuiKey_GamepadBack = 632,
        ImGuiKey_GamepadFaceLeft = 633,
        ImGuiKey_GamepadFaceRight = 634,
        ImGuiKey_GamepadFaceUp = 635,
        ImGuiKey_GamepadFaceDown = 636,
        ImGuiKey_GamepadDpadLeft = 637,
        ImGuiKey_GamepadDpadRight = 638,
        ImGuiKey_GamepadDpadUp = 639,
        ImGuiKey_GamepadDpadDown = 640,
        ImGuiKey_GamepadL1 = 641,
        ImGuiKey_GamepadR1 = 642,
        ImGuiKey_GamepadL2 = 643,
        ImGuiKey_GamepadR2 = 644,
        ImGuiKey_GamepadL3 = 645,
        ImGuiKey_GamepadR3 = 646,
        ImGuiKey_GamepadLStickLeft = 647,
        ImGuiKey_GamepadLStickRight = 648,
        ImGuiKey_GamepadLStickUp = 649,
        ImGuiKey_GamepadLStickDown = 650,
        ImGuiKey_GamepadRStickLeft = 651,
        ImGuiKey_GamepadRStickRight = 652,
        ImGuiKey_GamepadRStickUp = 653,
        ImGuiKey_GamepadRStickDown = 654,
        ImGuiKey_MouseLeft = 655,
        ImGuiKey_MouseRight = 656,
        ImGuiKey_MouseMiddle = 657,
        ImGuiKey_MouseX1 = 658,
        ImGuiKey_MouseX2 = 659,
        ImGuiKey_MouseWheelX = 660,
        ImGuiKey_MouseWheelY = 661,
        ImGuiKey_ReservedForModCtrl = 662,
        ImGuiKey_ReservedForModShift = 663,
        ImGuiKey_ReservedForModAlt = 664,
        ImGuiKey_ReservedForModSuper = 665,
        ImGuiKey_NamedKey_END = 666,
        ImGuiMod_None = 0,
        ImGuiMod_Ctrl = 1 << 12,
        ImGuiMod_Shift = 1 << 13,
        ImGuiMod_Alt = 1 << 14,
        ImGuiMod_Super = 1 << 15,
        ImGuiMod_Mask_ = 0xF000,
        ImGuiKey_NamedKey_COUNT = ImGuiKey_NamedKey_END - ImGuiKey_NamedKey_BEGIN,
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
        ImGuiConfigFlags_IsSRGB = 1 << 20,
        ImGuiConfigFlags_IsTouchScreen = 1 << 21,
    }

    public enum ImGuiBackendFlags_
    {
        ImGuiBackendFlags_None = 0,
        ImGuiBackendFlags_HasGamepad = 1 << 0,
        ImGuiBackendFlags_HasMouseCursors = 1 << 1,
        ImGuiBackendFlags_HasSetMousePos = 1 << 2,
        ImGuiBackendFlags_RendererHasVtxOffset = 1 << 3,
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
        ImGuiCol_TabHovered,
        ImGuiCol_Tab,
        ImGuiCol_TabSelected,
        ImGuiCol_TabSelectedOverline,
        ImGuiCol_TabDimmed,
        ImGuiCol_TabDimmedSelected,
        ImGuiCol_TabDimmedSelectedOverline,
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
        ImGuiCol_DragDropTarget,
        ImGuiCol_NavCursor,
        ImGuiCol_NavWindowingHighlight,
        ImGuiCol_NavWindowingDimBg,
        ImGuiCol_ModalWindowDimBg,
        ImGuiCol_COUNT,
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
        ImGuiStyleVar_GrabMinSize,
        ImGuiStyleVar_GrabRounding,
        ImGuiStyleVar_TabRounding,
        ImGuiStyleVar_TabBorderSize,
        ImGuiStyleVar_TabBarBorderSize,
        ImGuiStyleVar_TabBarOverlineSize,
        ImGuiStyleVar_TableAngledHeadersAngle,
        ImGuiStyleVar_TableAngledHeadersTextAlign,
        ImGuiStyleVar_ButtonTextAlign,
        ImGuiStyleVar_SelectableTextAlign,
        ImGuiStyleVar_SeparatorTextBorderSize,
        ImGuiStyleVar_SeparatorTextAlign,
        ImGuiStyleVar_SeparatorTextPadding,
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
        ImGuiColorEditFlags_AlphaBar = 1 << 16,
        ImGuiColorEditFlags_AlphaPreview = 1 << 17,
        ImGuiColorEditFlags_AlphaPreviewHalf = 1 << 18,
        ImGuiColorEditFlags_HDR = 1 << 19,
        ImGuiColorEditFlags_DisplayRGB = 1 << 20,
        ImGuiColorEditFlags_DisplayHSV = 1 << 21,
        ImGuiColorEditFlags_DisplayHex = 1 << 22,
        ImGuiColorEditFlags_Uint8 = 1 << 23,
        ImGuiColorEditFlags_Float = 1 << 24,
        ImGuiColorEditFlags_PickerHueBar = 1 << 25,
        ImGuiColorEditFlags_PickerHueWheel = 1 << 26,
        ImGuiColorEditFlags_InputRGB = 1 << 27,
        ImGuiColorEditFlags_InputHSV = 1 << 28,
        ImGuiColorEditFlags_DefaultOptions_ = ImGuiColorEditFlags_Uint8 | ImGuiColorEditFlags_DisplayRGB | ImGuiColorEditFlags_InputRGB | ImGuiColorEditFlags_PickerHueBar,
        ImGuiColorEditFlags_DisplayMask_ = ImGuiColorEditFlags_DisplayRGB | ImGuiColorEditFlags_DisplayHSV | ImGuiColorEditFlags_DisplayHex,
        ImGuiColorEditFlags_DataTypeMask_ = ImGuiColorEditFlags_Uint8 | ImGuiColorEditFlags_Float,
        ImGuiColorEditFlags_PickerMask_ = ImGuiColorEditFlags_PickerHueWheel | ImGuiColorEditFlags_PickerHueBar,
        ImGuiColorEditFlags_InputMask_ = ImGuiColorEditFlags_InputRGB | ImGuiColorEditFlags_InputHSV,
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
        ImGuiMouseCursor_NotAllowed,
        ImGuiMouseCursor_COUNT,
    }

    public enum ImGuiMouseSource
    {
        ImGuiMouseSource_Mouse = 0,
        ImGuiMouseSource_TouchScreen = 1,
        ImGuiMouseSource_Pen = 2,
        ImGuiMouseSource_COUNT = 3,
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

    public unsafe partial struct ImGuiTableSortSpecs
    {
        [NativeTypeName("const ImGuiTableColumnSortSpecs *")]
        public ImGuiTableColumnSortSpecs* Specs;

        public int SpecsCount;

        [NativeTypeName("bool")]
        public byte SpecsDirty;
    }

    public partial struct ImGuiTableColumnSortSpecs
    {
        [NativeTypeName("ImGuiID")]
        public uint ColumnUserID;

        [NativeTypeName("ImS16")]
        public short ColumnIndex;

        [NativeTypeName("ImS16")]
        public short SortOrder;

        public ImGuiSortDirection SortDirection;
    }

    public partial struct ImGuiStyle
    {
        public float Alpha;

        public float DisabledAlpha;

        public ImVec2 WindowPadding;

        public float WindowRounding;

        public float WindowBorderSize;

        public ImVec2 WindowMinSize;

        public ImVec2 WindowTitleAlign;

        public ImGuiDir WindowMenuButtonPosition;

        public float ChildRounding;

        public float ChildBorderSize;

        public float PopupRounding;

        public float PopupBorderSize;

        public ImVec2 FramePadding;

        public float FrameRounding;

        public float FrameBorderSize;

        public ImVec2 ItemSpacing;

        public ImVec2 ItemInnerSpacing;

        public ImVec2 CellPadding;

        public ImVec2 TouchExtraPadding;

        public float IndentSpacing;

        public float ColumnsMinSpacing;

        public float ScrollbarSize;

        public float ScrollbarRounding;

        public float GrabMinSize;

        public float GrabRounding;

        public float LogSliderDeadzone;

        public float TabRounding;

        public float TabBorderSize;

        public float TabMinWidthForCloseButton;

        public float TabBarBorderSize;

        public float TabBarOverlineSize;

        public float TableAngledHeadersAngle;

        public ImVec2 TableAngledHeadersTextAlign;

        public ImGuiDir ColorButtonPosition;

        public ImVec2 ButtonTextAlign;

        public ImVec2 SelectableTextAlign;

        public float SeparatorTextBorderSize;

        public ImVec2 SeparatorTextAlign;

        public ImVec2 SeparatorTextPadding;

        public ImVec2 DisplayWindowPadding;

        public ImVec2 DisplaySafeAreaPadding;

        public float MouseCursorScale;

        [NativeTypeName("bool")]
        public byte AntiAliasedLines;

        [NativeTypeName("bool")]
        public byte AntiAliasedLinesUseTex;

        [NativeTypeName("bool")]
        public byte AntiAliasedFill;

        public float CurveTessellationTol;

        public float CircleTessellationMaxError;

        [NativeTypeName("ImVec4[56]")]
        public _Colors_e__FixedBuffer Colors;

        public float HoverStationaryDelay;

        public float HoverDelayShort;

        public float HoverDelayNormal;

        [NativeTypeName("ImGuiHoveredFlags")]
        public int HoverFlagsForTooltipMouse;

        [NativeTypeName("ImGuiHoveredFlags")]
        public int HoverFlagsForTooltipNav;

        [InlineArray(56)]
        public partial struct _Colors_e__FixedBuffer
        {
            public ImVec4 e0;
        }
    }

    public partial struct ImGuiKeyData
    {
        [NativeTypeName("bool")]
        public byte Down;

        public float DownDuration;

        public float DownDurationPrev;

        public float AnalogValue;
    }

    public unsafe partial struct ImVector_ImWchar
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImWchar *")]
        public ushort* Data;
    }

    public unsafe partial struct ImGuiIO
    {
        [NativeTypeName("ImGuiConfigFlags")]
        public int ConfigFlags;

        [NativeTypeName("ImGuiBackendFlags")]
        public int BackendFlags;

        public ImVec2 DisplaySize;

        public float DeltaTime;

        public float IniSavingRate;

        [NativeTypeName("const char *")]
        public sbyte* IniFilename;

        [NativeTypeName("const char *")]
        public sbyte* LogFilename;

        public void* UserData;

        public ImFontAtlas* Fonts;

        public float FontGlobalScale;

        [NativeTypeName("bool")]
        public byte FontAllowUserScaling;

        public ImFont* FontDefault;

        public ImVec2 DisplayFramebufferScale;

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
        public byte MouseDrawCursor;

        [NativeTypeName("bool")]
        public byte ConfigMacOSXBehaviors;

        [NativeTypeName("bool")]
        public byte ConfigInputTrickleEventQueue;

        [NativeTypeName("bool")]
        public byte ConfigInputTextCursorBlink;

        [NativeTypeName("bool")]
        public byte ConfigInputTextEnterKeepActive;

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

        public float ConfigMemoryCompactTimer;

        public float MouseDoubleClickTime;

        public float MouseDoubleClickMaxDist;

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
        public byte ConfigDebugBeginReturnValueOnce;

        [NativeTypeName("bool")]
        public byte ConfigDebugBeginReturnValueLoop;

        [NativeTypeName("bool")]
        public byte ConfigDebugIgnoreFocusLoss;

        [NativeTypeName("bool")]
        public byte ConfigDebugIniSettings;

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

        public ImVec2 MouseDelta;

        public ImGuiContext* Ctx;

        public ImVec2 MousePos;

        [NativeTypeName("bool[5]")]
        public _MouseDown_e__FixedBuffer MouseDown;

        public float MouseWheel;

        public float MouseWheelH;

        public ImGuiMouseSource MouseSource;

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

        [NativeTypeName("ImGuiKeyData[154]")]
        public _KeysData_e__FixedBuffer KeysData;

        [NativeTypeName("bool")]
        public byte WantCaptureMouseUnlessPopupClose;

        public ImVec2 MousePosPrev;

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

        [NativeTypeName("float[5]")]
        public _MouseDragMaxDistanceSqr_e__FixedBuffer MouseDragMaxDistanceSqr;

        public float PenPressure;

        [NativeTypeName("bool")]
        public byte AppFocusLost;

        [NativeTypeName("bool")]
        public byte AppAcceptingEvents;

        [NativeTypeName("ImWchar16")]
        public ushort InputQueueSurrogate;

        public ImVector_ImWchar InputQueueCharacters;

        [InlineArray(5)]
        public partial struct _MouseDown_e__FixedBuffer
        {
            public bool e0;
        }

        [InlineArray(154)]
        public partial struct _KeysData_e__FixedBuffer
        {
            public ImGuiKeyData e0;
        }

        [InlineArray(5)]
        public partial struct _MouseClickedPos_e__FixedBuffer
        {
            public ImVec2 e0;
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
        public partial struct _MouseDragMaxDistanceSqr_e__FixedBuffer
        {
            public float e0;
        }
    }

    public unsafe partial struct ImGuiInputTextCallbackData
    {
        public ImGuiContext* Ctx;

        [NativeTypeName("ImGuiInputTextFlags")]
        public int EventFlag;

        [NativeTypeName("ImGuiInputTextFlags")]
        public int Flags;

        public void* UserData;

        [NativeTypeName("ImWchar")]
        public ushort EventChar;

        public ImGuiKey EventKey;

        [NativeTypeName("char *")]
        public sbyte* Buf;

        public int BufTextLen;

        public int BufSize;

        [NativeTypeName("bool")]
        public byte BufDirty;

        public int CursorPos;

        public int SelectionStart;

        public int SelectionEnd;
    }

    public unsafe partial struct ImGuiSizeCallbackData
    {
        public void* UserData;

        public ImVec2 Pos;

        public ImVec2 CurrentSize;

        public ImVec2 DesiredSize;
    }

    public unsafe partial struct ImGuiPayload
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

    public partial struct ImGuiOnceUponAFrame
    {
        public int RefFrame;
    }

    public unsafe partial struct ImGuiTextRange
    {
        [NativeTypeName("const char *")]
        public sbyte* b;

        [NativeTypeName("const char *")]
        public sbyte* e;
    }

    public unsafe partial struct ImVector_ImGuiTextRange
    {
        public int Size;

        public int Capacity;

        public ImGuiTextRange* Data;
    }

    public partial struct ImGuiTextFilter
    {
        [NativeTypeName("char[256]")]
        public _InputBuf_e__FixedBuffer InputBuf;

        public ImVector_ImGuiTextRange Filters;

        public int CountGrep;

        [InlineArray(256)]
        public partial struct _InputBuf_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public unsafe partial struct ImVector_char
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("char *")]
        public sbyte* Data;
    }

    public partial struct ImGuiTextBuffer
    {
        public ImVector_char Buf;
    }

    public unsafe partial struct ImGuiStoragePair
    {
        [NativeTypeName("ImGuiID")]
        public uint key;

        [NativeTypeName("__AnonymousRecord_cimgui_L1155_C5")]
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

    public unsafe partial struct ImVector_ImGuiStoragePair
    {
        public int Size;

        public int Capacity;

        public ImGuiStoragePair* Data;
    }

    public partial struct ImGuiStorage
    {
        public ImVector_ImGuiStoragePair Data;
    }

    public unsafe partial struct ImGuiListClipper
    {
        public ImGuiContext* Ctx;

        public int DisplayStart;

        public int DisplayEnd;

        public int ItemsCount;

        public float ItemsHeight;

        public float StartPosY;

        public double StartSeekOffsetY;

        public void* TempData;
    }

    public partial struct ImColor
    {
        public ImVec4 Value;
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
        ImGuiMultiSelectFlags_SelectOnClick = 1 << 13,
        ImGuiMultiSelectFlags_SelectOnClickRelease = 1 << 14,
        ImGuiMultiSelectFlags_NavWrapX = 1 << 16,
    }

    public unsafe partial struct ImVector_ImGuiSelectionRequest
    {
        public int Size;

        public int Capacity;

        public ImGuiSelectionRequest* Data;
    }

    public partial struct ImGuiMultiSelectIO
    {
        public ImVector_ImGuiSelectionRequest Requests;

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

    public partial struct ImGuiSelectionRequest
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

    public unsafe partial struct ImGuiSelectionBasicStorage
    {
        public int Size;

        [NativeTypeName("bool")]
        public byte PreserveOrder;

        public void* UserData;

        [NativeTypeName("ImGuiID (*)(ImGuiSelectionBasicStorage *, int)")]
        public delegate* unmanaged[Cdecl]<ImGuiSelectionBasicStorage*, int, uint> AdapterIndexToStorageId;

        public int _SelectionOrder;

        public ImGuiStorage _Storage;
    }

    public unsafe partial struct ImGuiSelectionExternalStorage
    {
        public void* UserData;

        [NativeTypeName("void (*)(ImGuiSelectionExternalStorage *, int, bool)")]
        public delegate* unmanaged[Cdecl]<ImGuiSelectionExternalStorage*, int, byte, void> AdapterSetItemSelected;
    }

    public unsafe partial struct ImDrawCmd
    {
        public ImVec4 ClipRect;

        [NativeTypeName("ImTextureID")]
        public ulong TextureId;

        [NativeTypeName("unsigned int")]
        public uint VtxOffset;

        [NativeTypeName("unsigned int")]
        public uint IdxOffset;

        [NativeTypeName("unsigned int")]
        public uint ElemCount;

        [NativeTypeName("ImDrawCallback")]
        public delegate* unmanaged[Cdecl]<ImDrawList*, ImDrawCmd*, void> UserCallback;

        public void* UserCallbackData;

        public int UserCallbackDataSize;

        public int UserCallbackDataOffset;
    }

    public partial struct ImDrawVert
    {
        public ImVec2 pos;

        public ImVec2 uv;

        [NativeTypeName("ImU32")]
        public uint col;
    }

    public partial struct ImDrawCmdHeader
    {
        public ImVec4 ClipRect;

        [NativeTypeName("ImTextureID")]
        public ulong TextureId;

        [NativeTypeName("unsigned int")]
        public uint VtxOffset;
    }

    public unsafe partial struct ImVector_ImDrawCmd
    {
        public int Size;

        public int Capacity;

        public ImDrawCmd* Data;
    }

    public unsafe partial struct ImVector_ImDrawIdx
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImDrawIdx *")]
        public ushort* Data;
    }

    public partial struct ImDrawChannel
    {
        public ImVector_ImDrawCmd _CmdBuffer;

        public ImVector_ImDrawIdx _IdxBuffer;
    }

    public unsafe partial struct ImVector_ImDrawChannel
    {
        public int Size;

        public int Capacity;

        public ImDrawChannel* Data;
    }

    public partial struct ImDrawListSplitter
    {
        public int _Current;

        public int _Count;

        public ImVector_ImDrawChannel _Channels;
    }

    public enum ImDrawFlags_
    {
        ImDrawFlags_None = 0,
        ImDrawFlags_Closed = 1 << 0,
        ImDrawFlags_RoundCornersTopLeft = 1 << 4,
        ImDrawFlags_RoundCornersTopRight = 1 << 5,
        ImDrawFlags_RoundCornersBottomLeft = 1 << 6,
        ImDrawFlags_RoundCornersBottomRight = 1 << 7,
        ImDrawFlags_RoundCornersNone = 1 << 8,
        ImDrawFlags_RoundCornersTop = ImDrawFlags_RoundCornersTopLeft | ImDrawFlags_RoundCornersTopRight,
        ImDrawFlags_RoundCornersBottom = ImDrawFlags_RoundCornersBottomLeft | ImDrawFlags_RoundCornersBottomRight,
        ImDrawFlags_RoundCornersLeft = ImDrawFlags_RoundCornersBottomLeft | ImDrawFlags_RoundCornersTopLeft,
        ImDrawFlags_RoundCornersRight = ImDrawFlags_RoundCornersBottomRight | ImDrawFlags_RoundCornersTopRight,
        ImDrawFlags_RoundCornersAll = ImDrawFlags_RoundCornersTopLeft | ImDrawFlags_RoundCornersTopRight | ImDrawFlags_RoundCornersBottomLeft | ImDrawFlags_RoundCornersBottomRight,
        ImDrawFlags_RoundCornersDefault_ = ImDrawFlags_RoundCornersAll,
        ImDrawFlags_RoundCornersMask_ = ImDrawFlags_RoundCornersAll | ImDrawFlags_RoundCornersNone,
    }

    public enum ImDrawListFlags_
    {
        ImDrawListFlags_None = 0,
        ImDrawListFlags_AntiAliasedLines = 1 << 0,
        ImDrawListFlags_AntiAliasedLinesUseTex = 1 << 1,
        ImDrawListFlags_AntiAliasedFill = 1 << 2,
        ImDrawListFlags_AllowVtxOffset = 1 << 3,
    }

    public unsafe partial struct ImVector_ImDrawVert
    {
        public int Size;

        public int Capacity;

        public ImDrawVert* Data;
    }

    public unsafe partial struct ImVector_ImVec2
    {
        public int Size;

        public int Capacity;

        public ImVec2* Data;
    }

    public unsafe partial struct ImVector_ImVec4
    {
        public int Size;

        public int Capacity;

        public ImVec4* Data;
    }

    public unsafe partial struct ImVector_ImTextureID
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImTextureID *")]
        public ulong* Data;
    }

    public unsafe partial struct ImVector_ImU8
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImU8 *")]
        public byte* Data;
    }

    public unsafe partial struct ImDrawList
    {
        public ImVector_ImDrawCmd CmdBuffer;

        public ImVector_ImDrawIdx IdxBuffer;

        public ImVector_ImDrawVert VtxBuffer;

        [NativeTypeName("ImDrawListFlags")]
        public int Flags;

        [NativeTypeName("unsigned int")]
        public uint _VtxCurrentIdx;

        public ImDrawListSharedData* _Data;

        public ImDrawVert* _VtxWritePtr;

        [NativeTypeName("ImDrawIdx *")]
        public ushort* _IdxWritePtr;

        public ImVector_ImVec2 _Path;

        public ImDrawCmdHeader _CmdHeader;

        public ImDrawListSplitter _Splitter;

        public ImVector_ImVec4 _ClipRectStack;

        public ImVector_ImTextureID _TextureIdStack;

        public ImVector_ImU8 _CallbacksDataBuf;

        public float _FringeScale;

        [NativeTypeName("const char *")]
        public sbyte* _OwnerName;
    }

    public unsafe partial struct ImVector_ImDrawListPtr
    {
        public int Size;

        public int Capacity;

        public ImDrawList** Data;
    }

    public unsafe partial struct ImDrawData
    {
        [NativeTypeName("bool")]
        public byte Valid;

        public int CmdListsCount;

        public int TotalIdxCount;

        public int TotalVtxCount;

        public ImVector_ImDrawListPtr CmdLists;

        public ImVec2 DisplayPos;

        public ImVec2 DisplaySize;

        public ImVec2 FramebufferScale;

        public ImGuiViewport* OwnerViewport;
    }

    public unsafe partial struct ImFontConfig
    {
        public void* FontData;

        public int FontDataSize;

        [NativeTypeName("bool")]
        public byte FontDataOwnedByAtlas;

        public int FontNo;

        public float SizePixels;

        public int OversampleH;

        public int OversampleV;

        [NativeTypeName("bool")]
        public byte PixelSnapH;

        public ImVec2 GlyphExtraSpacing;

        public ImVec2 GlyphOffset;

        [NativeTypeName("const ImWchar *")]
        public ushort* GlyphRanges;

        public float GlyphMinAdvanceX;

        public float GlyphMaxAdvanceX;

        [NativeTypeName("bool")]
        public byte MergeMode;

        [NativeTypeName("unsigned int")]
        public uint FontBuilderFlags;

        public float RasterizerMultiply;

        public float RasterizerDensity;

        [NativeTypeName("ImWchar")]
        public ushort EllipsisChar;

        [NativeTypeName("char[40]")]
        public _Name_e__FixedBuffer Name;

        public ImFont* DstFont;

        [InlineArray(40)]
        public partial struct _Name_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct ImFontGlyph
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

        [NativeTypeName("unsigned int : 30")]
        public uint Codepoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 2) & 0x3FFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
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
    }

    public unsafe partial struct ImVector_ImU32
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImU32 *")]
        public uint* Data;
    }

    public partial struct ImFontGlyphRangesBuilder
    {
        public ImVector_ImU32 UsedChars;
    }

    public unsafe partial struct ImFontAtlasCustomRect
    {
        [NativeTypeName("unsigned short")]
        public ushort Width;

        [NativeTypeName("unsigned short")]
        public ushort Height;

        [NativeTypeName("unsigned short")]
        public ushort X;

        [NativeTypeName("unsigned short")]
        public ushort Y;

        public uint _bitfield;

        [NativeTypeName("unsigned int : 31")]
        public uint GlyphID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _bitfield & 0x7FFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x7FFFFFFFu) | (value & 0x7FFFFFFFu);
            }
        }

        [NativeTypeName("unsigned int : 1")]
        public uint GlyphColored
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 31) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31);
            }
        }

        public float GlyphAdvanceX;

        public ImVec2 GlyphOffset;

        public ImFont* Font;
    }

    public enum ImFontAtlasFlags_
    {
        ImFontAtlasFlags_None = 0,
        ImFontAtlasFlags_NoPowerOfTwoHeight = 1 << 0,
        ImFontAtlasFlags_NoMouseCursors = 1 << 1,
        ImFontAtlasFlags_NoBakedLines = 1 << 2,
    }

    public unsafe partial struct ImVector_ImFontPtr
    {
        public int Size;

        public int Capacity;

        public ImFont** Data;
    }

    public unsafe partial struct ImVector_ImFontAtlasCustomRect
    {
        public int Size;

        public int Capacity;

        public ImFontAtlasCustomRect* Data;
    }

    public unsafe partial struct ImVector_ImFontConfig
    {
        public int Size;

        public int Capacity;

        public ImFontConfig* Data;
    }

    public unsafe partial struct ImFontAtlas
    {
        [NativeTypeName("ImFontAtlasFlags")]
        public int Flags;

        [NativeTypeName("ImTextureID")]
        public ulong TexID;

        public int TexDesiredWidth;

        public int TexGlyphPadding;

        [NativeTypeName("bool")]
        public byte Locked;

        public void* UserData;

        [NativeTypeName("bool")]
        public byte TexReady;

        [NativeTypeName("bool")]
        public byte TexPixelsUseColors;

        [NativeTypeName("unsigned char *")]
        public byte* TexPixelsAlpha8;

        [NativeTypeName("unsigned int *")]
        public uint* TexPixelsRGBA32;

        public int TexWidth;

        public int TexHeight;

        public ImVec2 TexUvScale;

        public ImVec2 TexUvWhitePixel;

        public ImVector_ImFontPtr Fonts;

        public ImVector_ImFontAtlasCustomRect CustomRects;

        public ImVector_ImFontConfig ConfigData;

        [NativeTypeName("ImVec4[64]")]
        public _TexUvLines_e__FixedBuffer TexUvLines;

        [NativeTypeName("const ImFontBuilderIO *")]
        public ImFontBuilderIO* FontBuilderIO;

        [NativeTypeName("unsigned int")]
        public uint FontBuilderFlags;

        public int PackIdMouseCursors;

        public int PackIdLines;

        [InlineArray(64)]
        public partial struct _TexUvLines_e__FixedBuffer
        {
            public ImVec4 e0;
        }
    }

    public unsafe partial struct ImVector_float
    {
        public int Size;

        public int Capacity;

        public float* Data;
    }

    public unsafe partial struct ImVector_ImFontGlyph
    {
        public int Size;

        public int Capacity;

        public ImFontGlyph* Data;
    }

    public unsafe partial struct ImFont
    {
        public ImVector_float IndexAdvanceX;

        public float FallbackAdvanceX;

        public float FontSize;

        public ImVector_ImWchar IndexLookup;

        public ImVector_ImFontGlyph Glyphs;

        [NativeTypeName("const ImFontGlyph *")]
        public ImFontGlyph* FallbackGlyph;

        public ImFontAtlas* ContainerAtlas;

        [NativeTypeName("const ImFontConfig *")]
        public ImFontConfig* ConfigData;

        public short ConfigDataCount;

        [NativeTypeName("ImWchar")]
        public ushort FallbackChar;

        [NativeTypeName("ImWchar")]
        public ushort EllipsisChar;

        public short EllipsisCharCount;

        public float EllipsisWidth;

        public float EllipsisCharStep;

        [NativeTypeName("bool")]
        public byte DirtyLookupTables;

        public float Scale;

        public float Ascent;

        public float Descent;

        public int MetricsTotalSurface;

        [NativeTypeName("ImU8[2]")]
        public _Used4kPagesMap_e__FixedBuffer Used4kPagesMap;

        [InlineArray(2)]
        public partial struct _Used4kPagesMap_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public enum ImGuiViewportFlags_
    {
        ImGuiViewportFlags_None = 0,
        ImGuiViewportFlags_IsPlatformWindow = 1 << 0,
        ImGuiViewportFlags_IsPlatformMonitor = 1 << 1,
        ImGuiViewportFlags_OwnedByApp = 1 << 2,
    }

    public unsafe partial struct ImGuiViewport
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiViewportFlags")]
        public int Flags;

        public ImVec2 Pos;

        public ImVec2 Size;

        public ImVec2 WorkPos;

        public ImVec2 WorkSize;

        public void* PlatformHandle;

        public void* PlatformHandleRaw;
    }

    public unsafe partial struct ImGuiPlatformIO
    {
        [NativeTypeName("const char *(*)(ImGuiContext *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, sbyte*> Platform_GetClipboardTextFn;

        [NativeTypeName("void (*)(ImGuiContext *, const char *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, sbyte*, void> Platform_SetClipboardTextFn;

        public void* Platform_ClipboardUserData;

        [NativeTypeName("bool (*)(ImGuiContext *, const char *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, sbyte*, byte> Platform_OpenInShellFn;

        public void* Platform_OpenInShellUserData;

        [NativeTypeName("void (*)(ImGuiContext *, ImGuiViewport *, ImGuiPlatformImeData *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, ImGuiViewport*, ImGuiPlatformImeData*, void> Platform_SetImeDataFn;

        public void* Platform_ImeUserData;

        [NativeTypeName("ImWchar")]
        public ushort Platform_LocaleDecimalPoint;

        public void* Renderer_RenderState;
    }

    public partial struct ImGuiPlatformImeData
    {
        [NativeTypeName("bool")]
        public byte WantVisible;

        public ImVec2 InputPos;

        public float InputLineHeight;
    }

    public partial struct ImVec1
    {
        public float x;
    }

    public partial struct ImVec2ih
    {
        public short x;

        public short y;
    }

    public partial struct ImRect
    {
        public ImVec2 Min;

        public ImVec2 Max;
    }

    public partial struct ImBitVector
    {
        public ImVector_ImU32 Storage;
    }

    public unsafe partial struct ImVector_int
    {
        public int Size;

        public int Capacity;

        public int* Data;
    }

    public partial struct ImGuiTextIndex
    {
        public ImVector_int LineOffsets;

        public int EndOffset;
    }

    public unsafe partial struct ImDrawListSharedData
    {
        public ImVec2 TexUvWhitePixel;

        public ImFont* Font;

        public float FontSize;

        public float FontScale;

        public float CurveTessellationTol;

        public float CircleSegmentMaxError;

        public ImVec4 ClipRectFullscreen;

        [NativeTypeName("ImDrawListFlags")]
        public int InitialFlags;

        public ImVector_ImVec2 TempBuffer;

        [NativeTypeName("ImVec2[48]")]
        public _ArcFastVtx_e__FixedBuffer ArcFastVtx;

        public float ArcFastRadiusCutoff;

        [NativeTypeName("ImU8[64]")]
        public _CircleSegmentCounts_e__FixedBuffer CircleSegmentCounts;

        [NativeTypeName("const ImVec4 *")]
        public ImVec4* TexUvLines;

        [InlineArray(48)]
        public partial struct _ArcFastVtx_e__FixedBuffer
        {
            public ImVec2 e0;
        }

        [InlineArray(64)]
        public partial struct _CircleSegmentCounts_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct ImDrawDataBuilder
    {
        [NativeTypeName("ImVector_ImDrawListPtr *[2]")]
        public _Layers_e__FixedBuffer Layers;

        public ImVector_ImDrawListPtr LayerData1;

        public unsafe partial struct _Layers_e__FixedBuffer
        {
            public ImVector_ImDrawListPtr* e0;
            public ImVector_ImDrawListPtr* e1;

            public ref ImVector_ImDrawListPtr* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (ImVector_ImDrawListPtr** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public partial struct ImGuiDataVarInfo
    {
        [NativeTypeName("ImGuiDataType")]
        public int Type;

        [NativeTypeName("ImU32")]
        public uint Count;

        [NativeTypeName("ImU32")]
        public uint Offset;
    }

    public partial struct ImGuiDataTypeStorage
    {
        [NativeTypeName("ImU8[8]")]
        public _Data_e__FixedBuffer Data;

        [InlineArray(8)]
        public partial struct _Data_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public unsafe partial struct ImGuiDataTypeInfo
    {
        [NativeTypeName("size_t")]
        public nuint Size;

        [NativeTypeName("const char *")]
        public sbyte* Name;

        [NativeTypeName("const char *")]
        public sbyte* PrintFmt;

        [NativeTypeName("const char *")]
        public sbyte* ScanFmt;
    }

    public enum ImGuiDataTypePrivate_
    {
        ImGuiDataType_String = ImGuiDataType_COUNT + 1,
        ImGuiDataType_Pointer,
        ImGuiDataType_ID,
    }

    public enum ImGuiItemFlagsPrivate_
    {
        ImGuiItemFlags_Disabled = 1 << 10,
        ImGuiItemFlags_ReadOnly = 1 << 11,
        ImGuiItemFlags_MixedValue = 1 << 12,
        ImGuiItemFlags_NoWindowHoverableCheck = 1 << 13,
        ImGuiItemFlags_AllowOverlap = 1 << 14,
        ImGuiItemFlags_NoNavDisableMouseHover = 1 << 15,
        ImGuiItemFlags_NoMarkEdited = 1 << 16,
        ImGuiItemFlags_Inputable = 1 << 20,
        ImGuiItemFlags_HasSelectionUserData = 1 << 21,
        ImGuiItemFlags_IsMultiSelect = 1 << 22,
        ImGuiItemFlags_Default_ = ImGuiItemFlags_AutoClosePopups,
    }

    public enum ImGuiItemStatusFlags_
    {
        ImGuiItemStatusFlags_None = 0,
        ImGuiItemStatusFlags_HoveredRect = 1 << 0,
        ImGuiItemStatusFlags_HasDisplayRect = 1 << 1,
        ImGuiItemStatusFlags_Edited = 1 << 2,
        ImGuiItemStatusFlags_ToggledSelection = 1 << 3,
        ImGuiItemStatusFlags_ToggledOpen = 1 << 4,
        ImGuiItemStatusFlags_HasDeactivated = 1 << 5,
        ImGuiItemStatusFlags_Deactivated = 1 << 6,
        ImGuiItemStatusFlags_HoveredWindow = 1 << 7,
        ImGuiItemStatusFlags_Visible = 1 << 8,
        ImGuiItemStatusFlags_HasClipRect = 1 << 9,
        ImGuiItemStatusFlags_HasShortcut = 1 << 10,
    }

    public enum ImGuiHoveredFlagsPrivate_
    {
        ImGuiHoveredFlags_DelayMask_ = ImGuiHoveredFlags_DelayNone | ImGuiHoveredFlags_DelayShort | ImGuiHoveredFlags_DelayNormal | ImGuiHoveredFlags_NoSharedDelay,
        ImGuiHoveredFlags_AllowedMaskForIsWindowHovered = ImGuiHoveredFlags_ChildWindows | ImGuiHoveredFlags_RootWindow | ImGuiHoveredFlags_AnyWindow | ImGuiHoveredFlags_NoPopupHierarchy | ImGuiHoveredFlags_AllowWhenBlockedByPopup | ImGuiHoveredFlags_AllowWhenBlockedByActiveItem | ImGuiHoveredFlags_ForTooltip | ImGuiHoveredFlags_Stationary,
        ImGuiHoveredFlags_AllowedMaskForIsItemHovered = ImGuiHoveredFlags_AllowWhenBlockedByPopup | ImGuiHoveredFlags_AllowWhenBlockedByActiveItem | ImGuiHoveredFlags_AllowWhenOverlapped | ImGuiHoveredFlags_AllowWhenDisabled | ImGuiHoveredFlags_NoNavOverride | ImGuiHoveredFlags_ForTooltip | ImGuiHoveredFlags_Stationary | ImGuiHoveredFlags_DelayMask_,
    }

    public enum ImGuiInputTextFlagsPrivate_
    {
        ImGuiInputTextFlags_Multiline = 1 << 26,
        ImGuiInputTextFlags_MergedItem = 1 << 27,
        ImGuiInputTextFlags_LocalizeDecimalPoint = 1 << 28,
    }

    public enum ImGuiButtonFlagsPrivate_
    {
        ImGuiButtonFlags_PressedOnClick = 1 << 4,
        ImGuiButtonFlags_PressedOnClickRelease = 1 << 5,
        ImGuiButtonFlags_PressedOnClickReleaseAnywhere = 1 << 6,
        ImGuiButtonFlags_PressedOnRelease = 1 << 7,
        ImGuiButtonFlags_PressedOnDoubleClick = 1 << 8,
        ImGuiButtonFlags_PressedOnDragDropHold = 1 << 9,
        ImGuiButtonFlags_FlattenChildren = 1 << 11,
        ImGuiButtonFlags_AllowOverlap = 1 << 12,
        ImGuiButtonFlags_AlignTextBaseLine = 1 << 15,
        ImGuiButtonFlags_NoKeyModsAllowed = 1 << 16,
        ImGuiButtonFlags_NoHoldingActiveId = 1 << 17,
        ImGuiButtonFlags_NoNavFocus = 1 << 18,
        ImGuiButtonFlags_NoHoveredOnFocus = 1 << 19,
        ImGuiButtonFlags_NoSetKeyOwner = 1 << 20,
        ImGuiButtonFlags_NoTestKeyOwner = 1 << 21,
        ImGuiButtonFlags_PressedOnMask_ = ImGuiButtonFlags_PressedOnClick | ImGuiButtonFlags_PressedOnClickRelease | ImGuiButtonFlags_PressedOnClickReleaseAnywhere | ImGuiButtonFlags_PressedOnRelease | ImGuiButtonFlags_PressedOnDoubleClick | ImGuiButtonFlags_PressedOnDragDropHold,
        ImGuiButtonFlags_PressedOnDefault_ = ImGuiButtonFlags_PressedOnClickRelease,
    }

    public enum ImGuiComboFlagsPrivate_
    {
        ImGuiComboFlags_CustomPreview = 1 << 20,
    }

    public enum ImGuiSliderFlagsPrivate_
    {
        ImGuiSliderFlags_Vertical = 1 << 20,
        ImGuiSliderFlags_ReadOnly = 1 << 21,
    }

    public enum ImGuiSelectableFlagsPrivate_
    {
        ImGuiSelectableFlags_NoHoldingActiveID = 1 << 20,
        ImGuiSelectableFlags_SelectOnNav = 1 << 21,
        ImGuiSelectableFlags_SelectOnClick = 1 << 22,
        ImGuiSelectableFlags_SelectOnRelease = 1 << 23,
        ImGuiSelectableFlags_SpanAvailWidth = 1 << 24,
        ImGuiSelectableFlags_SetNavIdOnHover = 1 << 25,
        ImGuiSelectableFlags_NoPadWithHalfSpacing = 1 << 26,
        ImGuiSelectableFlags_NoSetKeyOwner = 1 << 27,
    }

    public enum ImGuiTreeNodeFlagsPrivate_
    {
        ImGuiTreeNodeFlags_ClipLabelForTrailingButton = 1 << 28,
        ImGuiTreeNodeFlags_UpsideDownArrow = 1 << 29,
        ImGuiTreeNodeFlags_OpenOnMask_ = ImGuiTreeNodeFlags_OpenOnDoubleClick | ImGuiTreeNodeFlags_OpenOnArrow,
    }

    public enum ImGuiSeparatorFlags_
    {
        ImGuiSeparatorFlags_None = 0,
        ImGuiSeparatorFlags_Horizontal = 1 << 0,
        ImGuiSeparatorFlags_Vertical = 1 << 1,
        ImGuiSeparatorFlags_SpanAllColumns = 1 << 2,
    }

    public enum ImGuiFocusRequestFlags_
    {
        ImGuiFocusRequestFlags_None = 0,
        ImGuiFocusRequestFlags_RestoreFocusedChild = 1 << 0,
        ImGuiFocusRequestFlags_UnlessBelowModal = 1 << 1,
    }

    public enum ImGuiTextFlags_
    {
        ImGuiTextFlags_None = 0,
        ImGuiTextFlags_NoWidthForLargeClippedText = 1 << 0,
    }

    public enum ImGuiTooltipFlags_
    {
        ImGuiTooltipFlags_None = 0,
        ImGuiTooltipFlags_OverridePrevious = 1 << 1,
    }

    public enum ImGuiLayoutType_
    {
        ImGuiLayoutType_Horizontal = 0,
        ImGuiLayoutType_Vertical = 1,
    }

    public enum ImGuiLogFlags_
    {
        ImGuiLogFlags_None = 0,
        ImGuiLogFlags_OutputTTY = 1 << 0,
        ImGuiLogFlags_OutputFile = 1 << 1,
        ImGuiLogFlags_OutputBuffer = 1 << 2,
        ImGuiLogFlags_OutputClipboard = 1 << 3,
        ImGuiLogFlags_OutputMask_ = ImGuiLogFlags_OutputTTY | ImGuiLogFlags_OutputFile | ImGuiLogFlags_OutputBuffer | ImGuiLogFlags_OutputClipboard,
    }

    public enum ImGuiAxis
    {
        ImGuiAxis_None = -1,
        ImGuiAxis_X = 0,
        ImGuiAxis_Y = 1,
    }

    public enum ImGuiPlotType
    {
        ImGuiPlotType_Lines,
        ImGuiPlotType_Histogram,
    }

    public partial struct ImGuiColorMod
    {
        [NativeTypeName("ImGuiCol")]
        public int Col;

        public ImVec4 BackupValue;
    }

    public partial struct ImGuiStyleMod
    {
        [NativeTypeName("ImGuiStyleVar")]
        public int VarIdx;

        [NativeTypeName("__AnonymousRecord_cimgui_L1752_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public Span<int> BackupInt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.BackupInt;
            }
        }

        [UnscopedRef]
        public Span<float> BackupFloat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.BackupFloat;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("int[2]")]
            public _BackupInt_e__FixedBuffer BackupInt;

            [FieldOffset(0)]
            [NativeTypeName("float[2]")]
            public _BackupFloat_e__FixedBuffer BackupFloat;

            [InlineArray(2)]
            public partial struct _BackupInt_e__FixedBuffer
            {
                public int e0;
            }

            [InlineArray(2)]
            public partial struct _BackupFloat_e__FixedBuffer
            {
                public float e0;
            }
        }
    }

    public partial struct ImGuiComboPreviewData
    {
        public ImRect PreviewRect;

        public ImVec2 BackupCursorPos;

        public ImVec2 BackupCursorMaxPos;

        public ImVec2 BackupCursorPosPrevLine;

        public float BackupPrevLineTextBaseOffset;

        [NativeTypeName("ImGuiLayoutType")]
        public int BackupLayout;
    }

    public partial struct ImGuiGroupData
    {
        [NativeTypeName("ImGuiID")]
        public uint WindowID;

        public ImVec2 BackupCursorPos;

        public ImVec2 BackupCursorMaxPos;

        public ImVec2 BackupCursorPosPrevLine;

        public ImVec1 BackupIndent;

        public ImVec1 BackupGroupOffset;

        public ImVec2 BackupCurrLineSize;

        public float BackupCurrLineTextBaseOffset;

        [NativeTypeName("ImGuiID")]
        public uint BackupActiveIdIsAlive;

        [NativeTypeName("bool")]
        public byte BackupActiveIdPreviousFrameIsAlive;

        [NativeTypeName("bool")]
        public byte BackupHoveredIdIsAlive;

        [NativeTypeName("bool")]
        public byte BackupIsSameLine;

        [NativeTypeName("bool")]
        public byte EmitItem;
    }

    public partial struct ImGuiMenuColumns
    {
        [NativeTypeName("ImU32")]
        public uint TotalWidth;

        [NativeTypeName("ImU32")]
        public uint NextTotalWidth;

        [NativeTypeName("ImU16")]
        public ushort Spacing;

        [NativeTypeName("ImU16")]
        public ushort OffsetIcon;

        [NativeTypeName("ImU16")]
        public ushort OffsetLabel;

        [NativeTypeName("ImU16")]
        public ushort OffsetShortcut;

        [NativeTypeName("ImU16")]
        public ushort OffsetMark;

        [NativeTypeName("ImU16[4]")]
        public _Widths_e__FixedBuffer Widths;

        [InlineArray(4)]
        public partial struct _Widths_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    public partial struct ImGuiInputTextDeactivatedState
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        public ImVector_char TextA;
    }

    public unsafe partial struct ImGuiInputTextState
    {
        public ImGuiContext* Ctx;

        [NativeTypeName("ImStbTexteditState *")]
        public STB_TexteditState* Stb;

        [NativeTypeName("ImGuiID")]
        public uint ID;

        public int TextLen;

        public ImVector_char TextA;

        public ImVector_char TextToRevertTo;

        public ImVector_char CallbackTextBackup;

        public int BufCapacity;

        public ImVec2 Scroll;

        public float CursorAnim;

        [NativeTypeName("bool")]
        public byte CursorFollow;

        [NativeTypeName("bool")]
        public byte SelectedAllMouseLock;

        [NativeTypeName("bool")]
        public byte Edited;

        [NativeTypeName("ImGuiInputTextFlags")]
        public int Flags;

        [NativeTypeName("bool")]
        public byte ReloadUserBuf;

        public int ReloadSelectionStart;

        public int ReloadSelectionEnd;
    }

    public enum ImGuiWindowRefreshFlags_
    {
        ImGuiWindowRefreshFlags_None = 0,
        ImGuiWindowRefreshFlags_TryToAvoidRefresh = 1 << 0,
        ImGuiWindowRefreshFlags_RefreshOnHover = 1 << 1,
        ImGuiWindowRefreshFlags_RefreshOnFocus = 1 << 2,
    }

    public enum ImGuiNextWindowDataFlags_
    {
        ImGuiNextWindowDataFlags_None = 0,
        ImGuiNextWindowDataFlags_HasPos = 1 << 0,
        ImGuiNextWindowDataFlags_HasSize = 1 << 1,
        ImGuiNextWindowDataFlags_HasContentSize = 1 << 2,
        ImGuiNextWindowDataFlags_HasCollapsed = 1 << 3,
        ImGuiNextWindowDataFlags_HasSizeConstraint = 1 << 4,
        ImGuiNextWindowDataFlags_HasFocus = 1 << 5,
        ImGuiNextWindowDataFlags_HasBgAlpha = 1 << 6,
        ImGuiNextWindowDataFlags_HasScroll = 1 << 7,
        ImGuiNextWindowDataFlags_HasChildFlags = 1 << 8,
        ImGuiNextWindowDataFlags_HasRefreshPolicy = 1 << 9,
    }

    public unsafe partial struct ImGuiNextWindowData
    {
        [NativeTypeName("ImGuiNextWindowDataFlags")]
        public int Flags;

        [NativeTypeName("ImGuiCond")]
        public int PosCond;

        [NativeTypeName("ImGuiCond")]
        public int SizeCond;

        [NativeTypeName("ImGuiCond")]
        public int CollapsedCond;

        public ImVec2 PosVal;

        public ImVec2 PosPivotVal;

        public ImVec2 SizeVal;

        public ImVec2 ContentSizeVal;

        public ImVec2 ScrollVal;

        [NativeTypeName("ImGuiChildFlags")]
        public int ChildFlags;

        [NativeTypeName("bool")]
        public byte CollapsedVal;

        public ImRect SizeConstraintRect;

        [NativeTypeName("ImGuiSizeCallback")]
        public delegate* unmanaged[Cdecl]<ImGuiSizeCallbackData*, void> SizeCallback;

        public void* SizeCallbackUserData;

        public float BgAlphaVal;

        public ImVec2 MenuBarOffsetMinVal;

        [NativeTypeName("ImGuiWindowRefreshFlags")]
        public int RefreshFlagsVal;
    }

    public enum ImGuiNextItemDataFlags_
    {
        ImGuiNextItemDataFlags_None = 0,
        ImGuiNextItemDataFlags_HasWidth = 1 << 0,
        ImGuiNextItemDataFlags_HasOpen = 1 << 1,
        ImGuiNextItemDataFlags_HasShortcut = 1 << 2,
        ImGuiNextItemDataFlags_HasRefVal = 1 << 3,
        ImGuiNextItemDataFlags_HasStorageID = 1 << 4,
    }

    public partial struct ImGuiNextItemData
    {
        [NativeTypeName("ImGuiNextItemDataFlags")]
        public int HasFlags;

        [NativeTypeName("ImGuiItemFlags")]
        public int ItemFlags;

        [NativeTypeName("ImGuiID")]
        public uint FocusScopeId;

        [NativeTypeName("ImGuiSelectionUserData")]
        public long SelectionUserData;

        public float Width;

        [NativeTypeName("ImGuiKeyChord")]
        public int Shortcut;

        [NativeTypeName("ImGuiInputFlags")]
        public int ShortcutFlags;

        [NativeTypeName("bool")]
        public byte OpenVal;

        [NativeTypeName("ImU8")]
        public byte OpenCond;

        public ImGuiDataTypeStorage RefVal;

        [NativeTypeName("ImGuiID")]
        public uint StorageId;
    }

    public partial struct ImGuiLastItemData
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiItemFlags")]
        public int ItemFlags;

        [NativeTypeName("ImGuiItemStatusFlags")]
        public int StatusFlags;

        public ImRect Rect;

        public ImRect NavRect;

        public ImRect DisplayRect;

        public ImRect ClipRect;

        [NativeTypeName("ImGuiKeyChord")]
        public int Shortcut;
    }

    public partial struct ImGuiTreeNodeStackData
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiTreeNodeFlags")]
        public int TreeFlags;

        [NativeTypeName("ImGuiItemFlags")]
        public int ItemFlags;

        public ImRect NavRect;
    }

    public partial struct ImGuiErrorRecoveryState
    {
        public short SizeOfWindowStack;

        public short SizeOfIDStack;

        public short SizeOfTreeStack;

        public short SizeOfColorStack;

        public short SizeOfStyleVarStack;

        public short SizeOfFontStack;

        public short SizeOfFocusScopeStack;

        public short SizeOfGroupStack;

        public short SizeOfItemFlagsStack;

        public short SizeOfBeginPopupStack;

        public short SizeOfDisabledStack;
    }

    public unsafe partial struct ImGuiWindowStackData
    {
        public ImGuiWindow* Window;

        public ImGuiLastItemData ParentLastItemDataBackup;

        public ImGuiErrorRecoveryState StackSizesInBegin;

        [NativeTypeName("bool")]
        public byte DisabledOverrideReenable;
    }

    public partial struct ImGuiShrinkWidthItem
    {
        public int Index;

        public float Width;

        public float InitialWidth;
    }

    public unsafe partial struct ImGuiPtrOrIndex
    {
        public void* Ptr;

        public int Index;
    }

    public enum ImGuiPopupPositionPolicy
    {
        ImGuiPopupPositionPolicy_Default,
        ImGuiPopupPositionPolicy_ComboBox,
        ImGuiPopupPositionPolicy_Tooltip,
    }

    public unsafe partial struct ImGuiPopupData
    {
        [NativeTypeName("ImGuiID")]
        public uint PopupId;

        public ImGuiWindow* Window;

        public ImGuiWindow* RestoreNavWindow;

        public int ParentNavLayer;

        public int OpenFrameCount;

        [NativeTypeName("ImGuiID")]
        public uint OpenParentId;

        public ImVec2 OpenPopupPos;

        public ImVec2 OpenMousePos;
    }

    public partial struct ImBitArray_ImGuiKey_NamedKey_COUNT__lessImGuiKey_NamedKey_BEGIN
    {
        [NativeTypeName("ImU32[5]")]
        public _Storage_e__FixedBuffer Storage;

        [InlineArray(5)]
        public partial struct _Storage_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public enum ImGuiInputEventType
    {
        ImGuiInputEventType_None = 0,
        ImGuiInputEventType_MousePos,
        ImGuiInputEventType_MouseWheel,
        ImGuiInputEventType_MouseButton,
        ImGuiInputEventType_Key,
        ImGuiInputEventType_Text,
        ImGuiInputEventType_Focus,
        ImGuiInputEventType_COUNT,
    }

    public enum ImGuiInputSource
    {
        ImGuiInputSource_None = 0,
        ImGuiInputSource_Mouse,
        ImGuiInputSource_Keyboard,
        ImGuiInputSource_Gamepad,
        ImGuiInputSource_COUNT,
    }

    public partial struct ImGuiInputEventMousePos
    {
        public float PosX;

        public float PosY;

        public ImGuiMouseSource MouseSource;
    }

    public partial struct ImGuiInputEventMouseWheel
    {
        public float WheelX;

        public float WheelY;

        public ImGuiMouseSource MouseSource;
    }

    public partial struct ImGuiInputEventMouseButton
    {
        public int Button;

        [NativeTypeName("bool")]
        public byte Down;

        public ImGuiMouseSource MouseSource;
    }

    public partial struct ImGuiInputEventKey
    {
        public ImGuiKey Key;

        [NativeTypeName("bool")]
        public byte Down;

        public float AnalogValue;
    }

    public partial struct ImGuiInputEventText
    {
        [NativeTypeName("unsigned int")]
        public uint Char;
    }

    public partial struct ImGuiInputEventAppFocused
    {
        [NativeTypeName("bool")]
        public byte Focused;
    }

    public partial struct ImGuiInputEvent
    {
        public ImGuiInputEventType Type;

        public ImGuiInputSource Source;

        [NativeTypeName("ImU32")]
        public uint EventId;

        [NativeTypeName("__AnonymousRecord_cimgui_L1998_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("bool")]
        public byte AddedByTestEngine;

        [UnscopedRef]
        public ref ImGuiInputEventMousePos MousePos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.MousePos;
            }
        }

        [UnscopedRef]
        public ref ImGuiInputEventMouseWheel MouseWheel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.MouseWheel;
            }
        }

        [UnscopedRef]
        public ref ImGuiInputEventMouseButton MouseButton
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.MouseButton;
            }
        }

        [UnscopedRef]
        public ref ImGuiInputEventKey Key
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Key;
            }
        }

        [UnscopedRef]
        public ref ImGuiInputEventText Text
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Text;
            }
        }

        [UnscopedRef]
        public ref ImGuiInputEventAppFocused AppFocused
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.AppFocused;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ImGuiInputEventMousePos MousePos;

            [FieldOffset(0)]
            public ImGuiInputEventMouseWheel MouseWheel;

            [FieldOffset(0)]
            public ImGuiInputEventMouseButton MouseButton;

            [FieldOffset(0)]
            public ImGuiInputEventKey Key;

            [FieldOffset(0)]
            public ImGuiInputEventText Text;

            [FieldOffset(0)]
            public ImGuiInputEventAppFocused AppFocused;
        }
    }

    public partial struct ImGuiKeyRoutingData
    {
        [NativeTypeName("ImGuiKeyRoutingIndex")]
        public short NextEntryIndex;

        [NativeTypeName("ImU16")]
        public ushort Mods;

        [NativeTypeName("ImU8")]
        public byte RoutingCurrScore;

        [NativeTypeName("ImU8")]
        public byte RoutingNextScore;

        [NativeTypeName("ImGuiID")]
        public uint RoutingCurr;

        [NativeTypeName("ImGuiID")]
        public uint RoutingNext;
    }

    public unsafe partial struct ImVector_ImGuiKeyRoutingData
    {
        public int Size;

        public int Capacity;

        public ImGuiKeyRoutingData* Data;
    }

    public partial struct ImGuiKeyRoutingTable
    {
        [NativeTypeName("ImGuiKeyRoutingIndex[154]")]
        public _Index_e__FixedBuffer Index;

        public ImVector_ImGuiKeyRoutingData Entries;

        public ImVector_ImGuiKeyRoutingData EntriesNext;

        [InlineArray(154)]
        public partial struct _Index_e__FixedBuffer
        {
            public short e0;
        }
    }

    public partial struct ImGuiKeyOwnerData
    {
        [NativeTypeName("ImGuiID")]
        public uint OwnerCurr;

        [NativeTypeName("ImGuiID")]
        public uint OwnerNext;

        [NativeTypeName("bool")]
        public byte LockThisFrame;

        [NativeTypeName("bool")]
        public byte LockUntilRelease;
    }

    public enum ImGuiInputFlagsPrivate_
    {
        ImGuiInputFlags_RepeatRateDefault = 1 << 1,
        ImGuiInputFlags_RepeatRateNavMove = 1 << 2,
        ImGuiInputFlags_RepeatRateNavTweak = 1 << 3,
        ImGuiInputFlags_RepeatUntilRelease = 1 << 4,
        ImGuiInputFlags_RepeatUntilKeyModsChange = 1 << 5,
        ImGuiInputFlags_RepeatUntilKeyModsChangeFromNone = 1 << 6,
        ImGuiInputFlags_RepeatUntilOtherKeyPress = 1 << 7,
        ImGuiInputFlags_LockThisFrame = 1 << 20,
        ImGuiInputFlags_LockUntilRelease = 1 << 21,
        ImGuiInputFlags_CondHovered = 1 << 22,
        ImGuiInputFlags_CondActive = 1 << 23,
        ImGuiInputFlags_CondDefault_ = ImGuiInputFlags_CondHovered | ImGuiInputFlags_CondActive,
        ImGuiInputFlags_RepeatRateMask_ = ImGuiInputFlags_RepeatRateDefault | ImGuiInputFlags_RepeatRateNavMove | ImGuiInputFlags_RepeatRateNavTweak,
        ImGuiInputFlags_RepeatUntilMask_ = ImGuiInputFlags_RepeatUntilRelease | ImGuiInputFlags_RepeatUntilKeyModsChange | ImGuiInputFlags_RepeatUntilKeyModsChangeFromNone | ImGuiInputFlags_RepeatUntilOtherKeyPress,
        ImGuiInputFlags_RepeatMask_ = ImGuiInputFlags_Repeat | ImGuiInputFlags_RepeatRateMask_ | ImGuiInputFlags_RepeatUntilMask_,
        ImGuiInputFlags_CondMask_ = ImGuiInputFlags_CondHovered | ImGuiInputFlags_CondActive,
        ImGuiInputFlags_RouteTypeMask_ = ImGuiInputFlags_RouteActive | ImGuiInputFlags_RouteFocused | ImGuiInputFlags_RouteGlobal | ImGuiInputFlags_RouteAlways,
        ImGuiInputFlags_RouteOptionsMask_ = ImGuiInputFlags_RouteOverFocused | ImGuiInputFlags_RouteOverActive | ImGuiInputFlags_RouteUnlessBgFocused | ImGuiInputFlags_RouteFromRootWindow,
        ImGuiInputFlags_SupportedByIsKeyPressed = ImGuiInputFlags_RepeatMask_,
        ImGuiInputFlags_SupportedByIsMouseClicked = ImGuiInputFlags_Repeat,
        ImGuiInputFlags_SupportedByShortcut = ImGuiInputFlags_RepeatMask_ | ImGuiInputFlags_RouteTypeMask_ | ImGuiInputFlags_RouteOptionsMask_,
        ImGuiInputFlags_SupportedBySetNextItemShortcut = ImGuiInputFlags_RepeatMask_ | ImGuiInputFlags_RouteTypeMask_ | ImGuiInputFlags_RouteOptionsMask_ | ImGuiInputFlags_Tooltip,
        ImGuiInputFlags_SupportedBySetKeyOwner = ImGuiInputFlags_LockThisFrame | ImGuiInputFlags_LockUntilRelease,
        ImGuiInputFlags_SupportedBySetItemKeyOwner = ImGuiInputFlags_SupportedBySetKeyOwner | ImGuiInputFlags_CondMask_,
    }

    public partial struct ImGuiListClipperRange
    {
        public int Min;

        public int Max;

        [NativeTypeName("bool")]
        public byte PosToIndexConvert;

        [NativeTypeName("ImS8")]
        public sbyte PosToIndexOffsetMin;

        [NativeTypeName("ImS8")]
        public sbyte PosToIndexOffsetMax;
    }

    public unsafe partial struct ImVector_ImGuiListClipperRange
    {
        public int Size;

        public int Capacity;

        public ImGuiListClipperRange* Data;
    }

    public unsafe partial struct ImGuiListClipperData
    {
        public ImGuiListClipper* ListClipper;

        public float LossynessOffset;

        public int StepNo;

        public int ItemsFrozen;

        public ImVector_ImGuiListClipperRange Ranges;
    }

    public enum ImGuiActivateFlags_
    {
        ImGuiActivateFlags_None = 0,
        ImGuiActivateFlags_PreferInput = 1 << 0,
        ImGuiActivateFlags_PreferTweak = 1 << 1,
        ImGuiActivateFlags_TryToPreserveState = 1 << 2,
        ImGuiActivateFlags_FromTabbing = 1 << 3,
        ImGuiActivateFlags_FromShortcut = 1 << 4,
    }

    public enum ImGuiScrollFlags_
    {
        ImGuiScrollFlags_None = 0,
        ImGuiScrollFlags_KeepVisibleEdgeX = 1 << 0,
        ImGuiScrollFlags_KeepVisibleEdgeY = 1 << 1,
        ImGuiScrollFlags_KeepVisibleCenterX = 1 << 2,
        ImGuiScrollFlags_KeepVisibleCenterY = 1 << 3,
        ImGuiScrollFlags_AlwaysCenterX = 1 << 4,
        ImGuiScrollFlags_AlwaysCenterY = 1 << 5,
        ImGuiScrollFlags_NoScrollParent = 1 << 6,
        ImGuiScrollFlags_MaskX_ = ImGuiScrollFlags_KeepVisibleEdgeX | ImGuiScrollFlags_KeepVisibleCenterX | ImGuiScrollFlags_AlwaysCenterX,
        ImGuiScrollFlags_MaskY_ = ImGuiScrollFlags_KeepVisibleEdgeY | ImGuiScrollFlags_KeepVisibleCenterY | ImGuiScrollFlags_AlwaysCenterY,
    }

    public enum ImGuiNavRenderCursorFlags_
    {
        ImGuiNavRenderCursorFlags_None = 0,
        ImGuiNavRenderCursorFlags_Compact = 1 << 1,
        ImGuiNavRenderCursorFlags_AlwaysDraw = 1 << 2,
        ImGuiNavRenderCursorFlags_NoRounding = 1 << 3,
    }

    public enum ImGuiNavMoveFlags_
    {
        ImGuiNavMoveFlags_None = 0,
        ImGuiNavMoveFlags_LoopX = 1 << 0,
        ImGuiNavMoveFlags_LoopY = 1 << 1,
        ImGuiNavMoveFlags_WrapX = 1 << 2,
        ImGuiNavMoveFlags_WrapY = 1 << 3,
        ImGuiNavMoveFlags_WrapMask_ = ImGuiNavMoveFlags_LoopX | ImGuiNavMoveFlags_LoopY | ImGuiNavMoveFlags_WrapX | ImGuiNavMoveFlags_WrapY,
        ImGuiNavMoveFlags_AllowCurrentNavId = 1 << 4,
        ImGuiNavMoveFlags_AlsoScoreVisibleSet = 1 << 5,
        ImGuiNavMoveFlags_ScrollToEdgeY = 1 << 6,
        ImGuiNavMoveFlags_Forwarded = 1 << 7,
        ImGuiNavMoveFlags_DebugNoResult = 1 << 8,
        ImGuiNavMoveFlags_FocusApi = 1 << 9,
        ImGuiNavMoveFlags_IsTabbing = 1 << 10,
        ImGuiNavMoveFlags_IsPageMove = 1 << 11,
        ImGuiNavMoveFlags_Activate = 1 << 12,
        ImGuiNavMoveFlags_NoSelect = 1 << 13,
        ImGuiNavMoveFlags_NoSetNavCursorVisible = 1 << 14,
        ImGuiNavMoveFlags_NoClearActiveId = 1 << 15,
    }

    public enum ImGuiNavLayer
    {
        ImGuiNavLayer_Main = 0,
        ImGuiNavLayer_Menu = 1,
        ImGuiNavLayer_COUNT,
    }

    public unsafe partial struct ImGuiNavItemData
    {
        public ImGuiWindow* Window;

        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiID")]
        public uint FocusScopeId;

        public ImRect RectRel;

        [NativeTypeName("ImGuiItemFlags")]
        public int ItemFlags;

        public float DistBox;

        public float DistCenter;

        public float DistAxial;

        [NativeTypeName("ImGuiSelectionUserData")]
        public long SelectionUserData;
    }

    public partial struct ImGuiFocusScopeData
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiID")]
        public uint WindowID;
    }

    public enum ImGuiTypingSelectFlags_
    {
        ImGuiTypingSelectFlags_None = 0,
        ImGuiTypingSelectFlags_AllowBackspace = 1 << 0,
        ImGuiTypingSelectFlags_AllowSingleCharMode = 1 << 1,
    }

    public unsafe partial struct ImGuiTypingSelectRequest
    {
        [NativeTypeName("ImGuiTypingSelectFlags")]
        public int Flags;

        public int SearchBufferLen;

        [NativeTypeName("const char *")]
        public sbyte* SearchBuffer;

        [NativeTypeName("bool")]
        public byte SelectRequest;

        [NativeTypeName("bool")]
        public byte SingleCharMode;

        [NativeTypeName("ImS8")]
        public sbyte SingleCharSize;
    }

    public partial struct ImGuiTypingSelectState
    {
        public ImGuiTypingSelectRequest Request;

        [NativeTypeName("char[64]")]
        public _SearchBuffer_e__FixedBuffer SearchBuffer;

        [NativeTypeName("ImGuiID")]
        public uint FocusScope;

        public int LastRequestFrame;

        public float LastRequestTime;

        [NativeTypeName("bool")]
        public byte SingleCharModeLock;

        [InlineArray(64)]
        public partial struct _SearchBuffer_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public enum ImGuiOldColumnFlags_
    {
        ImGuiOldColumnFlags_None = 0,
        ImGuiOldColumnFlags_NoBorder = 1 << 0,
        ImGuiOldColumnFlags_NoResize = 1 << 1,
        ImGuiOldColumnFlags_NoPreserveWidths = 1 << 2,
        ImGuiOldColumnFlags_NoForceWithinWindow = 1 << 3,
        ImGuiOldColumnFlags_GrowParentContentsSize = 1 << 4,
    }

    public partial struct ImGuiOldColumnData
    {
        public float OffsetNorm;

        public float OffsetNormBeforeResize;

        [NativeTypeName("ImGuiOldColumnFlags")]
        public int Flags;

        public ImRect ClipRect;
    }

    public unsafe partial struct ImVector_ImGuiOldColumnData
    {
        public int Size;

        public int Capacity;

        public ImGuiOldColumnData* Data;
    }

    public partial struct ImGuiOldColumns
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiOldColumnFlags")]
        public int Flags;

        [NativeTypeName("bool")]
        public byte IsFirstFrame;

        [NativeTypeName("bool")]
        public byte IsBeingResized;

        public int Current;

        public int Count;

        public float OffMinX;

        public float OffMaxX;

        public float LineMinY;

        public float LineMaxY;

        public float HostCursorPosY;

        public float HostCursorMaxPosX;

        public ImRect HostInitialClipRect;

        public ImRect HostBackupClipRect;

        public ImRect HostBackupParentWorkRect;

        public ImVector_ImGuiOldColumnData Columns;

        public ImDrawListSplitter Splitter;
    }

    public unsafe partial struct ImGuiBoxSelectState
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("bool")]
        public byte IsActive;

        [NativeTypeName("bool")]
        public byte IsStarting;

        [NativeTypeName("bool")]
        public byte IsStartedFromVoid;

        [NativeTypeName("bool")]
        public byte IsStartedSetNavIdOnce;

        [NativeTypeName("bool")]
        public byte RequestClear;

        public int _bitfield;

        [NativeTypeName("ImGuiKeyChord : 16")]
        public int KeyMods
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 16) >> 16;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFFFF) | (value & 0xFFFF);
            }
        }

        public ImVec2 StartPosRel;

        public ImVec2 EndPosRel;

        public ImVec2 ScrollAccum;

        public ImGuiWindow* Window;

        [NativeTypeName("bool")]
        public byte UnclipMode;

        public ImRect UnclipRect;

        public ImRect BoxSelectRectPrev;

        public ImRect BoxSelectRectCurr;
    }

    public unsafe partial struct ImGuiMultiSelectTempData
    {
        public ImGuiMultiSelectIO IO;

        public ImGuiMultiSelectState* Storage;

        [NativeTypeName("ImGuiID")]
        public uint FocusScopeId;

        [NativeTypeName("ImGuiMultiSelectFlags")]
        public int Flags;

        public ImVec2 ScopeRectMin;

        public ImVec2 BackupCursorMaxPos;

        [NativeTypeName("ImGuiSelectionUserData")]
        public long LastSubmittedItem;

        [NativeTypeName("ImGuiID")]
        public uint BoxSelectId;

        [NativeTypeName("ImGuiKeyChord")]
        public int KeyMods;

        [NativeTypeName("ImS8")]
        public sbyte LoopRequestSetAll;

        [NativeTypeName("bool")]
        public byte IsEndIO;

        [NativeTypeName("bool")]
        public byte IsFocused;

        [NativeTypeName("bool")]
        public byte IsKeyboardSetRange;

        [NativeTypeName("bool")]
        public byte NavIdPassedBy;

        [NativeTypeName("bool")]
        public byte RangeSrcPassedBy;

        [NativeTypeName("bool")]
        public byte RangeDstPassedBy;
    }

    public unsafe partial struct ImGuiMultiSelectState
    {
        public ImGuiWindow* Window;

        [NativeTypeName("ImGuiID")]
        public uint ID;

        public int LastFrameActive;

        public int LastSelectionSize;

        [NativeTypeName("ImS8")]
        public sbyte RangeSelected;

        [NativeTypeName("ImS8")]
        public sbyte NavIdSelected;

        [NativeTypeName("ImGuiSelectionUserData")]
        public long RangeSrcItem;

        [NativeTypeName("ImGuiSelectionUserData")]
        public long NavIdItem;
    }

    public partial struct ImGuiViewportP
    {
        public ImGuiViewport _ImGuiViewport;

        [NativeTypeName("int[2]")]
        public _BgFgDrawListsLastFrame_e__FixedBuffer BgFgDrawListsLastFrame;

        [NativeTypeName("ImDrawList *[2]")]
        public _BgFgDrawLists_e__FixedBuffer BgFgDrawLists;

        public ImDrawData DrawDataP;

        public ImDrawDataBuilder DrawDataBuilder;

        public ImVec2 WorkInsetMin;

        public ImVec2 WorkInsetMax;

        public ImVec2 BuildWorkInsetMin;

        public ImVec2 BuildWorkInsetMax;

        [InlineArray(2)]
        public partial struct _BgFgDrawListsLastFrame_e__FixedBuffer
        {
            public int e0;
        }

        public unsafe partial struct _BgFgDrawLists_e__FixedBuffer
        {
            public ImDrawList* e0;
            public ImDrawList* e1;

            public ref ImDrawList* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (ImDrawList** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public partial struct ImGuiWindowSettings
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        public ImVec2ih Pos;

        public ImVec2ih Size;

        [NativeTypeName("bool")]
        public byte Collapsed;

        [NativeTypeName("bool")]
        public byte IsChild;

        [NativeTypeName("bool")]
        public byte WantApply;

        [NativeTypeName("bool")]
        public byte WantDelete;
    }

    public unsafe partial struct ImGuiSettingsHandler
    {
        [NativeTypeName("const char *")]
        public sbyte* TypeName;

        [NativeTypeName("ImGuiID")]
        public uint TypeHash;

        [NativeTypeName("void (*)(ImGuiContext *, ImGuiSettingsHandler *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, ImGuiSettingsHandler*, void> ClearAllFn;

        [NativeTypeName("void (*)(ImGuiContext *, ImGuiSettingsHandler *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, ImGuiSettingsHandler*, void> ReadInitFn;

        [NativeTypeName("void *(*)(ImGuiContext *, ImGuiSettingsHandler *, const char *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, ImGuiSettingsHandler*, sbyte*, void*> ReadOpenFn;

        [NativeTypeName("void (*)(ImGuiContext *, ImGuiSettingsHandler *, void *, const char *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, ImGuiSettingsHandler*, void*, sbyte*, void> ReadLineFn;

        [NativeTypeName("void (*)(ImGuiContext *, ImGuiSettingsHandler *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, ImGuiSettingsHandler*, void> ApplyAllFn;

        [NativeTypeName("void (*)(ImGuiContext *, ImGuiSettingsHandler *, ImGuiTextBuffer *)")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, ImGuiSettingsHandler*, ImGuiTextBuffer*, void> WriteAllFn;

        public void* UserData;
    }

    public enum ImGuiLocKey
    {
        ImGuiLocKey_VersionStr = 0,
        ImGuiLocKey_TableSizeOne = 1,
        ImGuiLocKey_TableSizeAllFit = 2,
        ImGuiLocKey_TableSizeAllDefault = 3,
        ImGuiLocKey_TableResetOrder = 4,
        ImGuiLocKey_WindowingMainMenuBar = 5,
        ImGuiLocKey_WindowingPopup = 6,
        ImGuiLocKey_WindowingUntitled = 7,
        ImGuiLocKey_OpenLink_s = 8,
        ImGuiLocKey_CopyLink = 9,
        ImGuiLocKey_COUNT = 10,
    }

    public unsafe partial struct ImGuiLocEntry
    {
        public ImGuiLocKey Key;

        [NativeTypeName("const char *")]
        public sbyte* Text;
    }

    public enum ImGuiDebugLogFlags_
    {
        ImGuiDebugLogFlags_None = 0,
        ImGuiDebugLogFlags_EventError = 1 << 0,
        ImGuiDebugLogFlags_EventActiveId = 1 << 1,
        ImGuiDebugLogFlags_EventFocus = 1 << 2,
        ImGuiDebugLogFlags_EventPopup = 1 << 3,
        ImGuiDebugLogFlags_EventNav = 1 << 4,
        ImGuiDebugLogFlags_EventClipper = 1 << 5,
        ImGuiDebugLogFlags_EventSelection = 1 << 6,
        ImGuiDebugLogFlags_EventIO = 1 << 7,
        ImGuiDebugLogFlags_EventInputRouting = 1 << 8,
        ImGuiDebugLogFlags_EventDocking = 1 << 9,
        ImGuiDebugLogFlags_EventViewport = 1 << 10,
        ImGuiDebugLogFlags_EventMask_ = ImGuiDebugLogFlags_EventError | ImGuiDebugLogFlags_EventActiveId | ImGuiDebugLogFlags_EventFocus | ImGuiDebugLogFlags_EventPopup | ImGuiDebugLogFlags_EventNav | ImGuiDebugLogFlags_EventClipper | ImGuiDebugLogFlags_EventSelection | ImGuiDebugLogFlags_EventIO | ImGuiDebugLogFlags_EventInputRouting | ImGuiDebugLogFlags_EventDocking | ImGuiDebugLogFlags_EventViewport,
        ImGuiDebugLogFlags_OutputToTTY = 1 << 20,
        ImGuiDebugLogFlags_OutputToTestEngine = 1 << 21,
    }

    public partial struct ImGuiDebugAllocEntry
    {
        public int FrameCount;

        [NativeTypeName("ImS16")]
        public short AllocCount;

        [NativeTypeName("ImS16")]
        public short FreeCount;
    }

    public partial struct ImGuiDebugAllocInfo
    {
        public int TotalAllocCount;

        public int TotalFreeCount;

        [NativeTypeName("ImS16")]
        public short LastEntriesIdx;

        [NativeTypeName("ImGuiDebugAllocEntry[6]")]
        public _LastEntriesBuf_e__FixedBuffer LastEntriesBuf;

        [InlineArray(6)]
        public partial struct _LastEntriesBuf_e__FixedBuffer
        {
            public ImGuiDebugAllocEntry e0;
        }
    }

    public partial struct ImGuiMetricsConfig
    {
        [NativeTypeName("bool")]
        public byte ShowDebugLog;

        [NativeTypeName("bool")]
        public byte ShowIDStackTool;

        [NativeTypeName("bool")]
        public byte ShowWindowsRects;

        [NativeTypeName("bool")]
        public byte ShowWindowsBeginOrder;

        [NativeTypeName("bool")]
        public byte ShowTablesRects;

        [NativeTypeName("bool")]
        public byte ShowDrawCmdMesh;

        [NativeTypeName("bool")]
        public byte ShowDrawCmdBoundingBoxes;

        [NativeTypeName("bool")]
        public byte ShowTextEncodingViewer;

        [NativeTypeName("bool")]
        public byte ShowAtlasTintedWithTextColor;

        public int ShowWindowsRectsType;

        public int ShowTablesRectsType;

        public int HighlightMonitorIdx;

        [NativeTypeName("ImGuiID")]
        public uint HighlightViewportID;
    }

    public partial struct ImGuiStackLevelInfo
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImS8")]
        public sbyte QueryFrameCount;

        [NativeTypeName("bool")]
        public byte QuerySuccess;

        public int _bitfield;

        [NativeTypeName("ImGuiDataType : 8")]
        public int DataType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 24) >> 24;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFF) | (value & 0xFF);
            }
        }

        [NativeTypeName("char[57]")]
        public _Desc_e__FixedBuffer Desc;

        [InlineArray(57)]
        public partial struct _Desc_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public unsafe partial struct ImVector_ImGuiStackLevelInfo
    {
        public int Size;

        public int Capacity;

        public ImGuiStackLevelInfo* Data;
    }

    public partial struct ImGuiIDStackTool
    {
        public int LastActiveFrame;

        public int StackLevel;

        [NativeTypeName("ImGuiID")]
        public uint QueryId;

        public ImVector_ImGuiStackLevelInfo Results;

        [NativeTypeName("bool")]
        public byte CopyToClipboardOnCtrlC;

        public float CopyToClipboardLastTime;
    }

    public enum ImGuiContextHookType
    {
        ImGuiContextHookType_NewFramePre,
        ImGuiContextHookType_NewFramePost,
        ImGuiContextHookType_EndFramePre,
        ImGuiContextHookType_EndFramePost,
        ImGuiContextHookType_RenderPre,
        ImGuiContextHookType_RenderPost,
        ImGuiContextHookType_Shutdown,
        ImGuiContextHookType_PendingRemoval_,
    }

    public unsafe partial struct ImGuiContextHook
    {
        [NativeTypeName("ImGuiID")]
        public uint HookId;

        public ImGuiContextHookType Type;

        [NativeTypeName("ImGuiID")]
        public uint Owner;

        [NativeTypeName("ImGuiContextHookCallback")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, ImGuiContextHook*, void> Callback;

        public void* UserData;
    }

    public unsafe partial struct ImVector_ImGuiInputEvent
    {
        public int Size;

        public int Capacity;

        public ImGuiInputEvent* Data;
    }

    public unsafe partial struct ImVector_ImGuiWindowPtr
    {
        public int Size;

        public int Capacity;

        public ImGuiWindow** Data;
    }

    public unsafe partial struct ImVector_ImGuiWindowStackData
    {
        public int Size;

        public int Capacity;

        public ImGuiWindowStackData* Data;
    }

    public unsafe partial struct ImVector_ImGuiColorMod
    {
        public int Size;

        public int Capacity;

        public ImGuiColorMod* Data;
    }

    public unsafe partial struct ImVector_ImGuiStyleMod
    {
        public int Size;

        public int Capacity;

        public ImGuiStyleMod* Data;
    }

    public unsafe partial struct ImVector_ImGuiFocusScopeData
    {
        public int Size;

        public int Capacity;

        public ImGuiFocusScopeData* Data;
    }

    public unsafe partial struct ImVector_ImGuiItemFlags
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImGuiItemFlags *")]
        public int* Data;
    }

    public unsafe partial struct ImVector_ImGuiGroupData
    {
        public int Size;

        public int Capacity;

        public ImGuiGroupData* Data;
    }

    public unsafe partial struct ImVector_ImGuiPopupData
    {
        public int Size;

        public int Capacity;

        public ImGuiPopupData* Data;
    }

    public unsafe partial struct ImVector_ImGuiTreeNodeStackData
    {
        public int Size;

        public int Capacity;

        public ImGuiTreeNodeStackData* Data;
    }

    public unsafe partial struct ImVector_ImGuiViewportPPtr
    {
        public int Size;

        public int Capacity;

        public ImGuiViewportP** Data;
    }

    public unsafe partial struct ImVector_unsigned_char
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("unsigned char *")]
        public byte* Data;
    }

    public unsafe partial struct ImVector_ImGuiListClipperData
    {
        public int Size;

        public int Capacity;

        public ImGuiListClipperData* Data;
    }

    public unsafe partial struct ImVector_ImGuiTableTempData
    {
        public int Size;

        public int Capacity;

        public ImGuiTableTempData* Data;
    }

    public unsafe partial struct ImVector_ImGuiTable
    {
        public int Size;

        public int Capacity;

        public ImGuiTable* Data;
    }

    public partial struct ImPool_ImGuiTable
    {
        public ImVector_ImGuiTable Buf;

        public ImGuiStorage Map;

        [NativeTypeName("ImPoolIdx")]
        public int FreeIdx;

        [NativeTypeName("ImPoolIdx")]
        public int AliveCount;
    }

    public unsafe partial struct ImVector_ImGuiTabBar
    {
        public int Size;

        public int Capacity;

        public ImGuiTabBar* Data;
    }

    public partial struct ImPool_ImGuiTabBar
    {
        public ImVector_ImGuiTabBar Buf;

        public ImGuiStorage Map;

        [NativeTypeName("ImPoolIdx")]
        public int FreeIdx;

        [NativeTypeName("ImPoolIdx")]
        public int AliveCount;
    }

    public unsafe partial struct ImVector_ImGuiPtrOrIndex
    {
        public int Size;

        public int Capacity;

        public ImGuiPtrOrIndex* Data;
    }

    public unsafe partial struct ImVector_ImGuiShrinkWidthItem
    {
        public int Size;

        public int Capacity;

        public ImGuiShrinkWidthItem* Data;
    }

    public unsafe partial struct ImVector_ImGuiMultiSelectTempData
    {
        public int Size;

        public int Capacity;

        public ImGuiMultiSelectTempData* Data;
    }

    public unsafe partial struct ImVector_ImGuiMultiSelectState
    {
        public int Size;

        public int Capacity;

        public ImGuiMultiSelectState* Data;
    }

    public partial struct ImPool_ImGuiMultiSelectState
    {
        public ImVector_ImGuiMultiSelectState Buf;

        public ImGuiStorage Map;

        [NativeTypeName("ImPoolIdx")]
        public int FreeIdx;

        [NativeTypeName("ImPoolIdx")]
        public int AliveCount;
    }

    public unsafe partial struct ImVector_ImGuiID
    {
        public int Size;

        public int Capacity;

        [NativeTypeName("ImGuiID *")]
        public uint* Data;
    }

    public unsafe partial struct ImVector_ImGuiSettingsHandler
    {
        public int Size;

        public int Capacity;

        public ImGuiSettingsHandler* Data;
    }

    public partial struct ImChunkStream_ImGuiWindowSettings
    {
        public ImVector_char Buf;
    }

    public partial struct ImChunkStream_ImGuiTableSettings
    {
        public ImVector_char Buf;
    }

    public unsafe partial struct ImVector_ImGuiContextHook
    {
        public int Size;

        public int Capacity;

        public ImGuiContextHook* Data;
    }

    public unsafe partial struct ImGuiContext
    {
        [NativeTypeName("bool")]
        public byte Initialized;

        [NativeTypeName("bool")]
        public byte FontAtlasOwnedByContext;

        public ImGuiIO IO;

        public ImGuiPlatformIO PlatformIO;

        public ImGuiStyle Style;

        public ImFont* Font;

        public float FontSize;

        public float FontBaseSize;

        public float FontScale;

        public float CurrentDpiScale;

        public ImDrawListSharedData DrawListSharedData;

        public double Time;

        public int FrameCount;

        public int FrameCountEnded;

        public int FrameCountRendered;

        [NativeTypeName("bool")]
        public byte WithinFrameScope;

        [NativeTypeName("bool")]
        public byte WithinFrameScopeWithImplicitWindow;

        [NativeTypeName("bool")]
        public byte WithinEndChild;

        [NativeTypeName("bool")]
        public byte GcCompactAll;

        [NativeTypeName("bool")]
        public byte TestEngineHookItems;

        public void* TestEngine;

        [NativeTypeName("char[16]")]
        public _ContextName_e__FixedBuffer ContextName;

        public ImVector_ImGuiInputEvent InputEventsQueue;

        public ImVector_ImGuiInputEvent InputEventsTrail;

        public ImGuiMouseSource InputEventsNextMouseSource;

        [NativeTypeName("ImU32")]
        public uint InputEventsNextEventId;

        public ImVector_ImGuiWindowPtr Windows;

        public ImVector_ImGuiWindowPtr WindowsFocusOrder;

        public ImVector_ImGuiWindowPtr WindowsTempSortBuffer;

        public ImVector_ImGuiWindowStackData CurrentWindowStack;

        public ImGuiStorage WindowsById;

        public int WindowsActiveCount;

        public ImVec2 WindowsHoverPadding;

        [NativeTypeName("ImGuiID")]
        public uint DebugBreakInWindow;

        public ImGuiWindow* CurrentWindow;

        public ImGuiWindow* HoveredWindow;

        public ImGuiWindow* HoveredWindowUnderMovingWindow;

        public ImGuiWindow* HoveredWindowBeforeClear;

        public ImGuiWindow* MovingWindow;

        public ImGuiWindow* WheelingWindow;

        public ImVec2 WheelingWindowRefMousePos;

        public int WheelingWindowStartFrame;

        public int WheelingWindowScrolledFrame;

        public float WheelingWindowReleaseTimer;

        public ImVec2 WheelingWindowWheelRemainder;

        public ImVec2 WheelingAxisAvg;

        [NativeTypeName("ImGuiID")]
        public uint DebugDrawIdConflicts;

        [NativeTypeName("ImGuiID")]
        public uint DebugHookIdInfo;

        [NativeTypeName("ImGuiID")]
        public uint HoveredId;

        [NativeTypeName("ImGuiID")]
        public uint HoveredIdPreviousFrame;

        public int HoveredIdPreviousFrameItemCount;

        public float HoveredIdTimer;

        public float HoveredIdNotActiveTimer;

        [NativeTypeName("bool")]
        public byte HoveredIdAllowOverlap;

        [NativeTypeName("bool")]
        public byte HoveredIdIsDisabled;

        [NativeTypeName("bool")]
        public byte ItemUnclipByLog;

        [NativeTypeName("ImGuiID")]
        public uint ActiveId;

        [NativeTypeName("ImGuiID")]
        public uint ActiveIdIsAlive;

        public float ActiveIdTimer;

        [NativeTypeName("bool")]
        public byte ActiveIdIsJustActivated;

        [NativeTypeName("bool")]
        public byte ActiveIdAllowOverlap;

        [NativeTypeName("bool")]
        public byte ActiveIdNoClearOnFocusLoss;

        [NativeTypeName("bool")]
        public byte ActiveIdHasBeenPressedBefore;

        [NativeTypeName("bool")]
        public byte ActiveIdHasBeenEditedBefore;

        [NativeTypeName("bool")]
        public byte ActiveIdHasBeenEditedThisFrame;

        [NativeTypeName("bool")]
        public byte ActiveIdFromShortcut;

        public int _bitfield;

        [NativeTypeName("int : 8")]
        public int ActiveIdMouseButton
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 24) >> 24;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFF) | (value & 0xFF);
            }
        }

        public ImVec2 ActiveIdClickOffset;

        public ImGuiWindow* ActiveIdWindow;

        public ImGuiInputSource ActiveIdSource;

        [NativeTypeName("ImGuiID")]
        public uint ActiveIdPreviousFrame;

        [NativeTypeName("bool")]
        public byte ActiveIdPreviousFrameIsAlive;

        [NativeTypeName("bool")]
        public byte ActiveIdPreviousFrameHasBeenEditedBefore;

        public ImGuiWindow* ActiveIdPreviousFrameWindow;

        [NativeTypeName("ImGuiID")]
        public uint LastActiveId;

        public float LastActiveIdTimer;

        public double LastKeyModsChangeTime;

        public double LastKeyModsChangeFromNoneTime;

        public double LastKeyboardKeyPressTime;

        [NativeTypeName("ImBitArrayForNamedKeys")]
        public ImBitArray_ImGuiKey_NamedKey_COUNT__lessImGuiKey_NamedKey_BEGIN KeysMayBeCharInput;

        [NativeTypeName("ImGuiKeyOwnerData[154]")]
        public _KeysOwnerData_e__FixedBuffer KeysOwnerData;

        public ImGuiKeyRoutingTable KeysRoutingTable;

        [NativeTypeName("ImU32")]
        public uint ActiveIdUsingNavDirMask;

        [NativeTypeName("bool")]
        public byte ActiveIdUsingAllKeyboardKeys;

        [NativeTypeName("ImGuiKeyChord")]
        public int DebugBreakInShortcutRouting;

        [NativeTypeName("ImGuiID")]
        public uint CurrentFocusScopeId;

        [NativeTypeName("ImGuiItemFlags")]
        public int CurrentItemFlags;

        [NativeTypeName("ImGuiID")]
        public uint DebugLocateId;

        public ImGuiNextItemData NextItemData;

        public ImGuiLastItemData LastItemData;

        public ImGuiNextWindowData NextWindowData;

        [NativeTypeName("bool")]
        public byte DebugShowGroupRects;

        [NativeTypeName("ImGuiCol")]
        public int DebugFlashStyleColorIdx;

        public ImVector_ImGuiColorMod ColorStack;

        public ImVector_ImGuiStyleMod StyleVarStack;

        public ImVector_ImFontPtr FontStack;

        public ImVector_ImGuiFocusScopeData FocusScopeStack;

        public ImVector_ImGuiItemFlags ItemFlagsStack;

        public ImVector_ImGuiGroupData GroupStack;

        public ImVector_ImGuiPopupData OpenPopupStack;

        public ImVector_ImGuiPopupData BeginPopupStack;

        public ImVector_ImGuiTreeNodeStackData TreeNodeStack;

        public ImVector_ImGuiViewportPPtr Viewports;

        [NativeTypeName("bool")]
        public byte NavCursorVisible;

        [NativeTypeName("bool")]
        public byte NavHighlightItemUnderNav;

        [NativeTypeName("bool")]
        public byte NavMousePosDirty;

        [NativeTypeName("bool")]
        public byte NavIdIsAlive;

        [NativeTypeName("ImGuiID")]
        public uint NavId;

        public ImGuiWindow* NavWindow;

        [NativeTypeName("ImGuiID")]
        public uint NavFocusScopeId;

        public ImGuiNavLayer NavLayer;

        [NativeTypeName("ImGuiID")]
        public uint NavActivateId;

        [NativeTypeName("ImGuiID")]
        public uint NavActivateDownId;

        [NativeTypeName("ImGuiID")]
        public uint NavActivatePressedId;

        [NativeTypeName("ImGuiActivateFlags")]
        public int NavActivateFlags;

        public ImVector_ImGuiFocusScopeData NavFocusRoute;

        [NativeTypeName("ImGuiID")]
        public uint NavHighlightActivatedId;

        public float NavHighlightActivatedTimer;

        [NativeTypeName("ImGuiID")]
        public uint NavNextActivateId;

        [NativeTypeName("ImGuiActivateFlags")]
        public int NavNextActivateFlags;

        public ImGuiInputSource NavInputSource;

        [NativeTypeName("ImGuiSelectionUserData")]
        public long NavLastValidSelectionUserData;

        [NativeTypeName("ImS8")]
        public sbyte NavCursorHideFrames;

        [NativeTypeName("bool")]
        public byte NavAnyRequest;

        [NativeTypeName("bool")]
        public byte NavInitRequest;

        [NativeTypeName("bool")]
        public byte NavInitRequestFromMove;

        public ImGuiNavItemData NavInitResult;

        [NativeTypeName("bool")]
        public byte NavMoveSubmitted;

        [NativeTypeName("bool")]
        public byte NavMoveScoringItems;

        [NativeTypeName("bool")]
        public byte NavMoveForwardToNextFrame;

        [NativeTypeName("ImGuiNavMoveFlags")]
        public int NavMoveFlags;

        [NativeTypeName("ImGuiScrollFlags")]
        public int NavMoveScrollFlags;

        [NativeTypeName("ImGuiKeyChord")]
        public int NavMoveKeyMods;

        public ImGuiDir NavMoveDir;

        public ImGuiDir NavMoveDirForDebug;

        public ImGuiDir NavMoveClipDir;

        public ImRect NavScoringRect;

        public ImRect NavScoringNoClipRect;

        public int NavScoringDebugCount;

        public int NavTabbingDir;

        public int NavTabbingCounter;

        public ImGuiNavItemData NavMoveResultLocal;

        public ImGuiNavItemData NavMoveResultLocalVisible;

        public ImGuiNavItemData NavMoveResultOther;

        public ImGuiNavItemData NavTabbingResultFirst;

        [NativeTypeName("ImGuiID")]
        public uint NavJustMovedFromFocusScopeId;

        [NativeTypeName("ImGuiID")]
        public uint NavJustMovedToId;

        [NativeTypeName("ImGuiID")]
        public uint NavJustMovedToFocusScopeId;

        [NativeTypeName("ImGuiKeyChord")]
        public int NavJustMovedToKeyMods;

        [NativeTypeName("bool")]
        public byte NavJustMovedToIsTabbing;

        [NativeTypeName("bool")]
        public byte NavJustMovedToHasSelectionData;

        [NativeTypeName("ImGuiKeyChord")]
        public int ConfigNavWindowingKeyNext;

        [NativeTypeName("ImGuiKeyChord")]
        public int ConfigNavWindowingKeyPrev;

        public ImGuiWindow* NavWindowingTarget;

        public ImGuiWindow* NavWindowingTargetAnim;

        public ImGuiWindow* NavWindowingListWindow;

        public float NavWindowingTimer;

        public float NavWindowingHighlightAlpha;

        [NativeTypeName("bool")]
        public byte NavWindowingToggleLayer;

        public ImGuiKey NavWindowingToggleKey;

        public ImVec2 NavWindowingAccumDeltaPos;

        public ImVec2 NavWindowingAccumDeltaSize;

        public float DimBgRatio;

        [NativeTypeName("bool")]
        public byte DragDropActive;

        [NativeTypeName("bool")]
        public byte DragDropWithinSource;

        [NativeTypeName("bool")]
        public byte DragDropWithinTarget;

        [NativeTypeName("ImGuiDragDropFlags")]
        public int DragDropSourceFlags;

        public int DragDropSourceFrameCount;

        public int DragDropMouseButton;

        public ImGuiPayload DragDropPayload;

        public ImRect DragDropTargetRect;

        public ImRect DragDropTargetClipRect;

        [NativeTypeName("ImGuiID")]
        public uint DragDropTargetId;

        [NativeTypeName("ImGuiDragDropFlags")]
        public int DragDropAcceptFlags;

        public float DragDropAcceptIdCurrRectSurface;

        [NativeTypeName("ImGuiID")]
        public uint DragDropAcceptIdCurr;

        [NativeTypeName("ImGuiID")]
        public uint DragDropAcceptIdPrev;

        public int DragDropAcceptFrameCount;

        [NativeTypeName("ImGuiID")]
        public uint DragDropHoldJustPressedId;

        public ImVector_unsigned_char DragDropPayloadBufHeap;

        [NativeTypeName("unsigned char[16]")]
        public _DragDropPayloadBufLocal_e__FixedBuffer DragDropPayloadBufLocal;

        public int ClipperTempDataStacked;

        public ImVector_ImGuiListClipperData ClipperTempData;

        public ImGuiTable* CurrentTable;

        [NativeTypeName("ImGuiID")]
        public uint DebugBreakInTable;

        public int TablesTempDataStacked;

        public ImVector_ImGuiTableTempData TablesTempData;

        public ImPool_ImGuiTable Tables;

        public ImVector_float TablesLastTimeActive;

        public ImVector_ImDrawChannel DrawChannelsTempMergeBuffer;

        public ImGuiTabBar* CurrentTabBar;

        public ImPool_ImGuiTabBar TabBars;

        public ImVector_ImGuiPtrOrIndex CurrentTabBarStack;

        public ImVector_ImGuiShrinkWidthItem ShrinkWidthBuffer;

        public ImGuiBoxSelectState BoxSelectState;

        public ImGuiMultiSelectTempData* CurrentMultiSelect;

        public int MultiSelectTempDataStacked;

        public ImVector_ImGuiMultiSelectTempData MultiSelectTempData;

        public ImPool_ImGuiMultiSelectState MultiSelectStorage;

        [NativeTypeName("ImGuiID")]
        public uint HoverItemDelayId;

        [NativeTypeName("ImGuiID")]
        public uint HoverItemDelayIdPreviousFrame;

        public float HoverItemDelayTimer;

        public float HoverItemDelayClearTimer;

        [NativeTypeName("ImGuiID")]
        public uint HoverItemUnlockedStationaryId;

        [NativeTypeName("ImGuiID")]
        public uint HoverWindowUnlockedStationaryId;

        [NativeTypeName("ImGuiMouseCursor")]
        public int MouseCursor;

        public float MouseStationaryTimer;

        public ImVec2 MouseLastValidPos;

        public ImGuiInputTextState InputTextState;

        public ImGuiInputTextDeactivatedState InputTextDeactivatedState;

        public ImFont InputTextPasswordFont;

        [NativeTypeName("ImGuiID")]
        public uint TempInputId;

        public ImGuiDataTypeStorage DataTypeZeroValue;

        public int BeginMenuDepth;

        public int BeginComboDepth;

        [NativeTypeName("ImGuiColorEditFlags")]
        public int ColorEditOptions;

        [NativeTypeName("ImGuiID")]
        public uint ColorEditCurrentID;

        [NativeTypeName("ImGuiID")]
        public uint ColorEditSavedID;

        public float ColorEditSavedHue;

        public float ColorEditSavedSat;

        [NativeTypeName("ImU32")]
        public uint ColorEditSavedColor;

        public ImVec4 ColorPickerRef;

        public ImGuiComboPreviewData ComboPreviewData;

        public ImRect WindowResizeBorderExpectedRect;

        [NativeTypeName("bool")]
        public byte WindowResizeRelativeMode;

        public short ScrollbarSeekMode;

        public float ScrollbarClickDeltaToGrabCenter;

        public float SliderGrabClickOffset;

        public float SliderCurrentAccum;

        [NativeTypeName("bool")]
        public byte SliderCurrentAccumDirty;

        [NativeTypeName("bool")]
        public byte DragCurrentAccumDirty;

        public float DragCurrentAccum;

        public float DragSpeedDefaultRatio;

        public float DisabledAlphaBackup;

        public short DisabledStackSize;

        public short TooltipOverrideCount;

        public ImGuiWindow* TooltipPreviousWindow;

        public ImVector_char ClipboardHandlerData;

        public ImVector_ImGuiID MenusIdSubmittedThisFrame;

        public ImGuiTypingSelectState TypingSelectState;

        public ImGuiPlatformImeData PlatformImeData;

        public ImGuiPlatformImeData PlatformImeDataPrev;

        [NativeTypeName("bool")]
        public byte SettingsLoaded;

        public float SettingsDirtyTimer;

        public ImGuiTextBuffer SettingsIniData;

        public ImVector_ImGuiSettingsHandler SettingsHandlers;

        public ImChunkStream_ImGuiWindowSettings SettingsWindows;

        public ImChunkStream_ImGuiTableSettings SettingsTables;

        public ImVector_ImGuiContextHook Hooks;

        [NativeTypeName("ImGuiID")]
        public uint HookIdNext;

        [NativeTypeName("const char *[10]")]
        public _LocalizationTable_e__FixedBuffer LocalizationTable;

        [NativeTypeName("bool")]
        public byte LogEnabled;

        [NativeTypeName("ImGuiLogFlags")]
        public int LogFlags;

        public ImGuiWindow* LogWindow;

        [NativeTypeName("ImFileHandle")]
        public void* LogFile;

        public ImGuiTextBuffer LogBuffer;

        [NativeTypeName("const char *")]
        public sbyte* LogNextPrefix;

        [NativeTypeName("const char *")]
        public sbyte* LogNextSuffix;

        public float LogLinePosY;

        [NativeTypeName("bool")]
        public byte LogLineFirstItem;

        public int LogDepthRef;

        public int LogDepthToExpand;

        public int LogDepthToExpandDefault;

        [NativeTypeName("ImGuiErrorCallback")]
        public delegate* unmanaged[Cdecl]<ImGuiContext*, void*, sbyte*, void> ErrorCallback;

        public void* ErrorCallbackUserData;

        public ImVec2 ErrorTooltipLockedPos;

        [NativeTypeName("bool")]
        public byte ErrorFirst;

        public int ErrorCountCurrentFrame;

        public ImGuiErrorRecoveryState StackSizesInNewFrame;

        public ImGuiErrorRecoveryState* StackSizesInBeginForCurrentWindow;

        public int DebugDrawIdConflictsCount;

        [NativeTypeName("ImGuiDebugLogFlags")]
        public int DebugLogFlags;

        public ImGuiTextBuffer DebugLogBuf;

        public ImGuiTextIndex DebugLogIndex;

        public int DebugLogSkippedErrors;

        [NativeTypeName("ImGuiDebugLogFlags")]
        public int DebugLogAutoDisableFlags;

        [NativeTypeName("ImU8")]
        public byte DebugLogAutoDisableFrames;

        [NativeTypeName("ImU8")]
        public byte DebugLocateFrames;

        [NativeTypeName("bool")]
        public byte DebugBreakInLocateId;

        [NativeTypeName("ImGuiKeyChord")]
        public int DebugBreakKeyChord;

        [NativeTypeName("ImS8")]
        public sbyte DebugBeginReturnValueCullDepth;

        [NativeTypeName("bool")]
        public byte DebugItemPickerActive;

        [NativeTypeName("ImU8")]
        public byte DebugItemPickerMouseButton;

        [NativeTypeName("ImGuiID")]
        public uint DebugItemPickerBreakId;

        public float DebugFlashStyleColorTime;

        public ImVec4 DebugFlashStyleColorBackup;

        public ImGuiMetricsConfig DebugMetricsConfig;

        public ImGuiIDStackTool DebugIDStackTool;

        public ImGuiDebugAllocInfo DebugAllocInfo;

        [NativeTypeName("float[60]")]
        public _FramerateSecPerFrame_e__FixedBuffer FramerateSecPerFrame;

        public int FramerateSecPerFrameIdx;

        public int FramerateSecPerFrameCount;

        public float FramerateSecPerFrameAccum;

        public int WantCaptureMouseNextFrame;

        public int WantCaptureKeyboardNextFrame;

        public int WantTextInputNextFrame;

        public ImVector_char TempBuffer;

        [NativeTypeName("char[64]")]
        public _TempKeychordName_e__FixedBuffer TempKeychordName;

        [InlineArray(16)]
        public partial struct _ContextName_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(154)]
        public partial struct _KeysOwnerData_e__FixedBuffer
        {
            public ImGuiKeyOwnerData e0;
        }

        [InlineArray(16)]
        public partial struct _DragDropPayloadBufLocal_e__FixedBuffer
        {
            public byte e0;
        }

        public unsafe partial struct _LocalizationTable_e__FixedBuffer
        {
            public sbyte* e0;
            public sbyte* e1;
            public sbyte* e2;
            public sbyte* e3;
            public sbyte* e4;
            public sbyte* e5;
            public sbyte* e6;
            public sbyte* e7;
            public sbyte* e8;
            public sbyte* e9;

            public ref sbyte* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (sbyte** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        [InlineArray(60)]
        public partial struct _FramerateSecPerFrame_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(64)]
        public partial struct _TempKeychordName_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public unsafe partial struct ImGuiWindowTempData
    {
        public ImVec2 CursorPos;

        public ImVec2 CursorPosPrevLine;

        public ImVec2 CursorStartPos;

        public ImVec2 CursorMaxPos;

        public ImVec2 IdealMaxPos;

        public ImVec2 CurrLineSize;

        public ImVec2 PrevLineSize;

        public float CurrLineTextBaseOffset;

        public float PrevLineTextBaseOffset;

        [NativeTypeName("bool")]
        public byte IsSameLine;

        [NativeTypeName("bool")]
        public byte IsSetPos;

        public ImVec1 Indent;

        public ImVec1 ColumnsOffset;

        public ImVec1 GroupOffset;

        public ImVec2 CursorStartPosLossyness;

        public ImGuiNavLayer NavLayerCurrent;

        public short NavLayersActiveMask;

        public short NavLayersActiveMaskNext;

        [NativeTypeName("bool")]
        public byte NavIsScrollPushableX;

        [NativeTypeName("bool")]
        public byte NavHideHighlightOneFrame;

        [NativeTypeName("bool")]
        public byte NavWindowHasScrollY;

        [NativeTypeName("bool")]
        public byte MenuBarAppending;

        public ImVec2 MenuBarOffset;

        public ImGuiMenuColumns MenuColumns;

        public int TreeDepth;

        [NativeTypeName("ImU32")]
        public uint TreeHasStackDataDepthMask;

        public ImVector_ImGuiWindowPtr ChildWindows;

        public ImGuiStorage* StateStorage;

        public ImGuiOldColumns* CurrentColumns;

        public int CurrentTableIdx;

        [NativeTypeName("ImGuiLayoutType")]
        public int LayoutType;

        [NativeTypeName("ImGuiLayoutType")]
        public int ParentLayoutType;

        [NativeTypeName("ImU32")]
        public uint ModalDimBgColor;

        public float ItemWidth;

        public float TextWrapPos;

        public ImVector_float ItemWidthStack;

        public ImVector_float TextWrapPosStack;
    }

    public unsafe partial struct ImVector_ImGuiOldColumns
    {
        public int Size;

        public int Capacity;

        public ImGuiOldColumns* Data;
    }

    public unsafe partial struct ImGuiWindow
    {
        public ImGuiContext* Ctx;

        [NativeTypeName("char *")]
        public sbyte* Name;

        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiWindowFlags")]
        public int Flags;

        [NativeTypeName("ImGuiChildFlags")]
        public int ChildFlags;

        public ImGuiViewportP* Viewport;

        public ImVec2 Pos;

        public ImVec2 Size;

        public ImVec2 SizeFull;

        public ImVec2 ContentSize;

        public ImVec2 ContentSizeIdeal;

        public ImVec2 ContentSizeExplicit;

        public ImVec2 WindowPadding;

        public float WindowRounding;

        public float WindowBorderSize;

        public float TitleBarHeight;

        public float MenuBarHeight;

        public float DecoOuterSizeX1;

        public float DecoOuterSizeY1;

        public float DecoOuterSizeX2;

        public float DecoOuterSizeY2;

        public float DecoInnerSizeX1;

        public float DecoInnerSizeY1;

        public int NameBufLen;

        [NativeTypeName("ImGuiID")]
        public uint MoveId;

        [NativeTypeName("ImGuiID")]
        public uint ChildId;

        [NativeTypeName("ImGuiID")]
        public uint PopupId;

        public ImVec2 Scroll;

        public ImVec2 ScrollMax;

        public ImVec2 ScrollTarget;

        public ImVec2 ScrollTargetCenterRatio;

        public ImVec2 ScrollTargetEdgeSnapDist;

        public ImVec2 ScrollbarSizes;

        [NativeTypeName("bool")]
        public byte ScrollbarX;

        [NativeTypeName("bool")]
        public byte ScrollbarY;

        [NativeTypeName("bool")]
        public byte Active;

        [NativeTypeName("bool")]
        public byte WasActive;

        [NativeTypeName("bool")]
        public byte WriteAccessed;

        [NativeTypeName("bool")]
        public byte Collapsed;

        [NativeTypeName("bool")]
        public byte WantCollapseToggle;

        [NativeTypeName("bool")]
        public byte SkipItems;

        [NativeTypeName("bool")]
        public byte SkipRefresh;

        [NativeTypeName("bool")]
        public byte Appearing;

        [NativeTypeName("bool")]
        public byte Hidden;

        [NativeTypeName("bool")]
        public byte IsFallbackWindow;

        [NativeTypeName("bool")]
        public byte IsExplicitChild;

        [NativeTypeName("bool")]
        public byte HasCloseButton;

        [NativeTypeName("signed char")]
        public sbyte ResizeBorderHovered;

        [NativeTypeName("signed char")]
        public sbyte ResizeBorderHeld;

        public short BeginCount;

        public short BeginCountPreviousFrame;

        public short BeginOrderWithinParent;

        public short BeginOrderWithinContext;

        public short FocusOrder;

        [NativeTypeName("ImS8")]
        public sbyte AutoFitFramesX;

        [NativeTypeName("ImS8")]
        public sbyte AutoFitFramesY;

        [NativeTypeName("bool")]
        public byte AutoFitOnlyGrows;

        public ImGuiDir AutoPosLastDirection;

        [NativeTypeName("ImS8")]
        public sbyte HiddenFramesCanSkipItems;

        [NativeTypeName("ImS8")]
        public sbyte HiddenFramesCannotSkipItems;

        [NativeTypeName("ImS8")]
        public sbyte HiddenFramesForRenderOnly;

        [NativeTypeName("ImS8")]
        public sbyte DisableInputsFrames;

        public int _bitfield;

        [NativeTypeName("ImGuiCond : 8")]
        public int SetWindowPosAllowFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 24) >> 24;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFF) | (value & 0xFF);
            }
        }

        [NativeTypeName("ImGuiCond : 8")]
        public int SetWindowSizeAllowFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 16) >> 24;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFF << 8)) | ((value & 0xFF) << 8);
            }
        }

        [NativeTypeName("ImGuiCond : 8")]
        public int SetWindowCollapsedAllowFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 8) >> 24;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFF << 16)) | ((value & 0xFF) << 16);
            }
        }

        public ImVec2 SetWindowPosVal;

        public ImVec2 SetWindowPosPivot;

        public ImVector_ImGuiID IDStack;

        public ImGuiWindowTempData DC;

        public ImRect OuterRectClipped;

        public ImRect InnerRect;

        public ImRect InnerClipRect;

        public ImRect WorkRect;

        public ImRect ParentWorkRect;

        public ImRect ClipRect;

        public ImRect ContentRegionRect;

        public ImVec2ih HitTestHoleSize;

        public ImVec2ih HitTestHoleOffset;

        public int LastFrameActive;

        public float LastTimeActive;

        public float ItemWidthDefault;

        public ImGuiStorage StateStorage;

        public ImVector_ImGuiOldColumns ColumnsStorage;

        public float FontWindowScale;

        public int SettingsOffset;

        public ImDrawList* DrawList;

        public ImDrawList DrawListInst;

        public ImGuiWindow* ParentWindow;

        public ImGuiWindow* ParentWindowInBeginStack;

        public ImGuiWindow* RootWindow;

        public ImGuiWindow* RootWindowPopupTree;

        public ImGuiWindow* RootWindowForTitleBarHighlight;

        public ImGuiWindow* RootWindowForNav;

        public ImGuiWindow* ParentWindowForFocusRoute;

        public ImGuiWindow* NavLastChildNavWindow;

        [NativeTypeName("ImGuiID[2]")]
        public _NavLastIds_e__FixedBuffer NavLastIds;

        [NativeTypeName("ImRect[2]")]
        public _NavRectRel_e__FixedBuffer NavRectRel;

        [NativeTypeName("ImVec2[2]")]
        public _NavPreferredScoringPosRel_e__FixedBuffer NavPreferredScoringPosRel;

        [NativeTypeName("ImGuiID")]
        public uint NavRootFocusScopeId;

        public int MemoryDrawListIdxCapacity;

        public int MemoryDrawListVtxCapacity;

        [NativeTypeName("bool")]
        public byte MemoryCompacted;

        [InlineArray(2)]
        public partial struct _NavLastIds_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(2)]
        public partial struct _NavRectRel_e__FixedBuffer
        {
            public ImRect e0;
        }

        [InlineArray(2)]
        public partial struct _NavPreferredScoringPosRel_e__FixedBuffer
        {
            public ImVec2 e0;
        }
    }

    public enum ImGuiTabBarFlagsPrivate_
    {
        ImGuiTabBarFlags_DockNode = 1 << 20,
        ImGuiTabBarFlags_IsFocused = 1 << 21,
        ImGuiTabBarFlags_SaveSettings = 1 << 22,
    }

    public enum ImGuiTabItemFlagsPrivate_
    {
        ImGuiTabItemFlags_SectionMask_ = ImGuiTabItemFlags_Leading | ImGuiTabItemFlags_Trailing,
        ImGuiTabItemFlags_NoCloseButton = 1 << 20,
        ImGuiTabItemFlags_Button = 1 << 21,
    }

    public partial struct ImGuiTabItem
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiTabItemFlags")]
        public int Flags;

        public int LastFrameVisible;

        public int LastFrameSelected;

        public float Offset;

        public float Width;

        public float ContentWidth;

        public float RequestedWidth;

        [NativeTypeName("ImS32")]
        public int NameOffset;

        [NativeTypeName("ImS16")]
        public short BeginOrder;

        [NativeTypeName("ImS16")]
        public short IndexDuringLayout;

        [NativeTypeName("bool")]
        public byte WantClose;
    }

    public unsafe partial struct ImVector_ImGuiTabItem
    {
        public int Size;

        public int Capacity;

        public ImGuiTabItem* Data;
    }

    public unsafe partial struct ImGuiTabBar
    {
        public ImGuiWindow* Window;

        public ImVector_ImGuiTabItem Tabs;

        [NativeTypeName("ImGuiTabBarFlags")]
        public int Flags;

        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiID")]
        public uint SelectedTabId;

        [NativeTypeName("ImGuiID")]
        public uint NextSelectedTabId;

        [NativeTypeName("ImGuiID")]
        public uint VisibleTabId;

        public int CurrFrameVisible;

        public int PrevFrameVisible;

        public ImRect BarRect;

        public float CurrTabsContentsHeight;

        public float PrevTabsContentsHeight;

        public float WidthAllTabs;

        public float WidthAllTabsIdeal;

        public float ScrollingAnim;

        public float ScrollingTarget;

        public float ScrollingTargetDistToVisibility;

        public float ScrollingSpeed;

        public float ScrollingRectMinX;

        public float ScrollingRectMaxX;

        public float SeparatorMinX;

        public float SeparatorMaxX;

        [NativeTypeName("ImGuiID")]
        public uint ReorderRequestTabId;

        [NativeTypeName("ImS16")]
        public short ReorderRequestOffset;

        [NativeTypeName("ImS8")]
        public sbyte BeginCount;

        [NativeTypeName("bool")]
        public byte WantLayout;

        [NativeTypeName("bool")]
        public byte VisibleTabWasSubmitted;

        [NativeTypeName("bool")]
        public byte TabsAddedNew;

        [NativeTypeName("ImS16")]
        public short TabsActiveCount;

        [NativeTypeName("ImS16")]
        public short LastTabItemIdx;

        public float ItemSpacingY;

        public ImVec2 FramePadding;

        public ImVec2 BackupCursorPos;

        public ImGuiTextBuffer TabsNames;
    }

    public partial struct ImGuiTableColumn
    {
        [NativeTypeName("ImGuiTableColumnFlags")]
        public int Flags;

        public float WidthGiven;

        public float MinX;

        public float MaxX;

        public float WidthRequest;

        public float WidthAuto;

        public float WidthMax;

        public float StretchWeight;

        public float InitStretchWeightOrWidth;

        public ImRect ClipRect;

        [NativeTypeName("ImGuiID")]
        public uint UserID;

        public float WorkMinX;

        public float WorkMaxX;

        public float ItemWidth;

        public float ContentMaxXFrozen;

        public float ContentMaxXUnfrozen;

        public float ContentMaxXHeadersUsed;

        public float ContentMaxXHeadersIdeal;

        [NativeTypeName("ImS16")]
        public short NameOffset;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short DisplayOrder;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short IndexWithinEnabledSet;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short PrevEnabledColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short NextEnabledColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short SortOrder;

        [NativeTypeName("ImGuiTableDrawChannelIdx")]
        public ushort DrawChannelCurrent;

        [NativeTypeName("ImGuiTableDrawChannelIdx")]
        public ushort DrawChannelFrozen;

        [NativeTypeName("ImGuiTableDrawChannelIdx")]
        public ushort DrawChannelUnfrozen;

        [NativeTypeName("bool")]
        public byte IsEnabled;

        [NativeTypeName("bool")]
        public byte IsUserEnabled;

        [NativeTypeName("bool")]
        public byte IsUserEnabledNextFrame;

        [NativeTypeName("bool")]
        public byte IsVisibleX;

        [NativeTypeName("bool")]
        public byte IsVisibleY;

        [NativeTypeName("bool")]
        public byte IsRequestOutput;

        [NativeTypeName("bool")]
        public byte IsSkipItems;

        [NativeTypeName("bool")]
        public byte IsPreserveWidthAuto;

        [NativeTypeName("ImS8")]
        public sbyte NavLayerCurrent;

        [NativeTypeName("ImU8")]
        public byte AutoFitQueue;

        [NativeTypeName("ImU8")]
        public byte CannotSkipItemsQueue;

        public byte _bitfield;

        [NativeTypeName("ImU8 : 2")]
        public byte SortDirection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield & 0x3u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~0x3u) | (value & 0x3u));
            }
        }

        [NativeTypeName("ImU8 : 2")]
        public byte SortDirectionsAvailCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 2) & 0x3u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x3u << 2)) | ((value & 0x3u) << 2));
            }
        }

        [NativeTypeName("ImU8 : 4")]
        public byte SortDirectionsAvailMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 4) & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0xFu << 4)) | ((value & 0xFu) << 4));
            }
        }

        [NativeTypeName("ImU8")]
        public byte SortDirectionsAvailList;
    }

    public partial struct ImGuiTableCellData
    {
        [NativeTypeName("ImU32")]
        public uint BgColor;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short Column;
    }

    public partial struct ImGuiTableHeaderData
    {
        [NativeTypeName("ImGuiTableColumnIdx")]
        public short Index;

        [NativeTypeName("ImU32")]
        public uint TextColor;

        [NativeTypeName("ImU32")]
        public uint BgColor0;

        [NativeTypeName("ImU32")]
        public uint BgColor1;
    }

    public partial struct ImGuiTableInstanceData
    {
        [NativeTypeName("ImGuiID")]
        public uint TableInstanceID;

        public float LastOuterHeight;

        public float LastTopHeadersRowHeight;

        public float LastFrozenHeight;

        public int HoveredRowLast;

        public int HoveredRowNext;
    }

    public unsafe partial struct ImSpan_ImGuiTableColumn
    {
        public ImGuiTableColumn* Data;

        public ImGuiTableColumn* DataEnd;
    }

    public unsafe partial struct ImSpan_ImGuiTableColumnIdx
    {
        [NativeTypeName("ImGuiTableColumnIdx *")]
        public short* Data;

        [NativeTypeName("ImGuiTableColumnIdx *")]
        public short* DataEnd;
    }

    public unsafe partial struct ImSpan_ImGuiTableCellData
    {
        public ImGuiTableCellData* Data;

        public ImGuiTableCellData* DataEnd;
    }

    public unsafe partial struct ImVector_ImGuiTableInstanceData
    {
        public int Size;

        public int Capacity;

        public ImGuiTableInstanceData* Data;
    }

    public unsafe partial struct ImVector_ImGuiTableColumnSortSpecs
    {
        public int Size;

        public int Capacity;

        public ImGuiTableColumnSortSpecs* Data;
    }

    public unsafe partial struct ImGuiTable
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiTableFlags")]
        public int Flags;

        public void* RawData;

        public ImGuiTableTempData* TempData;

        public ImSpan_ImGuiTableColumn Columns;

        public ImSpan_ImGuiTableColumnIdx DisplayOrderToIndex;

        public ImSpan_ImGuiTableCellData RowCellData;

        [NativeTypeName("ImBitArrayPtr")]
        public uint* EnabledMaskByDisplayOrder;

        [NativeTypeName("ImBitArrayPtr")]
        public uint* EnabledMaskByIndex;

        [NativeTypeName("ImBitArrayPtr")]
        public uint* VisibleMaskByIndex;

        [NativeTypeName("ImGuiTableFlags")]
        public int SettingsLoadedFlags;

        public int SettingsOffset;

        public int LastFrameActive;

        public int ColumnsCount;

        public int CurrentRow;

        public int CurrentColumn;

        [NativeTypeName("ImS16")]
        public short InstanceCurrent;

        [NativeTypeName("ImS16")]
        public short InstanceInteracted;

        public float RowPosY1;

        public float RowPosY2;

        public float RowMinHeight;

        public float RowCellPaddingY;

        public float RowTextBaseline;

        public float RowIndentOffsetX;

        public int _bitfield;

        [NativeTypeName("ImGuiTableRowFlags : 16")]
        public int RowFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 16) >> 16;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFFFF) | (value & 0xFFFF);
            }
        }

        [NativeTypeName("ImGuiTableRowFlags : 16")]
        public int LastRowFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 0) >> 16;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFF << 16)) | ((value & 0xFFFF) << 16);
            }
        }

        public int RowBgColorCounter;

        [NativeTypeName("ImU32[2]")]
        public _RowBgColor_e__FixedBuffer RowBgColor;

        [NativeTypeName("ImU32")]
        public uint BorderColorStrong;

        [NativeTypeName("ImU32")]
        public uint BorderColorLight;

        public float BorderX1;

        public float BorderX2;

        public float HostIndentX;

        public float MinColumnWidth;

        public float OuterPaddingX;

        public float CellPaddingX;

        public float CellSpacingX1;

        public float CellSpacingX2;

        public float InnerWidth;

        public float ColumnsGivenWidth;

        public float ColumnsAutoFitWidth;

        public float ColumnsStretchSumWeights;

        public float ResizedColumnNextWidth;

        public float ResizeLockMinContentsX2;

        public float RefScale;

        public float AngledHeadersHeight;

        public float AngledHeadersSlope;

        public ImRect OuterRect;

        public ImRect InnerRect;

        public ImRect WorkRect;

        public ImRect InnerClipRect;

        public ImRect BgClipRect;

        public ImRect Bg0ClipRectForDrawCmd;

        public ImRect Bg2ClipRectForDrawCmd;

        public ImRect HostClipRect;

        public ImRect HostBackupInnerClipRect;

        public ImGuiWindow* OuterWindow;

        public ImGuiWindow* InnerWindow;

        public ImGuiTextBuffer ColumnsNames;

        public ImDrawListSplitter* DrawSplitter;

        public ImGuiTableInstanceData InstanceDataFirst;

        public ImVector_ImGuiTableInstanceData InstanceDataExtra;

        public ImGuiTableColumnSortSpecs SortSpecsSingle;

        public ImVector_ImGuiTableColumnSortSpecs SortSpecsMulti;

        public ImGuiTableSortSpecs SortSpecs;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short SortSpecsCount;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short ColumnsEnabledCount;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short ColumnsEnabledFixedCount;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short DeclColumnsCount;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short AngledHeadersCount;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short HoveredColumnBody;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short HoveredColumnBorder;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short HighlightColumnHeader;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short AutoFitSingleColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short ResizedColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short LastResizedColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short HeldHeaderColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short ReorderColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short ReorderColumnDir;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short LeftMostEnabledColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short RightMostEnabledColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short LeftMostStretchedColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short RightMostStretchedColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short ContextPopupColumn;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short FreezeRowsRequest;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short FreezeRowsCount;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short FreezeColumnsRequest;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short FreezeColumnsCount;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short RowCellDataCurrent;

        [NativeTypeName("ImGuiTableDrawChannelIdx")]
        public ushort DummyDrawChannel;

        [NativeTypeName("ImGuiTableDrawChannelIdx")]
        public ushort Bg2DrawChannelCurrent;

        [NativeTypeName("ImGuiTableDrawChannelIdx")]
        public ushort Bg2DrawChannelUnfrozen;

        [NativeTypeName("bool")]
        public byte IsLayoutLocked;

        [NativeTypeName("bool")]
        public byte IsInsideRow;

        [NativeTypeName("bool")]
        public byte IsInitializing;

        [NativeTypeName("bool")]
        public byte IsSortSpecsDirty;

        [NativeTypeName("bool")]
        public byte IsUsingHeaders;

        [NativeTypeName("bool")]
        public byte IsContextPopupOpen;

        [NativeTypeName("bool")]
        public byte DisableDefaultContextMenu;

        [NativeTypeName("bool")]
        public byte IsSettingsRequestLoad;

        [NativeTypeName("bool")]
        public byte IsSettingsDirty;

        [NativeTypeName("bool")]
        public byte IsDefaultDisplayOrder;

        [NativeTypeName("bool")]
        public byte IsResetAllRequest;

        [NativeTypeName("bool")]
        public byte IsResetDisplayOrderRequest;

        [NativeTypeName("bool")]
        public byte IsUnfrozenRows;

        [NativeTypeName("bool")]
        public byte IsDefaultSizingPolicy;

        [NativeTypeName("bool")]
        public byte IsActiveIdAliveBeforeTable;

        [NativeTypeName("bool")]
        public byte IsActiveIdInTable;

        [NativeTypeName("bool")]
        public byte HasScrollbarYCurr;

        [NativeTypeName("bool")]
        public byte HasScrollbarYPrev;

        [NativeTypeName("bool")]
        public byte MemoryCompacted;

        [NativeTypeName("bool")]
        public byte HostSkipItems;

        [InlineArray(2)]
        public partial struct _RowBgColor_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public unsafe partial struct ImVector_ImGuiTableHeaderData
    {
        public int Size;

        public int Capacity;

        public ImGuiTableHeaderData* Data;
    }

    public partial struct ImGuiTableTempData
    {
        public int TableIndex;

        public float LastTimeActive;

        public float AngledHeadersExtraWidth;

        public ImVector_ImGuiTableHeaderData AngledHeadersRequests;

        public ImVec2 UserOuterSize;

        public ImDrawListSplitter DrawSplitter;

        public ImRect HostBackupWorkRect;

        public ImRect HostBackupParentWorkRect;

        public ImVec2 HostBackupPrevLineSize;

        public ImVec2 HostBackupCurrLineSize;

        public ImVec2 HostBackupCursorMaxPos;

        public ImVec1 HostBackupColumnsOffset;

        public float HostBackupItemWidth;

        public int HostBackupItemWidthStackSize;
    }

    public partial struct ImGuiTableColumnSettings
    {
        public float WidthOrWeight;

        [NativeTypeName("ImGuiID")]
        public uint UserID;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short Index;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short DisplayOrder;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short SortOrder;

        public byte _bitfield;

        [NativeTypeName("ImU8 : 2")]
        public byte SortDirection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield & 0x3u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~0x3u) | (value & 0x3u));
            }
        }

        [NativeTypeName("ImU8 : 1")]
        public byte IsEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 2) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
            }
        }

        [NativeTypeName("ImU8 : 1")]
        public byte IsStretch
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 3) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3));
            }
        }
    }

    public partial struct ImGuiTableSettings
    {
        [NativeTypeName("ImGuiID")]
        public uint ID;

        [NativeTypeName("ImGuiTableFlags")]
        public int SaveFlags;

        public float RefScale;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short ColumnsCount;

        [NativeTypeName("ImGuiTableColumnIdx")]
        public short ColumnsCountMax;

        [NativeTypeName("bool")]
        public byte WantApply;
    }

    public unsafe partial struct ImFontBuilderIO
    {
        [NativeTypeName("bool (*)(ImFontAtlas *)")]
        public delegate* unmanaged[Cdecl]<ImFontAtlas*, byte> FontBuilder_Build;
    }

    public partial struct simgui_image_t
    {
        [NativeTypeName("uint32_t")]
        public uint id;
    }

    public partial struct simgui_image_desc_t
    {
        public sg_image image;

        public sg_sampler sampler;
    }

    public enum simgui_log_item_t
    {
        SIMGUI_LOGITEM_OK,
        SIMGUI_LOGITEM_MALLOC_FAILED,
        SIMGUI_LOGITEM_IMAGE_POOL_EXHAUSTED,
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

        public int image_pool_size;

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
        public static extern ImVec2* ImVec2_ImVec2_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImVec2_destroy(ImVec2* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImVec2* ImVec2_ImVec2_Float(float _x, float _y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImVec4* ImVec4_ImVec4_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImVec4_destroy(ImVec4* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImVec4* ImVec4_ImVec4_Float(float _x, float _y, float _z, float _w);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiContext* igCreateContext(ImFontAtlas* shared_font_atlas);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDestroyContext(ImGuiContext* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiContext* igGetCurrentContext();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCurrentContext(ImGuiContext* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiIO* igGetIO();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiPlatformIO* igGetPlatformIO();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStyle* igGetStyle();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNewFrame();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndFrame();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRender();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawData* igGetDrawData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowDemoWindow(bool* p_open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowMetricsWindow(bool* p_open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowDebugLogWindow(bool* p_open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowIDStackToolWindow(bool* p_open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowAboutWindow(bool* p_open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowStyleEditor(ImGuiStyle* @ref);

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
        public static extern void igStyleColorsDark(ImGuiStyle* dst);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igStyleColorsLight(ImGuiStyle* dst);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igStyleColorsClassic(ImGuiStyle* dst);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBegin([NativeTypeName("const char *")] sbyte* name, bool* p_open, [NativeTypeName("ImGuiWindowFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEnd();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginChild_Str([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("const ImVec2")] ImVec2 size, [NativeTypeName("ImGuiChildFlags")] int child_flags, [NativeTypeName("ImGuiWindowFlags")] int window_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginChild_ID([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("const ImVec2")] ImVec2 size, [NativeTypeName("ImGuiChildFlags")] int child_flags, [NativeTypeName("ImGuiWindowFlags")] int window_flags);

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
        public static extern ImDrawList* igGetWindowDrawList();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetWindowPos(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetWindowSize(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetWindowWidth();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetWindowHeight();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowPos([NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("ImGuiCond")] int cond, [NativeTypeName("const ImVec2")] ImVec2 pivot);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowSize([NativeTypeName("const ImVec2")] ImVec2 size, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowSizeConstraints([NativeTypeName("const ImVec2")] ImVec2 size_min, [NativeTypeName("const ImVec2")] ImVec2 size_max, [NativeTypeName("ImGuiSizeCallback")] delegate* unmanaged[Cdecl]<ImGuiSizeCallbackData*, void> custom_callback, void* custom_callback_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowContentSize([NativeTypeName("const ImVec2")] ImVec2 size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowCollapsed([NativeTypeName("bool")] byte collapsed, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowFocus();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowScroll([NativeTypeName("const ImVec2")] ImVec2 scroll);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowBgAlpha(float alpha);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowPos_Vec2([NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowSize_Vec2([NativeTypeName("const ImVec2")] ImVec2 size, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowCollapsed_Bool([NativeTypeName("bool")] byte collapsed, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowFocus_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowFontScale(float scale);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowPos_Str([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowSize_Str([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const ImVec2")] ImVec2 size, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowCollapsed_Str([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("bool")] byte collapsed, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowFocus_Str([NativeTypeName("const char *")] sbyte* name);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetScrollX();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetScrollY();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollX_Float(float scroll_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollY_Float(float scroll_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetScrollMaxX();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetScrollMaxY();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollHereX(float center_x_ratio);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollHereY(float center_y_ratio);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollFromPosX_Float(float local_x, float center_x_ratio);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollFromPosY_Float(float local_y, float center_y_ratio);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushFont(ImFont* font);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopFont();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleColor_U32([NativeTypeName("ImGuiCol")] int idx, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleColor_Vec4([NativeTypeName("ImGuiCol")] int idx, [NativeTypeName("const ImVec4")] ImVec4 col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopStyleColor(int count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleVar_Float([NativeTypeName("ImGuiStyleVar")] int idx, float val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleVar_Vec2([NativeTypeName("ImGuiStyleVar")] int idx, [NativeTypeName("const ImVec2")] ImVec2 val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleVarX([NativeTypeName("ImGuiStyleVar")] int idx, float val_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushStyleVarY([NativeTypeName("ImGuiStyleVar")] int idx, float val_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopStyleVar(int count);

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
        public static extern ImFont* igGetFont();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetFontSize();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetFontTexUvWhitePixel(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igGetColorU32_Col([NativeTypeName("ImGuiCol")] int idx, float alpha_mul);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igGetColorU32_Vec4([NativeTypeName("const ImVec4")] ImVec4 col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igGetColorU32_U32([NativeTypeName("ImU32")] uint col, float alpha_mul);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImVec4 *")]
        public static extern ImVec4* igGetStyleColorVec4([NativeTypeName("ImGuiCol")] int idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetCursorScreenPos(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCursorScreenPos([NativeTypeName("const ImVec2")] ImVec2 pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetContentRegionAvail(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetCursorPos(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetCursorPosX();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetCursorPosY();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCursorPos([NativeTypeName("const ImVec2")] ImVec2 local_pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCursorPosX(float local_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCursorPosY(float local_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetCursorStartPos(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSeparator();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSameLine(float offset_from_start_x, float spacing);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNewLine();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSpacing();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDummy([NativeTypeName("const ImVec2")] ImVec2 size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igIndent(float indent_w);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igUnindent(float indent_w);

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
        public static extern void igPushID_Str([NativeTypeName("const char *")] sbyte* str_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushID_StrStr([NativeTypeName("const char *")] sbyte* str_id_begin, [NativeTypeName("const char *")] sbyte* str_id_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushID_Ptr([NativeTypeName("const void *")] void* ptr_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushID_Int(int int_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopID();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetID_Str([NativeTypeName("const char *")] sbyte* str_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetID_StrStr([NativeTypeName("const char *")] sbyte* str_id_begin, [NativeTypeName("const char *")] sbyte* str_id_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetID_Ptr([NativeTypeName("const void *")] void* ptr_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetID_Int(int int_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextUnformatted([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igText([NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextColored([NativeTypeName("const ImVec4")] ImVec4 col, [NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextColoredV([NativeTypeName("const ImVec4")] ImVec4 col, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextDisabled([NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextDisabledV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextWrapped([NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextWrappedV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLabelText([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLabelTextV([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBulletText([NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBulletTextV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSeparatorText([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igButton([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const ImVec2")] ImVec2 size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSmallButton([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInvisibleButton([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("const ImVec2")] ImVec2 size, [NativeTypeName("ImGuiButtonFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igArrowButton([NativeTypeName("const char *")] sbyte* str_id, ImGuiDir dir);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCheckbox([NativeTypeName("const char *")] sbyte* label, bool* v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCheckboxFlags_IntPtr([NativeTypeName("const char *")] sbyte* label, int* flags, int flags_value);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCheckboxFlags_UintPtr([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("unsigned int *")] uint* flags, [NativeTypeName("unsigned int")] uint flags_value);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igRadioButton_Bool([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("bool")] byte active);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igRadioButton_IntPtr([NativeTypeName("const char *")] sbyte* label, int* v, int v_button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igProgressBar(float fraction, [NativeTypeName("const ImVec2")] ImVec2 size_arg, [NativeTypeName("const char *")] sbyte* overlay);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBullet();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTextLink([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextLinkOpenURL([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* url);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImage([NativeTypeName("ImTextureID")] ulong user_texture_id, [NativeTypeName("const ImVec2")] ImVec2 image_size, [NativeTypeName("const ImVec2")] ImVec2 uv0, [NativeTypeName("const ImVec2")] ImVec2 uv1, [NativeTypeName("const ImVec4")] ImVec4 tint_col, [NativeTypeName("const ImVec4")] ImVec4 border_col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImageButton([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImTextureID")] ulong user_texture_id, [NativeTypeName("const ImVec2")] ImVec2 image_size, [NativeTypeName("const ImVec2")] ImVec2 uv0, [NativeTypeName("const ImVec2")] ImVec2 uv1, [NativeTypeName("const ImVec4")] ImVec4 bg_col, [NativeTypeName("const ImVec4")] ImVec4 tint_col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginCombo([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* preview_value, [NativeTypeName("ImGuiComboFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndCombo();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCombo_Str_arr([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *const[]")] sbyte** items, int items_count, int popup_max_height_in_items);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCombo_Str([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *")] sbyte* items_separated_by_zeros, int popup_max_height_in_items);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCombo_FnStrPtr([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *(*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, sbyte*> getter, void* user_data, int items_count, int popup_max_height_in_items);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat([NativeTypeName("const char *")] sbyte* label, float* v, float v_speed, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[2]")] float* v, float v_speed, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* v, float v_speed, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloat4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* v, float v_speed, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragFloatRange2([NativeTypeName("const char *")] sbyte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("const char *")] sbyte* format_max, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt([NativeTypeName("const char *")] sbyte* label, int* v, float v_speed, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[2]")] int* v, float v_speed, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[3]")] int* v, float v_speed, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragInt4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[4]")] int* v, float v_speed, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragIntRange2([NativeTypeName("const char *")] sbyte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("const char *")] sbyte* format_max, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragScalar([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, float v_speed, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragScalarN([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, int components, float v_speed, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat([NativeTypeName("const char *")] sbyte* label, float* v, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[2]")] float* v, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* v, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderFloat4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* v, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderAngle([NativeTypeName("const char *")] sbyte* label, float* v_rad, float v_degrees_min, float v_degrees_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt([NativeTypeName("const char *")] sbyte* label, int* v, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[2]")] int* v, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[3]")] int* v, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderInt4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("int[4]")] int* v, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderScalar([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderScalarN([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, int components, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igVSliderFloat([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const ImVec2")] ImVec2 size, float* v, float v_min, float v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igVSliderInt([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const ImVec2")] ImVec2 size, int* v, int v_min, int v_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igVSliderScalar([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const ImVec2")] ImVec2 size, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputText([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("ImGuiInputTextFlags")] int flags, [NativeTypeName("ImGuiInputTextCallback")] delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback, void* user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputTextMultiline([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("const ImVec2")] ImVec2 size, [NativeTypeName("ImGuiInputTextFlags")] int flags, [NativeTypeName("ImGuiInputTextCallback")] delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback, void* user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputTextWithHint([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* hint, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("ImGuiInputTextFlags")] int flags, [NativeTypeName("ImGuiInputTextCallback")] delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback, void* user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat([NativeTypeName("const char *")] sbyte* label, float* v, float step, float step_fast, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat2([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[2]")] float* v, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat3([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[3]")] float* v, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputFloat4([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float[4]")] float* v, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputInt([NativeTypeName("const char *")] sbyte* label, int* v, int step, int step_fast, [NativeTypeName("ImGuiInputTextFlags")] int flags);

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
        public static extern byte igInputDouble([NativeTypeName("const char *")] sbyte* label, double* v, double step, double step_fast, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputScalar([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const void *")] void* p_step, [NativeTypeName("const void *")] void* p_step_fast, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputScalarN([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, int components, [NativeTypeName("const void *")] void* p_step, [NativeTypeName("const void *")] void* p_step_fast, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiInputTextFlags")] int flags);

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
        public static extern byte igColorButton([NativeTypeName("const char *")] sbyte* desc_id, [NativeTypeName("const ImVec4")] ImVec4 col, [NativeTypeName("ImGuiColorEditFlags")] int flags, [NativeTypeName("const ImVec2")] ImVec2 size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetColorEditOptions([NativeTypeName("ImGuiColorEditFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNode_Str([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNode_StrStr([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNode_Ptr([NativeTypeName("const void *")] void* ptr_id, [NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeV_Str([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeV_Ptr([NativeTypeName("const void *")] void* ptr_id, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeEx_Str([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiTreeNodeFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeEx_StrStr([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiTreeNodeFlags")] int flags, [NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeEx_Ptr([NativeTypeName("const void *")] void* ptr_id, [NativeTypeName("ImGuiTreeNodeFlags")] int flags, [NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeExV_Str([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiTreeNodeFlags")] int flags, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeExV_Ptr([NativeTypeName("const void *")] void* ptr_id, [NativeTypeName("ImGuiTreeNodeFlags")] int flags, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTreePush_Str([NativeTypeName("const char *")] sbyte* str_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTreePush_Ptr([NativeTypeName("const void *")] void* ptr_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTreePop();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetTreeNodeToLabelSpacing();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCollapsingHeader_TreeNodeFlags([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiTreeNodeFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCollapsingHeader_BoolPtr([NativeTypeName("const char *")] sbyte* label, bool* p_visible, [NativeTypeName("ImGuiTreeNodeFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemOpen([NativeTypeName("bool")] byte is_open, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemStorageID([NativeTypeName("ImGuiID")] uint storage_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSelectable_Bool([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("bool")] byte selected, [NativeTypeName("ImGuiSelectableFlags")] int flags, [NativeTypeName("const ImVec2")] ImVec2 size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSelectable_BoolPtr([NativeTypeName("const char *")] sbyte* label, bool* p_selected, [NativeTypeName("ImGuiSelectableFlags")] int flags, [NativeTypeName("const ImVec2")] ImVec2 size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiMultiSelectIO* igBeginMultiSelect([NativeTypeName("ImGuiMultiSelectFlags")] int flags, int selection_size, int items_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiMultiSelectIO* igEndMultiSelect();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemSelectionUserData([NativeTypeName("ImGuiSelectionUserData")] long selection_user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsItemToggledSelection();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginListBox([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const ImVec2")] ImVec2 size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndListBox();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igListBox_Str_arr([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *const[]")] sbyte** items, int items_count, int height_in_items);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igListBox_FnStrPtr([NativeTypeName("const char *")] sbyte* label, int* current_item, [NativeTypeName("const char *(*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, sbyte*> getter, void* user_data, int items_count, int height_in_items);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotLines_FloatPtr([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const float *")] float* values, int values_count, int values_offset, [NativeTypeName("const char *")] sbyte* overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotLines_FnFloatPtr([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float (*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, float> values_getter, void* data, int values_count, int values_offset, [NativeTypeName("const char *")] sbyte* overlay_text, float scale_min, float scale_max, ImVec2 graph_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotHistogram_FloatPtr([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const float *")] float* values, int values_count, int values_offset, [NativeTypeName("const char *")] sbyte* overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPlotHistogram_FnFloatPtr([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float (*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, float> values_getter, void* data, int values_count, int values_offset, [NativeTypeName("const char *")] sbyte* overlay_text, float scale_min, float scale_max, ImVec2 graph_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igValue_Bool([NativeTypeName("const char *")] sbyte* prefix, [NativeTypeName("bool")] byte b);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igValue_Int([NativeTypeName("const char *")] sbyte* prefix, int v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igValue_Uint([NativeTypeName("const char *")] sbyte* prefix, [NativeTypeName("unsigned int")] uint v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igValue_Float([NativeTypeName("const char *")] sbyte* prefix, float v, [NativeTypeName("const char *")] sbyte* float_format);

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
        public static extern byte igBeginMenu([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("bool")] byte enabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndMenu();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igMenuItem_Bool([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* shortcut, [NativeTypeName("bool")] byte selected, [NativeTypeName("bool")] byte enabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igMenuItem_BoolPtr([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* shortcut, bool* p_selected, [NativeTypeName("bool")] byte enabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTooltip();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndTooltip();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetTooltip([NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetTooltipV([NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginItemTooltip();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetItemTooltip([NativeTypeName("const char *")] sbyte* fmt, params string[] args);

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
        public static extern void igOpenPopup_Str([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igOpenPopup_ID([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igOpenPopupOnItemClick([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igCloseCurrentPopup();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupContextItem([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupContextWindow([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupContextVoid([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsPopupOpen_Str([NativeTypeName("const char *")] sbyte* str_id, [NativeTypeName("ImGuiPopupFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTable([NativeTypeName("const char *")] sbyte* str_id, int columns, [NativeTypeName("ImGuiTableFlags")] int flags, [NativeTypeName("const ImVec2")] ImVec2 outer_size, float inner_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndTable();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableNextRow([NativeTypeName("ImGuiTableRowFlags")] int row_flags, float min_row_height);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTableNextColumn();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTableSetColumnIndex(int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetupColumn([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiTableColumnFlags")] int flags, float init_width_or_weight, [NativeTypeName("ImGuiID")] uint user_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetupScrollFreeze(int cols, int rows);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableHeader([NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableHeadersRow();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableAngledHeadersRow();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableSortSpecs* igTableGetSortSpecs();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTableGetColumnCount();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTableGetColumnIndex();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTableGetRowIndex();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igTableGetColumnName_Int(int column_n);

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
        public static extern void igColumns(int count, [NativeTypeName("const char *")] sbyte* id, [NativeTypeName("bool")] byte borders);

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
        public static extern ImGuiPayload* igAcceptDragDropPayload([NativeTypeName("const char *")] sbyte* type, [NativeTypeName("ImGuiDragDropFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndDragDropTarget();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImGuiPayload *")]
        public static extern ImGuiPayload* igGetDragDropPayload();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBeginDisabled([NativeTypeName("bool")] byte disabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndDisabled();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushClipRect([NativeTypeName("const ImVec2")] ImVec2 clip_rect_min, [NativeTypeName("const ImVec2")] ImVec2 clip_rect_max, [NativeTypeName("bool")] byte intersect_with_current_clip_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopClipRect();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetItemDefaultFocus();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetKeyboardFocusHere(int offset);

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
        public static extern byte igIsItemClicked([NativeTypeName("ImGuiMouseButton")] int mouse_button);

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
        public static extern void igGetItemRectMin(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetItemRectMax(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetItemRectSize(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiViewport* igGetMainViewport();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawList* igGetBackgroundDrawList_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawList* igGetForegroundDrawList_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsRectVisible_Nil([NativeTypeName("const ImVec2")] ImVec2 size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsRectVisible_Vec2([NativeTypeName("const ImVec2")] ImVec2 rect_min, [NativeTypeName("const ImVec2")] ImVec2 rect_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double igGetTime();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igGetFrameCount();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawListSharedData* igGetDrawListSharedData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igGetStyleColorName([NativeTypeName("ImGuiCol")] int idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetStateStorage(ImGuiStorage* storage);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStorage* igGetStateStorage();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igCalcTextSize(ImVec2* pOut, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, [NativeTypeName("bool")] byte hide_text_after_double_hash, float wrap_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igColorConvertU32ToFloat4(ImVec4* pOut, [NativeTypeName("ImU32")] uint @in);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igColorConvertFloat4ToU32([NativeTypeName("const ImVec4")] ImVec4 @in);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyDown_Nil(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyPressed_Bool(ImGuiKey key, [NativeTypeName("bool")] byte repeat);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyReleased_Nil(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyChordPressed_Nil([NativeTypeName("ImGuiKeyChord")] int key_chord);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igGetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igGetKeyName(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextFrameWantCaptureKeyboard([NativeTypeName("bool")] byte want_capture_keyboard);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igShortcut_Nil([NativeTypeName("ImGuiKeyChord")] int key_chord, [NativeTypeName("ImGuiInputFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemShortcut([NativeTypeName("ImGuiKeyChord")] int key_chord, [NativeTypeName("ImGuiInputFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetItemKeyOwner_Nil(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseDown_Nil([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseClicked_Bool([NativeTypeName("ImGuiMouseButton")] int button, [NativeTypeName("bool")] byte repeat);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseReleased_Nil([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseDoubleClicked_Nil([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igGetMouseClickedCount([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseHoveringRect([NativeTypeName("const ImVec2")] ImVec2 r_min, [NativeTypeName("const ImVec2")] ImVec2 r_max, [NativeTypeName("bool")] byte clip);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMousePosValid([NativeTypeName("const ImVec2 *")] ImVec2* mouse_pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsAnyMouseDown();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetMousePos(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetMousePosOnOpeningCurrentPopup(ImVec2* pOut);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseDragging([NativeTypeName("ImGuiMouseButton")] int button, float lock_threshold);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetMouseDragDelta(ImVec2* pOut, [NativeTypeName("ImGuiMouseButton")] int button, float lock_threshold);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igResetMouseDragDelta([NativeTypeName("ImGuiMouseButton")] int button);

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
        public static extern void igDebugLog([NativeTypeName("const char *")] sbyte* fmt, params string[] args);

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
        public static extern ImGuiTableSortSpecs* ImGuiTableSortSpecs_ImGuiTableSortSpecs();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStyle* ImGuiStyle_ImGuiStyle();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStyle_destroy(ImGuiStyle* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddKeyEvent(ImGuiIO* self, ImGuiKey key, [NativeTypeName("bool")] byte down);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, [NativeTypeName("bool")] byte down, float v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddMousePosEvent(ImGuiIO* self, float x, float y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddMouseButtonEvent(ImGuiIO* self, int button, [NativeTypeName("bool")] byte down);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddMouseWheelEvent(ImGuiIO* self, float wheel_x, float wheel_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddFocusEvent(ImGuiIO* self, [NativeTypeName("bool")] byte focused);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, [NativeTypeName("unsigned int")] uint c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, [NativeTypeName("ImWchar16")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, [NativeTypeName("const char *")] sbyte* str);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* self, [NativeTypeName("bool")] byte accepting_events);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_ClearEventsQueue(ImGuiIO* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_ClearInputKeys(ImGuiIO* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_ClearInputMouse(ImGuiIO* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiIO* ImGuiIO_ImGuiIO();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIO_destroy(ImGuiIO* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiPayload* ImGuiPayload_ImGuiPayload();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPayload_destroy(ImGuiPayload* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPayload_Clear(ImGuiPayload* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, [NativeTypeName("const char *")] sbyte* type);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter([NativeTypeName("const char *")] sbyte* default_filter);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextFilter_destroy(ImGuiTextFilter* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, [NativeTypeName("const char *")] sbyte* label, float width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextRange_destroy(ImGuiTextRange* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Str([NativeTypeName("const char *")] sbyte* _b, [NativeTypeName("const char *")] sbyte* _e);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiTextRange_empty(ImGuiTextRange* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextRange_split(ImGuiTextRange* self, [NativeTypeName("char")] sbyte separator, ImVector_ImGuiTextRange* @out);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, [NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char *")] sbyte* str_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_appendfv(ImGuiTextBuffer* self, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Int([NativeTypeName("ImGuiID")] uint _key, int _val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStoragePair_destroy(ImGuiStoragePair* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Float([NativeTypeName("ImGuiID")] uint _key, float _val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Ptr([NativeTypeName("ImGuiID")] uint _key, void* _val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_Clear(ImGuiStorage* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, int default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, int val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, [NativeTypeName("bool")] byte default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, [NativeTypeName("bool")] byte val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, float default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, float val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, void* val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, int default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern bool* ImGuiStorage_GetBoolRef(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, [NativeTypeName("bool")] byte default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, float default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, [NativeTypeName("ImGuiID")] uint key, void* default_val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiListClipper* ImGuiListClipper_ImGuiListClipper();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_destroy(ImGuiListClipper* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_End(ImGuiListClipper* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_IncludeItemByIndex(ImGuiListClipper* self, int item_index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_IncludeItemsByIndex(ImGuiListClipper* self, int item_begin, int item_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipper_SeekCursorForItem(ImGuiListClipper* self, int item_index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImColor* ImColor_ImColor_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImColor_destroy(ImColor* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImColor* ImColor_ImColor_Float(float r, float g, float b, float a);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImColor* ImColor_ImColor_Vec4([NativeTypeName("const ImVec4")] ImVec4 col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImColor* ImColor_ImColor_Int(int r, int g, int b, int a);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImColor* ImColor_ImColor_U32([NativeTypeName("ImU32")] uint rgba);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiSelectionBasicStorage* ImGuiSelectionBasicStorage_ImGuiSelectionBasicStorage();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionBasicStorage_destroy(ImGuiSelectionBasicStorage* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionBasicStorage_ApplyRequests(ImGuiSelectionBasicStorage* self, ImGuiMultiSelectIO* ms_io);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiSelectionBasicStorage_Contains(ImGuiSelectionBasicStorage* self, [NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionBasicStorage_Clear(ImGuiSelectionBasicStorage* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionBasicStorage_Swap(ImGuiSelectionBasicStorage* self, ImGuiSelectionBasicStorage* r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionBasicStorage_SetItemSelected(ImGuiSelectionBasicStorage* self, [NativeTypeName("ImGuiID")] uint id, [NativeTypeName("bool")] byte selected);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiSelectionBasicStorage_GetNextSelectedItem(ImGuiSelectionBasicStorage* self, void** opaque_it, [NativeTypeName("ImGuiID *")] uint* out_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint ImGuiSelectionBasicStorage_GetStorageIdFromIndex(ImGuiSelectionBasicStorage* self, int idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiSelectionExternalStorage* ImGuiSelectionExternalStorage_ImGuiSelectionExternalStorage();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionExternalStorage_destroy(ImGuiSelectionExternalStorage* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSelectionExternalStorage_ApplyRequests(ImGuiSelectionExternalStorage* self, ImGuiMultiSelectIO* ms_io);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawCmd* ImDrawCmd_ImDrawCmd();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawCmd_destroy(ImDrawCmd* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImTextureID")]
        public static extern ulong ImDrawCmd_GetTexID(ImDrawCmd* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_destroy(ImDrawListSplitter* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawList* ImDrawList_ImDrawList(ImDrawListSharedData* shared_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_destroy(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PushClipRect(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 clip_rect_min, [NativeTypeName("const ImVec2")] ImVec2 clip_rect_max, [NativeTypeName("bool")] byte intersect_with_current_clip_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PopClipRect(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PushTextureID(ImDrawList* self, [NativeTypeName("ImTextureID")] ulong texture_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PopTextureID(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_GetClipRectMin(ImVec2* pOut, ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_GetClipRectMax(ImVec2* pOut, ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddLine(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("ImU32")] uint col, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddRect(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p_min, [NativeTypeName("const ImVec2")] ImVec2 p_max, [NativeTypeName("ImU32")] uint col, float rounding, [NativeTypeName("ImDrawFlags")] int flags, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddRectFilled(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p_min, [NativeTypeName("const ImVec2")] ImVec2 p_max, [NativeTypeName("ImU32")] uint col, float rounding, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p_min, [NativeTypeName("const ImVec2")] ImVec2 p_max, [NativeTypeName("ImU32")] uint col_upr_left, [NativeTypeName("ImU32")] uint col_upr_right, [NativeTypeName("ImU32")] uint col_bot_right, [NativeTypeName("ImU32")] uint col_bot_left);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddQuad(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("const ImVec2")] ImVec2 p4, [NativeTypeName("ImU32")] uint col, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("const ImVec2")] ImVec2 p4, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddTriangle(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("ImU32")] uint col, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddCircle(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, float radius, [NativeTypeName("ImU32")] uint col, int num_segments, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, float radius, [NativeTypeName("ImU32")] uint col, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddNgon(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, float radius, [NativeTypeName("ImU32")] uint col, int num_segments, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, float radius, [NativeTypeName("ImU32")] uint col, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddEllipse(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, [NativeTypeName("const ImVec2")] ImVec2 radius, [NativeTypeName("ImU32")] uint col, float rot, int num_segments, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddEllipseFilled(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, [NativeTypeName("const ImVec2")] ImVec2 radius, [NativeTypeName("ImU32")] uint col, float rot, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddText_Vec2(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("const char *")] sbyte* text_begin, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddText_FontPtr(ImDrawList* self, ImFont* font, float font_size, [NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("const char *")] sbyte* text_begin, [NativeTypeName("const char *")] sbyte* text_end, float wrap_width, [NativeTypeName("const ImVec4 *")] ImVec4* cpu_fine_clip_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddBezierCubic(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("const ImVec2")] ImVec2 p4, [NativeTypeName("ImU32")] uint col, float thickness, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddBezierQuadratic(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("ImU32")] uint col, float thickness, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddPolyline(ImDrawList* self, [NativeTypeName("const ImVec2 *")] ImVec2* points, int num_points, [NativeTypeName("ImU32")] uint col, [NativeTypeName("ImDrawFlags")] int flags, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, [NativeTypeName("const ImVec2 *")] ImVec2* points, int num_points, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddConcavePolyFilled(ImDrawList* self, [NativeTypeName("const ImVec2 *")] ImVec2* points, int num_points, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddImage(ImDrawList* self, [NativeTypeName("ImTextureID")] ulong user_texture_id, [NativeTypeName("const ImVec2")] ImVec2 p_min, [NativeTypeName("const ImVec2")] ImVec2 p_max, [NativeTypeName("const ImVec2")] ImVec2 uv_min, [NativeTypeName("const ImVec2")] ImVec2 uv_max, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddImageQuad(ImDrawList* self, [NativeTypeName("ImTextureID")] ulong user_texture_id, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("const ImVec2")] ImVec2 p4, [NativeTypeName("const ImVec2")] ImVec2 uv1, [NativeTypeName("const ImVec2")] ImVec2 uv2, [NativeTypeName("const ImVec2")] ImVec2 uv3, [NativeTypeName("const ImVec2")] ImVec2 uv4, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddImageRounded(ImDrawList* self, [NativeTypeName("ImTextureID")] ulong user_texture_id, [NativeTypeName("const ImVec2")] ImVec2 p_min, [NativeTypeName("const ImVec2")] ImVec2 p_max, [NativeTypeName("const ImVec2")] ImVec2 uv_min, [NativeTypeName("const ImVec2")] ImVec2 uv_max, [NativeTypeName("ImU32")] uint col, float rounding, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathClear(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathLineTo(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathFillConvex(ImDrawList* self, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathFillConcave(ImDrawList* self, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathStroke(ImDrawList* self, [NativeTypeName("ImU32")] uint col, [NativeTypeName("ImDrawFlags")] int flags, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathArcTo(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, float radius, float a_min, float a_max, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathArcToFast(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, float radius, int a_min_of_12, int a_max_of_12);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathEllipticalArcTo(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, [NativeTypeName("const ImVec2")] ImVec2 radius, float rot, float a_min, float a_max, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("const ImVec2")] ImVec2 p4, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PathRect(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 rect_min, [NativeTypeName("const ImVec2")] ImVec2 rect_max, float rounding, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddCallback(ImDrawList* self, [NativeTypeName("ImDrawCallback")] delegate* unmanaged[Cdecl]<ImDrawList*, ImDrawCmd*, void> callback, void* userdata, [NativeTypeName("size_t")] nuint userdata_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimRect(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimRectUV(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("const ImVec2")] ImVec2 uv_a, [NativeTypeName("const ImVec2")] ImVec2 uv_b, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("const ImVec2")] ImVec2 c, [NativeTypeName("const ImVec2")] ImVec2 d, [NativeTypeName("const ImVec2")] ImVec2 uv_a, [NativeTypeName("const ImVec2")] ImVec2 uv_b, [NativeTypeName("const ImVec2")] ImVec2 uv_c, [NativeTypeName("const ImVec2")] ImVec2 uv_d, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("const ImVec2")] ImVec2 uv, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, [NativeTypeName("ImDrawIdx")] ushort idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList_PrimVtx(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("const ImVec2")] ImVec2 uv, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__ResetForNewFrame(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__ClearFreeMemory(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__TryMergeDrawCmds(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__OnChangedClipRect(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__OnChangedTextureID(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__OnChangedVtxOffset(ImDrawList* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__SetTextureID(ImDrawList* self, [NativeTypeName("ImTextureID")] ulong texture_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__PathArcToFastEx(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, float radius, int a_min_sample, int a_max_sample, int a_step);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawList__PathArcToN(ImDrawList* self, [NativeTypeName("const ImVec2")] ImVec2 center, float radius, float a_min, float a_max, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawData* ImDrawData_ImDrawData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawData_destroy(ImDrawData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawData_Clear(ImDrawData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawData_AddDrawList(ImDrawData* self, ImDrawList* draw_list);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, [NativeTypeName("const ImVec2")] ImVec2 fb_scale);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFontConfig* ImFontConfig_ImFontConfig();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontConfig_destroy(ImFontConfig* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, [NativeTypeName("size_t")] nuint n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, [NativeTypeName("size_t")] nuint n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, [NativeTypeName("const ImWchar *")] ushort* ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector_ImWchar* out_ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFontAtlas* ImFontAtlas_ImFontAtlas();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_destroy(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, [NativeTypeName("const ImFontConfig *")] ImFontConfig* font_cfg);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, [NativeTypeName("const ImFontConfig *")] ImFontConfig* font_cfg);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, [NativeTypeName("const char *")] sbyte* filename, float size_pixels, [NativeTypeName("const ImFontConfig *")] ImFontConfig* font_cfg, [NativeTypeName("const ImWchar *")] ushort* glyph_ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_data_size, float size_pixels, [NativeTypeName("const ImFontConfig *")] ImFontConfig* font_cfg, [NativeTypeName("const ImWchar *")] ushort* glyph_ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, [NativeTypeName("const void *")] void* compressed_font_data, int compressed_font_data_size, float size_pixels, [NativeTypeName("const ImFontConfig *")] ImFontConfig* font_cfg, [NativeTypeName("const ImWchar *")] ushort* glyph_ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, [NativeTypeName("const char *")] sbyte* compressed_font_data_base85, float size_pixels, [NativeTypeName("const ImFontConfig *")] ImFontConfig* font_cfg, [NativeTypeName("const ImWchar *")] ushort* glyph_ranges);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_Clear(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFontAtlas_Build(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, [NativeTypeName("unsigned char **")] byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, [NativeTypeName("unsigned char **")] byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFontAtlas_IsBuilt(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_SetTexID(ImFontAtlas* self, [NativeTypeName("ImTextureID")] ulong id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesGreek(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImWchar *")]
        public static extern ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, [NativeTypeName("ImWchar")] ushort id, int width, int height, float advance_x, [NativeTypeName("const ImVec2")] ImVec2 offset);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, [NativeTypeName("const ImFontAtlasCustomRect *")] ImFontAtlasCustomRect* rect, ImVec2* out_uv_min, ImVec2* out_uv_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, [NativeTypeName("ImGuiMouseCursor")] int cursor, ImVec2* out_offset, ImVec2* out_size, [NativeTypeName("ImVec2[2]")] ImVec2* out_uv_border, [NativeTypeName("ImVec2[2]")] ImVec2* out_uv_fill);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFont* ImFont_ImFont();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_destroy(ImFont* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImFontGlyph *")]
        public static extern ImFontGlyph* ImFont_FindGlyph(ImFont* self, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImFontGlyph *")]
        public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float ImFont_GetCharAdvance(ImFont* self, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFont_IsLoaded(ImFont* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImFont_GetDebugName(ImFont* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_CalcTextSizeA(ImVec2* pOut, ImFont* self, float size, float max_width, float wrap_width, [NativeTypeName("const char *")] sbyte* text_begin, [NativeTypeName("const char *")] sbyte* text_end, [NativeTypeName("const char **")] sbyte** remaining);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, float wrap_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, [NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("ImWchar")] ushort c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, [NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("ImU32")] uint col, [NativeTypeName("const ImVec4")] ImVec4 clip_rect, [NativeTypeName("const char *")] sbyte* text_begin, [NativeTypeName("const char *")] sbyte* text_end, float wrap_width, [NativeTypeName("bool")] byte cpu_fine_clip);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_BuildLookupTable(ImFont* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_ClearOutputData(ImFont* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_GrowIndex(ImFont* self, int new_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_AddGlyph(ImFont* self, [NativeTypeName("const ImFontConfig *")] ImFontConfig* src_cfg, [NativeTypeName("ImWchar")] ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_AddRemapChar(ImFont* self, [NativeTypeName("ImWchar")] ushort dst, [NativeTypeName("ImWchar")] ushort src, [NativeTypeName("bool")] byte overwrite_dst);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImFont_SetGlyphVisible(ImFont* self, [NativeTypeName("ImWchar")] ushort c, [NativeTypeName("bool")] byte visible);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImFont_IsGlyphRangeUnused(ImFont* self, [NativeTypeName("unsigned int")] uint c_begin, [NativeTypeName("unsigned int")] uint c_last);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiViewport* ImGuiViewport_ImGuiViewport();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiViewport_destroy(ImGuiViewport* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiViewport_GetCenter(ImVec2* pOut, ImGuiViewport* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiViewport_GetWorkCenter(ImVec2* pOut, ImGuiViewport* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiPlatformIO* ImGuiPlatformIO_ImGuiPlatformIO();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPlatformIO_destroy(ImGuiPlatformIO* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiPlatformImeData* ImGuiPlatformImeData_ImGuiPlatformImeData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPlatformImeData_destroy(ImGuiPlatformImeData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igImHashData([NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint data_size, [NativeTypeName("ImGuiID")] uint seed);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igImHashStr([NativeTypeName("const char *")] sbyte* data, [NativeTypeName("size_t")] nuint data_size, [NativeTypeName("ImGuiID")] uint seed);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImQsort(void* @base, [NativeTypeName("size_t")] nuint count, [NativeTypeName("size_t")] nuint size_of_element, [NativeTypeName("int (*)(const void *, const void *)")] delegate* unmanaged[Cdecl]<void*, void*, int> compare_func);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU32")]
        public static extern uint igImAlphaBlendColors([NativeTypeName("ImU32")] uint col_a, [NativeTypeName("ImU32")] uint col_b);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImIsPowerOfTwo_Int(int v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImIsPowerOfTwo_U64([NativeTypeName("ImU64")] ulong v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImUpperPowerOfTwo(int v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImStricmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImStrnicmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2, [NativeTypeName("size_t")] nuint count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImStrncpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src, [NativeTypeName("size_t")] nuint count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* igImStrdup([NativeTypeName("const char *")] sbyte* str);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* igImStrdupcpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("size_t *")] nuint* p_dst_size, [NativeTypeName("const char *")] sbyte* str);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImStrchrRange([NativeTypeName("const char *")] sbyte* str_begin, [NativeTypeName("const char *")] sbyte* str_end, [NativeTypeName("char")] sbyte c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImStreolRange([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char *")] sbyte* str_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImStristr([NativeTypeName("const char *")] sbyte* haystack, [NativeTypeName("const char *")] sbyte* haystack_end, [NativeTypeName("const char *")] sbyte* needle, [NativeTypeName("const char *")] sbyte* needle_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImStrTrimBlanks([NativeTypeName("char *")] sbyte* str);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImStrSkipBlank([NativeTypeName("const char *")] sbyte* str);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImStrlenW([NativeTypeName("const ImWchar *")] ushort* str);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImStrbol([NativeTypeName("const char *")] sbyte* buf_mid_line, [NativeTypeName("const char *")] sbyte* buf_begin);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char")]
        public static extern sbyte igImToUpper([NativeTypeName("char")] sbyte c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImCharIsBlankA([NativeTypeName("char")] sbyte c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImCharIsBlankW([NativeTypeName("unsigned int")] uint c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImCharIsXdigitA([NativeTypeName("char")] sbyte c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImFormatString([NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImFormatStringV([NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFormatStringToTempBuffer([NativeTypeName("const char **")] sbyte** out_buf, [NativeTypeName("const char **")] sbyte** out_buf_end, [NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFormatStringToTempBufferV([NativeTypeName("const char **")] sbyte** out_buf, [NativeTypeName("const char **")] sbyte** out_buf_end, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImParseFormatFindStart([NativeTypeName("const char *")] sbyte* format);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImParseFormatFindEnd([NativeTypeName("const char *")] sbyte* format);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImParseFormatTrimDecorations([NativeTypeName("const char *")] sbyte* format, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImParseFormatSanitizeForPrinting([NativeTypeName("const char *")] sbyte* fmt_in, [NativeTypeName("char *")] sbyte* fmt_out, [NativeTypeName("size_t")] nuint fmt_out_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImParseFormatSanitizeForScanning([NativeTypeName("const char *")] sbyte* fmt_in, [NativeTypeName("char *")] sbyte* fmt_out, [NativeTypeName("size_t")] nuint fmt_out_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImParseFormatPrecision([NativeTypeName("const char *")] sbyte* format, int default_value);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImTextCharToUtf8([NativeTypeName("char[5]")] sbyte* out_buf, [NativeTypeName("unsigned int")] uint c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImTextStrToUtf8([NativeTypeName("char *")] sbyte* out_buf, int out_buf_size, [NativeTypeName("const ImWchar *")] ushort* in_text, [NativeTypeName("const ImWchar *")] ushort* in_text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImTextCharFromUtf8([NativeTypeName("unsigned int *")] uint* out_char, [NativeTypeName("const char *")] sbyte* in_text, [NativeTypeName("const char *")] sbyte* in_text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImTextStrFromUtf8([NativeTypeName("ImWchar *")] ushort* out_buf, int out_buf_size, [NativeTypeName("const char *")] sbyte* in_text, [NativeTypeName("const char *")] sbyte* in_text_end, [NativeTypeName("const char **")] sbyte** in_remaining);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImTextCountCharsFromUtf8([NativeTypeName("const char *")] sbyte* in_text, [NativeTypeName("const char *")] sbyte* in_text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImTextCountUtf8BytesFromChar([NativeTypeName("const char *")] sbyte* in_text, [NativeTypeName("const char *")] sbyte* in_text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImTextCountUtf8BytesFromStr([NativeTypeName("const ImWchar *")] ushort* in_text, [NativeTypeName("const ImWchar *")] ushort* in_text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igImTextFindPreviousUtf8Codepoint([NativeTypeName("const char *")] sbyte* in_text_start, [NativeTypeName("const char *")] sbyte* in_text_curr);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImTextCountLines([NativeTypeName("const char *")] sbyte* in_text, [NativeTypeName("const char *")] sbyte* in_text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImFileHandle")]
        public static extern void* igImFileOpen([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("const char *")] sbyte* mode);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImFileClose([NativeTypeName("ImFileHandle")] void* file);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU64")]
        public static extern ulong igImFileGetSize([NativeTypeName("ImFileHandle")] void* file);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU64")]
        public static extern ulong igImFileRead(void* data, [NativeTypeName("ImU64")] ulong size, [NativeTypeName("ImU64")] ulong count, [NativeTypeName("ImFileHandle")] void* file);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImU64")]
        public static extern ulong igImFileWrite([NativeTypeName("const void *")] void* data, [NativeTypeName("ImU64")] ulong size, [NativeTypeName("ImU64")] ulong count, [NativeTypeName("ImFileHandle")] void* file);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* igImFileLoadToMemory([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("const char *")] sbyte* mode, [NativeTypeName("size_t *")] nuint* out_file_size, int padding_bytes);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImPow_Float(float x, float y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double igImPow_double(double x, double y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImLog_Float(float x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double igImLog_double(double x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImAbs_Int(int x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImAbs_Float(float x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double igImAbs_double(double x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImSign_Float(float x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double igImSign_double(double x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImRsqrt_Float(float x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double igImRsqrt_double(double x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImMin(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 lhs, [NativeTypeName("const ImVec2")] ImVec2 rhs);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImMax(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 lhs, [NativeTypeName("const ImVec2")] ImVec2 rhs);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImClamp(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 v, [NativeTypeName("const ImVec2")] ImVec2 mn, [NativeTypeName("const ImVec2")] ImVec2 mx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImLerp_Vec2Float(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, float t);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImLerp_Vec2Vec2(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("const ImVec2")] ImVec2 t);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImLerp_Vec4(ImVec4* pOut, [NativeTypeName("const ImVec4")] ImVec4 a, [NativeTypeName("const ImVec4")] ImVec4 b, float t);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImSaturate(float f);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImLengthSqr_Vec2([NativeTypeName("const ImVec2")] ImVec2 lhs);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImLengthSqr_Vec4([NativeTypeName("const ImVec4")] ImVec4 lhs);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImInvLength([NativeTypeName("const ImVec2")] ImVec2 lhs, float fail_value);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImTrunc_Float(float f);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImTrunc_Vec2(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImFloor_Float(float f);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFloor_Vec2(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igImModPositive(int a, int b);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImDot([NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImRotate(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 v, float cos_a, float sin_a);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImLinearSweep(float current, float target, float speed);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImLinearRemapClamp(float s0, float s1, float d0, float d1, float x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImMul(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 lhs, [NativeTypeName("const ImVec2")] ImVec2 rhs);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImIsFloatAboveGuaranteedIntegerPrecision(float f);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImExponentialMovingAverage(float avg, float sample, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImBezierCubicCalc(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("const ImVec2")] ImVec2 p4, float t);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImBezierCubicClosestPoint(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("const ImVec2")] ImVec2 p4, [NativeTypeName("const ImVec2")] ImVec2 p, int num_segments);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImBezierCubicClosestPointCasteljau(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, [NativeTypeName("const ImVec2")] ImVec2 p4, [NativeTypeName("const ImVec2")] ImVec2 p, float tess_tol);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImBezierQuadraticCalc(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 p1, [NativeTypeName("const ImVec2")] ImVec2 p2, [NativeTypeName("const ImVec2")] ImVec2 p3, float t);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImLineClosestPoint(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("const ImVec2")] ImVec2 p);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImTriangleContainsPoint([NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("const ImVec2")] ImVec2 c, [NativeTypeName("const ImVec2")] ImVec2 p);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImTriangleClosestPoint(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("const ImVec2")] ImVec2 c, [NativeTypeName("const ImVec2")] ImVec2 p);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImTriangleBarycentricCoords([NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("const ImVec2")] ImVec2 c, [NativeTypeName("const ImVec2")] ImVec2 p, float* out_u, float* out_v, float* out_w);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igImTriangleArea([NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("const ImVec2")] ImVec2 c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImTriangleIsClockwise([NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("const ImVec2")] ImVec2 c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImVec1* ImVec1_ImVec1_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImVec1_destroy(ImVec1* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImVec1* ImVec1_ImVec1_Float(float _x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ih_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImVec2ih_destroy(ImVec2ih* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ih_short(short _x, short _y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ih_Vec2([NativeTypeName("const ImVec2")] ImVec2 rhs);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImRect* ImRect_ImRect_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_destroy(ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImRect* ImRect_ImRect_Vec2([NativeTypeName("const ImVec2")] ImVec2 min, [NativeTypeName("const ImVec2")] ImVec2 max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImRect* ImRect_ImRect_Vec4([NativeTypeName("const ImVec4")] ImVec4 v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImRect* ImRect_ImRect_Float(float x1, float y1, float x2, float y2);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_GetCenter(ImVec2* pOut, ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_GetSize(ImVec2* pOut, ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float ImRect_GetWidth(ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float ImRect_GetHeight(ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float ImRect_GetArea(ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_GetTL(ImVec2* pOut, ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_GetTR(ImVec2* pOut, ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_GetBL(ImVec2* pOut, ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_GetBR(ImVec2* pOut, ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImRect_Contains_Vec2(ImRect* self, [NativeTypeName("const ImVec2")] ImVec2 p);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImRect_Contains_Rect(ImRect* self, [NativeTypeName("const ImRect")] ImRect r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImRect_ContainsWithPad(ImRect* self, [NativeTypeName("const ImVec2")] ImVec2 p, [NativeTypeName("const ImVec2")] ImVec2 pad);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImRect_Overlaps(ImRect* self, [NativeTypeName("const ImRect")] ImRect r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_Add_Vec2(ImRect* self, [NativeTypeName("const ImVec2")] ImVec2 p);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_Add_Rect(ImRect* self, [NativeTypeName("const ImRect")] ImRect r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_Expand_Float(ImRect* self, [NativeTypeName("const float")] float amount);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_Expand_Vec2(ImRect* self, [NativeTypeName("const ImVec2")] ImVec2 amount);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_Translate(ImRect* self, [NativeTypeName("const ImVec2")] ImVec2 d);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_TranslateX(ImRect* self, float dx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_TranslateY(ImRect* self, float dy);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_ClipWith(ImRect* self, [NativeTypeName("const ImRect")] ImRect r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_ClipWithFull(ImRect* self, [NativeTypeName("const ImRect")] ImRect r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_Floor(ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImRect_IsInverted(ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImRect_ToVec4(ImVec4* pOut, ImRect* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint igImBitArrayGetStorageSizeInBytes(int bitcount);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImBitArrayClearAllBits([NativeTypeName("ImU32 *")] uint* arr, int bitcount);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImBitArrayTestBit([NativeTypeName("const ImU32 *")] uint* arr, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImBitArrayClearBit([NativeTypeName("ImU32 *")] uint* arr, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImBitArraySetBit([NativeTypeName("ImU32 *")] uint* arr, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImBitArraySetBitRange([NativeTypeName("ImU32 *")] uint* arr, int n, int n2);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImBitVector_Create(ImBitVector* self, int sz);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImBitVector_Clear(ImBitVector* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImBitVector_TestBit(ImBitVector* self, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImBitVector_SetBit(ImBitVector* self, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImBitVector_ClearBit(ImBitVector* self, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextIndex_clear(ImGuiTextIndex* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImGuiTextIndex_size(ImGuiTextIndex* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImGuiTextIndex_get_line_begin(ImGuiTextIndex* self, [NativeTypeName("const char *")] sbyte* @base, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* ImGuiTextIndex_get_line_end(ImGuiTextIndex* self, [NativeTypeName("const char *")] sbyte* @base, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextIndex_append(ImGuiTextIndex* self, [NativeTypeName("const char *")] sbyte* @base, int old_size, int new_size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStoragePair* igImLowerBound(ImGuiStoragePair* in_begin, ImGuiStoragePair* in_end, [NativeTypeName("ImGuiID")] uint key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawListSharedData* ImDrawListSharedData_ImDrawListSharedData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSharedData_destroy(ImDrawListSharedData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawListSharedData_SetCircleTessellationMaxError(ImDrawListSharedData* self, float max_error);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawDataBuilder* ImDrawDataBuilder_ImDrawDataBuilder();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImDrawDataBuilder_destroy(ImDrawDataBuilder* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* ImGuiDataVarInfo_GetVarPtr(ImGuiDataVarInfo* self, void* parent);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod_Int([NativeTypeName("ImGuiStyleVar")] int idx, int v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStyleMod_destroy(ImGuiStyleMod* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod_Float([NativeTypeName("ImGuiStyleVar")] int idx, float v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod_Vec2([NativeTypeName("ImGuiStyleVar")] int idx, ImVec2 v);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiComboPreviewData* ImGuiComboPreviewData_ImGuiComboPreviewData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiComboPreviewData_destroy(ImGuiComboPreviewData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiMenuColumns* ImGuiMenuColumns_ImGuiMenuColumns();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiMenuColumns_destroy(ImGuiMenuColumns* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiMenuColumns_Update(ImGuiMenuColumns* self, float spacing, [NativeTypeName("bool")] byte window_reappearing);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* self, float w_icon, float w_label, float w_shortcut, float w_mark);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiMenuColumns_CalcNextTotalWidth(ImGuiMenuColumns* self, [NativeTypeName("bool")] byte update_offsets);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiInputTextDeactivatedState* ImGuiInputTextDeactivatedState_ImGuiInputTextDeactivatedState();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextDeactivatedState_destroy(ImGuiInputTextDeactivatedState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextDeactivatedState_ClearFreeMemory(ImGuiInputTextDeactivatedState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiInputTextState* ImGuiInputTextState_ImGuiInputTextState();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_destroy(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_ClearText(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* self, int key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_OnCharPressed(ImGuiInputTextState* self, [NativeTypeName("unsigned int")] uint c);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ImGuiInputTextState_HasSelection(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImGuiInputTextState_GetCursorPos(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImGuiInputTextState_GetSelectionStart(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ImGuiInputTextState_GetSelectionEnd(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_SelectAll(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_ReloadUserBufAndSelectAll(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_ReloadUserBufAndKeepSelection(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputTextState_ReloadUserBufAndMoveToEnd(ImGuiInputTextState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiNextWindowData* ImGuiNextWindowData_ImGuiNextWindowData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiNextWindowData_destroy(ImGuiNextWindowData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiNextWindowData_ClearFlags(ImGuiNextWindowData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiNextItemData* ImGuiNextItemData_ImGuiNextItemData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiNextItemData_destroy(ImGuiNextItemData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiNextItemData_ClearFlags(ImGuiNextItemData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiLastItemData* ImGuiLastItemData_ImGuiLastItemData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiLastItemData_destroy(ImGuiLastItemData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiErrorRecoveryState* ImGuiErrorRecoveryState_ImGuiErrorRecoveryState();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiErrorRecoveryState_destroy(ImGuiErrorRecoveryState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndex_Ptr(void* ptr);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPtrOrIndex_destroy(ImGuiPtrOrIndex* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndex_Int(int index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiPopupData* ImGuiPopupData_ImGuiPopupData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiPopupData_destroy(ImGuiPopupData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiInputEvent* ImGuiInputEvent_ImGuiInputEvent();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiInputEvent_destroy(ImGuiInputEvent* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiKeyRoutingData* ImGuiKeyRoutingData_ImGuiKeyRoutingData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiKeyRoutingData_destroy(ImGuiKeyRoutingData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiKeyRoutingTable* ImGuiKeyRoutingTable_ImGuiKeyRoutingTable();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiKeyRoutingTable_destroy(ImGuiKeyRoutingTable* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiKeyRoutingTable_Clear(ImGuiKeyRoutingTable* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiKeyOwnerData* ImGuiKeyOwnerData_ImGuiKeyOwnerData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiKeyOwnerData_destroy(ImGuiKeyOwnerData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiListClipperRange ImGuiListClipperRange_FromIndices(int min, int max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiListClipperRange ImGuiListClipperRange_FromPositions(float y1, float y2, int off_min, int off_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiListClipperData* ImGuiListClipperData_ImGuiListClipperData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipperData_destroy(ImGuiListClipperData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiListClipperData_Reset(ImGuiListClipperData* self, ImGuiListClipper* clipper);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiNavItemData* ImGuiNavItemData_ImGuiNavItemData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiNavItemData_destroy(ImGuiNavItemData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiNavItemData_Clear(ImGuiNavItemData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTypingSelectState* ImGuiTypingSelectState_ImGuiTypingSelectState();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTypingSelectState_destroy(ImGuiTypingSelectState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTypingSelectState_Clear(ImGuiTypingSelectState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiOldColumnData* ImGuiOldColumnData_ImGuiOldColumnData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiOldColumnData_destroy(ImGuiOldColumnData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiOldColumns* ImGuiOldColumns_ImGuiOldColumns();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiOldColumns_destroy(ImGuiOldColumns* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiBoxSelectState* ImGuiBoxSelectState_ImGuiBoxSelectState();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiBoxSelectState_destroy(ImGuiBoxSelectState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiMultiSelectTempData* ImGuiMultiSelectTempData_ImGuiMultiSelectTempData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiMultiSelectTempData_destroy(ImGuiMultiSelectTempData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiMultiSelectTempData_Clear(ImGuiMultiSelectTempData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiMultiSelectTempData_ClearIO(ImGuiMultiSelectTempData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiMultiSelectState* ImGuiMultiSelectState_ImGuiMultiSelectState();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiMultiSelectState_destroy(ImGuiMultiSelectState* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiViewportP* ImGuiViewportP_ImGuiViewportP();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiViewportP_destroy(ImGuiViewportP* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiViewportP_CalcWorkRectPos(ImVec2* pOut, ImGuiViewportP* self, [NativeTypeName("const ImVec2")] ImVec2 inset_min);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiViewportP_CalcWorkRectSize(ImVec2* pOut, ImGuiViewportP* self, [NativeTypeName("const ImVec2")] ImVec2 inset_min, [NativeTypeName("const ImVec2")] ImVec2 inset_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiViewportP_UpdateWorkRect(ImGuiViewportP* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiViewportP_GetMainRect(ImRect* pOut, ImGuiViewportP* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiViewportP_GetWorkRect(ImRect* pOut, ImGuiViewportP* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiViewportP_GetBuildWorkRect(ImRect* pOut, ImGuiViewportP* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindowSettings* ImGuiWindowSettings_ImGuiWindowSettings();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiWindowSettings_destroy(ImGuiWindowSettings* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* ImGuiWindowSettings_GetName(ImGuiWindowSettings* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiSettingsHandler* ImGuiSettingsHandler_ImGuiSettingsHandler();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiSettingsHandler_destroy(ImGuiSettingsHandler* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiDebugAllocInfo* ImGuiDebugAllocInfo_ImGuiDebugAllocInfo();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiDebugAllocInfo_destroy(ImGuiDebugAllocInfo* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiStackLevelInfo* ImGuiStackLevelInfo_ImGuiStackLevelInfo();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiStackLevelInfo_destroy(ImGuiStackLevelInfo* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiIDStackTool* ImGuiIDStackTool_ImGuiIDStackTool();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiIDStackTool_destroy(ImGuiIDStackTool* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiContextHook* ImGuiContextHook_ImGuiContextHook();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiContextHook_destroy(ImGuiContextHook* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiContext* ImGuiContext_ImGuiContext(ImFontAtlas* shared_font_atlas);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiContext_destroy(ImGuiContext* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindow* ImGuiWindow_ImGuiWindow(ImGuiContext* context, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiWindow_destroy(ImGuiWindow* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint ImGuiWindow_GetID_Str(ImGuiWindow* self, [NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char *")] sbyte* str_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint ImGuiWindow_GetID_Ptr(ImGuiWindow* self, [NativeTypeName("const void *")] void* ptr);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint ImGuiWindow_GetID_Int(ImGuiWindow* self, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint ImGuiWindow_GetIDFromPos(ImGuiWindow* self, [NativeTypeName("const ImVec2")] ImVec2 p_abs);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint ImGuiWindow_GetIDFromRectangle(ImGuiWindow* self, [NativeTypeName("const ImRect")] ImRect r_abs);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiWindow_Rect(ImRect* pOut, ImGuiWindow* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float ImGuiWindow_CalcFontSize(ImGuiWindow* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiWindow_TitleBarRect(ImRect* pOut, ImGuiWindow* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiWindow_MenuBarRect(ImRect* pOut, ImGuiWindow* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTabItem* ImGuiTabItem_ImGuiTabItem();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTabItem_destroy(ImGuiTabItem* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTabBar* ImGuiTabBar_ImGuiTabBar();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTabBar_destroy(ImGuiTabBar* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableColumn* ImGuiTableColumn_ImGuiTableColumn();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTableColumn_destroy(ImGuiTableColumn* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableInstanceData* ImGuiTableInstanceData_ImGuiTableInstanceData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTableInstanceData_destroy(ImGuiTableInstanceData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTable* ImGuiTable_ImGuiTable();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTable_destroy(ImGuiTable* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableTempData* ImGuiTableTempData_ImGuiTableTempData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTableTempData_destroy(ImGuiTableTempData* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableColumnSettings* ImGuiTableColumnSettings_ImGuiTableColumnSettings();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTableColumnSettings_destroy(ImGuiTableColumnSettings* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableSettings* ImGuiTableSettings_ImGuiTableSettings();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTableSettings_destroy(ImGuiTableSettings* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableColumnSettings* ImGuiTableSettings_GetColumnSettings(ImGuiTableSettings* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiIO* igGetIOEx(ImGuiContext* ctx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindow* igGetCurrentWindowRead();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindow* igGetCurrentWindow();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindow* igFindWindowByID([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindow* igFindWindowByName([NativeTypeName("const char *")] sbyte* name);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igUpdateWindowParentAndRootLinks(ImGuiWindow* window, [NativeTypeName("ImGuiWindowFlags")] int flags, ImGuiWindow* parent_window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igUpdateWindowSkipRefresh(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igCalcWindowNextAutoFitSize(ImVec2* pOut, ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, [NativeTypeName("bool")] byte popup_hierarchy);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsWindowNavFocusable(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowPos_WindowPtr(ImGuiWindow* window, [NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowSize_WindowPtr(ImGuiWindow* window, [NativeTypeName("const ImVec2")] ImVec2 size, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowCollapsed_WindowPtr(ImGuiWindow* window, [NativeTypeName("bool")] byte collapsed, [NativeTypeName("ImGuiCond")] int cond);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowHitTestHole(ImGuiWindow* window, [NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("const ImVec2")] ImVec2 size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowParentWindowForFocusRoute(ImGuiWindow* window, ImGuiWindow* parent_window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igWindowRectAbsToRel(ImRect* pOut, ImGuiWindow* window, [NativeTypeName("const ImRect")] ImRect r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igWindowRectRelToAbs(ImRect* pOut, ImGuiWindow* window, [NativeTypeName("const ImRect")] ImRect r);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igWindowPosAbsToRel(ImVec2* pOut, ImGuiWindow* window, [NativeTypeName("const ImVec2")] ImVec2 p);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igWindowPosRelToAbs(ImVec2* pOut, ImGuiWindow* window, [NativeTypeName("const ImVec2")] ImVec2 p);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igFocusWindow(ImGuiWindow* window, [NativeTypeName("ImGuiFocusRequestFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igFocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window, ImGuiViewport* filter_viewport, [NativeTypeName("ImGuiFocusRequestFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBringWindowToFocusFront(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBringWindowToDisplayFront(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBringWindowToDisplayBack(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* above_window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igFindWindowDisplayIndex(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindow* igFindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextWindowRefreshPolicy([NativeTypeName("ImGuiWindowRefreshFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetCurrentFont(ImFont* font);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImFont* igGetDefaultFont();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawList* igGetForegroundDrawList_WindowPtr(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawList* igGetBackgroundDrawList_ViewportPtr(ImGuiViewport* viewport);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImDrawList* igGetForegroundDrawList_ViewportPtr(ImGuiViewport* viewport);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igAddDrawListToDrawDataEx(ImDrawData* draw_data, ImVector_ImDrawListPtr* out_list, ImDrawList* draw_list);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igInitialize();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShutdown();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igUpdateInputEvents([NativeTypeName("bool")] byte trickle_fast_inputs);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igUpdateHoveredWindowAndCaptureFlags();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igFindHoveredWindowEx([NativeTypeName("const ImVec2")] ImVec2 pos, [NativeTypeName("bool")] byte find_first_and_in_any_viewport, ImGuiWindow** out_hovered_window, ImGuiWindow** out_hovered_window_under_moving_window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igStartMouseMovingWindow(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igUpdateMouseMovingWindowNewFrame();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igUpdateMouseMovingWindowEndFrame();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igAddContextHook(ImGuiContext* context, [NativeTypeName("const ImGuiContextHook *")] ImGuiContextHook* hook);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRemoveContextHook(ImGuiContext* context, [NativeTypeName("ImGuiID")] uint hook_to_remove);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igCallContextHooks(ImGuiContext* context, ImGuiContextHookType type);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igMarkIniSettingsDirty_Nil();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igMarkIniSettingsDirty_WindowPtr(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igClearIniSettings();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igAddSettingsHandler([NativeTypeName("const ImGuiSettingsHandler *")] ImGuiSettingsHandler* handler);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRemoveSettingsHandler([NativeTypeName("const char *")] sbyte* type_name);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiSettingsHandler* igFindSettingsHandler([NativeTypeName("const char *")] sbyte* type_name);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindowSettings* igCreateNewWindowSettings([NativeTypeName("const char *")] sbyte* name);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindowSettings* igFindWindowSettingsByID([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindowSettings* igFindWindowSettingsByWindow(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igClearWindowSettings([NativeTypeName("const char *")] sbyte* name);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLocalizeRegisterEntries([NativeTypeName("const ImGuiLocEntry *")] ImGuiLocEntry* entries, int count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igLocalizeGetMsg(ImGuiLocKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollX_WindowPtr(ImGuiWindow* window, float scroll_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollY_WindowPtr(ImGuiWindow* window, float scroll_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollFromPosX_WindowPtr(ImGuiWindow* window, float local_x, float center_x_ratio);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetScrollFromPosY_WindowPtr(ImGuiWindow* window, float local_y, float center_y_ratio);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igScrollToItem([NativeTypeName("ImGuiScrollFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igScrollToRect(ImGuiWindow* window, [NativeTypeName("const ImRect")] ImRect rect, [NativeTypeName("ImGuiScrollFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igScrollToRectEx(ImVec2* pOut, ImGuiWindow* window, [NativeTypeName("const ImRect")] ImRect rect, [NativeTypeName("ImGuiScrollFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igScrollToBringRectIntoView(ImGuiWindow* window, [NativeTypeName("const ImRect")] ImRect rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiItemStatusFlags")]
        public static extern int igGetItemStatusFlags();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiItemFlags")]
        public static extern int igGetItemFlags();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetActiveID();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetFocusID();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetActiveID([NativeTypeName("ImGuiID")] uint id, ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetFocusID([NativeTypeName("ImGuiID")] uint id, ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igClearActiveID();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetHoveredID();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetHoveredID([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igKeepAliveID([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igMarkItemEdited([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushOverrideID([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetIDWithSeed_Str([NativeTypeName("const char *")] sbyte* str_id_begin, [NativeTypeName("const char *")] sbyte* str_id_end, [NativeTypeName("ImGuiID")] uint seed);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetIDWithSeed_Int(int n, [NativeTypeName("ImGuiID")] uint seed);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igItemSize_Vec2([NativeTypeName("const ImVec2")] ImVec2 size, float text_baseline_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igItemSize_Rect([NativeTypeName("const ImRect")] ImRect bb, float text_baseline_y);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igItemAdd([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id, [NativeTypeName("const ImRect *")] ImRect* nav_bb, [NativeTypeName("ImGuiItemFlags")] int extra_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igItemHoverable([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiItemFlags")] int item_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsWindowContentHoverable(ImGuiWindow* window, [NativeTypeName("ImGuiHoveredFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsClippedEx([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetLastItemData([NativeTypeName("ImGuiID")] uint item_id, [NativeTypeName("ImGuiItemFlags")] int in_flags, [NativeTypeName("ImGuiItemStatusFlags")] int status_flags, [NativeTypeName("const ImRect")] ImRect item_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igCalcItemSize(ImVec2* pOut, ImVec2 size, float default_w, float default_h);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igCalcWrapWidthForPos([NativeTypeName("const ImVec2")] ImVec2 pos, float wrap_pos_x);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushMultiItemsWidths(int components, float width_full);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImGuiDataVarInfo *")]
        public static extern ImGuiDataVarInfo* igGetStyleVarInfo([NativeTypeName("ImGuiStyleVar")] int idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBeginDisabledOverrideReenable();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndDisabledOverrideReenable();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogBegin([NativeTypeName("ImGuiLogFlags")] int flags, int auto_open_depth);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogToBuffer(int auto_open_depth);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogRenderedText([NativeTypeName("const ImVec2 *")] ImVec2* ref_pos, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogSetNextTextDecoration([NativeTypeName("const char *")] sbyte* prefix, [NativeTypeName("const char *")] sbyte* suffix);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginChildEx([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("ImGuiID")] uint id, [NativeTypeName("const ImVec2")] ImVec2 size_arg, [NativeTypeName("ImGuiChildFlags")] int child_flags, [NativeTypeName("ImGuiWindowFlags")] int window_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginPopupEx([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiWindowFlags")] int extra_window_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igOpenPopupEx([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igClosePopupToLevel(int remaining, [NativeTypeName("bool")] byte restore_focus_to_window_under_popup);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igClosePopupsOverWindow(ImGuiWindow* ref_window, [NativeTypeName("bool")] byte restore_focus_to_window_under_popup);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igClosePopupsExceptModals();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsPopupOpen_ID([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiPopupFlags")] int popup_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetPopupAllowedExtentRect(ImRect* pOut, ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindow* igGetTopMostPopupModal();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindow* igGetTopMostAndVisiblePopupModal();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiWindow* igFindBlockingModal(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igFindBestWindowPosForPopup(ImVec2* pOut, ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igFindBestWindowPosForPopupEx(ImVec2* pOut, [NativeTypeName("const ImVec2")] ImVec2 ref_pos, [NativeTypeName("const ImVec2")] ImVec2 size, ImGuiDir* last_dir, [NativeTypeName("const ImRect")] ImRect r_outer, [NativeTypeName("const ImRect")] ImRect r_avoid, ImGuiPopupPositionPolicy policy);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTooltipEx([NativeTypeName("ImGuiTooltipFlags")] int tooltip_flags, [NativeTypeName("ImGuiWindowFlags")] int extra_window_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTooltipHidden();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginViewportSideBar([NativeTypeName("const char *")] sbyte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, [NativeTypeName("ImGuiWindowFlags")] int window_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginMenuEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* icon, [NativeTypeName("bool")] byte enabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igMenuItemEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* icon, [NativeTypeName("const char *")] sbyte* shortcut, [NativeTypeName("bool")] byte selected, [NativeTypeName("bool")] byte enabled);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginComboPopup([NativeTypeName("ImGuiID")] uint popup_id, [NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiComboFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginComboPreview();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndComboPreview();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavInitWindow(ImGuiWindow* window, [NativeTypeName("bool")] byte force_reinit);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavInitRequestApplyResult();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igNavMoveRequestButNoResultYet();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, [NativeTypeName("ImGuiNavMoveFlags")] int move_flags, [NativeTypeName("ImGuiScrollFlags")] int scroll_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, [NativeTypeName("ImGuiNavMoveFlags")] int move_flags, [NativeTypeName("ImGuiScrollFlags")] int scroll_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavMoveRequestResolveWithLastItem(ImGuiNavItemData* result);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavMoveRequestResolveWithPastTreeNode(ImGuiNavItemData* result, ImGuiTreeNodeStackData* tree_node_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavMoveRequestCancel();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavMoveRequestApplyResult();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavMoveRequestTryWrapping(ImGuiWindow* window, [NativeTypeName("ImGuiNavMoveFlags")] int move_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavHighlightActivated([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavClearPreferredPosForAxis(ImGuiAxis axis);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNavCursorVisibleAfterMove();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igNavUpdateCurrentWindowIsScrollPushableX();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNavWindow(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNavID([NativeTypeName("ImGuiID")] uint id, ImGuiNavLayer nav_layer, [NativeTypeName("ImGuiID")] uint focus_scope_id, [NativeTypeName("const ImRect")] ImRect rect_rel);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNavFocusScope([NativeTypeName("ImGuiID")] uint focus_scope_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igFocusItem();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igActivateItemByID([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsNamedKey(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsNamedKeyOrMod(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsLegacyKey(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyboardKey(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsGamepadKey(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseKey(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsAliasKey(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsLRModKey(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiKeyChord")]
        public static extern int igFixupKeyChord([NativeTypeName("ImGuiKeyChord")] int key_chord);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiKey igConvertSingleModFlagToKey(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiKeyData* igGetKeyData_ContextPtr(ImGuiContext* ctx, ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiKeyData* igGetKeyData_Key(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igGetKeyChordName([NativeTypeName("ImGuiKeyChord")] int key_chord);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiKey igMouseButtonToKey([NativeTypeName("ImGuiMouseButton")] int button);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseDragPastThreshold([NativeTypeName("ImGuiMouseButton")] int button, float lock_threshold);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetKeyMagnitude2d(ImVec2* pOut, ImGuiKey key_left, ImGuiKey key_right, ImGuiKey key_up, ImGuiKey key_down);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetNavTweakPressedAmount(ImGuiAxis axis);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igCalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetTypematicRepeatRate([NativeTypeName("ImGuiInputFlags")] int flags, float* repeat_delay, float* repeat_rate);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTeleportMousePos([NativeTypeName("const ImVec2")] ImVec2 pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetActiveIdUsingAllKeyboardKeys();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsActiveIdUsingNavDir(ImGuiDir dir);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetKeyOwner(ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetKeyOwner(ImGuiKey key, [NativeTypeName("ImGuiID")] uint owner_id, [NativeTypeName("ImGuiInputFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetKeyOwnersForKeyChord([NativeTypeName("ImGuiKeyChord")] int key, [NativeTypeName("ImGuiID")] uint owner_id, [NativeTypeName("ImGuiInputFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetItemKeyOwner_InputFlags(ImGuiKey key, [NativeTypeName("ImGuiInputFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTestKeyOwner(ImGuiKey key, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiKeyOwnerData* igGetKeyOwnerData(ImGuiContext* ctx, ImGuiKey key);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyDown_ID(ImGuiKey key, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyPressed_InputFlags(ImGuiKey key, [NativeTypeName("ImGuiInputFlags")] int flags, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyReleased_ID(ImGuiKey key, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsKeyChordPressed_InputFlags([NativeTypeName("ImGuiKeyChord")] int key_chord, [NativeTypeName("ImGuiInputFlags")] int flags, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseDown_ID([NativeTypeName("ImGuiMouseButton")] int button, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseClicked_InputFlags([NativeTypeName("ImGuiMouseButton")] int button, [NativeTypeName("ImGuiInputFlags")] int flags, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseReleased_ID([NativeTypeName("ImGuiMouseButton")] int button, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsMouseDoubleClicked_ID([NativeTypeName("ImGuiMouseButton")] int button, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igShortcut_ID([NativeTypeName("ImGuiKeyChord")] int key_chord, [NativeTypeName("ImGuiInputFlags")] int flags, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSetShortcutRouting([NativeTypeName("ImGuiKeyChord")] int key_chord, [NativeTypeName("ImGuiInputFlags")] int flags, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTestShortcutRouting([NativeTypeName("ImGuiKeyChord")] int key_chord, [NativeTypeName("ImGuiID")] uint owner_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiKeyRoutingData* igGetShortcutRoutingData([NativeTypeName("ImGuiKeyChord")] int key_chord);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushFocusScope([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopFocusScope();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetCurrentFocusScope();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsDragDropActive();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginDragDropTargetCustom([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igClearDragDrop();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igIsDragDropPayloadBeingAccepted();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderDragDropTargetRect([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("const ImRect")] ImRect item_clip_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTypingSelectRequest* igGetTypingSelectRequest([NativeTypeName("ImGuiTypingSelectFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTypingSelectFindMatch(ImGuiTypingSelectRequest* req, int items_count, [NativeTypeName("const char *(*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, sbyte*> get_item_name_func, void* user_data, int nav_item_idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequest* req, int items_count, [NativeTypeName("const char *(*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, sbyte*> get_item_name_func, void* user_data, int nav_item_idx);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequest* req, int items_count, [NativeTypeName("const char *(*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, sbyte*> get_item_name_func, void* user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginBoxSelect([NativeTypeName("const ImRect")] ImRect scope_rect, ImGuiWindow* window, [NativeTypeName("ImGuiID")] uint box_select_id, [NativeTypeName("ImGuiMultiSelectFlags")] int ms_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndBoxSelect([NativeTypeName("const ImRect")] ImRect scope_rect, [NativeTypeName("ImGuiMultiSelectFlags")] int ms_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igMultiSelectItemHeader([NativeTypeName("ImGuiID")] uint id, bool* p_selected, [NativeTypeName("ImGuiButtonFlags *")] int* p_button_flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igMultiSelectItemFooter([NativeTypeName("ImGuiID")] uint id, bool* p_selected, bool* p_pressed);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igMultiSelectAddSetAll(ImGuiMultiSelectTempData* ms, [NativeTypeName("bool")] byte selected);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igMultiSelectAddSetRange(ImGuiMultiSelectTempData* ms, [NativeTypeName("bool")] byte selected, int range_dir, [NativeTypeName("ImGuiSelectionUserData")] long first_item, [NativeTypeName("ImGuiSelectionUserData")] long last_item);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiBoxSelectState* igGetBoxSelectState([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiMultiSelectState* igGetMultiSelectState([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetWindowClipRectBeforeSetChannel(ImGuiWindow* window, [NativeTypeName("const ImRect")] ImRect clip_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igBeginColumns([NativeTypeName("const char *")] sbyte* str_id, int count, [NativeTypeName("ImGuiOldColumnFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndColumns();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushColumnClipRect(int column_index);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPushColumnsBackground();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igPopColumnsBackground();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetColumnsID([NativeTypeName("const char *")] sbyte* str_id, int count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiOldColumns* igFindOrCreateColumns(ImGuiWindow* window, [NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetColumnOffsetFromNorm([NativeTypeName("const ImGuiOldColumns *")] ImGuiOldColumns* columns, float offset_norm);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGetColumnNormFromOffset([NativeTypeName("const ImGuiOldColumns *")] ImGuiOldColumns* columns, float offset);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableOpenContextMenu(int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetColumnWidth(int column_n, float width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, [NativeTypeName("bool")] byte append_to_sort_specs);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTableGetHoveredRow();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igTableGetHeaderRowHeight();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igTableGetHeaderAngledMaxLabelWidth();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTablePushBackgroundChannel();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTablePopBackgroundChannel();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableAngledHeadersRowEx([NativeTypeName("ImGuiID")] uint row_id, float angle, float max_label_width, [NativeTypeName("const ImGuiTableHeaderData *")] ImGuiTableHeaderData* data, int data_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTable* igGetCurrentTable();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTable* igTableFindByID([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTableEx([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("ImGuiID")] uint id, int columns_count, [NativeTypeName("ImGuiTableFlags")] int flags, [NativeTypeName("const ImVec2")] ImVec2 outer_size, float inner_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableBeginInitMemory(ImGuiTable* table, int columns_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableBeginApplyRequests(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetupDrawChannels(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableUpdateLayout(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableUpdateBorders(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableUpdateColumnsWeightFromWidth(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableDrawBorders(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableDrawDefaultContextMenu(ImGuiTable* table, [NativeTypeName("ImGuiTableFlags")] int flags_for_section_to_display);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTableBeginContextMenuPopup(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableMergeDrawChannels(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableInstanceData* igTableGetInstanceData(ImGuiTable* table, int instance_no);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igTableGetInstanceID(ImGuiTable* table, int instance_no);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSortSpecsSanitize(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSortSpecsBuild(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiSortDirection igTableGetColumnNextSortDirection(ImGuiTableColumn* column);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igTableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableBeginRow(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableEndRow(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableBeginCell(ImGuiTable* table, int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableEndCell(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableGetCellBgRect(ImRect* pOut, [NativeTypeName("const ImGuiTable *")] ImGuiTable* table, int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igTableGetColumnName_TablePtr([NativeTypeName("const ImGuiTable *")] ImGuiTable* table, int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igTableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igTableCalcMaxColumnWidth([NativeTypeName("const ImGuiTable *")] ImGuiTable* table, int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSetColumnWidthAutoAll(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableRemove(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableGcCompactTransientBuffers_TablePtr(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableGcCompactTransientBuffers_TableTempDataPtr(ImGuiTableTempData* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableGcCompactSettings();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableLoadSettings(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSaveSettings(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableResetSettings(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableSettings* igTableGetBoundSettings(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTableSettingsAddSettingsHandler();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableSettings* igTableSettingsCreate([NativeTypeName("ImGuiID")] uint id, int columns_count);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTableSettings* igTableSettingsFindByID([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTabBar* igGetCurrentTabBar();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginTabBarEx(ImGuiTabBar* tab_bar, [NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiTabBarFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTabItem* igTabBarFindTabByID(ImGuiTabBar* tab_bar, [NativeTypeName("ImGuiID")] uint tab_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTabItem* igTabBarFindTabByOrder(ImGuiTabBar* tab_bar, int order);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiTabItem* igTabBarGetCurrentTab(ImGuiTabBar* tab_bar);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igTabBarGetTabOrder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igTabBarGetTabName(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTabBarRemoveTab(ImGuiTabBar* tab_bar, [NativeTypeName("ImGuiID")] uint tab_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTabBarQueueFocus_TabItemPtr(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTabBarQueueFocus_Str(ImGuiTabBar* tab_bar, [NativeTypeName("const char *")] sbyte* tab_name);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, ImVec2 mouse_pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTabBarProcessReorder(ImGuiTabBar* tab_bar);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTabItemEx(ImGuiTabBar* tab_bar, [NativeTypeName("const char *")] sbyte* label, bool* p_open, [NativeTypeName("ImGuiTabItemFlags")] int flags, ImGuiWindow* docked_window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTabItemCalcSize_Str(ImVec2* pOut, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("bool")] byte has_close_button_or_unsaved_marker);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTabItemCalcSize_WindowPtr(ImVec2* pOut, ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTabItemBackground(ImDrawList* draw_list, [NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiTabItemFlags")] int flags, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTabItemLabelAndCloseButton(ImDrawList* draw_list, [NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiTabItemFlags")] int flags, ImVec2 frame_padding, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiID")] uint tab_id, [NativeTypeName("ImGuiID")] uint close_button_id, [NativeTypeName("bool")] byte is_contents_visible, bool* out_just_closed, bool* out_text_clipped);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderText(ImVec2 pos, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, [NativeTypeName("bool")] byte hide_text_after_hash);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderTextWrapped(ImVec2 pos, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, float wrap_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderTextClipped([NativeTypeName("const ImVec2")] ImVec2 pos_min, [NativeTypeName("const ImVec2")] ImVec2 pos_max, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, [NativeTypeName("const ImVec2 *")] ImVec2* text_size_if_known, [NativeTypeName("const ImVec2")] ImVec2 align, [NativeTypeName("const ImRect *")] ImRect* clip_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderTextClippedEx(ImDrawList* draw_list, [NativeTypeName("const ImVec2")] ImVec2 pos_min, [NativeTypeName("const ImVec2")] ImVec2 pos_max, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, [NativeTypeName("const ImVec2 *")] ImVec2* text_size_if_known, [NativeTypeName("const ImVec2")] ImVec2 align, [NativeTypeName("const ImRect *")] ImRect* clip_rect);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderTextEllipsis(ImDrawList* draw_list, [NativeTypeName("const ImVec2")] ImVec2 pos_min, [NativeTypeName("const ImVec2")] ImVec2 pos_max, float clip_max_x, float ellipsis_max_x, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, [NativeTypeName("const ImVec2 *")] ImVec2* text_size_if_known);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderFrame(ImVec2 p_min, ImVec2 p_max, [NativeTypeName("ImU32")] uint fill_col, [NativeTypeName("bool")] byte borders, float rounding);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderFrameBorder(ImVec2 p_min, ImVec2 p_max, float rounding);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, ImVec2 p_min, ImVec2 p_max, [NativeTypeName("ImU32")] uint fill_col, float grid_step, ImVec2 grid_off, float rounding, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderNavCursor([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiNavRenderCursorFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* igFindRenderedTextEnd([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderMouseCursor(ImVec2 pos, float scale, [NativeTypeName("ImGuiMouseCursor")] int mouse_cursor, [NativeTypeName("ImU32")] uint col_fill, [NativeTypeName("ImU32")] uint col_border, [NativeTypeName("ImU32")] uint col_shadow);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderArrow(ImDrawList* draw_list, ImVec2 pos, [NativeTypeName("ImU32")] uint col, ImGuiDir dir, float scale);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderBullet(ImDrawList* draw_list, ImVec2 pos, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderCheckMark(ImDrawList* draw_list, ImVec2 pos, [NativeTypeName("ImU32")] uint col, float sz);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderArrowPointingAt(ImDrawList* draw_list, ImVec2 pos, ImVec2 half_sz, ImGuiDir direction, [NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderRectFilledRangeH(ImDrawList* draw_list, [NativeTypeName("const ImRect")] ImRect rect, [NativeTypeName("ImU32")] uint col, float x_start_norm, float x_end_norm, float rounding);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igRenderRectFilledWithHole(ImDrawList* draw_list, [NativeTypeName("const ImRect")] ImRect outer, [NativeTypeName("const ImRect")] ImRect inner, [NativeTypeName("ImU32")] uint col, float rounding);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTextEx([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* text_end, [NativeTypeName("ImGuiTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igButtonEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const ImVec2")] ImVec2 size_arg, [NativeTypeName("ImGuiButtonFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igArrowButtonEx([NativeTypeName("const char *")] sbyte* str_id, ImGuiDir dir, ImVec2 size_arg, [NativeTypeName("ImGuiButtonFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igImageButtonEx([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImTextureID")] ulong texture_id, [NativeTypeName("const ImVec2")] ImVec2 image_size, [NativeTypeName("const ImVec2")] ImVec2 uv0, [NativeTypeName("const ImVec2")] ImVec2 uv1, [NativeTypeName("const ImVec4")] ImVec4 bg_col, [NativeTypeName("const ImVec4")] ImVec4 tint_col, [NativeTypeName("ImGuiButtonFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSeparatorEx([NativeTypeName("ImGuiSeparatorFlags")] int flags, float thickness);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSeparatorTextEx([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* label_end, float extra_width);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCheckboxFlags_S64Ptr([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImS64 *")] long* flags, [NativeTypeName("ImS64")] long flags_value);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCheckboxFlags_U64Ptr([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImU64 *")] ulong* flags, [NativeTypeName("ImU64")] ulong flags_value);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCloseButton([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("const ImVec2")] ImVec2 pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igCollapseButton([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("const ImVec2")] ImVec2 pos);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igScrollbar(ImGuiAxis axis);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igScrollbarEx([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id, ImGuiAxis axis, [NativeTypeName("ImS64 *")] long* p_scroll_v, [NativeTypeName("ImS64")] long avail_v, [NativeTypeName("ImS64")] long contents_v, [NativeTypeName("ImDrawFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetWindowResizeCornerID(ImGuiWindow* window, int n);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ImGuiID")]
        public static extern uint igGetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igButtonBehavior([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id, bool* out_hovered, bool* out_held, [NativeTypeName("ImGuiButtonFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDragBehavior([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiDataType")] int data_type, void* p_v, float v_speed, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSliderBehavior([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiDataType")] int data_type, void* p_v, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("ImGuiSliderFlags")] int flags, ImRect* out_grab_bb);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igSplitterBehavior([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, [NativeTypeName("ImU32")] uint bg_col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeBehavior([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiTreeNodeFlags")] int flags, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* label_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTreePushOverrideID([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeGetOpen([NativeTypeName("ImGuiID")] uint storage_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igTreeNodeSetOpen([NativeTypeName("ImGuiID")] uint storage_id, [NativeTypeName("bool")] byte open);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTreeNodeUpdateNextOpen([NativeTypeName("ImGuiID")] uint storage_id, [NativeTypeName("ImGuiTreeNodeFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImGuiDataTypeInfo *")]
        public static extern ImGuiDataTypeInfo* igDataTypeGetInfo([NativeTypeName("ImGuiDataType")] int data_type);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igDataTypeFormatString([NativeTypeName("char *")] sbyte* buf, int buf_size, [NativeTypeName("ImGuiDataType")] int data_type, [NativeTypeName("const void *")] void* p_data, [NativeTypeName("const char *")] sbyte* format);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDataTypeApplyOp([NativeTypeName("ImGuiDataType")] int data_type, int op, void* output, [NativeTypeName("const void *")] void* arg_1, [NativeTypeName("const void *")] void* arg_2);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDataTypeApplyFromText([NativeTypeName("const char *")] sbyte* buf, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const char *")] sbyte* format, void* p_data_when_empty);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igDataTypeCompare([NativeTypeName("ImGuiDataType")] int data_type, [NativeTypeName("const void *")] void* arg_1, [NativeTypeName("const void *")] void* arg_2);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDataTypeClamp([NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const void *")] void* p_min, [NativeTypeName("const void *")] void* p_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDataTypeIsZero([NativeTypeName("ImGuiDataType")] int data_type, [NativeTypeName("const void *")] void* p_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igInputTextEx([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* hint, [NativeTypeName("char *")] sbyte* buf, int buf_size, [NativeTypeName("const ImVec2")] ImVec2 size_arg, [NativeTypeName("ImGuiInputTextFlags")] int flags, [NativeTypeName("ImGuiInputTextCallback")] delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback, void* user_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igInputTextDeactivateHook([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTempInputText([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("char *")] sbyte* buf, int buf_size, [NativeTypeName("ImGuiInputTextFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTempInputScalar([NativeTypeName("const ImRect")] ImRect bb, [NativeTypeName("ImGuiID")] uint id, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("ImGuiDataType")] int data_type, void* p_data, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("const void *")] void* p_clamp_min, [NativeTypeName("const void *")] void* p_clamp_max);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igTempInputIsActive([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImGuiInputTextState* igGetInputTextState([NativeTypeName("ImGuiID")] uint id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igSetNextItemRefVal([NativeTypeName("ImGuiDataType")] int data_type, void* p_data);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igColorTooltip([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const float *")] float* col, [NativeTypeName("ImGuiColorEditFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igColorEditOptionsPopup([NativeTypeName("const float *")] float* col, [NativeTypeName("ImGuiColorEditFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igColorPickerOptionsPopup([NativeTypeName("const float *")] float* ref_col, [NativeTypeName("ImGuiColorEditFlags")] int flags);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int igPlotEx(ImGuiPlotType plot_type, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("float (*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, float> values_getter, void* data, int values_count, int values_offset, [NativeTypeName("const char *")] sbyte* overlay_text, float scale_min, float scale_max, [NativeTypeName("const ImVec2")] ImVec2 size_arg);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, ImVec2 gradient_p0, ImVec2 gradient_p1, [NativeTypeName("ImU32")] uint col0, [NativeTypeName("ImU32")] uint col1);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, [NativeTypeName("const ImVec2")] ImVec2 a, [NativeTypeName("const ImVec2")] ImVec2 b, [NativeTypeName("const ImVec2")] ImVec2 uv_a, [NativeTypeName("const ImVec2")] ImVec2 uv_b, [NativeTypeName("bool")] byte clamp);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShadeVertsTransformPos(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, [NativeTypeName("const ImVec2")] ImVec2 pivot_in, float cos_a, float sin_a, [NativeTypeName("const ImVec2")] ImVec2 pivot_out);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGcCompactTransientMiscBuffers();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGcCompactTransientWindowBuffers(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igGcAwakeTransientWindowBuffers(ImGuiWindow* window);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igErrorLog([NativeTypeName("const char *")] sbyte* msg);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igErrorRecoveryStoreState(ImGuiErrorRecoveryState* state_out);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igErrorRecoveryTryToRecoverState([NativeTypeName("const ImGuiErrorRecoveryState *")] ImGuiErrorRecoveryState* state_in);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igErrorRecoveryTryToRecoverWindowState([NativeTypeName("const ImGuiErrorRecoveryState *")] ImGuiErrorRecoveryState* state_in);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igErrorCheckUsingSetCursorPosToExtendParentBoundaries();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igErrorCheckEndFrameFinalizeErrorTooltip();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igBeginErrorTooltip();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igEndErrorTooltip();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugAllocHook(ImGuiDebugAllocInfo* info, int frame_count, void* ptr, [NativeTypeName("size_t")] nuint size);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugDrawCursorPos([NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugDrawLineExtents([NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugDrawItemRect([NativeTypeName("ImU32")] uint col);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugTextUnformattedWithLocateItem([NativeTypeName("const char *")] sbyte* line_begin, [NativeTypeName("const char *")] sbyte* line_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugLocateItem([NativeTypeName("ImGuiID")] uint target_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugLocateItemOnHover([NativeTypeName("ImGuiID")] uint target_id);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugLocateItemResolveWithLastItem();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugBreakClearData();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte igDebugBreakButton([NativeTypeName("const char *")] sbyte* label, [NativeTypeName("const char *")] sbyte* description_of_location);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugBreakButtonTooltip([NativeTypeName("bool")] byte keyboard_only, [NativeTypeName("const char *")] sbyte* description_of_location);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igShowFontAtlas(ImFontAtlas* atlas);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugHookIdInfo([NativeTypeName("ImGuiID")] uint id, [NativeTypeName("ImGuiDataType")] int data_type, [NativeTypeName("const void *")] void* data_id, [NativeTypeName("const void *")] void* data_id_end);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeColumns(ImGuiOldColumns* columns);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeDrawList(ImGuiWindow* window, ImGuiViewportP* viewport, [NativeTypeName("const ImDrawList *")] ImDrawList* draw_list, [NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* out_draw_list, [NativeTypeName("const ImDrawList *")] ImDrawList* draw_list, [NativeTypeName("const ImDrawCmd *")] ImDrawCmd* draw_cmd, [NativeTypeName("bool")] byte show_mesh, [NativeTypeName("bool")] byte show_aabb);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeFont(ImFont* font);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeFontGlyph(ImFont* font, [NativeTypeName("const ImFontGlyph *")] ImFontGlyph* glyph);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeStorage(ImGuiStorage* storage, [NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeTabBar(ImGuiTabBar* tab_bar, [NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeTable(ImGuiTable* table);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeTableSettings(ImGuiTableSettings* settings);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeInputTextState(ImGuiInputTextState* state);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeTypingSelectState(ImGuiTypingSelectState* state);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeMultiSelectState(ImGuiMultiSelectState* state);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeWindow(ImGuiWindow* window, [NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeWindowSettings(ImGuiWindowSettings* settings);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeWindowsList(ImVector_ImGuiWindowPtr* windows, [NativeTypeName("const char *")] sbyte* label);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windows_size, ImGuiWindow* parent_in_begin_stack);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugNodeViewport(ImGuiViewportP* viewport);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugRenderKeyboardPreview(ImDrawList* draw_list);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igDebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, [NativeTypeName("const ImRect")] ImRect bb);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const ImFontBuilderIO *")]
        public static extern ImFontBuilderIO* igImFontAtlasGetBuilderForStbTruetype();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFontAtlasUpdateConfigDataPointers(ImFontAtlas* atlas);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFontAtlasBuildInit(ImFontAtlas* atlas);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFontAtlasBuildFinish(ImFontAtlas* atlas);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, [NativeTypeName("const char *")] sbyte* in_str, [NativeTypeName("char")] sbyte in_marker_char, [NativeTypeName("unsigned char")] byte in_marker_pixel_value);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, [NativeTypeName("const char *")] sbyte* in_str, [NativeTypeName("char")] sbyte in_marker_char, [NativeTypeName("unsigned int")] uint in_marker_pixel_value);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFontAtlasBuildMultiplyCalcLookupTable([NativeTypeName("unsigned char[256]")] byte* out_table, float in_multiply_factor);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igImFontAtlasBuildMultiplyRectAlpha8([NativeTypeName("const unsigned char[256]")] byte* table, [NativeTypeName("unsigned char *")] byte* pixels, int x, int y, int w, int h, int stride);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void igLogText([NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGuiTextBuffer_appendf([NativeTypeName("struct ImGuiTextBuffer *")] ImGuiTextBuffer* buffer, [NativeTypeName("const char *")] sbyte* fmt, params string[] args);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGET_FLT_MAX();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float igGET_FLT_MIN();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ImVector_ImWchar* ImVector_ImWchar_create();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImVector_ImWchar_destroy(ImVector_ImWchar* self);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImVector_ImWchar_Init(ImVector_ImWchar* p);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImVector_ImWchar_UnInit(ImVector_ImWchar* p);

        public const int SIMGUI_INVALID_ID = 0;

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_setup", ExactSpelling = true)]
        public static extern void setup([NativeTypeName("const simgui_desc_t *")] simgui_desc_t* desc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_new_frame", ExactSpelling = true)]
        public static extern void new_frame([NativeTypeName("const simgui_frame_desc_t *")] simgui_frame_desc_t* desc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_render", ExactSpelling = true)]
        public static extern void render();

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_make_image", ExactSpelling = true)]
        public static extern simgui_image_t make_image([NativeTypeName("const simgui_image_desc_t *")] simgui_image_desc_t* desc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_destroy_image", ExactSpelling = true)]
        public static extern void destroy_image(simgui_image_t img);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_query_image_desc", ExactSpelling = true)]
        public static extern simgui_image_desc_t query_image_desc(simgui_image_t img);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_imtextureid", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong imtextureid(simgui_image_t img);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_image_from_imtextureid", ExactSpelling = true)]
        public static extern simgui_image_t image_from_imtextureid([NativeTypeName("uint64_t")] ulong im_texture_id);

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

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_create_fonts_texture", ExactSpelling = true)]
        public static extern void create_fonts_texture([NativeTypeName("const simgui_font_tex_desc_t *")] simgui_font_tex_desc_t* desc);

        [DllImport("sokol", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simgui_destroy_fonts_texture", ExactSpelling = true)]
        public static extern void destroy_fonts_texture();
    }
}

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Security;

namespace Glfw
{
    public readonly struct CharPtr
    {
        readonly IntPtr _ptr;
        public CharPtr(IntPtr ptr) => this._ptr = ptr;
        public static explicit operator CharPtr(IntPtr ptr) => new CharPtr(ptr);
        public static implicit operator IntPtr(CharPtr charPtr) => charPtr._ptr;
    
        public unsafe ReadOnlySpan<byte> AsSpan()
        {
            byte* start = (byte*)_ptr;
            byte* current = start;
    
            while (*current != 0)
                current++;
    
            return new ReadOnlySpan<byte>(start, (int)(current - start));
        }
    
        public unsafe override string ToString() => 
    		System.Text.Encoding.UTF8.GetString(AsSpan());
            
    }
    
    public class NativeStructAttribute : Attribute
    {
    	public NativeStructAttribute(string name, int size)
    	{
    		Size = size;
    		Name = name;
    	}
    	public string Name{get;}
    	public int Size{get;}
    }
#region Enums
    public enum MouseButton
    {
        Btn1 = 0,//0
        Btn2 = 1,//1
        Btn3 = 2,//2
        Btn4 = 3,//3
        Btn5 = 4,//4
        Btn6 = 5,//5
        Btn7 = 6,//6
        Btn8 = 7,//7
        BtnLast = Btn8,//GLFW_MOUSE_BUTTON_8
        BtnLeft = Btn1,//GLFW_MOUSE_BUTTON_1
        BtnRight = Btn2,//GLFW_MOUSE_BUTTON_2
        BtnMiddle = Btn3,//GLFW_MOUSE_BUTTON_3
    }

    public enum Joystick
    {
        Joy1 = 0,//0
        Joy2 = 1,//1
        Joy3 = 2,//2
        Joy4 = 3,//3
        Joy5 = 4,//4
        Joy6 = 5,//5
        Joy7 = 6,//6
        Joy8 = 7,//7
        Joy9 = 8,//8
        Joy10 = 9,//9
        Joy11 = 10,//10
        Joy12 = 11,//11
        Joy13 = 12,//12
        Joy14 = 13,//13
        Joy15 = 14,//14
        Joy16 = 15,//15
    }

    public enum Keyboard : int
    {
        KeyUnknown = -1,//- 1
        KeySpace = 32,//32
        KeyApostrophe = 39,//39
        KeyComma = 44,//44
        KeyMinus = 45,//45
        KeyPeriod = 46,//46
        KeySlash = 47,//47
        Key0 = 48,//48
        Key1 = 49,//49
        Key2 = 50,//50
        Key3 = 51,//51
        Key4 = 52,//52
        Key5 = 53,//53
        Key6 = 54,//54
        Key7 = 55,//55
        Key8 = 56,//56
        Key9 = 57,//57
        KeySemicolon = 59,//59
        KeyEqual = 61,//61
        KeyA = 65,//65
        KeyB = 66,//66
        KeyC = 67,//67
        KeyD = 68,//68
        KeyE = 69,//69
        KeyF = 70,//70
        KeyG = 71,//71
        KeyH = 72,//72
        KeyI = 73,//73
        KeyJ = 74,//74
        KeyK = 75,//75
        KeyL = 76,//76
        KeyM = 77,//77
        KeyN = 78,//78
        KeyO = 79,//79
        KeyP = 80,//80
        KeyQ = 81,//81
        KeyR = 82,//82
        KeyS = 83,//83
        KeyT = 84,//84
        KeyU = 85,//85
        KeyV = 86,//86
        KeyW = 87,//87
        KeyX = 88,//88
        KeyY = 89,//89
        KeyZ = 90,//90
        KeyLeftBracket = 91,//91
        KeyBackslash = 92,//92
        KeyRightBracket = 93,//93
        KeyGraveAccent = 96,//96
        KeyWorld1 = 161,//161
        KeyWorld2 = 162,//162
        KeyEscape = 256,//256
        KeyEnter = 257,//257
        KeyTab = 258,//258
        KeyBackspace = 259,//259
        KeyInsert = 260,//260
        KeyDelete = 261,//261
        KeyRight = 262,//262
        KeyLeft = 263,//263
        KeyDown = 264,//264
        KeyUp = 265,//265
        KeyPageUp = 266,//266
        KeyPageDown = 267,//267
        KeyHome = 268,//268
        KeyEnd = 269,//269
        KeyCapsLock = 280,//280
        KeyScrollLock = 281,//281
        KeyNumLock = 282,//282
        KeyPrintScreen = 283,//283
        KeyPause = 284,//284
        KeyF1 = 290,//290
        KeyF2 = 291,//291
        KeyF3 = 292,//292
        KeyF4 = 293,//293
        KeyF5 = 294,//294
        KeyF6 = 295,//295
        KeyF7 = 296,//296
        KeyF8 = 297,//297
        KeyF9 = 298,//298
        KeyF10 = 299,//299
        KeyF11 = 300,//300
        KeyF12 = 301,//301
        KeyF13 = 302,//302
        KeyF14 = 303,//303
        KeyF15 = 304,//304
        KeyF16 = 305,//305
        KeyF17 = 306,//306
        KeyF18 = 307,//307
        KeyF19 = 308,//308
        KeyF20 = 309,//309
        KeyF21 = 310,//310
        KeyF22 = 311,//311
        KeyF23 = 312,//312
        KeyF24 = 313,//313
        KeyF25 = 314,//314
        KeyKp0 = 320,//320
        KeyKp1 = 321,//321
        KeyKp2 = 322,//322
        KeyKp3 = 323,//323
        KeyKp4 = 324,//324
        KeyKp5 = 325,//325
        KeyKp6 = 326,//326
        KeyKp7 = 327,//327
        KeyKp8 = 328,//328
        KeyKp9 = 329,//329
        KeyKpDecimal = 330,//330
        KeyKpDivide = 331,//331
        KeyKpMultiply = 332,//332
        KeyKpSubtract = 333,//333
        KeyKpAdd = 334,//334
        KeyKpEnter = 335,//335
        KeyKpEqual = 336,//336
        KeyLeftShift = 340,//340
        KeyLeftControl = 341,//341
        KeyLeftAlt = 342,//342
        KeyLeftSuper = 343,//343
        KeyRightShift = 344,//344
        KeyRightControl = 345,//345
        KeyRightAlt = 346,//346
        KeyRightSuper = 347,//347
        KeyMenu = 348,//348
    }

    [Flags]
    public enum KeyModifiers
    {
        Shift = 0x1,//0x0001
        Control = 0x2,//0x0002
        Alt = 0x4,//0x0004
        Super = 0x8,//0x0008
    }

    public enum KeyState
    {
        Release = 0,//0
        Press = 1,//1
        Repeat = 2,//2
    }

    public enum SystemCursors
    {
        ArrowCursor = 221185,//0x00036001
        IbeamCursor = 221186,//0x00036002
        CrosshairCursor = 221187,//0x00036003
        HandCursor = 221188,//0x00036004
        HresizeCursor = 221189,//0x00036005
        VresizeCursor = 221190,//0x00036006
    }

#endregion

#region Structs
    //GLFWvidmode
    [NativeStruct("GLFWvidmode", 24), StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VideoMode
    {
        public VideoMode* Ptr() { fixed(VideoMode* ptr = &this) return ptr; }
        internal int width; //size: 4, offset:0
        internal int height; //size: 4, offset:4
        internal int redBits; //size: 4, offset:8
        internal int greenBits; //size: 4, offset:12
        internal int blueBits; //size: 4, offset:16
        internal int refreshRate; //size: 4, offset:20
    }

    //GLFWgammaramp
    [NativeStruct("GLFWgammaramp", 32), StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct Gammaramp
    {
        public Gammaramp* Ptr() { fixed(Gammaramp* ptr = &this) return ptr; }
        internal ushort* red; //size: 8, offset:0
        internal ushort* green; //size: 8, offset:8
        internal ushort* blue; //size: 8, offset:16
        internal uint size; //size: 4, offset:24
    }

    //GLFWimage
    [NativeStruct("GLFWimage", 16), StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct Image
    {
        public Image* Ptr() { fixed(Image* ptr = &this) return ptr; }
        internal int width; //size: 4, offset:0
        internal int height; //size: 4, offset:4
        internal byte* pixels; //size: 8, offset:8
    }

#endregion

#region OpaquePtrs
    //GLFWmonitor
    public unsafe partial struct Monitor
    {
        readonly IntPtr ptr;
        public Monitor(IntPtr ptr) => this.ptr = ptr;
        internal Monitor* Ptr => (Monitor*) ptr;
    }

    //GLFWwindow
    public unsafe partial struct Window
    {
        readonly IntPtr ptr;
        public Window(IntPtr ptr) => this.ptr = ptr;
        internal Window* Ptr => (Window*) ptr;
    }

    //GLFWcursor
    public unsafe partial struct Cursor
    {
        readonly IntPtr ptr;
        public Cursor(IntPtr ptr) => this.ptr = ptr;
        internal Cursor* Ptr => (Cursor*) ptr;
    }

#endregion

#region Delegates
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ErrorfunDelegate(int param0, CharPtr param1);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void MonitorfunDelegate(Monitor param0, int param1);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void WindowposfunDelegate(Window param0, int param1, int param2);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void WindowsizefunDelegate(Window param0, int param1, int param2);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void WindowclosefunDelegate(Window param0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void WindowrefreshfunDelegate(Window param0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void WindowfocusfunDelegate(Window param0, int param1);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void WindowiconifyfunDelegate(Window param0, int param1);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void FramebuffersizefunDelegate(Window param0, int param1, int param2);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void KeyfunDelegate(Window param0, int param1, int param2, int param3, int param4);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void CharfunDelegate(Window param0, uint param1);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void CharmodsfunDelegate(Window param0, uint param1, int param2);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void MousebuttonfunDelegate(Window param0, int param1, int param2, int param3);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void CursorposfunDelegate(Window param0, double param1, double param2);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void CursorenterfunDelegate(Window param0, int param1);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ScrollfunDelegate(Window param0, double param1, double param2);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DropfunDelegate(Window param0, int param1, CharPtr* param2);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JoystickfunDelegate(int param0, int param1);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void GlprocDelegate();

#endregion

    internal unsafe static partial class glfw
    {
        ///<summary>
        /// Initializes the GLFW library.
        ///</summary>
        ///<returns>
        /// `GLFW_TRUE` if successful, or `GLFW_FALSE` if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function initializes the GLFW library.  Before most GLFW functions can  be used, GLFW must be initialized, and before an application terminates GLFW  should be terminated in order to free any resources allocated during or  after initialization.
        ///  If this function fails, it calls 
        ///  succeeds, you should call 
        ///  Additional calls to this function after successful initialization but before  termination will return `GLFW_TRUE` immediately.
        ///   Possible errors include 
        ///  This function will change the current directory of the  application to the `Contents/Resources` subdirectory of the application's  bundle, if present.  This can be disabled with a  [compile-time option](
        ///  _safety This function must only be called from the main thread.
        /// glfwTerminate
        /// Added in version 1.0.
        ///</remarks>
        ///<code>
        ///int glfwInit()
        ///</code>
        // glfwInit: 
        [DllImport(DLL, EntryPoint = "glfwInit", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern int Init();

        ///<summary>
        /// Terminates the GLFW library.
        ///</summary>
        ///<remarks>
        ///  This function destroys all remaining windows and cursors, restores any  modified gamma ramps and frees any other allocated resources.  Once this  function is called, you must again call 
        ///  you will be able to use most GLFW functions.
        ///  If GLFW has been successfully initialized, this function should be called  before the application exits.  If initialization fails, there is no need to  call this function, as it is called by 
        ///  failure.
        ///   Possible errors include 
        /// This function may be called before 
        /// The contexts of any remaining windows must not be current on any  other thread when this function is called.
        ///   This function must not be called from a callback.
        ///  _safety This function must only be called from the main thread.
        /// glfwInit
        /// Added in version 1.0.
        ///</remarks>
        ///<code>
        ///void glfwTerminate()
        ///</code>
        // glfwTerminate: 
        [DllImport(DLL, EntryPoint = "glfwTerminate", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void Terminate();

        ///<summary>
        /// Retrieves the version of the GLFW library.
        ///</summary>
        ///<param name="major"> [out]  Where to store the major version number, or `NULL`.  </param>
        ///<param name="minor"> [out]  Where to store the minor version number, or `NULL`.  </param>
        ///<param name="rev"> [out]  Where to store the revision number, or `NULL`.</param>
        ///<remarks>
        ///  This function retrieves the major, minor and revision numbers of the GLFW  library.  It is intended for when you are using GLFW as a shared library and  want to ensure that you are using the minimum required version.
        ///  Any or all of the version arguments may be `NULL`.
        ///   None.
        /// This function may be called before 
        ///  _safety This function may be called from any thread.
        /// glfwGetVersionString
        /// Added in version 1.0.
        ///</remarks>
        ///<code>
        ///void glfwGetVersion(int *major, int *minor, int *rev)
        ///</code>
        // glfwGetVersion: 
        [DllImport(DLL, EntryPoint = "glfwGetVersion", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void GetVersion(out int major, out int minor, out int rev);

        ///<summary>
        /// Returns a string describing the compile-time configuration.
        ///</summary>
        ///<returns>
        /// The ASCII encoded GLFW version string.
        ///</returns>
        ///<remarks>
        ///  This function returns the compile-time generated  [version string](
        ///  describes the version, platform, compiler and any platform-specific  compile-time options.  It should not be confused with the OpenGL or OpenGL  ES version string, queried with `glGetString`.
        ///  __Do not use the version string__ to parse the GLFW library version.  The  
        ///  binary in numerical format.
        ///   None.
        /// This function may be called before 
        ///  _lifetime The returned string is static and compile-time generated.
        ///  _safety This function may be called from any thread.
        /// glfwGetVersion
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///const char *glfwGetVersionString()
        ///</code>
        // glfwGetVersionString: 
        [DllImport(DLL, EntryPoint = "glfwGetVersionString", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern CharPtr GetVersionString();

        ///<summary>
        /// Sets the error callback.
        ///</summary>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set.
        ///</returns>
        ///<remarks>
        ///  This function sets the error callback, which is called with an error code  and a human-readable description each time a GLFW error occurs.
        ///  The error callback is called on the thread where the error occurred.  If you  are using GLFW from multiple threads, your error callback needs to be  written accordingly.
        ///  Because the description string may have been generated specifically for that  error, it is not guaranteed to be valid after the callback has returned.  If  you wish to use it after the callback returns, you need to make a copy.
        ///  Once set, the error callback remains set even after the library has been  terminated.
        ///   None.
        /// This function may be called before 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWerrorfun glfwSetErrorCallback(GLFWerrorfun cbfun)
        ///</code>
        // glfwSetErrorCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetErrorCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ErrorfunDelegate SetErrorCallback(ErrorfunDelegate cbfun);

        ///<summary>
        /// Returns the currently connected monitors.
        ///</summary>
        ///<param name="count"> [out]  Where to store the number of monitors in the returned  array.  This is set to zero if an error occurred.  </param>
        ///<returns>
        /// An array of monitor handles, or `NULL` if no monitors were found or  if an [error](
        ///</returns>
        ///<remarks>
        ///  This function returns an array of handles for all currently connected  monitors.  The primary monitor is always first in the returned array.  If no  monitors were found, this function returns `NULL`.
        ///   Possible errors include 
        ///  _lifetime The returned array is allocated and freed by GLFW.  You  should not free it yourself.  It is guaranteed to be valid only until the  monitor configuration changes or the library is terminated.
        ///  _safety This function must only be called from the main thread.
        /// glfwGetPrimaryMonitor
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWmonitor **glfwGetMonitors(int *count)
        ///</code>
        // glfwGetMonitors: 
        [DllImport(DLL, EntryPoint = "glfwGetMonitors", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ref Monitor GetMonitors(out int count);

        ///<summary>
        /// Returns the primary monitor.
        ///</summary>
        ///<returns>
        /// The primary monitor, or `NULL` if no monitors were found or if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the primary monitor.  This is usually the monitor  where elements like the task bar or global menu bar are located.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// The primary monitor is always first in the array returned by 
        ///  glfwGetMonitors.
        /// glfwGetMonitors
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWmonitor *glfwGetPrimaryMonitor()
        ///</code>
        // glfwGetPrimaryMonitor: 
        [DllImport(DLL, EntryPoint = "glfwGetPrimaryMonitor", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern Monitor GetPrimaryMonitor();

        ///<summary>
        /// Returns the position of the monitor's viewport on the virtual screen.
        ///</summary>
        ///<param name="monitor"> [in]  The monitor to query.  </param>
        ///<param name="xpos"> [out]  Where to store the monitor x-coordinate, or `NULL`.  </param>
        ///<param name="ypos"> [out]  Where to store the monitor y-coordinate, or `NULL`.</param>
        ///<remarks>
        ///  This function returns the position, in screen coordinates, of the upper-left  corner of the specified monitor.
        ///  Any or all of the position arguments may be `NULL`.  If an error occurs, all  non-`NULL` position arguments will be set to zero.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwGetMonitorPos(GLFWmonitor *monitor, int *xpos, int *ypos)
        ///</code>
        // glfwGetMonitorPos: 
        [DllImport(DLL, EntryPoint = "glfwGetMonitorPos", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void GetMonitorPos(Monitor monitor, out int xpos, out int ypos);

        ///<summary>
        /// Returns the physical size of the monitor.
        ///</summary>
        ///<param name="monitor"> [in]  The monitor to query.  </param>
        ///<param name="widthMM"> [out]  Where to store the width, in millimetres, of the  monitor's display area, or `NULL`.  </param>
        ///<param name="heightMM"> [out]  Where to store the height, in millimetres, of the  monitor's display area, or `NULL`.</param>
        ///<remarks>
        ///  This function returns the size, in millimetres, of the display area of the  specified monitor.
        ///  Some systems do not provide accurate monitor size information, either  because the monitor  [EDID](https://en.wikipedia.org/wiki/Extended_display_identification_data)  data is incorrect or because the driver does not report it accurately.
        ///  Any or all of the size arguments may be `NULL`.  If an error occurs, all  non-`NULL` size arguments will be set to zero.
        ///   Possible errors include 
        ///  calculates the returned physical size from the  current resolution and system DPI instead of querying the monitor EDID data.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwGetMonitorPhysicalSize(GLFWmonitor *monitor, int *widthMM,
        ///                                int *heightMM)
        ///</code>
        // glfwGetMonitorPhysicalSize: 
        [DllImport(DLL, EntryPoint = "glfwGetMonitorPhysicalSize", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void GetMonitorPhysicalSize(Monitor monitor, out int widthMM, out int heightMM);

        ///<summary>
        /// Returns the name of the specified monitor.
        ///</summary>
        ///<param name="monitor"> [in]  The monitor to query.  </param>
        ///<returns>
        /// The UTF-8 encoded name of the monitor, or `NULL` if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns a human-readable name, encoded as UTF-8, of the  specified monitor.  The name typically reflects the make and model of the  monitor and is not guaranteed to be unique among the connected monitors.
        ///   Possible errors include 
        ///  _lifetime The returned string is allocated and freed by GLFW.  You  should not free it yourself.  It is valid until the specified monitor is  disconnected or the library is terminated.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///const char *glfwGetMonitorName(GLFWmonitor *monitor)
        ///</code>
        // glfwGetMonitorName: 
        [DllImport(DLL, EntryPoint = "glfwGetMonitorName", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern CharPtr GetMonitorName(Monitor monitor);

        ///<summary>
        /// Sets the monitor configuration callback.
        ///</summary>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the monitor configuration callback, or removes the  currently set callback.  This is called when a monitor is connected to or  disconnected from the system.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWmonitorfun glfwSetMonitorCallback(GLFWmonitorfun cbfun)
        ///</code>
        // glfwSetMonitorCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetMonitorCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern MonitorfunDelegate SetMonitorCallback(MonitorfunDelegate cbfun);

        ///<summary>
        /// Returns the available video modes for the specified monitor.
        ///</summary>
        ///<param name="monitor"> [in]  The monitor to query.  </param>
        ///<param name="count"> [out]  Where to store the number of video modes in the returned  array.  This is set to zero if an error occurred.  </param>
        ///<returns>
        /// An array of video modes, or `NULL` if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns an array of all video modes supported by the specified  monitor.  The returned array is sorted in ascending order, first by color  bit depth (the sum of all channel depths) and then by resolution area (the  product of width and height).
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _lifetime The returned array is allocated and freed by GLFW.  You  should not free it yourself.  It is valid until the specified monitor is  disconnected, this function is called again for that monitor or the library  is terminated.
        ///  _safety This function must only be called from the main thread.
        /// glfwGetVideoMode
        /// Added in version 1.0.   Changed to return an array of modes for a specific monitor.
        ///</remarks>
        ///<code>
        ///const GLFWvidmode *glfwGetVideoModes(GLFWmonitor *monitor, int *count)
        ///</code>
        // glfwGetVideoModes: 
        [DllImport(DLL, EntryPoint = "glfwGetVideoModes", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ref VideoMode GetVideoModes(Monitor monitor, out int count);

        ///<summary>
        /// Returns the current mode of the specified monitor.
        ///</summary>
        ///<param name="monitor"> [in]  The monitor to query.  </param>
        ///<returns>
        /// The current mode of the monitor, or `NULL` if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the current video mode of the specified monitor.  If  you have created a full screen window for that monitor, the return value  will depend on whether that window is iconified.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _lifetime The returned array is allocated and freed by GLFW.  You  should not free it yourself.  It is valid until the specified monitor is  disconnected or the library is terminated.
        ///  _safety This function must only be called from the main thread.
        /// glfwGetVideoModes
        /// Added in version 3.0.  Replaces `glfwGetDesktopMode`.
        ///</remarks>
        ///<code>
        ///const GLFWvidmode *glfwGetVideoMode(GLFWmonitor *monitor)
        ///</code>
        // glfwGetVideoMode: 
        [DllImport(DLL, EntryPoint = "glfwGetVideoMode", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ref VideoMode GetVideoMode(Monitor monitor);

        ///<summary>
        /// Generates a gamma ramp and sets it for the specified monitor.
        ///</summary>
        ///<param name="monitor"> [in]  The monitor whose gamma ramp to set.  </param>
        ///<param name="gamma"> [in]  The desired exponent.</param>
        ///<remarks>
        ///  This function generates a 256-element gamma ramp from the specified exponent  and then calls 
        ///  number greater than zero.
        ///   Possible errors include 
        ///  GLFW_INVALID_VALUE and 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwSetGamma(GLFWmonitor *monitor, float gamma)
        ///</code>
        // glfwSetGamma: 
        [DllImport(DLL, EntryPoint = "glfwSetGamma", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetGamma(Monitor monitor, float gamma);

        ///<summary>
        /// Returns the current gamma ramp for the specified monitor.
        ///</summary>
        ///<param name="monitor"> [in]  The monitor to query.  </param>
        ///<returns>
        /// The current gamma ramp, or `NULL` if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the current gamma ramp of the specified monitor.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _lifetime The returned structure and its arrays are allocated and  freed by GLFW.  You should not free them yourself.  They are valid until the  specified monitor is disconnected, this function is called again for that  monitor or the library is terminated.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///const GLFWgammaramp *glfwGetGammaRamp(GLFWmonitor *monitor)
        ///</code>
        // glfwGetGammaRamp: 
        [DllImport(DLL, EntryPoint = "glfwGetGammaRamp", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ref Gammaramp GetGammaRamp(Monitor monitor);

        ///<summary>
        /// Sets the current gamma ramp for the specified monitor.
        ///</summary>
        ///<param name="monitor"> [in]  The monitor whose gamma ramp to set.  </param>
        ///<param name="ramp"> [in]  The gamma ramp to use.</param>
        ///<remarks>
        ///  This function sets the current gamma ramp for the specified monitor.  The  original gamma ramp for that monitor is saved by GLFW the first time this  function is called and is restored by 
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        /// Gamma ramp sizes other than 256 are not supported by all platforms  or graphics hardware.
        ///  The gamma ramp size must be 256.
        ///  _lifetime The specified gamma ramp is copied before this function  returns.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwSetGammaRamp(GLFWmonitor *monitor, const GLFWgammaramp *ramp)
        ///</code>
        // glfwSetGammaRamp: 
        [DllImport(DLL, EntryPoint = "glfwSetGammaRamp", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetGammaRamp(Monitor monitor, out Gammaramp ramp);

        ///<summary>
        /// Resets all window hints to their default values.
        ///</summary>
        ///<remarks>
        ///  This function resets all window hints to their  [default values](
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// glfwWindowHint
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwDefaultWindowHints()
        ///</code>
        // glfwDefaultWindowHints: 
        [DllImport(DLL, EntryPoint = "glfwDefaultWindowHints", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void DefaultWindowHints();

        ///<summary>
        /// Sets the specified window hint to the desired value.
        ///</summary>
        ///<param name="hint"> [in]  The [window hint](</param>
        ///<param name="value"> [in]  The new value of the window hint.</param>
        ///<remarks>
        ///  This function sets hints for the next call to 
        ///  hints, once set, retain their values until changed by a call to 
        ///  glfwWindowHint or 
        ///  terminated.
        ///  This function does not check whether the specified hint values are valid.  If you set hints to invalid values this will instead be reported by the next  call to 
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM.
        ///  _safety This function must only be called from the main thread.
        /// glfwDefaultWindowHints
        /// Added in version 3.0.  Replaces `glfwOpenWindowHint`.
        ///</remarks>
        ///<code>
        ///void glfwWindowHint(int hint, int value)
        ///</code>
        // glfwWindowHint: 
        [DllImport(DLL, EntryPoint = "glfwWindowHint", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void WindowHint(int hint, int @value);

        ///<summary>
        /// Creates a window and its associated context.
        ///</summary>
        ///<param name="width"> [in]  The desired width, in screen coordinates, of the window.  This must be greater than zero.  </param>
        ///<param name="height"> [in]  The desired height, in screen coordinates, of the window.  This must be greater than zero.  </param>
        ///<param name="title"> [in]  The initial, UTF-8 encoded window title.  </param>
        ///<param name="monitor"> [in]  The monitor to use for full screen mode, or `NULL` for  windowed mode.  </param>
        ///<param name="share"> [in]  The window whose context to share resources with, or `NULL`  to not share resources.  </param>
        ///<returns>
        /// The handle of the created window, or `NULL` if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function creates a window and its associated OpenGL or OpenGL ES  context.  Most of the options controlling how the window and its context  should be created are specified with [window hints](
        ///  Successful creation does not change which context is current.  Before you  can use the newly created context, you need to  [make it current](
        ///  parameter, see 
        ///  The created window, framebuffer and context may differ from what you  requested, as not all parameters and hints are  [hard constraints](
        ///  window, especially for full screen windows.  To query the actual attributes  of the created window, framebuffer and context, see 
        ///  glfwGetWindowAttrib, 
        ///  To create a full screen window, you need to specify the monitor the window  will cover.  If no monitor is specified, the window will be windowed mode.  Unless you have a way for the user to choose a specific monitor, it is  recommended that you pick the primary monitor.  For more information on how  to query connected monitors, see 
        ///  For full screen windows, the specified size becomes the resolution of the  window's _desired video mode_.  As long as a full screen window is not  iconified, the supported video mode most closely matching the desired video  mode is set for the specified monitor.  For more information about full  screen windows, including the creation of so called _windowed full screen_  or _borderless full screen_ windows, see 
        ///  Once you have created the window, you can switch it between windowed and  full screen mode with 
        ///  OpenGL or OpenGL ES context, it will be unaffected.
        ///  By default, newly created windows use the placement recommended by the  window system.  To create the window at a specific position, make it  initially invisible using the [GLFW_VISIBLE](
        ///  hint, set its [position](
        ///  it.
        ///  As long as at least one full screen window is not iconified, the screensaver  is prohibited from starting.
        ///  Window systems put limits on window sizes.  Very large or very small window  dimensions may be overridden by the window system on creation.  Check the  actual [size](
        ///  The [swap interval](
        ///  the initial value may vary depending on driver settings and defaults.
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM, 
        ///  GLFW_VERSION_UNAVAILABLE, 
        ///  GLFW_PLATFORM_ERROR.
        ///  Window creation will fail if the Microsoft GDI software  OpenGL implementation is the only one available.
        ///  If the executable has an icon resource named `GLFW_ICON,` it  will be set as the initial icon for the window.  If no such icon is present,  the `IDI_WINLOGO` icon will be used instead.  To set a different icon, see  
        ///  The context to share resources with must not be current on  any other thread.
        ///  The GLFW window has no icon, as it is not a document  window, but the dock icon will be the same as the application bundle's icon.  For more information on bundles, see the  [Bundle Programming Guide](https://developer.apple.com/library/mac/documentation/CoreFoundation/Conceptual/CFBundles/)  in the Mac Developer Library.
        ///  The first time a window is created the menu bar is populated  with common commands like Hide, Quit and About.  The About entry opens  a minimal about dialog with information from the application's bundle.  The  menu bar can be disabled with a  [compile-time option](
        ///  On OS X 10.10 and later the window frame will not be rendered  at full resolution on Retina displays unless the `NSHighResolutionCapable`  key is enabled in the application bundle's `Info.plist`.  For more  information, see  [High Resolution Guidelines for OS X](https://developer.apple.com/library/mac/documentation/GraphicsAnimation/Conceptual/HighResolutionOSX/Explained/Explained.html)  in the Mac Developer Library.  The GLFW test and example programs use  a custom `Info.plist` template for this, which can be found as  `CMake/MacOSXBundleInfo.plist.in` in the source tree.
        ///  Some window managers will not respect the placement of  initially hidden windows.
        ///  Due to the asynchronous nature of X11, it may take a moment for  a window to reach its requested state.  This means you may not be able to  query the final size, position or other attributes directly after window  creation.
        ///   This function must not be called from a callback.
        ///  _safety This function must only be called from the main thread.
        /// glfwDestroyWindow
        /// Added in version 3.0.  Replaces `glfwOpenWindow`.
        ///</remarks>
        ///<code>
        ///GLFWwindow *glfwCreateWindow(int width, int height, const char *title,
        ///                             GLFWmonitor *monitor, GLFWwindow *share)
        ///</code>
        // glfwCreateWindow: 
        [DllImport(DLL, EntryPoint = "glfwCreateWindow", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern Window CreateWindow(int width, int height, CharPtr title, Monitor monitor, Window share);

        ///<summary>
        /// Destroys the specified window and its context.
        ///</summary>
        ///<param name="window"> [in]  The window to destroy.</param>
        ///<remarks>
        ///  This function destroys the specified window and its context.  On calling  this function, no further callbacks will be called for that window.
        ///  If the context of the specified window is current on the main thread, it is  detached before being destroyed.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        /// The context of the specified window must not be current on any other  thread when this function is called.
        ///   This function must not be called from a callback.
        ///  _safety This function must only be called from the main thread.
        /// glfwCreateWindow
        /// Added in version 3.0.  Replaces `glfwCloseWindow`.
        ///</remarks>
        ///<code>
        ///void glfwDestroyWindow(GLFWwindow *window)
        ///</code>
        // glfwDestroyWindow: 
        [DllImport(DLL, EntryPoint = "glfwDestroyWindow", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void DestroyWindow(Window window);

        ///<summary>
        /// Checks the close flag of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to query.  </param>
        ///<returns>
        /// The value of the close flag.
        ///</returns>
        ///<remarks>
        ///  This function returns the value of the close flag of the specified window.
        ///   Possible errors include 
        ///  _safety This function may be called from any thread.  Access is not  synchronized.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///int glfwWindowShouldClose(GLFWwindow *window)
        ///</code>
        // glfwWindowShouldClose: 
        [DllImport(DLL, EntryPoint = "glfwWindowShouldClose", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern int WindowShouldClose(Window window);

        ///<summary>
        /// Sets the close flag of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose flag to change.  </param>
        ///<param name="value"> [in]  The new value.</param>
        ///<remarks>
        ///  This function sets the value of the close flag of the specified window.  This can be used to override the user's attempt to close the window, or  to signal that it should be closed.
        ///   Possible errors include 
        ///  _safety This function may be called from any thread.  Access is not  synchronized.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwSetWindowShouldClose(GLFWwindow *window, int value)
        ///</code>
        // glfwSetWindowShouldClose: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowShouldClose", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetWindowShouldClose(Window window, int @value);

        ///<summary>
        /// Sets the title of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose title to change.  </param>
        ///<param name="title"> [in]  The UTF-8 encoded window title.</param>
        ///<remarks>
        ///  This function sets the window title, encoded as UTF-8, of the specified  window.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  The window title will not be updated until the next time you  process events.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 1.0.   Added window handle parameter.
        ///</remarks>
        ///<code>
        ///void glfwSetWindowTitle(GLFWwindow *window, const char *title)
        ///</code>
        // glfwSetWindowTitle: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowTitle", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetWindowTitle(Window window, CharPtr title);

        ///<summary>
        /// Sets the icon for the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose icon to set.  </param>
        ///<param name="count"> [in]  The number of images in the specified array, or zero to  revert to the default window icon.  </param>
        ///<param name="images"> [in]  The images to create the icon from.  This is ignored if  count is zero.</param>
        ///<remarks>
        ///  This function sets the icon of the specified window.  If passed an array of  candidate images, those of or closest to the sizes desired by the system are  selected.  If no images are specified, the window reverts to its default  icon.
        ///  The desired image sizes varies depending on platform and system settings.  The selected images will be rescaled as needed.  Good sizes include 16x16,  32x32 and 48x48.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _lifetime The specified image data is copied before this function  returns.
        ///  The GLFW window has no icon, as it is not a document  window, so this function does nothing.  The dock icon will be the same as  the application bundle's icon.  For more information on bundles, see the  [Bundle Programming Guide](https://developer.apple.com/library/mac/documentation/CoreFoundation/Conceptual/CFBundles/)  in the Mac Developer Library.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///void glfwSetWindowIcon(GLFWwindow *window, int count, const GLFWimage *images)
        ///</code>
        // glfwSetWindowIcon: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowIcon", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetWindowIcon(Window window, int count, out Image images);

        ///<summary>
        /// Retrieves the position of the client area of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to query.  </param>
        ///<param name="xpos"> [out]  Where to store the x-coordinate of the upper-left corner of  the client area, or `NULL`.  </param>
        ///<param name="ypos"> [out]  Where to store the y-coordinate of the upper-left corner of  the client area, or `NULL`.</param>
        ///<remarks>
        ///  This function retrieves the position, in screen coordinates, of the  upper-left corner of the client area of the specified window.
        ///  Any or all of the position arguments may be `NULL`.  If an error occurs, all  non-`NULL` position arguments will be set to zero.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwSetWindowPos
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwGetWindowPos(GLFWwindow *window, int *xpos, int *ypos)
        ///</code>
        // glfwGetWindowPos: 
        [DllImport(DLL, EntryPoint = "glfwGetWindowPos", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void GetWindowPos(Window window, out int xpos, out int ypos);

        ///<summary>
        /// Sets the position of the client area of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to query.  </param>
        ///<param name="xpos"> [in]  The x-coordinate of the upper-left corner of the client area.  </param>
        ///<param name="ypos"> [in]  The y-coordinate of the upper-left corner of the client area.</param>
        ///<remarks>
        ///  This function sets the position, in screen coordinates, of the upper-left  corner of the client area of the specified windowed mode window.  If the  window is a full screen window, this function does nothing.
        ///  __Do not use this function__ to move an already visible window unless you  have very good reasons for doing so, as it will confuse and annoy the user.
        ///  The window manager may put limits on what positions are allowed.  GLFW  cannot and should not override these limits.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwGetWindowPos
        /// Added in version 1.0.   Added window handle parameter.
        ///</remarks>
        ///<code>
        ///void glfwSetWindowPos(GLFWwindow *window, int xpos, int ypos)
        ///</code>
        // glfwSetWindowPos: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowPos", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetWindowPos(Window window, int xpos, int ypos);

        ///<summary>
        /// Retrieves the size of the client area of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose size to retrieve.  </param>
        ///<param name="width"> [out]  Where to store the width, in screen coordinates, of the  client area, or `NULL`.  </param>
        ///<param name="height"> [out]  Where to store the height, in screen coordinates, of the  client area, or `NULL`.</param>
        ///<remarks>
        ///  This function retrieves the size, in screen coordinates, of the client area  of the specified window.  If you wish to retrieve the size of the  framebuffer of the window in pixels, see 
        ///  Any or all of the size arguments may be `NULL`.  If an error occurs, all  non-`NULL` size arguments will be set to zero.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwSetWindowSize
        /// Added in version 1.0.   Added window handle parameter.
        ///</remarks>
        ///<code>
        ///void glfwGetWindowSize(GLFWwindow *window, int *width, int *height)
        ///</code>
        // glfwGetWindowSize: 
        [DllImport(DLL, EntryPoint = "glfwGetWindowSize", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void GetWindowSize(Window window, out int width, out int height);

        ///<summary>
        /// Sets the size limits of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to set limits for.  </param>
        ///<param name="minwidth"> [in]  The minimum width, in screen coordinates, of the client  area, or `GLFW_DONT_CARE`.  </param>
        ///<param name="minheight"> [in]  The minimum height, in screen coordinates, of the  client area, or `GLFW_DONT_CARE`.  </param>
        ///<param name="maxwidth"> [in]  The maximum width, in screen coordinates, of the client  area, or `GLFW_DONT_CARE`.  </param>
        ///<param name="maxheight"> [in]  The maximum height, in screen coordinates, of the  client area, or `GLFW_DONT_CARE`.</param>
        ///<remarks>
        ///  This function sets the size limits of the client area of the specified  window.  If the window is full screen, the size limits only take effect  once it is made windowed.  If the window is not resizable, this function  does nothing.
        ///  The size limits are applied immediately to a windowed mode window and may  cause it to be resized.
        ///  The maximum dimensions must be greater than or equal to the minimum  dimensions and all must be greater than or equal to zero.
        ///   Possible errors include 
        ///  GLFW_INVALID_VALUE and 
        /// If you set size limits and an aspect ratio that conflict, the  results are undefined.
        ///  _safety This function must only be called from the main thread.
        /// glfwSetWindowAspectRatio
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///void glfwSetWindowSizeLimits(GLFWwindow *window, int minwidth, int minheight,
        ///                             int maxwidth, int maxheight)
        ///</code>
        // glfwSetWindowSizeLimits: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowSizeLimits", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetWindowSizeLimits(Window window, int minwidth, int minheight, int maxwidth, int maxheight);

        ///<summary>
        /// Sets the aspect ratio of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to set limits for.  </param>
        ///<param name="numer"> [in]  The numerator of the desired aspect ratio, or  `GLFW_DONT_CARE`.  </param>
        ///<param name="denom"> [in]  The denominator of the desired aspect ratio, or  `GLFW_DONT_CARE`.</param>
        ///<remarks>
        ///  This function sets the required aspect ratio of the client area of the  specified window.  If the window is full screen, the aspect ratio only takes  effect once it is made windowed.  If the window is not resizable, this  function does nothing.
        ///  The aspect ratio is specified as a numerator and a denominator and both  values must be greater than zero.  For example, the common 16:9 aspect ratio  is specified as 16 and 9, respectively.
        ///  If the numerator and denominator is set to `GLFW_DONT_CARE` then the aspect  ratio limit is disabled.
        ///  The aspect ratio is applied immediately to a windowed mode window and may  cause it to be resized.
        ///   Possible errors include 
        ///  GLFW_INVALID_VALUE and 
        /// If you set size limits and an aspect ratio that conflict, the  results are undefined.
        ///  _safety This function must only be called from the main thread.
        /// glfwSetWindowSizeLimits
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///void glfwSetWindowAspectRatio(GLFWwindow *window, int numer, int denom)
        ///</code>
        // glfwSetWindowAspectRatio: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowAspectRatio", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetWindowAspectRatio(Window window, int numer, int denom);

        ///<summary>
        /// Sets the size of the client area of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to resize.  </param>
        ///<param name="width"> [in]  The desired width, in screen coordinates, of the window  client area.  </param>
        ///<param name="height"> [in]  The desired height, in screen coordinates, of the window  client area.</param>
        ///<remarks>
        ///  This function sets the size, in screen coordinates, of the client area of  the specified window.
        ///  For full screen windows, this function updates the resolution of its desired  video mode and switches to the video mode closest to it, without affecting  the window's context.  As the context is unaffected, the bit depths of the  framebuffer remain unchanged.
        ///  If you wish to update the refresh rate of the desired video mode in addition  to its resolution, see 
        ///  The window manager may put limits on what sizes are allowed.  GLFW cannot  and should not override these limits.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwGetWindowSize  
        /// glfwSetWindowMonitor
        /// Added in version 1.0.   Added window handle parameter.
        ///</remarks>
        ///<code>
        ///void glfwSetWindowSize(GLFWwindow *window, int width, int height)
        ///</code>
        // glfwSetWindowSize: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowSize", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetWindowSize(Window window, int width, int height);

        ///<summary>
        /// Retrieves the size of the framebuffer of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose framebuffer to query.  </param>
        ///<param name="width"> [out]  Where to store the width, in pixels, of the framebuffer,  or `NULL`.  </param>
        ///<param name="height"> [out]  Where to store the height, in pixels, of the framebuffer,  or `NULL`.</param>
        ///<remarks>
        ///  This function retrieves the size, in pixels, of the framebuffer of the  specified window.  If you wish to retrieve the size of the window in screen  coordinates, see 
        ///  Any or all of the size arguments may be `NULL`.  If an error occurs, all  non-`NULL` size arguments will be set to zero.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwSetFramebufferSizeCallback
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwGetFramebufferSize(GLFWwindow *window, int *width, int *height)
        ///</code>
        // glfwGetFramebufferSize: 
        [DllImport(DLL, EntryPoint = "glfwGetFramebufferSize", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void GetFramebufferSize(Window window, out int width, out int height);

        ///<summary>
        /// Retrieves the size of the frame of the window.
        ///</summary>
        ///<param name="window"> [in]  The window whose frame size to query.  </param>
        ///<param name="left"> [out]  Where to store the size, in screen coordinates, of the left  edge of the window frame, or `NULL`.  </param>
        ///<param name="top"> [out]  Where to store the size, in screen coordinates, of the top  edge of the window frame, or `NULL`.  </param>
        ///<param name="right"> [out]  Where to store the size, in screen coordinates, of the  right edge of the window frame, or `NULL`.  </param>
        ///<param name="bottom"> [out]  Where to store the size, in screen coordinates, of the  bottom edge of the window frame, or `NULL`.</param>
        ///<remarks>
        ///  This function retrieves the size, in screen coordinates, of each edge of the  frame of the specified window.  This size includes the title bar, if the  window has one.  The size of the frame may vary depending on the  [window-related hints](
        ///  Because this function retrieves the size of each window frame edge and not  the offset along a particular coordinate axis, the retrieved values will  always be zero or positive.
        ///  Any or all of the size arguments may be `NULL`.  If an error occurs, all  non-`NULL` size arguments will be set to zero.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.1.
        ///</remarks>
        ///<code>
        ///void glfwGetWindowFrameSize(GLFWwindow *window, int *left, int *top, int *right,
        ///                            int *bottom)
        ///</code>
        // glfwGetWindowFrameSize: 
        [DllImport(DLL, EntryPoint = "glfwGetWindowFrameSize", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void GetWindowFrameSize(Window window, out int left, out int top, out int right, out int bottom);

        ///<summary>
        /// Iconifies the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to iconify.</param>
        ///<remarks>
        ///  This function iconifies (minimizes) the specified window if it was  previously restored.  If the window is already iconified, this function does  nothing.
        ///  If the specified window is a full screen window, the original monitor  resolution is restored until the window is restored.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwRestoreWindow  
        /// glfwMaximizeWindow
        /// Added in version 2.1.   Added window handle parameter.
        ///</remarks>
        ///<code>
        ///void glfwIconifyWindow(GLFWwindow *window)
        ///</code>
        // glfwIconifyWindow: 
        [DllImport(DLL, EntryPoint = "glfwIconifyWindow", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void IconifyWindow(Window window);

        ///<summary>
        /// Restores the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to restore.</param>
        ///<remarks>
        ///  This function restores the specified window if it was previously iconified  (minimized) or maximized.  If the window is already restored, this function  does nothing.
        ///  If the specified window is a full screen window, the resolution chosen for  the window is restored on the selected monitor.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwIconifyWindow  
        /// glfwMaximizeWindow
        /// Added in version 2.1.   Added window handle parameter.
        ///</remarks>
        ///<code>
        ///void glfwRestoreWindow(GLFWwindow *window)
        ///</code>
        // glfwRestoreWindow: 
        [DllImport(DLL, EntryPoint = "glfwRestoreWindow", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void RestoreWindow(Window window);

        ///<summary>
        /// Maximizes the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to maximize.</param>
        ///<remarks>
        ///  This function maximizes the specified window if it was previously not  maximized.  If the window is already maximized, this function does nothing.
        ///  If the specified window is a full screen window, this function does nothing.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        /// Thread Safety  This function may only be called from the main thread.
        /// glfwIconifyWindow  
        /// glfwRestoreWindow
        /// Added in GLFW 3.2.
        ///</remarks>
        ///<code>
        ///void glfwMaximizeWindow(GLFWwindow *window)
        ///</code>
        // glfwMaximizeWindow: 
        [DllImport(DLL, EntryPoint = "glfwMaximizeWindow", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void MaximizeWindow(Window window);

        ///<summary>
        /// Makes the specified window visible.
        ///</summary>
        ///<param name="window"> [in]  The window to make visible.</param>
        ///<remarks>
        ///  This function makes the specified window visible if it was previously  hidden.  If the window is already visible or is in full screen mode, this  function does nothing.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwHideWindow
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwShowWindow(GLFWwindow *window)
        ///</code>
        // glfwShowWindow: 
        [DllImport(DLL, EntryPoint = "glfwShowWindow", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void ShowWindow(Window window);

        ///<summary>
        /// Hides the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to hide.</param>
        ///<remarks>
        ///  This function hides the specified window if it was previously visible.  If  the window is already hidden or is in full screen mode, this function does  nothing.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwShowWindow
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwHideWindow(GLFWwindow *window)
        ///</code>
        // glfwHideWindow: 
        [DllImport(DLL, EntryPoint = "glfwHideWindow", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void HideWindow(Window window);

        ///<summary>
        /// Brings the specified window to front and sets input focus.
        ///</summary>
        ///<param name="window"> [in]  The window to give input focus.</param>
        ///<remarks>
        ///  This function brings the specified window to front and sets input focus.  The window should already be visible and not iconified.
        ///  By default, both windowed and full screen mode windows are focused when  initially created.  Set the [GLFW_FOCUSED](
        ///  this behavior.
        ///  __Do not use this function__ to steal focus from other applications unless  you are certain that is what the user wants.  Focus stealing can be  extremely disruptive.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///void glfwFocusWindow(GLFWwindow *window)
        ///</code>
        // glfwFocusWindow: 
        [DllImport(DLL, EntryPoint = "glfwFocusWindow", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void FocusWindow(Window window);

        ///<summary>
        /// Returns the monitor that the window uses for full screen mode.
        ///</summary>
        ///<param name="window"> [in]  The window to query.  </param>
        ///<returns>
        /// The monitor, or `NULL` if the window is in windowed mode or an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the handle of the monitor that the specified window is  in full screen on.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// glfwSetWindowMonitor
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWmonitor *glfwGetWindowMonitor(GLFWwindow *window)
        ///</code>
        // glfwGetWindowMonitor: 
        [DllImport(DLL, EntryPoint = "glfwGetWindowMonitor", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern Monitor GetWindowMonitor(Window window);

        ///<summary>
        /// Sets the mode, monitor, video mode and placement of a window.
        ///</summary>
        ///<param name="window"> [in]  The window whose monitor, size or video mode to set.  </param>
        ///<param name="monitor"> [in]  The desired monitor, or `NULL` to set windowed mode.  </param>
        ///<param name="xpos"> [in]  The desired x-coordinate of the upper-left corner of the  client area.  </param>
        ///<param name="ypos"> [in]  The desired y-coordinate of the upper-left corner of the  client area.  </param>
        ///<param name="width"> [in]  The desired with, in screen coordinates, of the client area  or video mode.  </param>
        ///<param name="height"> [in]  The desired height, in screen coordinates, of the client  area or video mode.  </param>
        ///<param name="refreshRate"> [in]  The desired refresh rate, in Hz, of the video mode,  or `GLFW_DONT_CARE`.</param>
        ///<remarks>
        ///  This function sets the monitor that the window uses for full screen mode or,  if the monitor is `NULL`, makes it windowed mode.
        ///  When setting a monitor, this function updates the width, height and refresh  rate of the desired video mode and switches to the video mode closest to it.  The window position is ignored when setting a monitor.
        ///  When the monitor is `NULL`, the position, width and height are used to  place the window client area.  The refresh rate is ignored when no monitor  is specified.
        ///  If you only wish to update the resolution of a full screen window or the  size of a windowed mode window, see 
        ///  When a window transitions from full screen to windowed mode, this function  restores any previous window settings such as whether it is decorated,  floating, resizable, has size or aspect ratio limits, etc..
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwGetWindowMonitor  
        /// glfwSetWindowSize
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///void glfwSetWindowMonitor(GLFWwindow *window, GLFWmonitor *monitor, int xpos,
        ///                          int ypos, int width, int height, int refreshRate)
        ///</code>
        // glfwSetWindowMonitor: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowMonitor", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetWindowMonitor(Window window, Monitor monitor, int xpos, int ypos, int width, int height, int refreshRate);

        ///<summary>
        /// Returns an attribute of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to query.  </param>
        ///<param name="attrib"> [in]  The [window attribute](</param>
        ///<returns>
        /// The value of the attribute, or zero if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the value of an attribute of the specified window or  its OpenGL or OpenGL ES context.
        ///  return.  
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM and 
        /// Framebuffer related hints are not window attributes.  See 
        ///  window_attribs_fb for more information.
        /// Zero is a valid value for many window and context related  attributes so you cannot use a return value of zero as an indication of  errors.  However, this function should not fail as long as it is passed  valid arguments and the library has been [initialized](
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.  Replaces `glfwGetWindowParam` and  `glfwGetGLVersion`.
        ///</remarks>
        ///<code>
        ///int glfwGetWindowAttrib(GLFWwindow *window, int attrib)
        ///</code>
        // glfwGetWindowAttrib: 
        [DllImport(DLL, EntryPoint = "glfwGetWindowAttrib", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern int GetWindowAttrib(Window window, int attrib);

        ///<summary>
        /// Sets the user pointer of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose pointer to set.  </param>
        ///<param name="pointer"> [in]  The new value.</param>
        ///<remarks>
        ///  This function sets the user-defined pointer of the specified window.  The  current value is retained until the window is destroyed.  The initial value  is `NULL`.
        ///   Possible errors include 
        ///  _safety This function may be called from any thread.  Access is not  synchronized.
        /// glfwGetWindowUserPointer
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwSetWindowUserPointer(GLFWwindow *window, void *pointer)
        ///</code>
        // glfwSetWindowUserPointer: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowUserPointer", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetWindowUserPointer(Window window, IntPtr pointer);

        ///<summary>
        /// Returns the user pointer of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose pointer to return.</param>
        ///<remarks>
        ///  This function returns the current value of the user-defined pointer of the  specified window.  The initial value is `NULL`.
        ///   Possible errors include 
        ///  _safety This function may be called from any thread.  Access is not  synchronized.
        /// glfwSetWindowUserPointer
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void *glfwGetWindowUserPointer(GLFWwindow *window)
        ///</code>
        // glfwGetWindowUserPointer: 
        [DllImport(DLL, EntryPoint = "glfwGetWindowUserPointer", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr GetWindowUserPointer(Window window);

        ///<summary>
        /// Sets the position callback for the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the position callback of the specified window, which is  called when the window is moved.  The callback is provided with the screen  position of the upper-left corner of the client area of the window.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWwindowposfun glfwSetWindowPosCallback(GLFWwindow *window,
        ///                                          GLFWwindowposfun cbfun)
        ///</code>
        // glfwSetWindowPosCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowPosCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern WindowposfunDelegate SetWindowPosCallback(Window window, WindowposfunDelegate cbfun);

        ///<summary>
        /// Sets the size callback for the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the size callback of the specified window, which is  called when the window is resized.  The callback is provided with the size,  in screen coordinates, of the client area of the window.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 1.0.   Added window handle parameter and return value.
        ///</remarks>
        ///<code>
        ///GLFWwindowsizefun glfwSetWindowSizeCallback(GLFWwindow *window,
        ///                                            GLFWwindowsizefun cbfun)
        ///</code>
        // glfwSetWindowSizeCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowSizeCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern WindowsizefunDelegate SetWindowSizeCallback(Window window, WindowsizefunDelegate cbfun);

        ///<summary>
        /// Sets the close callback for the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the close callback of the specified window, which is  called when the user attempts to close the window, for example by clicking  the close widget in the title bar.
        ///  The close flag is set before this callback is called, but you can modify it  at any time with 
        ///  The close callback is not triggered by 
        ///   Possible errors include 
        ///  Selecting Quit from the application menu will trigger the close  callback for all windows.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 2.5.   Added window handle parameter and return value.
        ///</remarks>
        ///<code>
        ///GLFWwindowclosefun glfwSetWindowCloseCallback(GLFWwindow *window,
        ///                                              GLFWwindowclosefun cbfun)
        ///</code>
        // glfwSetWindowCloseCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowCloseCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern WindowclosefunDelegate SetWindowCloseCallback(Window window, WindowclosefunDelegate cbfun);

        ///<summary>
        /// Sets the refresh callback for the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the refresh callback of the specified window, which is  called when the client area of the window needs to be redrawn, for example  if the window has been exposed after having been covered by another window.
        ///  On compositing window systems such as Aero, Compiz or Aqua, where the window  contents are saved off-screen, this callback may be called only very  infrequently or never at all.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 2.5.   Added window handle parameter and return value.
        ///</remarks>
        ///<code>
        ///GLFWwindowrefreshfun glfwSetWindowRefreshCallback(GLFWwindow *window,
        ///                                                  GLFWwindowrefreshfun cbfun)
        ///</code>
        // glfwSetWindowRefreshCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowRefreshCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern WindowrefreshfunDelegate SetWindowRefreshCallback(Window window, WindowrefreshfunDelegate cbfun);

        ///<summary>
        /// Sets the focus callback for the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the focus callback of the specified window, which is  called when the window gains or loses input focus.
        ///  After the focus callback is called for a window that lost input focus,  synthetic key and mouse button release events will be generated for all such  that had been pressed.  For more information, see 
        ///  and 
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWwindowfocusfun glfwSetWindowFocusCallback(GLFWwindow *window,
        ///                                              GLFWwindowfocusfun cbfun)
        ///</code>
        // glfwSetWindowFocusCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowFocusCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern WindowfocusfunDelegate SetWindowFocusCallback(Window window, WindowfocusfunDelegate cbfun);

        ///<summary>
        /// Sets the iconify callback for the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the iconification callback of the specified window, which  is called when the window is iconified or restored.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWwindowiconifyfun glfwSetWindowIconifyCallback(GLFWwindow *window,
        ///                                                  GLFWwindowiconifyfun cbfun)
        ///</code>
        // glfwSetWindowIconifyCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetWindowIconifyCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern WindowiconifyfunDelegate SetWindowIconifyCallback(Window window, WindowiconifyfunDelegate cbfun);

        ///<summary>
        /// Sets the framebuffer resize callback for the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the framebuffer resize callback of the specified window,  which is called when the framebuffer of the specified window is resized.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWframebuffersizefun
        ///glfwSetFramebufferSizeCallback(GLFWwindow *window, GLFWframebuffersizefun cbfun)
        ///</code>
        // glfwSetFramebufferSizeCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetFramebufferSizeCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern FramebuffersizefunDelegate SetFramebufferSizeCallback(Window window, FramebuffersizefunDelegate cbfun);

        ///<summary>
        /// Processes all pending events.
        ///</summary>
        ///<remarks>
        ///  This function processes only those events that are already in the event  queue and then returns immediately.  Processing events will cause the window  and input callbacks associated with those events to be called.
        ///  On some platforms, a window move, resize or menu operation will cause event  processing to block.  This is due to how event processing is designed on  those platforms.  You can use the  [window refresh callback](
        ///  your window when necessary during such operations.
        ///  On some platforms, certain events are sent directly to the application  without going through the event queue, causing callbacks to be called  outside of a call to one of the event processing functions.
        ///  Event processing is not required for joystick input to work.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///   This function must not be called from a callback.
        ///  _safety This function must only be called from the main thread.
        /// glfwWaitEvents  
        /// glfwWaitEventsTimeout
        /// Added in version 1.0.
        ///</remarks>
        ///<code>
        ///void glfwPollEvents()
        ///</code>
        // glfwPollEvents: 
        [DllImport(DLL, EntryPoint = "glfwPollEvents", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void PollEvents();

        ///<summary>
        /// Waits until events are queued and processes them.
        ///</summary>
        ///<remarks>
        ///  This function puts the calling thread to sleep until at least one event is  available in the event queue.  Once one or more events are available,  it behaves exactly like 
        ///  are processed and the function then returns immediately.  Processing events  will cause the window and input callbacks associated with those events to be  called.
        ///  Since not all events are associated with callbacks, this function may return  without a callback having been called even if you are monitoring all  callbacks.
        ///  On some platforms, a window move, resize or menu operation will cause event  processing to block.  This is due to how event processing is designed on  those platforms.  You can use the  [window refresh callback](
        ///  your window when necessary during such operations.
        ///  On some platforms, certain callbacks may be called outside of a call to one  of the event processing functions.
        ///  If no windows exist, this function returns immediately.  For synchronization  of threads in applications that do not create windows, use your threading  library of choice.
        ///  Event processing is not required for joystick input to work.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///   This function must not be called from a callback.
        ///  _safety This function must only be called from the main thread.
        /// glfwPollEvents  
        /// glfwWaitEventsTimeout
        /// Added in version 2.5.
        ///</remarks>
        ///<code>
        ///void glfwWaitEvents()
        ///</code>
        // glfwWaitEvents: 
        [DllImport(DLL, EntryPoint = "glfwWaitEvents", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void WaitEvents();

        ///<summary>
        /// Waits with timeout until events are queued and processes them.
        ///</summary>
        ///<param name="timeout"> [in]  The maximum amount of time, in seconds, to wait.</param>
        ///<remarks>
        ///  This function puts the calling thread to sleep until at least one event is  available in the event queue, or until the specified timeout is reached.  If  one or more events are available, it behaves exactly like 
        ///  glfwPollEvents, i.e. the events in the queue are processed and the function  then returns immediately.  Processing events will cause the window and input  callbacks associated with those events to be called.
        ///  The timeout value must be a positive finite number.
        ///  Since not all events are associated with callbacks, this function may return  without a callback having been called even if you are monitoring all  callbacks.
        ///  On some platforms, a window move, resize or menu operation will cause event  processing to block.  This is due to how event processing is designed on  those platforms.  You can use the  [window refresh callback](
        ///  your window when necessary during such operations.
        ///  On some platforms, certain callbacks may be called outside of a call to one  of the event processing functions.
        ///  If no windows exist, this function returns immediately.  For synchronization  of threads in applications that do not create windows, use your threading  library of choice.
        ///  Event processing is not required for joystick input to work.
        ///   This function must not be called from a callback.
        ///  _safety This function must only be called from the main thread.
        /// glfwPollEvents  
        /// glfwWaitEvents
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///void glfwWaitEventsTimeout(double timeout)
        ///</code>
        // glfwWaitEventsTimeout: 
        [DllImport(DLL, EntryPoint = "glfwWaitEventsTimeout", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void WaitEventsTimeout(double timeout);

        ///<summary>
        /// Posts an empty event to the event queue.
        ///</summary>
        ///<remarks>
        ///  This function posts an empty event from the current thread to the event  queue, causing 
        ///  If no windows exist, this function returns immediately.  For synchronization  of threads in applications that do not create windows, use your threading  library of choice.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function may be called from any thread.
        /// glfwWaitEvents  
        /// glfwWaitEventsTimeout
        /// Added in version 3.1.
        ///</remarks>
        ///<code>
        ///void glfwPostEmptyEvent()
        ///</code>
        // glfwPostEmptyEvent: 
        [DllImport(DLL, EntryPoint = "glfwPostEmptyEvent", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void PostEmptyEvent();

        ///<summary>
        /// Returns the value of an input option for the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window to query.  </param>
        ///<param name="mode"> [in]  One of `GLFW_CURSOR`, `GLFW_STICKY_KEYS` or  `GLFW_STICKY_MOUSE_BUTTONS`.</param>
        ///<remarks>
        ///  This function returns the value of an input option for the specified window.  The mode must be one of `GLFW_CURSOR`, `GLFW_STICKY_KEYS` or  `GLFW_STICKY_MOUSE_BUTTONS`.
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM.
        ///  _safety This function must only be called from the main thread.
        /// glfwSetInputMode
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///int glfwGetInputMode(GLFWwindow *window, int mode)
        ///</code>
        // glfwGetInputMode: 
        [DllImport(DLL, EntryPoint = "glfwGetInputMode", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern int GetInputMode(Window window, int mode);

        ///<summary>
        /// Sets an input option for the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose input mode to set.  </param>
        ///<param name="mode"> [in]  One of `GLFW_CURSOR`, `GLFW_STICKY_KEYS` or  `GLFW_STICKY_MOUSE_BUTTONS`.  </param>
        ///<param name="value"> [in]  The new value of the specified input mode.</param>
        ///<remarks>
        ///  This function sets an input mode option for the specified window.  The mode  must be one of `GLFW_CURSOR`, `GLFW_STICKY_KEYS` or  `GLFW_STICKY_MOUSE_BUTTONS`.
        ///  If the mode is `GLFW_CURSOR`, the value must be one of the following cursor  modes:  - `GLFW_CURSOR_NORMAL` makes the cursor visible and behaving normally.  - `GLFW_CURSOR_HIDDEN` makes the cursor invisible when it is over the client    area of the window but does not restrict the cursor from leaving.  - `GLFW_CURSOR_DISABLED` hides and grabs the cursor, providing virtual    and unlimited cursor movement.  This is useful for implementing for    example 3D camera controls.
        ///  If the mode is `GLFW_STICKY_KEYS`, the value must be either `GLFW_TRUE` to  enable sticky keys, or `GLFW_FALSE` to disable it.  If sticky keys are  enabled, a key press will ensure that 
        ///  the next time it is called even if the key had been released before the  call.  This is useful when you are only interested in whether keys have been  pressed but not when or in which order.
        ///  If the mode is `GLFW_STICKY_MOUSE_BUTTONS`, the value must be either  `GLFW_TRUE` to enable sticky mouse buttons, or `GLFW_FALSE` to disable it.  If sticky mouse buttons are enabled, a mouse button press will ensure that  
        ///  if the mouse button had been released before the call.  This is useful when  you are only interested in whether mouse buttons have been pressed but not  when or in which order.
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM and 
        ///  _safety This function must only be called from the main thread.
        /// glfwGetInputMode
        /// Added in version 3.0.  Replaces `glfwEnable` and `glfwDisable`.
        ///</remarks>
        ///<code>
        ///void glfwSetInputMode(GLFWwindow *window, int mode, int value)
        ///</code>
        // glfwSetInputMode: 
        [DllImport(DLL, EntryPoint = "glfwSetInputMode", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetInputMode(Window window, int mode, int @value);

        ///<summary>
        /// Returns the localized name of the specified printable key.
        ///</summary>
        ///<param name="key"> [in]  The key to query, or `GLFW_KEY_UNKNOWN`.  </param>
        ///<param name="scancode"> [in]  The scancode of the key to query.  </param>
        ///<returns>
        /// The localized name of the key, or `NULL`.
        ///</returns>
        ///<remarks>
        ///  This function returns the localized name of the specified printable key.  This is intended for displaying key bindings to the user.
        ///  If the key is `GLFW_KEY_UNKNOWN`, the scancode is used instead, otherwise  the scancode is ignored.  If a non-printable key or (if the key is  `GLFW_KEY_UNKNOWN`) a scancode that maps to a non-printable key is  specified, this function returns `NULL`.          
        ///  This behavior allows you to pass in the arguments passed to the  [key callback](
        ///  The printable keys are:  - `GLFW_KEY_APOSTROPHE`  - `GLFW_KEY_COMMA`  - `GLFW_KEY_MINUS`  - `GLFW_KEY_PERIOD`  - `GLFW_KEY_SLASH`  - `GLFW_KEY_SEMICOLON`  - `GLFW_KEY_EQUAL`  - `GLFW_KEY_LEFT_BRACKET`  - `GLFW_KEY_RIGHT_BRACKET`  - `GLFW_KEY_BACKSLASH`  - `GLFW_KEY_WORLD_1`  - `GLFW_KEY_WORLD_2`  - `GLFW_KEY_0` to `GLFW_KEY_9`  - `GLFW_KEY_A` to `GLFW_KEY_Z`  - `GLFW_KEY_KP_0` to `GLFW_KEY_KP_9`  - `GLFW_KEY_KP_DECIMAL`  - `GLFW_KEY_KP_DIVIDE`  - `GLFW_KEY_KP_MULTIPLY`  - `GLFW_KEY_KP_SUBTRACT`  - `GLFW_KEY_KP_ADD`  - `GLFW_KEY_KP_EQUAL`
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _lifetime The returned string is allocated and freed by GLFW.  You  should not free it yourself.  It is valid until the next call to 
        ///  glfwGetKeyName, or until the library is terminated.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///const char *glfwGetKeyName(int key, int scancode)
        ///</code>
        // glfwGetKeyName: 
        [DllImport(DLL, EntryPoint = "glfwGetKeyName", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern CharPtr GetKeyName(Keyboard key, int scancode);

        ///<summary>
        /// Returns the last reported state of a keyboard key for the specified  window.
        ///</summary>
        ///<param name="window"> [in]  The desired window.  </param>
        ///<param name="key"> [in]  The desired [keyboard key](</param>
        ///<returns>
        /// One of `GLFW_PRESS` or `GLFW_RELEASE`.
        ///</returns>
        ///<remarks>
        ///  This function returns the last state reported for the specified key to the  specified window.  The returned state is one of `GLFW_PRESS` or  `GLFW_RELEASE`.  The higher-level action `GLFW_REPEAT` is only reported to  the key callback.
        ///  If the `GLFW_STICKY_KEYS` input mode is enabled, this function returns  `GLFW_PRESS` the first time you call it for a key that was pressed, even if  that key has already been released.
        ///  The key functions deal with physical keys, with [key tokens](
        ///  named after their use on the standard US keyboard layout.  If you want to  input text, use the Unicode character callback instead.
        ///  The [modifier key bit masks](
        ///  used with this function.
        ///  __Do not use this function__ to implement [text input](
        ///  not a valid key for this function.  
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 1.0.   Added window handle parameter.
        ///</remarks>
        ///<code>
        ///int glfwGetKey(GLFWwindow *window, int key)
        ///</code>
        // glfwGetKey: 
        [DllImport(DLL, EntryPoint = "glfwGetKey", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern int GetKey(Window window, Keyboard key);

        ///<summary>
        /// Returns the last reported state of a mouse button for the specified  window.
        ///</summary>
        ///<param name="window"> [in]  The desired window.  </param>
        ///<param name="button"> [in]  The desired [mouse button](</param>
        ///<returns>
        /// One of `GLFW_PRESS` or `GLFW_RELEASE`.
        ///</returns>
        ///<remarks>
        ///  This function returns the last state reported for the specified mouse button  to the specified window.  The returned state is one of `GLFW_PRESS` or  `GLFW_RELEASE`.
        ///  If the `GLFW_STICKY_MOUSE_BUTTONS` input mode is enabled, this function  `GLFW_PRESS` the first time you call it for a mouse button that was pressed,  even if that mouse button has already been released.
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 1.0.   Added window handle parameter.
        ///</remarks>
        ///<code>
        ///int glfwGetMouseButton(GLFWwindow *window, int button)
        ///</code>
        // glfwGetMouseButton: 
        [DllImport(DLL, EntryPoint = "glfwGetMouseButton", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern int GetMouseButton(Window window, int button);

        ///<summary>
        /// Retrieves the position of the cursor relative to the client area of  the window.
        ///</summary>
        ///<param name="window"> [in]  The desired window.  </param>
        ///<param name="xpos"> [out]  Where to store the cursor x-coordinate, relative to the  left edge of the client area, or `NULL`.  </param>
        ///<param name="ypos"> [out]  Where to store the cursor y-coordinate, relative to the to  top edge of the client area, or `NULL`.</param>
        ///<remarks>
        ///  This function returns the position of the cursor, in screen coordinates,  relative to the upper-left corner of the client area of the specified  window.
        ///  If the cursor is disabled (with `GLFW_CURSOR_DISABLED`) then the cursor  position is unbounded and limited only by the minimum and maximum values of  a `double`.
        ///  The coordinate can be converted to their integer equivalents with the  `floor` function.  Casting directly to an integer type works for positive  coordinates, but fails for negative ones.
        ///  Any or all of the position arguments may be `NULL`.  If an error occurs, all  non-`NULL` position arguments will be set to zero.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwSetCursorPos
        /// Added in version 3.0.  Replaces `glfwGetMousePos`.
        ///</remarks>
        ///<code>
        ///void glfwGetCursorPos(GLFWwindow *window, double *xpos, double *ypos)
        ///</code>
        // glfwGetCursorPos: 
        [DllImport(DLL, EntryPoint = "glfwGetCursorPos", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void GetCursorPos(Window window, out double xpos, out double ypos);

        ///<summary>
        /// Sets the position of the cursor, relative to the client area of the  window.
        ///</summary>
        ///<param name="window"> [in]  The desired window.  </param>
        ///<param name="xpos"> [in]  The desired x-coordinate, relative to the left edge of the  client area.  </param>
        ///<param name="ypos"> [in]  The desired y-coordinate, relative to the top edge of the  client area.</param>
        ///<remarks>
        ///  This function sets the position, in screen coordinates, of the cursor  relative to the upper-left corner of the client area of the specified  window.  The window must have input focus.  If the window does not have  input focus when this function is called, it fails silently.
        ///  __Do not use this function__ to implement things like camera controls.  GLFW  already provides the `GLFW_CURSOR_DISABLED` cursor mode that hides the  cursor, transparently re-centers it and provides unconstrained cursor  motion.  See 
        ///  If the cursor mode is `GLFW_CURSOR_DISABLED` then the cursor position is  unconstrained and limited only by the minimum and maximum values of  a `double`.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// glfwGetCursorPos
        /// Added in version 3.0.  Replaces `glfwSetMousePos`.
        ///</remarks>
        ///<code>
        ///void glfwSetCursorPos(GLFWwindow *window, double xpos, double ypos)
        ///</code>
        // glfwSetCursorPos: 
        [DllImport(DLL, EntryPoint = "glfwSetCursorPos", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetCursorPos(Window window, double xpos, double ypos);

        ///<summary>
        /// Creates a custom cursor.
        ///</summary>
        ///<param name="image"> [in]  The desired cursor image.  </param>
        ///<param name="xhot"> [in]  The desired x-coordinate, in pixels, of the cursor hotspot.  </param>
        ///<param name="yhot"> [in]  The desired y-coordinate, in pixels, of the cursor hotspot.  </param>
        ///<returns>
        /// The handle of the created cursor, or `NULL` if an  [error](
        ///</returns>
        ///<remarks>
        ///  Creates a new custom cursor image that can be set for a window with 
        ///  glfwSetCursor.  The cursor can be destroyed with 
        ///  Any remaining cursors are destroyed by 
        ///  The pixels are 32-bit, little-endian, non-premultiplied RGBA, i.e. eight  bits per channel.  They are arranged canonically as packed sequential rows,  starting from the top-left corner.
        ///  The cursor hotspot is specified in pixels, relative to the upper-left corner  of the cursor image.  Like all other coordinate systems in GLFW, the X-axis  points to the right and the Y-axis points down.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _lifetime The specified image data is copied before this function  returns.
        ///   This function must not be called from a callback.
        ///  _safety This function must only be called from the main thread.
        /// glfwDestroyCursor  
        /// glfwCreateStandardCursor
        /// Added in version 3.1.
        ///</remarks>
        ///<code>
        ///GLFWcursor *glfwCreateCursor(const GLFWimage *image, int xhot, int yhot)
        ///</code>
        // glfwCreateCursor: 
        [DllImport(DLL, EntryPoint = "glfwCreateCursor", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern Cursor CreateCursor(out Image image, int xhot, int yhot);

        ///<summary>
        /// Creates a cursor with a standard shape.
        ///</summary>
        ///<param name="shape"> [in]  One of the [standard shapes](</param>
        ///<returns>
        /// A new cursor ready to use or `NULL` if an  [error](
        ///</returns>
        ///<remarks>
        ///  Returns a cursor with a [standard shape](
        ///  a window with 
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM and 
        ///   This function must not be called from a callback.
        ///  _safety This function must only be called from the main thread.
        /// glfwCreateCursor
        /// Added in version 3.1.
        ///</remarks>
        ///<code>
        ///GLFWcursor *glfwCreateStandardCursor(int shape)
        ///</code>
        // glfwCreateStandardCursor: 
        [DllImport(DLL, EntryPoint = "glfwCreateStandardCursor", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern Cursor CreateStandardCursor(SystemCursors shape);

        ///<summary>
        /// Destroys a cursor.
        ///</summary>
        ///<param name="cursor"> [in]  The cursor object to destroy.</param>
        ///<remarks>
        ///  This function destroys a cursor previously created with 
        ///  glfwCreateCursor.  Any remaining cursors will be destroyed by 
        ///  glfwTerminate.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///   This function must not be called from a callback.
        ///  _safety This function must only be called from the main thread.
        /// glfwCreateCursor
        /// Added in version 3.1.
        ///</remarks>
        ///<code>
        ///void glfwDestroyCursor(GLFWcursor *cursor)
        ///</code>
        // glfwDestroyCursor: 
        [DllImport(DLL, EntryPoint = "glfwDestroyCursor", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void DestroyCursor(Cursor cursor);

        ///<summary>
        /// Sets the cursor for the window.
        ///</summary>
        ///<param name="window"> [in]  The window to set the cursor for.  </param>
        ///<param name="cursor"> [in]  The cursor to set, or `NULL` to switch back to the default  arrow cursor.</param>
        ///<remarks>
        ///  This function sets the cursor image to be used when the cursor is over the  client area of the specified window.  The set cursor will only be visible  when the [cursor mode](
        ///  `GLFW_CURSOR_NORMAL`.
        ///  On some platforms, the set cursor may not be visible unless the window also  has input focus.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.1.
        ///</remarks>
        ///<code>
        ///void glfwSetCursor(GLFWwindow *window, GLFWcursor *cursor)
        ///</code>
        // glfwSetCursor: 
        [DllImport(DLL, EntryPoint = "glfwSetCursor", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetCursor(Window window, Cursor cursor);

        ///<summary>
        /// Sets the key callback.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new key callback, or `NULL` to remove the currently  set callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the key callback of the specified window, which is called  when a key is pressed, repeated or released.
        ///  The key functions deal with physical keys, with layout independent  [key tokens](
        ///  layout.  If you want to input text, use the  [character callback](
        ///  When a window loses input focus, it will generate synthetic key release  events for all pressed keys.  You can tell these events from user-generated  events by the fact that the synthetic ones are generated after the focus  loss event has been processed, i.e. after the  [window focus callback](
        ///  The scancode of a key is specific to that platform or sometimes even to that  machine.  Scancodes are intended to allow users to bind keys that don't have  a GLFW key token.  Such keys have `key` set to `GLFW_KEY_UNKNOWN`, their  state is not saved and so it cannot be queried with 
        ///  Sometimes GLFW needs to generate synthetic key events, in which case the  scancode may be zero.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 1.0.   Added window handle parameter and return value.
        ///</remarks>
        ///<code>
        ///GLFWkeyfun glfwSetKeyCallback(GLFWwindow *window, GLFWkeyfun cbfun)
        ///</code>
        // glfwSetKeyCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetKeyCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern KeyfunDelegate SetKeyCallback(Window window, KeyfunDelegate cbfun);

        ///<summary>
        /// Sets the Unicode character callback.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the character callback of the specified window, which is  called when a Unicode character is input.
        ///  The character callback is intended for Unicode text input.  As it deals with  characters, it is keyboard layout dependent, whereas the  [key callback](
        ///  to physical keys, as a key may produce zero, one or more characters.  If you  want to know whether a specific physical key was pressed or released, see  the key callback instead.
        ///  The character callback behaves as system text input normally does and will  not be called if modifier keys are held down that would prevent normal text  input on that platform, for example a Super (Command) key on OS X or Alt key  on Windows.  There is a  [character with modifiers callback](
        ///  receives these events.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 2.4.   Added window handle parameter and return value.
        ///</remarks>
        ///<code>
        ///GLFWcharfun glfwSetCharCallback(GLFWwindow *window, GLFWcharfun cbfun)
        ///</code>
        // glfwSetCharCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetCharCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern CharfunDelegate SetCharCallback(Window window, CharfunDelegate cbfun);

        ///<summary>
        /// Sets the Unicode character with modifiers callback.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or an  [error](
        ///</returns>
        ///<remarks>
        ///  This function sets the character with modifiers callback of the specified  window, which is called when a Unicode character is input regardless of what  modifier keys are used.
        ///  The character with modifiers callback is intended for implementing custom  Unicode character input.  For regular Unicode text input, see the  [character callback](
        ///  callback, the character with modifiers callback deals with characters and is  keyboard layout dependent.  Characters do not map 1:1 to physical keys, as  a key may produce zero, one or more characters.  If you want to know whether  a specific physical key was pressed or released, see the  [key callback](
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.1.
        ///</remarks>
        ///<code>
        ///GLFWcharmodsfun glfwSetCharModsCallback(GLFWwindow *window,
        ///                                        GLFWcharmodsfun cbfun)
        ///</code>
        // glfwSetCharModsCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetCharModsCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern CharmodsfunDelegate SetCharModsCallback(Window window, CharmodsfunDelegate cbfun);

        ///<summary>
        /// Sets the mouse button callback.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the mouse button callback of the specified window, which  is called when a mouse button is pressed or released.
        ///  When a window loses input focus, it will generate synthetic mouse button  release events for all pressed mouse buttons.  You can tell these events  from user-generated events by the fact that the synthetic ones are generated  after the focus loss event has been processed, i.e. after the  [window focus callback](
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 1.0.   Added window handle parameter and return value.
        ///</remarks>
        ///<code>
        ///GLFWmousebuttonfun glfwSetMouseButtonCallback(GLFWwindow *window,
        ///                                              GLFWmousebuttonfun cbfun)
        ///</code>
        // glfwSetMouseButtonCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetMouseButtonCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern MousebuttonfunDelegate SetMouseButtonCallback(Window window, MousebuttonfunDelegate cbfun);

        ///<summary>
        /// Sets the cursor position callback.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the cursor position callback of the specified window,  which is called when the cursor is moved.  The callback is provided with the  position, in screen coordinates, relative to the upper-left corner of the  client area of the window.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.  Replaces `glfwSetMousePosCallback`.
        ///</remarks>
        ///<code>
        ///GLFWcursorposfun glfwSetCursorPosCallback(GLFWwindow *window,
        ///                                          GLFWcursorposfun cbfun)
        ///</code>
        // glfwSetCursorPosCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetCursorPosCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern CursorposfunDelegate SetCursorPosCallback(Window window, CursorposfunDelegate cbfun);

        ///<summary>
        /// Sets the cursor enter/exit callback.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the cursor boundary crossing callback of the specified  window, which is called when the cursor enters or leaves the client area of  the window.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWcursorenterfun glfwSetCursorEnterCallback(GLFWwindow *window,
        ///                                              GLFWcursorenterfun cbfun)
        ///</code>
        // glfwSetCursorEnterCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetCursorEnterCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern CursorenterfunDelegate SetCursorEnterCallback(Window window, CursorenterfunDelegate cbfun);

        ///<summary>
        /// Sets the scroll callback.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new scroll callback, or `NULL` to remove the currently  set callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the scroll callback of the specified window, which is  called when a scrolling device is used, such as a mouse wheel or scrolling  area of a touchpad.
        ///  The scroll callback receives all scrolling input, like that from a mouse  wheel or a touchpad scrolling area.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.  Replaces `glfwSetMouseWheelCallback`.
        ///</remarks>
        ///<code>
        ///GLFWscrollfun glfwSetScrollCallback(GLFWwindow *window, GLFWscrollfun cbfun)
        ///</code>
        // glfwSetScrollCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetScrollCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ScrollfunDelegate SetScrollCallback(Window window, ScrollfunDelegate cbfun);

        ///<summary>
        /// Sets the file drop callback.
        ///</summary>
        ///<param name="window"> [in]  The window whose callback to set.  </param>
        ///<param name="cbfun"> [in]  The new file drop callback, or `NULL` to remove the  currently set callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the file drop callback of the specified window, which is  called when one or more dragged files are dropped on the window.
        ///  Because the path array and its strings may have been generated specifically  for that event, they are not guaranteed to be valid after the callback has  returned.  If you wish to use them after the callback returns, you need to  make a deep copy.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.1.
        ///</remarks>
        ///<code>
        ///GLFWdropfun glfwSetDropCallback(GLFWwindow *window, GLFWdropfun cbfun)
        ///</code>
        // glfwSetDropCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetDropCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern DropfunDelegate SetDropCallback(Window window, DropfunDelegate cbfun);

        ///<summary>
        /// Returns whether the specified joystick is present.
        ///</summary>
        ///<param name="joy"> [in]  The [joystick](</param>
        ///<returns>
        /// `GLFW_TRUE` if the joystick is present, or `GLFW_FALSE` otherwise.
        ///</returns>
        ///<remarks>
        ///  This function returns whether the specified joystick is present.
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM and 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.  Replaces `glfwGetJoystickParam`.
        ///</remarks>
        ///<code>
        ///int glfwJoystickPresent(int joy)
        ///</code>
        // glfwJoystickPresent: 
        [DllImport(DLL, EntryPoint = "glfwJoystickPresent", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern int JoystickPresent(Joystick joy);

        ///<summary>
        /// Returns the values of all axes of the specified joystick.
        ///</summary>
        ///<param name="joy"> [in]  The [joystick](</param>
        ///<param name="count"> [out]  Where to store the number of axis values in the returned  array.  This is set to zero if the joystick is not present or an error  occurred.  </param>
        ///<returns>
        /// An array of axis values, or `NULL` if the joystick is not present or  an [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the values of all axes of the specified joystick.  Each element in the array is a value between -1.0 and 1.0.
        ///  Querying a joystick slot with no device present is not an error, but will  cause this function to return `NULL`.  Call 
        ///  check device presence.
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM and 
        ///  _lifetime The returned array is allocated and freed by GLFW.  You  should not free it yourself.  It is valid until the specified joystick is  disconnected, this function is called again for that joystick or the library  is terminated.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.  Replaces `glfwGetJoystickPos`.
        ///</remarks>
        ///<code>
        ///const float *glfwGetJoystickAxes(int joy, int *count)
        ///</code>
        // glfwGetJoystickAxes: 
        [DllImport(DLL, EntryPoint = "glfwGetJoystickAxes", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ref float GetJoystickAxes(Joystick joy, out int count);

        ///<summary>
        /// Returns the state of all buttons of the specified joystick.
        ///</summary>
        ///<param name="joy"> [in]  The [joystick](</param>
        ///<param name="count"> [out]  Where to store the number of button states in the returned  array.  This is set to zero if the joystick is not present or an error  occurred.  </param>
        ///<returns>
        /// An array of button states, or `NULL` if the joystick is not present  or an [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the state of all buttons of the specified joystick.  Each element in the array is either `GLFW_PRESS` or `GLFW_RELEASE`.
        ///  Querying a joystick slot with no device present is not an error, but will  cause this function to return `NULL`.  Call 
        ///  check device presence.
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM and 
        ///  _lifetime The returned array is allocated and freed by GLFW.  You  should not free it yourself.  It is valid until the specified joystick is  disconnected, this function is called again for that joystick or the library  is terminated.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 2.2.   Changed to return a dynamic array.
        ///</remarks>
        ///<code>
        ///const unsigned char *glfwGetJoystickButtons(int joy, int *count)
        ///</code>
        // glfwGetJoystickButtons: 
        [DllImport(DLL, EntryPoint = "glfwGetJoystickButtons", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ref byte GetJoystickButtons(Joystick joy, out int count);

        ///<summary>
        /// Returns the name of the specified joystick.
        ///</summary>
        ///<param name="joy"> [in]  The [joystick](</param>
        ///<returns>
        /// The UTF-8 encoded name of the joystick, or `NULL` if the joystick  is not present or an [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the name, encoded as UTF-8, of the specified joystick.  The returned string is allocated and freed by GLFW.  You should not free it  yourself.
        ///  Querying a joystick slot with no device present is not an error, but will  cause this function to return `NULL`.  Call 
        ///  check device presence.
        ///   Possible errors include 
        ///  GLFW_INVALID_ENUM and 
        ///  _lifetime The returned string is allocated and freed by GLFW.  You  should not free it yourself.  It is valid until the specified joystick is  disconnected, this function is called again for that joystick or the library  is terminated.
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///const char *glfwGetJoystickName(int joy)
        ///</code>
        // glfwGetJoystickName: 
        [DllImport(DLL, EntryPoint = "glfwGetJoystickName", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern CharPtr GetJoystickName(Joystick joy);

        ///<summary>
        /// Sets the joystick configuration callback.
        ///</summary>
        ///<param name="cbfun"> [in]  The new callback, or `NULL` to remove the currently set  callback.  </param>
        ///<returns>
        /// The previously set callback, or `NULL` if no callback was set or the  library had not been [initialized](
        ///</returns>
        ///<remarks>
        ///  This function sets the joystick configuration callback, or removes the  currently set callback.  This is called when a joystick is connected to or  disconnected from the system.
        ///   Possible errors include 
        ///  _safety This function must only be called from the main thread.
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun cbfun)
        ///</code>
        // glfwSetJoystickCallback: 
        [DllImport(DLL, EntryPoint = "glfwSetJoystickCallback", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern JoystickfunDelegate SetJoystickCallback(JoystickfunDelegate cbfun);

        ///<summary>
        /// Sets the clipboard to the specified string.
        ///</summary>
        ///<param name="window"> [in]  The window that will own the clipboard contents.  </param>
        ///<param name="string"> [in]  A UTF-8 encoded string.</param>
        ///<remarks>
        ///  This function sets the system clipboard to the specified, UTF-8 encoded  string.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _lifetime The specified string is copied before this function  returns.
        ///  _safety This function must only be called from the main thread.
        /// glfwGetClipboardString
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwSetClipboardString(GLFWwindow *window, const char *string)
        ///</code>
        // glfwSetClipboardString: 
        [DllImport(DLL, EntryPoint = "glfwSetClipboardString", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetClipboardString(Window window, CharPtr @string);

        ///<summary>
        /// Returns the contents of the clipboard as a string.
        ///</summary>
        ///<param name="window"> [in]  The window that will request the clipboard contents.  </param>
        ///<returns>
        /// The contents of the clipboard as a UTF-8 encoded string, or `NULL`  if an [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the contents of the system clipboard, if it contains  or is convertible to a UTF-8 encoded string.  If the clipboard is empty or  if its contents cannot be converted, `NULL` is returned and a 
        ///  GLFW_FORMAT_UNAVAILABLE error is generated.
        ///   Possible errors include 
        ///  GLFW_PLATFORM_ERROR.
        ///  _lifetime The returned string is allocated and freed by GLFW.  You  should not free it yourself.  It is valid until the next call to 
        ///  glfwGetClipboardString or 
        ///  is terminated.
        ///  _safety This function must only be called from the main thread.
        /// glfwSetClipboardString
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///const char *glfwGetClipboardString(GLFWwindow *window)
        ///</code>
        // glfwGetClipboardString: 
        [DllImport(DLL, EntryPoint = "glfwGetClipboardString", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern CharPtr GetClipboardString(Window window);

        ///<summary>
        /// Returns the value of the GLFW timer.
        ///</summary>
        ///<returns>
        /// The current value, in seconds, or zero if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the value of the GLFW timer.  Unless the timer has  been set using 
        ///  was initialized.
        ///  The resolution of the timer is system dependent, but is usually on the order  of a few micro- or nanoseconds.  It uses the highest-resolution monotonic  time source on each supported platform.
        ///   Possible errors include 
        ///  _safety This function may be called from any thread.  Reading and  writing of the internal timer offset is not atomic, so it needs to be  externally synchronized with calls to 
        /// Added in version 1.0.
        ///</remarks>
        ///<code>
        ///double glfwGetTime()
        ///</code>
        // glfwGetTime: 
        [DllImport(DLL, EntryPoint = "glfwGetTime", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern double GetTime();

        ///<summary>
        /// Sets the GLFW timer.
        ///</summary>
        ///<param name="time"> [in]  The new value, in seconds.</param>
        ///<remarks>
        ///  This function sets the value of the GLFW timer.  It then continues to count  up from that value.  The value must be a positive finite number less than  or equal to 18446744073.0, which is approximately 584.5 years.
        ///   Possible errors include 
        ///  GLFW_INVALID_VALUE.
        /// The upper limit of the timer is calculated as  floor((2<sup>64</sup> - 1) / 10<sup>9</sup>) and is due to implementations  storing nanoseconds in 64 bits.  The limit may be increased in the future.
        ///  _safety This function may be called from any thread.  Reading and  writing of the internal timer offset is not atomic, so it needs to be  externally synchronized with calls to 
        /// Added in version 2.2.
        ///</remarks>
        ///<code>
        ///void glfwSetTime(double time)
        ///</code>
        // glfwSetTime: 
        [DllImport(DLL, EntryPoint = "glfwSetTime", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SetTime(double time);

        ///<summary>
        /// Returns the current value of the raw timer.
        ///</summary>
        ///<returns>
        /// The value of the timer, or zero if an   [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the current value of the raw timer, measured in  1 / frequency seconds.  To get the frequency, call 
        ///  glfwGetTimerFrequency.
        ///   Possible errors include 
        ///  _safety This function may be called from any thread.
        /// glfwGetTimerFrequency
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///uint64_t glfwGetTimerValue()
        ///</code>
        // glfwGetTimerValue: 
        [DllImport(DLL, EntryPoint = "glfwGetTimerValue", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ulong GetTimerValue();

        ///<summary>
        /// Returns the frequency, in Hz, of the raw timer.
        ///</summary>
        ///<returns>
        /// The frequency of the timer, in Hz, or zero if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the frequency, in Hz, of the raw timer.
        ///   Possible errors include 
        ///  _safety This function may be called from any thread.
        /// glfwGetTimerValue
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///uint64_t glfwGetTimerFrequency()
        ///</code>
        // glfwGetTimerFrequency: 
        [DllImport(DLL, EntryPoint = "glfwGetTimerFrequency", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ulong GetTimerFrequency();

        ///<summary>
        /// Makes the context of the specified window current for the calling  thread.
        ///</summary>
        ///<param name="window"> [in]  The window whose context to make current, or `NULL` to  detach the current context.</param>
        ///<remarks>
        ///  This function makes the OpenGL or OpenGL ES context of the specified window  current on the calling thread.  A context can only be made current on  a single thread at a time and each thread can have only a single current  context at a time.
        ///  By default, making a context non-current implicitly forces a pipeline flush.  On machines that support `GL_KHR_context_flush_control`, you can control  whether a context performs this flush by setting the  [GLFW_CONTEXT_RELEASE_BEHAVIOR](
        ///  The specified window must have an OpenGL or OpenGL ES context.  Specifying  a window without a context will generate a 
        ///  error.
        ///   Possible errors include 
        ///  GLFW_NO_WINDOW_CONTEXT and 
        ///  _safety This function may be called from any thread.
        /// glfwGetCurrentContext
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///void glfwMakeContextCurrent(GLFWwindow *window)
        ///</code>
        // glfwMakeContextCurrent: 
        [DllImport(DLL, EntryPoint = "glfwMakeContextCurrent", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void MakeContextCurrent(Window window);

        ///<summary>
        /// Returns the window whose context is current on the calling thread.
        ///</summary>
        ///<returns>
        /// The window whose context is current, or `NULL` if no window's  context is current.
        ///</returns>
        ///<remarks>
        ///  This function returns the window whose OpenGL or OpenGL ES context is  current on the calling thread.
        ///   Possible errors include 
        ///  _safety This function may be called from any thread.
        /// glfwMakeContextCurrent
        /// Added in version 3.0.
        ///</remarks>
        ///<code>
        ///GLFWwindow *glfwGetCurrentContext()
        ///</code>
        // glfwGetCurrentContext: 
        [DllImport(DLL, EntryPoint = "glfwGetCurrentContext", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern Window GetCurrentContext();

        ///<summary>
        /// Swaps the front and back buffers of the specified window.
        ///</summary>
        ///<param name="window"> [in]  The window whose buffers to swap.</param>
        ///<remarks>
        ///  This function swaps the front and back buffers of the specified window when  rendering with OpenGL or OpenGL ES.  If the swap interval is greater than  zero, the GPU driver waits the specified number of screen updates before  swapping the buffers.
        ///  The specified window must have an OpenGL or OpenGL ES context.  Specifying  a window without a context will generate a 
        ///  error.
        ///  This function does not apply to Vulkan.  If you are rendering with Vulkan,  see `vkQueuePresentKHR` instead.
        ///   Possible errors include 
        ///  GLFW_NO_WINDOW_CONTEXT and 
        /// __EGL:__ The context of the specified window must be current on the  calling thread.
        ///  _safety This function may be called from any thread.
        /// glfwSwapInterval
        /// Added in version 1.0.   Added window handle parameter.
        ///</remarks>
        ///<code>
        ///void glfwSwapBuffers(GLFWwindow *window)
        ///</code>
        // glfwSwapBuffers: 
        [DllImport(DLL, EntryPoint = "glfwSwapBuffers", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SwapBuffers(Window window);

        ///<summary>
        /// Sets the swap interval for the current context.
        ///</summary>
        ///<param name="interval"> [in]  The minimum number of screen updates to wait for  until the buffers are swapped by </param>
        ///<remarks>
        ///  This function sets the swap interval for the current OpenGL or OpenGL ES  context, i.e. the number of screen updates to wait from the time 
        ///  glfwSwapBuffers was called before swapping the buffers and returning.  This  is sometimes called _vertical synchronization_, _vertical retrace  synchronization_ or just _vsync_.
        ///  Contexts that support either of the `WGL_EXT_swap_control_tear` and  `GLX_EXT_swap_control_tear` extensions also accept negative swap intervals,  which allow the driver to swap even if a frame arrives a little bit late.  You can check for the presence of these extensions using 
        ///  glfwExtensionSupported.  For more information about swap tearing, see the  extension specifications.
        ///  A context must be current on the calling thread.  Calling this function  without a current context will cause a 
        ///  This function does not apply to Vulkan.  If you are rendering with Vulkan,  see the present mode of your swapchain instead.
        ///   Possible errors include 
        ///  GLFW_NO_CURRENT_CONTEXT and 
        /// This function is not called during context creation, leaving the  swap interval set to whatever is the default on that platform.  This is done  because some swap interval extensions used by GLFW do not allow the swap  interval to be reset to zero once it has been set to a non-zero value.
        /// Some GPU drivers do not honor the requested swap interval, either  because of a user setting that overrides the application's request or due to  bugs in the driver.
        ///  _safety This function may be called from any thread.
        /// glfwSwapBuffers
        /// Added in version 1.0.
        ///</remarks>
        ///<code>
        ///void glfwSwapInterval(int interval)
        ///</code>
        // glfwSwapInterval: 
        [DllImport(DLL, EntryPoint = "glfwSwapInterval", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void SwapInterval(int interval);

        ///<summary>
        /// Returns whether the specified extension is available.
        ///</summary>
        ///<param name="extension"> [in]  The ASCII encoded name of the extension.  </param>
        ///<returns>
        /// `GLFW_TRUE` if the extension is available, or `GLFW_FALSE`  otherwise.
        ///</returns>
        ///<remarks>
        ///  This function returns whether the specified  [API extension](
        ///  OpenGL ES context.  It searches both for client API extension and context  creation API extensions.
        ///  A context must be current on the calling thread.  Calling this function  without a current context will cause a 
        ///  As this functions retrieves and searches one or more extension strings each  call, it is recommended that you cache its results if it is going to be used  frequently.  The extension strings will not change during the lifetime of  a context, so there is no danger in doing this.
        ///  This function does not apply to Vulkan.  If you are using Vulkan, see 
        ///  glfwGetRequiredInstanceExtensions, `vkEnumerateInstanceExtensionProperties`  and `vkEnumerateDeviceExtensionProperties` instead.
        ///   Possible errors include 
        ///  GLFW_NO_CURRENT_CONTEXT, 
        ///  GLFW_PLATFORM_ERROR.
        ///  _safety This function may be called from any thread.
        /// glfwGetProcAddress
        /// Added in version 1.0.
        ///</remarks>
        ///<code>
        ///int glfwExtensionSupported(const char *extension)
        ///</code>
        // glfwExtensionSupported: 
        [DllImport(DLL, EntryPoint = "glfwExtensionSupported", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern int ExtensionSupported(CharPtr extension);

        ///<summary>
        /// Returns the address of the specified function for the current  context.
        ///</summary>
        ///<param name="procname"> [in]  The ASCII encoded name of the function.  </param>
        ///<returns>
        /// The address of the function, or `NULL` if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns the address of the specified OpenGL or OpenGL ES  [core or extension function](
        ///  by the current context.
        ///  A context must be current on the calling thread.  Calling this function  without a current context will cause a 
        ///  This function does not apply to Vulkan.  If you are rendering with Vulkan,  see 
        ///  `vkGetDeviceProcAddr` instead.
        ///   Possible errors include 
        ///  GLFW_NO_CURRENT_CONTEXT and 
        /// The address of a given function is not guaranteed to be the same  between contexts.
        /// This function may return a non-`NULL` address despite the  associated version or extension not being available.  Always check the  context version or extension string first.
        ///  _lifetime The returned function pointer is valid until the context  is destroyed or the library is terminated.
        ///  _safety This function may be called from any thread.
        /// glfwExtensionSupported
        /// Added in version 1.0.
        ///</remarks>
        ///<code>
        ///GLFWglproc glfwGetProcAddress(const char *procname)
        ///</code>
        // glfwGetProcAddress: 
        [DllImport(DLL, EntryPoint = "glfwGetProcAddress", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern GlprocDelegate GetProcAddress(CharPtr procname);

        ///<summary>
        /// Returns whether the Vulkan loader has been found.
        ///</summary>
        ///<returns>
        /// `GLFW_TRUE` if Vulkan is available, or `GLFW_FALSE` otherwise.
        ///</returns>
        ///<remarks>
        ///  This function returns whether the Vulkan loader has been found.  This check  is performed by 
        ///  The availability of a Vulkan loader does not by itself guarantee that window  surface creation or even device creation is possible.  Call 
        ///  glfwGetRequiredInstanceExtensions to check whether the extensions necessary  for Vulkan surface creation are available and 
        ///  glfwGetPhysicalDevicePresentationSupport to check whether a queue family of  a physical device supports image presentation.
        ///   Possible errors include 
        ///  _safety This function may be called from any thread.
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///int glfwVulkanSupported()
        ///</code>
        // glfwVulkanSupported: 
        [DllImport(DLL, EntryPoint = "glfwVulkanSupported", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern int VulkanSupported();

        ///<summary>
        /// Returns the Vulkan instance extensions required by GLFW.
        ///</summary>
        ///<param name="count"> [out]  Where to store the number of extensions in the returned  array.  This is set to zero if an error occurred.  </param>
        ///<returns>
        /// An array of ASCII encoded extension names, or `NULL` if an  [error](
        ///</returns>
        ///<remarks>
        ///  This function returns an array of names of Vulkan instance extensions required  by GLFW for creating Vulkan surfaces for GLFW windows.  If successful, the  list will always contains `VK_KHR_surface`, so if you don't require any  additional extensions you can pass this list directly to the  `VkInstanceCreateInfo` struct.
        ///  If Vulkan is not available on the machine, this function returns `NULL` and  generates a 
        ///  to check whether Vulkan is available.
        ///  If Vulkan is available but no set of extensions allowing window surface  creation was found, this function returns `NULL`.  You may still use Vulkan  for off-screen rendering and compute work.
        ///   Possible errors include 
        ///  GLFW_API_UNAVAILABLE.
        /// Additional extensions may be required by future versions of GLFW.  You should check if any extensions you wish to enable are already in the  returned array, as it is an error to specify an extension more than once in  the `VkInstanceCreateInfo` struct.
        ///  _lifetime The returned array is allocated and freed by GLFW.  You  should not free it yourself.  It is guaranteed to be valid only until the  library is terminated.
        ///  _safety This function may be called from any thread.
        /// glfwCreateWindowSurface
        /// Added in version 3.2.
        ///</remarks>
        ///<code>
        ///const char **glfwGetRequiredInstanceExtensions(uint32_t *count)
        ///</code>
        // glfwGetRequiredInstanceExtensions: 
        [DllImport(DLL, EntryPoint = "glfwGetRequiredInstanceExtensions", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern ref CharPtr GetRequiredInstanceExtensions(out uint count);

        ///<code>
        ///void * glfwGetWin32Window(GLFWwindow *)
        ///</code>
        // glfwGetWin32Window: 
        [DllImport(DLL, EntryPoint = "glfwGetWin32Window", CallingConvention=CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr GetWin32Window(Window window);

#region Size check
        internal static void CheckStructSizes()
        {
            //Test sizes match original sizes
            void check(params Type[] typeSize)
            {
                for (int i = 0; i < typeSize.Length; i++)
                {
                    var t = typeSize[i];
                    NativeStructAttribute cstruct = (NativeStructAttribute)t.GetCustomAttributes(typeof(NativeStructAttribute), false)[0];
                    var actualSize = Marshal.SizeOf(t);
                    if (!cstruct.Size.Equals(actualSize))
                    {
                        throw new ApplicationException($"Size mismatch for type { t.Name}: Size is { actualSize } but expected { cstruct.Size}.");
        
        
                    }
        
        
                }
            }
            check(typeof(Image), typeof(VideoMode), typeof(Gammaramp));
        }
#endregion

    }

}


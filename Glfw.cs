using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Glfw
{
    public unsafe static partial class Glfw
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Init()
        {
            return glfw.Init();
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Terminate()
        {
            glfw.Terminate();
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GetVersion(out int major, out int minor, out int rev)
        {
            glfw.GetVersion(out major, out minor, out rev);
        }

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
        public static CharPtr VersionString
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetVersionString();
            }

        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DefaultWindowHints()
        {
            glfw.DefaultWindowHints();
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WindowHint(int hint, int @value)
        {
            glfw.WindowHint(hint, @value);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void PollEvents()
        {
            glfw.PollEvents();
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WaitEvents()
        {
            glfw.WaitEvents();
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WaitEventsTimeout(double timeout)
        {
            glfw.WaitEventsTimeout(timeout);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void PostEmptyEvent()
        {
            glfw.PostEmptyEvent();
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CharPtr GetKeyName(Keyboard key, int scancode)
        {
            return glfw.GetKeyName(key, scancode);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int JoystickPresent(Joystick joy)
        {
            return glfw.JoystickPresent(joy);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref float GetJoystickAxes(Joystick joy, out int count)
        {
            return ref glfw.GetJoystickAxes(joy, out count);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref byte GetJoystickButtons(Joystick joy, out int count)
        {
            return ref glfw.GetJoystickButtons(joy, out count);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CharPtr GetJoystickName(Joystick joy)
        {
            return glfw.GetJoystickName(joy);
        }

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
        public static double Time
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetTime();
            }

        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTime(double time)
        {
            glfw.SetTime(time);
        }

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
        public static ulong TimerValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetTimerValue();
            }

        }

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
        public static ulong TimerFrequency
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetTimerFrequency();
            }

        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SwapInterval(int interval)
        {
            glfw.SwapInterval(interval);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ExtensionSupported(CharPtr extension)
        {
            return glfw.ExtensionSupported(extension);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int VulkanSupported()
        {
            return glfw.VulkanSupported();
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref CharPtr GetRequiredInstanceExtensions(out uint count)
        {
            return ref glfw.GetRequiredInstanceExtensions(out count);
        }

    }

}


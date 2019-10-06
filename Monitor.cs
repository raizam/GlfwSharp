using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Glfw
{
    unsafe partial struct Monitor
    {
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetPos(out int xpos, out int ypos)
        {
            glfw.GetMonitorPos( this, out xpos, out ypos);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetPhysicalSize(out int widthMM, out int heightMM)
        {
            glfw.GetMonitorPhysicalSize( this, out widthMM, out heightMM);
        }

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
        public CharPtr Name
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetMonitorName( this);
            }

        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref VideoMode GetVideoModes(out int count)
        {
            return ref glfw.GetVideoModes( this, out count);
        }

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
        public ref VideoMode VideoMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref glfw.GetVideoMode( this);
            }

        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetGamma(float gamma)
        {
            glfw.SetGamma( this, gamma);
        }

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
        public ref Gammaramp GammaRamp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref glfw.GetGammaRamp( this);
            }

        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetGammaRamp(out Gammaramp ramp)
        {
            glfw.SetGammaRamp( this, out ramp);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref Monitor GetMonitors(out int count)
        {
            return ref glfw.GetMonitors(out count);
        }

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
        public static Monitor PrimaryMonitor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetPrimaryMonitor();
            }

        }

    }

}


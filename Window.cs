using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Glfw
{
    unsafe partial struct Window
    {
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Destroy()
        {
            glfw.DestroyWindow( this);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int ShouldClose()
        {
            return glfw.WindowShouldClose( this);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetShouldClose(int @value)
        {
            glfw.SetWindowShouldClose( this, @value);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTitle(CharPtr title)
        {
            glfw.SetWindowTitle( this, title);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetIcon(int count, out Image images)
        {
            glfw.SetWindowIcon( this, count, out images);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetPos(out int xpos, out int ypos)
        {
            glfw.GetWindowPos( this, out xpos, out ypos);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetPos(int xpos, int ypos)
        {
            glfw.SetWindowPos( this, xpos, ypos);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetSize(out int width, out int height)
        {
            glfw.GetWindowSize( this, out width, out height);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetSizeLimits(int minwidth, int minheight, int maxwidth, int maxheight)
        {
            glfw.SetWindowSizeLimits( this, minwidth, minheight, maxwidth, maxheight);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAspectRatio(int numer, int denom)
        {
            glfw.SetWindowAspectRatio( this, numer, denom);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetSize(int width, int height)
        {
            glfw.SetWindowSize( this, width, height);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFramebufferSize(out int width, out int height)
        {
            glfw.GetFramebufferSize( this, out width, out height);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFrameSize(out int left, out int top, out int right, out int bottom)
        {
            glfw.GetWindowFrameSize( this, out left, out top, out right, out bottom);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Iconify()
        {
            glfw.IconifyWindow( this);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Restore()
        {
            glfw.RestoreWindow( this);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Maximize()
        {
            glfw.MaximizeWindow( this);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Show()
        {
            glfw.ShowWindow( this);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Hide()
        {
            glfw.HideWindow( this);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Focus()
        {
            glfw.FocusWindow( this);
        }

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
        public Monitor Monitor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetWindowMonitor( this);
            }

        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetMonitor(Monitor monitor, int xpos, int ypos, int width, int height, int refreshRate)
        {
            glfw.SetWindowMonitor( this, monitor, xpos, ypos, width, height, refreshRate);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetAttrib(int attrib)
        {
            return glfw.GetWindowAttrib( this, attrib);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetUserPointer(IntPtr pointer)
        {
            glfw.SetWindowUserPointer( this, pointer);
        }

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
        public IntPtr UserPointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetWindowUserPointer( this);
            }

        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WindowposfunDelegate SetPosCallback(WindowposfunDelegate cbfun)
        {
            return glfw.SetWindowPosCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WindowsizefunDelegate SetSizeCallback(WindowsizefunDelegate cbfun)
        {
            return glfw.SetWindowSizeCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WindowclosefunDelegate SetCloseCallback(WindowclosefunDelegate cbfun)
        {
            return glfw.SetWindowCloseCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WindowrefreshfunDelegate SetRefreshCallback(WindowrefreshfunDelegate cbfun)
        {
            return glfw.SetWindowRefreshCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WindowfocusfunDelegate SetFocusCallback(WindowfocusfunDelegate cbfun)
        {
            return glfw.SetWindowFocusCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WindowiconifyfunDelegate SetIconifyCallback(WindowiconifyfunDelegate cbfun)
        {
            return glfw.SetWindowIconifyCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public FramebuffersizefunDelegate SetFramebufferSizeCallback(FramebuffersizefunDelegate cbfun)
        {
            return glfw.SetFramebufferSizeCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetInputMode(int mode)
        {
            return glfw.GetInputMode( this, mode);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetInputMode(int mode, int @value)
        {
            glfw.SetInputMode( this, mode, @value);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetKey(Keyboard key)
        {
            return glfw.GetKey( this, key);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetMouseButton(int button)
        {
            return glfw.GetMouseButton( this, button);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetCursorPos(out double xpos, out double ypos)
        {
            glfw.GetCursorPos( this, out xpos, out ypos);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCursorPos(double xpos, double ypos)
        {
            glfw.SetCursorPos( this, xpos, ypos);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCursor(Cursor cursor)
        {
            glfw.SetCursor( this, cursor);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public KeyfunDelegate SetKeyCallback(KeyfunDelegate cbfun)
        {
            return glfw.SetKeyCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CharfunDelegate SetCharCallback(CharfunDelegate cbfun)
        {
            return glfw.SetCharCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CharmodsfunDelegate SetCharModsCallback(CharmodsfunDelegate cbfun)
        {
            return glfw.SetCharModsCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public MousebuttonfunDelegate SetMouseButtonCallback(MousebuttonfunDelegate cbfun)
        {
            return glfw.SetMouseButtonCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CursorposfunDelegate SetCursorPosCallback(CursorposfunDelegate cbfun)
        {
            return glfw.SetCursorPosCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CursorenterfunDelegate SetCursorEnterCallback(CursorenterfunDelegate cbfun)
        {
            return glfw.SetCursorEnterCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ScrollfunDelegate SetScrollCallback(ScrollfunDelegate cbfun)
        {
            return glfw.SetScrollCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DropfunDelegate SetDropCallback(DropfunDelegate cbfun)
        {
            return glfw.SetDropCallback( this, cbfun);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetClipboardString(CharPtr @string)
        {
            glfw.SetClipboardString( this, @string);
        }

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
        public CharPtr ClipboardString
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetClipboardString( this);
            }

        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void MakeContextCurrent()
        {
            glfw.MakeContextCurrent( this);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SwapBuffers()
        {
            glfw.SwapBuffers( this);
        }

        public IntPtr Win32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetWin32Window( this);
            }

        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Window CreateWindow(int width, int height, CharPtr title, Monitor monitor, Window share)
        {
            return glfw.CreateWindow(width, height, title, monitor, share);
        }

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
        public static Window CurrentContext
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return glfw.GetCurrentContext();
            }

        }

    }

}


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Glfw
{
    // GLFWimage: 
    unsafe partial struct Image
    {
        public int Width
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => width;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => width = value;
        }

        public int Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => height;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => height = value;
        }

        public byte* Pixels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => pixels;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => pixels = value;
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Cursor CreateCursor(int xhot, int yhot)
        {
            return glfw.CreateCursor(out this, xhot, yhot);
        }

    }

}


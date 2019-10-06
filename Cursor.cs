using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Glfw
{
    unsafe partial struct Cursor
    {
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Destroy()
        {
            glfw.DestroyCursor( this);
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Cursor CreateStandardCursor(SystemCursors shape)
        {
            return glfw.CreateStandardCursor(shape);
        }

    }

}


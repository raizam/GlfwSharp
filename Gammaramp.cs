using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Glfw
{
    // GLFWgammaramp: 
    unsafe partial struct Gammaramp
    {
        public ushort* Red
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => red;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => red = value;
        }

        public ushort* Green
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => green;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => green = value;
        }

        public ushort* Blue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => blue;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => blue = value;
        }

        public uint Size
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => size;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => size = value;
        }

    }

}


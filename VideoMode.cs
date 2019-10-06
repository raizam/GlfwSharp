using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Glfw
{
    // GLFWvidmode: 
    unsafe partial struct VideoMode
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

        public int RedBits
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => redBits;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => redBits = value;
        }

        public int GreenBits
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => greenBits;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => greenBits = value;
        }

        public int BlueBits
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => blueBits;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => blueBits = value;
        }

        public int RefreshRate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => refreshRate;
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => refreshRate = value;
        }

    }

}

